
using Octokit;
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
using System.Xml.Linq;
using WWHDR_configloader.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WWHDR_configloader
{

	public partial class Form1 : Form
	{
        //string dateformat = "dd/MM/yyyy";
        //string ampm = "";

        string version = "0.6.0";

        int ogSizeX = 328;
		int ogSizeY = 487;
		int mdSizeX = 890;
		int mdSizeY = 487;

		bool extMode = true;
		bool spoilerFromWiiU = false;
		bool ready = false;

        float timer = 0;

		ReadFolder rf;

        public Form1()
        {
            InitializeComponent();
            rf = new ReadFolder();
            
        }
		private void button3_Click(object sender, EventArgs e)
		{
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				pathTextbox.Text = fileDialog.FileName;
			}

			if (plandoPath.Text == "")
			{
				plandoPath.Text = removeLastDir(pathTextbox.Text) + "\\plandomizer.yaml";
			}

		}

		private string findWiiUPath()
		{
			List<string[]> eachFolder = new List<string[]>();
			(var wiiufolderName, var wiiufolderDateTime) = rf.readWiiUFolder("fs/vol/external01/wiiu/apps/save/", 1000);
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
		



		private void button4_Click(object sender, EventArgs e)
		{
			var response = rf.readWiiUFolderString("fs/vol/external01/wiiu/apps/save", 1000);
			if (response == "FileNull")
			{
				MessageBox.Show("The program was able to connect to the server, but no files were detected. Make sure to launch the Rando app at least once to generate a config file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (response == "ServerUnk")
			{
				MessageBox.Show("The program was unable to connect to the server. Make sure you entered the correct address (I.e. 192.168.XXX.XXX) without including the port (numbers after the colon)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				message.Text = "The Wii U responded correctly!";
                timer1.Start();
			}
		}

		private void toPc_Click(object sender, EventArgs e)
		{
			if(wiiuIpTextbox.Text == "")
			{
				MessageBox.Show("Please enter a valid IP address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (pathTextbox.Text == "")
			{
                MessageBox.Show("Please enter a path for the PC app", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (configSwitch.Checked)
			{
				rf.download(findWiiUPath() + "/config.yaml", removeLastDir(pathTextbox.Text) + "/config.yaml");
			}
			if (preferencesSwitch.Checked)
			{
                rf.download(findWiiUPath() + "/preferences.yaml", removeLastDir(pathTextbox.Text) + "/preferences.yaml");
			}
			if(plandoPath.Text != "")
			{
                if (plandoSwitch.Checked)
                {
                    rf.download(findWiiUPath() + "/plandomizer.yaml", plandoPath.Text);
                }
			}
			else
			{
                if (plandoSwitch.Checked)
                {
                    rf.download(findWiiUPath() + "/plandomizer.yaml", removeLastDir(pathTextbox.Text) + "/plandomizer.yaml");
                }
            }
            

            message.Text = "Successfully recieved the file!";
            timer1.Start();
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
				MessageBox.Show("Please enter a valid IP address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (pathTextbox.Text == "")
			{
				MessageBox.Show("Please enter a path for the PC app", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if(!File.Exists(removeLastDir(pathTextbox.Text) + "/config.yaml") && configSwitch.Checked)
			{
				MessageBox.Show("The config file does not exists on your computer. Make sure that you opened and closed the app at least once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!File.Exists(removeLastDir(pathTextbox.Text) + "/preferences.yaml") && preferencesSwitch.Checked)
			{
				MessageBox.Show("The preference file does not exists on your computer. Make sure that you opened and closed the app at least once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
            if (!File.Exists(plandoPath.Text) && plandoSwitch.Checked)
            {
                MessageBox.Show("The plandomizer file does not exists on your computer. Make sure you have selected a valid file.\r\nIf you don't want to transfer the plandomizer file, untick the checkbox.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (configSwitch.Checked)
			{
				rf.upload(findWiiUPath() + "/config.yaml", removeLastDir(pathTextbox.Text) + "/config.yaml");
			}

			if (preferencesSwitch.Checked)
			{
				rf.upload(findWiiUPath() + "/preferences.yaml", removeLastDir(pathTextbox.Text) + "/preferences.yaml");
			}
            if (plandoSwitch.Checked)
            {
                rf.upload(findWiiUPath() + "/plandomizer.yaml", plandoPath.Text);
            }

            message.Text = "Successfully sent the file!";
            timer1.Start();
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
            plandoPath.Text = Properties.Settings.Default.plandoPath;
            plandoSwitch.Checked = Properties.Settings.Default.plando;
			configSwitch.Checked = Properties.Settings.Default.config;
			preferencesSwitch.Checked = Properties.Settings.Default.pref;
            fileRepView.Enabled = Properties.Settings.Default.disclaimer;
			if(Properties.Settings.Default.gameinstall == "nand")
			{
                gameInstall.SelectedIndex = 0;
			}
			else if(Properties.Settings.Default.gameinstall == "usb")
			{
                gameInstall.SelectedIndex = 1;
            }

            removePatch.Enabled = false;
			patchOne.Enabled = false;


            if (Properties.Settings.Default.tab == "spoiler")
			{
                spoilerLog.Visible = true;
                fileRepView.Visible = false;
            }
			else if(Properties.Settings.Default.tab == "patch")
			{
                spoilerLog.Visible = false;
                fileRepView.Visible = true;
            }

			FileRViewLoad();

			if (Properties.Settings.Default.advancedView)
			{
                this.Width = mdSizeX;
                this.Height = mdSizeY;
                extMode = true;
			}
			else
			{
                this.Width = ogSizeX;
                this.Height = ogSizeY;
                extMode = false;
            }

            if (plandoPath.Text == "" && pathTextbox.Text != "")
            {
                plandoPath.Text = removeLastDir(pathTextbox.Text) + "\\plandomizer.yaml";
            }
            if (!plandoSwitch.Checked)
            {
                plandoPath.Enabled = false;
                plandoBrowse.Enabled = false;
            }
            else
            {
                plandoPath.Enabled = true;
                plandoBrowse.Enabled = true;
            }
            if (Properties.Settings.Default.update)
            {
                _ = CheckGitHubNewerVersion();
                
            }

            ready = true;

        }

        public async Task<bool> CheckGitHubNewerVersion()
        {

            GitHubClient client = new GitHubClient(new ProductHeaderValue("wwhdr-config-loader"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("Teotia444", "WWHDR-Config-loader");

            Version latestGitHubVersion = new Version(releases[0].TagName);
            Version localVersion = new Version(version); 

            int versionComparison = localVersion.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                DialogResult r = MessageBox.Show("There is an update available on Github! \r\nOpen the Github release tab?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/Teotia444/WWHDR-Config-loader/releases/latest");
                }
                return true;
            }
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);
		}

		private void configSwitch_CheckedChanged(object sender, EventArgs e)
		{
			if(!preferencesSwitch.Checked && !configSwitch.Checked && !plandoSwitch.Checked)
			{
				toPc.Enabled = false;
				toWiiU.Enabled = false;
			}
			else
			{
				toPc.Enabled = true;
				toWiiU.Enabled = true;
			}
            Properties.Settings.Default.config = configSwitch.Checked;
            Properties.Settings.Default.Save();
        }

		private void preferencesSwitch_CheckedChanged(object sender, EventArgs e)
		{
			if (!preferencesSwitch.Checked && !configSwitch.Checked && !plandoSwitch.Checked)
			{
				toPc.Enabled = false;
				toWiiU.Enabled = false;
			}
			else
			{
				toPc.Enabled = true;
				toWiiU.Enabled = true;
			}
            Properties.Settings.Default.pref = preferencesSwitch.Checked;
            Properties.Settings.Default.Save();
        }

        private void plandoSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (!preferencesSwitch.Checked && !configSwitch.Checked && !plandoSwitch.Checked)
            {
                toPc.Enabled = false;
                toWiiU.Enabled = false;
            }
            else
            {
                toPc.Enabled = true;
                toWiiU.Enabled = true;
            }

			if (!plandoSwitch.Checked)
			{
				plandoPath.Enabled = false;
				plandoBrowse.Enabled = false;
			}
			else
			{
                plandoPath.Enabled = true;
                plandoBrowse.Enabled = true;
            }

			Properties.Settings.Default.plando = plandoSwitch.Checked;
			Properties.Settings.Default.Save();
        }
        private void advancedSwitch_Click(object sender, EventArgs e)
        {
            if (extMode)
            {
                this.Width = ogSizeX;
                this.Height = ogSizeY;
                extMode = false;
                Properties.Settings.Default.advancedView = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                this.Width = mdSizeX;
                this.Height = mdSizeY;
                extMode = true;
				if (!spoilerLog.Visible)
				{
					spoilerLog.Visible = true;
				}
                Properties.Settings.Default.advancedView = true;
                Properties.Settings.Default.Save();
            }
        }



        void FetchSpoilerLogsWiiU()
        {
            listViewSpoiler.Items.Clear();
            string wiiupath = findWiiUPath();
            (var wiiufolderName, var wiiufolderDateTime) = rf.readWiiUFolder(wiiupath + "\\logs\\", 1000);
            if (wiiufolderName.Length == 0)
            {
                MessageBox.Show("Please enter a valid IP address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            List<NameDate> nd = new List<NameDate>();
            for (int i = 0; i < wiiufolderName.Length; i++)
            {
                nd.Add(new NameDate(wiiufolderName[i], wiiufolderDateTime[i]));

            }
            nd.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            
            for (int i = nd.Count - 1; i > 0; i--)
            {
                if (nd[i].Name.Contains("Spoiler Log") && !nd[i].Name.Contains("Non-Spoiler Log"))
                {
                    string[] row = { nd[i].Name, nd[i].Date.ToString().Substring(0, nd[i].Date.ToString().Length - 3) };
                    var listViewItem = new ListViewItem(row);
                    listViewSpoiler.Items.Add(listViewItem);
                    
                }
            }
        }

        void FileRViewLoad()
        {
			ready = false;
            fileRep.Items.Clear();
            fileRep.SelectedItems.Clear();

            if (Properties.Settings.Default.customFiles != null)
			{
                Properties.Settings.Default.customFiles.ForEach(line =>
				{

					var wiiufile = line.Split('|')[0];
					var pcfile = line.Split('|')[1];
                    bool check = (line.Split('|')[2].ToUpper() == "TRUE");
                    string[] row = { wiiufile, pcfile };
					var item = new ListViewItem(row);
					item.Checked = check;
                    fileRep.Items.Add(item);

				});
			}
			ready = true;
        }

        void FetchSpoilerLogsPC()
        {
            listViewSpoiler.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(removeLastDir(pathTextbox.Text) + "\\logs");
            FileInfo[] Files = d.GetFiles("*.txt");


            List<NameDate> nd = new List<NameDate>();
			foreach (FileInfo file in Files)
			{
				nd.Add(new NameDate(file.Name, file.CreationTime));
			}
			

            nd.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            
            for (int i = nd.Count -1; i >= 0; i--)
            {
                if (nd[i].Name.Contains("Spoiler Log") && !nd[i].Name.Contains("Non-Spoiler Log"))
                {
                    string[] row = { nd[i].Name, nd[i].Date.ToString().Substring(0, nd[i].Date.ToString().Length - 3) };
                    var listViewItem = new ListViewItem(row);
					
                    listViewSpoiler.Items.Add(listViewItem);
                    
                }
            }
        }


        public class NameDate
        {
			public NameDate(string name, DateTime date) { 
				this.Name = name;
				this.Date = date;
			}
            public string Name { get; set; }
            public DateTime Date { get; set; }
        }

        private void listViewSpoiler_SelectedIndexChanged(object sender, EventArgs e)
        {
			if(listViewSpoiler.SelectedIndices.Count != 0)
			{
				delLog.Enabled = true;
				openLog.Enabled = true;
			}
			else
			{
                delLog.Enabled = false;
                openLog.Enabled = false;
            }
        }

        private void wiiULog_Click(object sender, EventArgs e)
        { 
            FetchSpoilerLogsWiiU();
			spoilerFromWiiU = true;
        }

        private void pcLog_Click(object sender, EventArgs e)
        {
			FetchSpoilerLogsPC();
            spoilerFromWiiU = false;
        }

        private void openLog_Click(object sender, EventArgs e)
        {

			if (spoilerFromWiiU)
			{
				foreach(int index in listViewSpoiler.SelectedIndices)
				{
					rf.download(findWiiUPath()+"\\logs\\"+listViewSpoiler.Items[index].Text, System.IO.Path.GetTempPath() + "\\" + listViewSpoiler.Items[index].Text);
                    System.Diagnostics.Process.Start(System.IO.Path.GetTempPath() + "\\" + listViewSpoiler.Items[index].Text);

                }
			}
			if (!spoilerFromWiiU)
			{
                foreach (int index in listViewSpoiler.SelectedIndices)
                {
                    System.Diagnostics.Process.Start(removeLastDir(pathTextbox.Text) + "\\logs\\"+ listViewSpoiler.Items[index].Text);
                }
            }

        }

        private void delLog_Click(object sender, EventArgs e)
        {
            if (spoilerFromWiiU)
            {
                foreach (int index in listViewSpoiler.SelectedIndices)
                {
					Console.WriteLine(index.ToString());
					rf.delete(findWiiUPath() + "\\logs\\" + listViewSpoiler.Items[index].Text);
                }
				FetchSpoilerLogsWiiU();
            }
			if (!spoilerFromWiiU)
			{
                foreach (int index in listViewSpoiler.SelectedIndices)
				{
					File.Delete(removeLastDir(pathTextbox.Text) + "\\logs\\" + listViewSpoiler.Items[index].Text);
				}
				FetchSpoilerLogsPC();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
			Properties.Settings.Default.plandoPath = plandoPath.Text;
			Properties.Settings.Default.Save();
        }

        private void plandoBrowse_Click(object sender, EventArgs e)
        {
            if (plandoDialog.ShowDialog() == DialogResult.OK)
            {
                plandoPath.Text = plandoDialog.FileName;
                Properties.Settings.Default.plandoPath = plandoPath.Text;
                Properties.Settings.Default.Save();
            }

        }

        private void spoilerLogSwitch_Click(object sender, EventArgs e)
        {
            
            spoilerLog.Visible = true;
			fileRepView.Visible = false;
            Properties.Settings.Default.tab = "spoiler";
            Properties.Settings.Default.Save();
        }

        private void fileRepToggle_Click(object sender, EventArgs e)
        {
			patchMessage.Text = "";
            spoilerLog.Visible = false;
            fileRepView.Visible = true;
            Properties.Settings.Default.tab = "patch";
			if (!Properties.Settings.Default.disclaimer)
			{
				var confirmResult = MessageBox.Show("Warning! This tab allows you to modify game files, and will directly modify NAND/USB files. " +
												"Always double check you're not messing with the wrong files before adding patches! " +
												"Do you still want to continue?",
									 "Warning!",
                                     MessageBoxButtons.YesNo);
				if (confirmResult == DialogResult.Yes)
				{
                    Properties.Settings.Default.disclaimer = true;
                    fileRepView.Enabled = true;
				}
				else
				{
                    Properties.Settings.Default.disclaimer = false;
				}

			}
            Properties.Settings.Default.Save();

        }

        public void addFile(string wiiuPath, string pcPath, FileSelecter f)
		{
			f.Hide();
			if(Properties.Settings.Default.customFiles == null)
			{
				Properties.Settings.Default.customFiles = new List<string>();

            }
            Properties.Settings.Default.customFiles.Add(wiiuPath + "|" + pcPath + "|" + "true");
			Properties.Settings.Default.Save();

			FileRViewLoad();
        }

        private void fileRep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileRep.SelectedItems.Count > 0)
            {
                removePatch.Enabled = true;
                if (fileRep.SelectedItems[0].Checked)
                {
                    patchOne.Enabled = true;
                }
                else
                {
                    patchOne.Enabled = false;
                }
            }
            else
            {
                removePatch.Enabled = false;
                patchOne.Enabled = false;
            }
        }
        private void fileRep_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
			if (ready)
			{
                if (fileRep.SelectedItems.Count > 0 && fileRep.SelectedItems[0].Checked)
                {
                    patchOne.Enabled = true;
                }
                else
                {
                    patchOne.Enabled = false;
                }
                var wiiufile = Properties.Settings.Default.customFiles[e.Item.Index].Split('|')[0];
                var pcfile = Properties.Settings.Default.customFiles[e.Item.Index].Split('|')[1];
                Properties.Settings.Default.customFiles[e.Item.Index] = wiiufile + "|" + pcfile + "|" + e.Item.Checked.ToString();
                Properties.Settings.Default.Save();
			}
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.disclaimer = false;
            Properties.Settings.Default.customFiles.Clear();
            Properties.Settings.Default.Save();
        }

        private void addPatch_Click(object sender, EventArgs e)
        {
			if (!rf.checkInstall(gameInstall.SelectedIndex))
			{
				return;
			}
            FileRViewLoad();
            FileSelecter f = new FileSelecter(this);
            f.Show();
        }

        private void removePatch_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.customFiles.RemoveAt(fileRep.SelectedItems[0].Index);
            Properties.Settings.Default.Save();
            removePatch.Enabled = false;
            patchOne.Enabled = false;
            FileRViewLoad();
        }

        private void patchAll_Click(object sender, EventArgs e)
        {
            if (!rf.checkInstall(gameInstall.SelectedIndex))
            {
                return;
            }
            var install = "/storage_mlc/usr/title/00050000/10143599";
            if (Properties.Settings.Default.gameinstall == "usb")
            {
                install = "/storage_usb/usr/title/00050000/10143599";
            }
            foreach (ListViewItem patch in fileRep.Items)
            {
                patchMessage.ForeColor = Color.Black;
				patchMessage.Text = "Patching...";
                
                if (!patch.Checked)
				{
					continue;
				}
				if (!File.Exists(patch.SubItems[1].Text))
				{
					MessageBox.Show("File " + patch.SubItems[1].Text + " does not exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					continue;
				}
                
                if (rf.delete(install + patch.SubItems[0].Text) == true)
				{
					rf.upload(install + patch.SubItems[0].Text, patch.SubItems[1].Text);

				}
				else
				{
                    MessageBox.Show("File at " + patch.SubItems[1].Text + " does not exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					continue;
                }
                
            }
            patchMessage.ForeColor = Color.Green;
            patchMessage.Text = "Successfully patched the files!";
            timer1.Start();

        }

		private void patchOne_Click(object sender, EventArgs e)
		{
            if (!rf.checkInstall(gameInstall.SelectedIndex))
            {
                return;
            }
            var install = "/storage_mlc/usr/title/00050000/10143599";
			if (Properties.Settings.Default.gameinstall == "usb")
			{
				install = "/storage_usb/usr/title/00050000/10143599";
            }
            if (!fileRep.SelectedItems[0].Checked)
            {
                return;
            }
            if (!File.Exists(fileRep.SelectedItems[0].SubItems[1].Text))
            {
                MessageBox.Show("File " + fileRep.SelectedItems[0].SubItems[1].Text + " does not exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            patchMessage.ForeColor = Color.Black;
            patchMessage.Text = "Patching " + fileRep.SelectedItems[0].Text;
            

            if (rf.delete(install + fileRep.SelectedItems[0].SubItems[0].Text) == true)
            {
                rf.upload(install + fileRep.SelectedItems[0].SubItems[0].Text, fileRep.SelectedItems[0].SubItems[1].Text);

            }
            else
            {
                MessageBox.Show("File at " + fileRep.SelectedItems[0].SubItems[1].Text + " does not exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            patchMessage.ForeColor = Color.Green;
            patchMessage.Text = "Successfully patched the files!";
            timer1.Start();
        }

        private void gameInstall_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (gameInstall.SelectedIndex == 0)
			{
                Properties.Settings.Default.gameinstall = "nand";
			}
			else if (gameInstall.SelectedIndex == 1)
			{
                Properties.Settings.Default.gameinstall = "usb";
            }
            Properties.Settings.Default.Save();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show(timer.ToString());
            Settings s = new Settings(this);
            s.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += timer1.Interval * 0.001f;
            if(timer > 4)
            {
                message.Text = "";
                patchMessage.Text = "";
                timer = 0;
                timer1.Stop();
            }
        }
    }
}
