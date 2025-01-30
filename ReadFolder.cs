using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWHDR_configloader.Properties;

namespace WWHDR_configloader
{
    internal class ReadFolder
    {
        public (string[], List<DateTime>) readWiiUFolder(string path, int timeout)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + Properties.Settings.Default.ipaddress + ":21/" + path);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Timeout = timeout;
            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("anonymous", "whatever");

            FtpWebResponse response = null;
            try { response = (FtpWebResponse)request.GetResponse(); }
            catch (WebException)
            { //MessageBox.Show("Invalid IP address"); 
                return (new string[0], new List<DateTime>());
            }

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
        public string readWiiUFolderString(string path, int timeout)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + Properties.Settings.Default.ipaddress + ":21/" + path);
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
        public void download(string remoteFile, string localFile)
        {
            try
            {
                if (remoteFile == "ErrNoFolderFound/config.yaml" || remoteFile == "ErrNoFolderFound/preferences.yaml" || remoteFile == "ErrNoFolderFound/plandomizer.yaml")
                {
                    return;
                }
                /* Create an FTP Request */
                FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + Properties.Settings.Default.ipaddress + ":21/" + remoteFile);
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
                    if (a.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailableOrBusy)
                    {
                        MessageBox.Show("Error : couldn't find the file at " + remoteFile + " on the console.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                /* Resource Cleanup */
                localFileStream.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (WebException ex)
            {
                var a = ex.Response as FtpWebResponse;
                if (a.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailableOrBusy)
                {
                    MessageBox.Show("Error : File at \"" + remoteFile + " \"does not exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return;
        }


        public bool delete(string remoteFile)
        {
            try
            {
                if (remoteFile.Contains("ErrNoFolderFound"))
                {
                    return false;
                }
                /* Create an FTP Request */
                FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + Properties.Settings.Default.ipaddress + ":21/" + remoteFile);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential("anonymous", "whatever");
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                /* Establish Return Communication with the FTP Server */
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Get the FTP Server's Response Stream */
                Stream ftpStream = ftpResponse.GetResponseStream();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                return true;
            }
            catch (WebException ex)
            {
                var a = ex.Response as FtpWebResponse;
                if (a.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailableOrBusy)
                {
                    MessageBox.Show("Error : File at \"" + remoteFile + " \"does not exists.");
                    return false;
                }
            }
            return false;
        }

        public void upload(string remoteFile, string localFile)
        {
            try
            {
                /* Create an FTP Request */
                FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + Properties.Settings.Default.ipaddress + ":21/" + remoteFile);
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
        public bool checkInstall(int gameInstall)
        {
            var install = "/storage_usb/usr/title/00050000/10143599";
            if (gameInstall == 0)
            {
                install = "/storage_mlc/usr/title/00050000/10143599";
            }
            
            (string[] wiiu, List<DateTime> date) = readWiiUFolder(removeLastDir(install), 1000);
            string file = install.Substring(install.LastIndexOf("/") + 1);
            for (int i = 0; i < wiiu.Length; i++)
            {
                if (wiiu[i] == file)
                {
                    return true;
                }
            }
            MessageBox.Show("The game is not installed! Make sure you have selected the correct install device", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
