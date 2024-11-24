using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWHDR_configloader
{
    public partial class Settings : Form
    {
        Form1 parent;
        public Settings(Form1 _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Teotia444/WWHDR-Config-loader");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);
        }

        private void update_Click(object sender, EventArgs e)
        {
            Task<bool> task = Task.Run<bool>(async () => await parent.CheckGitHubNewerVersion());
            if (task.Result == false)
            {
                MessageBox.Show("No updates available", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.update = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.update;
        }
    }
}
