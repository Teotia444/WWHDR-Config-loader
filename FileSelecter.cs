using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWHDR_configloader.Properties;

namespace WWHDR_configloader
{
    public partial class FileSelecter : Form
    {
        ReadFolder f;
        Form1 parent;
        public string path;
        public FileSelecter(Form1 _parent)
        {
            InitializeComponent();
            f = new ReadFolder();
            parent = _parent;
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
        private bool Check()
        {
            var install = "/storage_mlc/usr/title/00050000/10143599";
            if (Properties.Settings.Default.gameinstall == "usb")
            {
                install = "/storage_usb/usr/title/00050000/10143599";
            }
            string p = install + customPath.Text;
            (string[] wiiu, List<DateTime> date) = f.readWiiUFolder(removeLastDir(p), 1000);
            string file = p.Substring(p.LastIndexOf("/") + 1);

            if (customPath.Text == string.Empty)
            {
                MessageBox.Show("The Wii U file path is empty!");
                return false;
            }

            if (!file.Contains("."))
            {
                fileExists.Visible = false;
                MessageBox.Show("The Wii U file path shouldn't be a folder!");
                return false;
            }
            for (int i = 0; i < wiiu.Length; i++)
            {
                if (wiiu[i] == file)
                {
                    fileExists.Visible = true;
                    return true;
                }
            }
            fileExists.Visible = false;
            MessageBox.Show("Wii U file not found. Make sure the path is correct and follows the example.");
            return false;
        }

        private void check_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (!File.Exists(fileTextbox.Text))
                {
                    MessageBox.Show("PC file not found. Make sure the path is correct.");
                    return;
                }
                string path = customPath.Text;
                parent.addFile(path, fileTextbox.Text, this);
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string file = customPath.Text.Substring(customPath.Text.LastIndexOf("/") + 1);
                fileDialog.Filter = file + " file|" + file;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileTextbox.Text = fileDialog.FileName;
                }
            }
        }
    }
}
