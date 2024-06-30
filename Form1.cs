using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWHDR_configloader
{

	public partial class Form1 : Form
	{
		string dateformat = "dd/MM/yyyy";
		string ampm = "";
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				pathTextbox.Text = fileDialog.FileName;
			}
		}


		private (string[], List<DateTime>) readWiiUFolder(string path, int timeout)
		{
			// Get the object used to communicate with the server.
			FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://"+ wiiuIpTextbox.Text + ":21/" + path);
			request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
			request.Timeout = timeout;
			// This example assumes the FTP site uses anonymous logon.
			request.Credentials = new NetworkCredential("anonymous", "whatever");

			FtpWebResponse response = null;
			try { response = (FtpWebResponse)request.GetResponse(); }
			catch (WebException e){ MessageBox.Show("Invalid IP address"); return (new string[0], new List<DateTime>()); }
			
			Stream responseStream = response.GetResponseStream();
			StreamReader reader = new StreamReader(responseStream);
			string pattern =
	@"^([\w-]+)\s+(\d+)\s+(\w+)\s+(\w+)\s+(\d+)\s+" +
	@"(\w+\s+\d+\s+\d+|\w+\s+\d+\s+\d+:\d+)\s+(.+)$";
			Regex regex = new Regex(pattern);
			IFormatProvider culture = CultureInfo.GetCultureInfo("en-us");
			string[] hourMinFormats =
				new[] { "MMM dd HH:mm", "MMM dd H:mm", "MMM d HH:mm", "MMM d H:mm" };
			string[] yearFormats =
				new[] { "MMM dd yyyy", "MMM d yyyy" };

			List<string> infos = new List<string>();
			List<DateTime> dates = new List<DateTime>();
			while (!reader.EndOfStream)
			{
				string line = reader.ReadLine();
				Match match = regex.Match(line);
				string permissions = match.Groups[1].Value;
				int inode = int.Parse(match.Groups[2].Value, culture);
				string owner = match.Groups[3].Value;
				string group = match.Groups[4].Value;
				long size = long.Parse(match.Groups[5].Value, culture);
				string s = Regex.Replace(match.Groups[6].Value, @"\s+", " ");



				string[] formats = new string[0];
				formats = (s.IndexOf(':') >= 0) ? hourMinFormats : yearFormats;
				if (formats == null)
				{
					formats[0] = "MMM dd yyyy";
					formats[1] = "MMM dd HH:mm";
				}
				try
				{
					dates.Add(DateTime.ParseExact(s, formats, culture, DateTimeStyles.None));
				}
				catch (Exception ex)
				{
					dates.Add(new DateTime(2024, 6, 16));
					Console.WriteLine(ex.ToString());
				}
				string name = match.Groups[7].Value;
				infos.Add(name);
				
			}
			return (infos.ToArray(), dates);

		}
		private string readWiiUFolderString(string path, int timeout)
		{
			// Get the object used to communicate with the server.
			FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + wiiuIpTextbox.Text + ":21/" + path);
			request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
			request.Timeout = timeout;
			// This example assumes the FTP site uses anonymous logon.
			request.Credentials = new NetworkCredential("anonymous", "whatever");

			FtpWebResponse response = null;
			try
			{
				response = (FtpWebResponse)request.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader reader = new StreamReader(responseStream);
				var items = reader.ReadToEnd();
				reader.Close();
				response.Close();
				return items;

			}
			catch (System.Net.WebException e)
			{

				response = (FtpWebResponse)e.Response;
				if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
				{
					return "FileNull";
				}
				else
				{
					return "ServerUnk";
				}
			}
		}

		private string findWiiUPath()
		{
			List<string[]> eachFolder = new List<string[]>();
			(var wiiufolderName, var wiiufolderDateTime) = readWiiUFolder("fs/vol/external01/wiiu/apps/save/", 1000);
			if (wiiufolderName != null)
			{ 
				string pathRecent = "";
				pathRecent = "B318AE3B (TWWHD Randomizer)";
				
				DateTime dateRecent = new DateTime(1970, 01, 01, 01, 01, 00);
				
				Console.WriteLine(wiiufolderName.Length);
				for (int i = 0; i<wiiufolderName.Length; i++)
				{
					Console.WriteLine(wiiufolderName[i]);
					if (wiiufolderName[i].Contains("(TWWHD Randomizer)"))
					{
						
						if (wiiufolderDateTime[i] > dateRecent)
						{
							pathRecent = wiiufolderName[i];
							dateRecent = wiiufolderDateTime[i];
						}
					}
				}
				return "fs/vol/external01/wiiu/apps/save/" + pathRecent;
			}
			return "ErrNoFolderFound";


		}
		public void download(string remoteFile, string localFile)
		{
			try
			{
				if(remoteFile == "ErrNoFolderFound/config.yaml" || remoteFile == "ErrNoFolderFound/preferences.yaml") {
					return;
				}
				/* Create an FTP Request */
				FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + wiiuIpTextbox.Text + ":21/" + remoteFile);
				/* Log in to the FTP Server with the User Name and Password Provided */
				ftpRequest.Credentials = new NetworkCredential("anonymous", "whatever");
				/* When in doubt, use these options */
				ftpRequest.UseBinary = true;
				ftpRequest.UsePassive = true;
				ftpRequest.KeepAlive = true;
				/* Specify the Type of FTP Request */
				ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
				/* Establish Return Communication with the FTP Server */
				FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
				/* Get the FTP Server's Response Stream */
				Stream ftpStream = ftpResponse.GetResponseStream();
				/* Open a File Stream to Write the Downloaded File */
				FileStream localFileStream = new FileStream(localFile, FileMode.Create);
				/* Buffer for the Downloaded Data */
				byte[] byteBuffer = new byte[2048];
				int bytesRead = ftpStream.Read(byteBuffer, 0, 2048);
				/* Download the File by Writing the Buffered Data Until the Transfer is Complete */
				try
				{
					while (bytesRead > 0)
					{
						localFileStream.Write(byteBuffer, 0, bytesRead);
						bytesRead = ftpStream.Read(byteBuffer, 0, 2048);
					}
				}
				catch (WebException ex)
				{
					var a = ex.Response as FtpWebResponse;
					if(a.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailableOrBusy)
					{
						MessageBox.Show("Error : File(s) does not exists");
					}
					
				}

				/* Resource Cleanup */
				localFileStream.Close();
				ftpStream.Close();
				ftpResponse.Close();
				ftpRequest = null;
			}
			catch (WebException ex) {
				var a = ex.Response as FtpWebResponse;
				if (a.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailableOrBusy)
				{
					MessageBox.Show("Error : File does not exists. This can happen if you never created a preferences.yaml or config.yaml file on your Wii U.");
				}
			}
			return;
		}
		public void upload(string remoteFile, string localFile)
		{
			try
			{
				/* Create an FTP Request */
				FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + wiiuIpTextbox.Text + ":21/"+ remoteFile);
				/* Log in to the FTP Server with the User Name and Password Provided */
				ftpRequest.Credentials = new NetworkCredential("anonymous", "whatever");
				/* When in doubt, use these options */
				ftpRequest.UseBinary = true;
				ftpRequest.UsePassive = true;
				ftpRequest.KeepAlive = true;
				/* Specify the Type of FTP Request */
				ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
				/* Establish Return Communication with the FTP Server */
				Stream ftpStream = ftpRequest.GetRequestStream();
				/* Open a File Stream to Read the File for Upload */
				FileStream localFileStream = new FileStream(localFile, FileMode.Open);
				/* Buffer for the Downloaded Data */
				byte[] byteBuffer = new byte[2048];
				int bytesSent = localFileStream.Read(byteBuffer, 0, 2048);
				/* Upload the File by Sending the Buffered Data Until the Transfer is Complete */
				try
				{
					while (bytesSent != 0)
					{
						ftpStream.Write(byteBuffer, 0, bytesSent);
						bytesSent = localFileStream.Read(byteBuffer, 0, 2048);
					}
				}
				catch (Exception ex) { Console.WriteLine(ex.ToString()); }
				/* Resource Cleanup */
				localFileStream.Close();
				ftpStream.Close();
				ftpRequest = null;
			}
			catch (Exception ex) { Console.WriteLine(ex.ToString()); }
			return;
		}



		private void button4_Click(object sender, EventArgs e)
		{
			var response = readWiiUFolderString("fs/vol/external01/wiiu/apps/save", 1000);
			if (response == "FileNull")
			{
				MessageBox.Show("The program was able to connect to the server, but no files were detected. Make sure to launch the Rando app at least once to generate a config file.");
			}
			else if (response == "ServerUnk")
			{
				MessageBox.Show("The program was unable to connect to the server. Make sure you entered the correct address (I.e. 192.168.XXX.XXX) without including the port (numbers after the colon)");
			}
			else
			{
				message.Text = "The Wii U responded correctly!";
			}
		}

		private void toPc_Click(object sender, EventArgs e)
		{
			if(wiiuIpTextbox.Text == "")
			{
				MessageBox.Show("Please enter a valid IP address");
				return;
			}
			if (pathTextbox.Text == "")
			{
				MessageBox.Show("Please enter a path for the PC app");
				return;
			}

			if (configSwitch.Checked)
			{
				download(findWiiUPath() + "/config.yaml", removeLastDir(pathTextbox.Text) + "/config.yaml");
			}
			if (preferencesSwitch.Checked)
			{
				download(findWiiUPath() + "/preferences.yaml", removeLastDir(pathTextbox.Text) + "/preferences.yaml");
			}
			message.Text = "Success!";
		}

		string removeLastDir(string path)
		{
			if (path.Contains("/"))
			{
				return path.Substring(0, path.LastIndexOf("/"));
			}
			else if (path.Contains("\\"))
			{
				return path.Substring(0, path.LastIndexOf("\\"));
			}
			else
			{
				return path;
			}
		}


		private void toWiiU_Click(object sender, EventArgs e)
		{
			if (wiiuIpTextbox.Text == "")
			{
				MessageBox.Show("Please enter a valid IP address");
				return;
			}
			if (pathTextbox.Text == "")
			{
				MessageBox.Show("Please enter a path for the PC app");
				return;
			}
			if(!File.Exists(removeLastDir(pathTextbox.Text) + "/config.yaml") && configSwitch.Enabled)
			{
				MessageBox.Show("The config file does not exists on your computer. Make sure that you opened and closed the app at least once.");
				return;
			}
			if (!File.Exists(removeLastDir(pathTextbox.Text) + "/preferences.yaml") && preferencesSwitch.Enabled)
			{
				MessageBox.Show("The preference file does not exists on your computer. Make sure that you opened and closed the app at least once.");
				return;
			}

			if (configSwitch.Checked)
			{
				upload(findWiiUPath() + "/config.yaml", removeLastDir(pathTextbox.Text) + "/config.yaml");
			}

			if (preferencesSwitch.Checked)
			{
				upload(findWiiUPath() + "/preferences.yaml", removeLastDir(pathTextbox.Text) + "/preferences.yaml");
			}

			
			message.Text = "Success!";
		}

		private void wiiuIpTextbox_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ipaddress = wiiuIpTextbox.Text;
			Properties.Settings.Default.Save();
		}

		private void pathTextbox_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.pathpc = pathTextbox.Text;
			Properties.Settings.Default.Save();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pathTextbox.Text = Properties.Settings.Default.pathpc;
			wiiuIpTextbox.Text = Properties.Settings.Default.ipaddress;
			
		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);
		}

		private void configSwitch_CheckedChanged(object sender, EventArgs e)
		{
			if(!preferencesSwitch.Checked && !configSwitch.Checked)
			{
				toPc.Enabled = false;
				toWiiU.Enabled = false;
			}
			else
			{
				toPc.Enabled = true;
				toWiiU.Enabled = true;
			}
		}

		private void preferencesSwitch_CheckedChanged(object sender, EventArgs e)
		{
			if (!preferencesSwitch.Checked && !configSwitch.Checked)
			{
				toPc.Enabled = false;
				toWiiU.Enabled = false;
			}
			else
			{
				toPc.Enabled = true;
				toWiiU.Enabled = true;
			}
		}
	}
}
