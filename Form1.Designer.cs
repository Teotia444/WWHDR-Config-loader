namespace WWHDR_configloader
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wiiuIpTextbox = new System.Windows.Forms.TextBox();
            this.toWiiU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toPc = new System.Windows.Forms.Button();
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcAppBrowse = new System.Windows.Forms.Button();
            this.ipCheck = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.message = new System.Windows.Forms.Label();
            this.configSwitch = new System.Windows.Forms.CheckBox();
            this.preferencesSwitch = new System.Windows.Forms.CheckBox();
            this.spoilerLogSwitch = new System.Windows.Forms.Button();
            this.plandoSwitch = new System.Windows.Forms.CheckBox();
            this.spoilerLog = new System.Windows.Forms.GroupBox();
            this.openLog = new System.Windows.Forms.Button();
            this.delLog = new System.Windows.Forms.Button();
            this.listViewSpoiler = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wiiULog = new System.Windows.Forms.Button();
            this.pcLog = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plandoBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.plandoPath = new System.Windows.Forms.TextBox();
            this.plandoDialog = new System.Windows.Forms.OpenFileDialog();
            this.spoilerLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // wiiuIpTextbox
            // 
            this.wiiuIpTextbox.Location = new System.Drawing.Point(32, 47);
            this.wiiuIpTextbox.Name = "wiiuIpTextbox";
            this.wiiuIpTextbox.Size = new System.Drawing.Size(210, 20);
            this.wiiuIpTextbox.TabIndex = 0;
            this.wiiuIpTextbox.TextChanged += new System.EventHandler(this.wiiuIpTextbox_TextChanged);
            // 
            // toWiiU
            // 
            this.toWiiU.Location = new System.Drawing.Point(56, 300);
            this.toWiiU.Name = "toWiiU";
            this.toWiiU.Size = new System.Drawing.Size(210, 56);
            this.toWiiU.TabIndex = 1;
            this.toWiiU.Text = "PC -> Wii U";
            this.toWiiU.UseVisualStyleBackColor = true;
            this.toWiiU.Click += new System.EventHandler(this.toWiiU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wii U IP address";
            // 
            // toPc
            // 
            this.toPc.Location = new System.Drawing.Point(56, 240);
            this.toPc.Name = "toPc";
            this.toPc.Size = new System.Drawing.Size(210, 54);
            this.toPc.TabIndex = 3;
            this.toPc.Text = "Wii U -> PC";
            this.toPc.UseVisualStyleBackColor = true;
            this.toPc.Click += new System.EventHandler(this.toPc_Click);
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(31, 88);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.Size = new System.Drawing.Size(210, 20);
            this.pathTextbox.TabIndex = 4;
            this.pathTextbox.TextChanged += new System.EventHandler(this.pathTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path to the desktop application";
            // 
            // pcAppBrowse
            // 
            this.pcAppBrowse.Location = new System.Drawing.Point(248, 84);
            this.pcAppBrowse.Name = "pcAppBrowse";
            this.pcAppBrowse.Size = new System.Drawing.Size(59, 23);
            this.pcAppBrowse.TabIndex = 6;
            this.pcAppBrowse.Text = "Browse";
            this.pcAppBrowse.UseVisualStyleBackColor = true;
            this.pcAppBrowse.Click += new System.EventHandler(this.button3_Click);
            // 
            // ipCheck
            // 
            this.ipCheck.Location = new System.Drawing.Point(248, 45);
            this.ipCheck.Name = "ipCheck";
            this.ipCheck.Size = new System.Drawing.Size(59, 23);
            this.ipCheck.TabIndex = 7;
            this.ipCheck.Text = "Check";
            this.ipCheck.UseVisualStyleBackColor = true;
            this.ipCheck.Click += new System.EventHandler(this.button4_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "WWHD Rando EXE (wwhd_rando.exe)|*.exe";
            this.fileDialog.RestoreDirectory = true;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.message.Location = new System.Drawing.Point(53, 155);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 8;
            // 
            // configSwitch
            // 
            this.configSwitch.AutoSize = true;
            this.configSwitch.Checked = true;
            this.configSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.configSwitch.Location = new System.Drawing.Point(56, 194);
            this.configSwitch.Name = "configSwitch";
            this.configSwitch.Size = new System.Drawing.Size(176, 17);
            this.configSwitch.TabIndex = 9;
            this.configSwitch.Text = "Transfer config.yaml (Permalink)";
            this.configSwitch.UseVisualStyleBackColor = true;
            this.configSwitch.CheckedChanged += new System.EventHandler(this.configSwitch_CheckedChanged);
            // 
            // preferencesSwitch
            // 
            this.preferencesSwitch.AutoSize = true;
            this.preferencesSwitch.Checked = true;
            this.preferencesSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preferencesSwitch.Location = new System.Drawing.Point(56, 217);
            this.preferencesSwitch.Name = "preferencesSwitch";
            this.preferencesSwitch.Size = new System.Drawing.Size(214, 17);
            this.preferencesSwitch.TabIndex = 10;
            this.preferencesSwitch.Text = "Transfer preferences.yaml (Preferences)";
            this.preferencesSwitch.UseVisualStyleBackColor = true;
            this.preferencesSwitch.CheckedChanged += new System.EventHandler(this.preferencesSwitch_CheckedChanged);
            // 
            // spoilerLogSwitch
            // 
            this.spoilerLogSwitch.Location = new System.Drawing.Point(56, 362);
            this.spoilerLogSwitch.Name = "spoilerLogSwitch";
            this.spoilerLogSwitch.Size = new System.Drawing.Size(210, 56);
            this.spoilerLogSwitch.TabIndex = 11;
            this.spoilerLogSwitch.Text = "Toggle Spoiler log view";
            this.spoilerLogSwitch.UseVisualStyleBackColor = true;
            this.spoilerLogSwitch.Click += new System.EventHandler(this.spoilerLogSwitch_Click);
            // 
            // plandoSwitch
            // 
            this.plandoSwitch.AutoSize = true;
            this.plandoSwitch.Checked = true;
            this.plandoSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.plandoSwitch.Location = new System.Drawing.Point(56, 171);
            this.plandoSwitch.Name = "plandoSwitch";
            this.plandoSwitch.Size = new System.Drawing.Size(230, 17);
            this.plandoSwitch.TabIndex = 12;
            this.plandoSwitch.Text = "Transfer plandomizer.yaml (Plandomizer file)";
            this.plandoSwitch.UseVisualStyleBackColor = true;
            this.plandoSwitch.CheckedChanged += new System.EventHandler(this.plandoSwitch_CheckedChanged);
            // 
            // spoilerLog
            // 
            this.spoilerLog.Controls.Add(this.openLog);
            this.spoilerLog.Controls.Add(this.delLog);
            this.spoilerLog.Controls.Add(this.listViewSpoiler);
            this.spoilerLog.Controls.Add(this.wiiULog);
            this.spoilerLog.Controls.Add(this.pcLog);
            this.spoilerLog.Location = new System.Drawing.Point(345, 13);
            this.spoilerLog.Name = "spoilerLog";
            this.spoilerLog.Size = new System.Drawing.Size(517, 419);
            this.spoilerLog.TabIndex = 13;
            this.spoilerLog.TabStop = false;
            this.spoilerLog.Text = "Spoiler Logs";
            // 
            // openLog
            // 
            this.openLog.Enabled = false;
            this.openLog.Location = new System.Drawing.Point(401, 349);
            this.openLog.Name = "openLog";
            this.openLog.Size = new System.Drawing.Size(110, 56);
            this.openLog.TabIndex = 16;
            this.openLog.Text = "Open";
            this.openLog.UseVisualStyleBackColor = true;
            this.openLog.Click += new System.EventHandler(this.openLog_Click);
            // 
            // delLog
            // 
            this.delLog.Enabled = false;
            this.delLog.Location = new System.Drawing.Point(285, 349);
            this.delLog.Name = "delLog";
            this.delLog.Size = new System.Drawing.Size(110, 56);
            this.delLog.TabIndex = 17;
            this.delLog.Text = "Delete";
            this.delLog.UseVisualStyleBackColor = true;
            this.delLog.Click += new System.EventHandler(this.delLog_Click);
            // 
            // listViewSpoiler
            // 
            this.listViewSpoiler.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewSpoiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.date});
            this.listViewSpoiler.HideSelection = false;
            this.listViewSpoiler.Location = new System.Drawing.Point(7, 20);
            this.listViewSpoiler.Name = "listViewSpoiler";
            this.listViewSpoiler.Size = new System.Drawing.Size(504, 285);
            this.listViewSpoiler.TabIndex = 0;
            this.listViewSpoiler.UseCompatibleStateImageBehavior = false;
            this.listViewSpoiler.View = System.Windows.Forms.View.Details;
            this.listViewSpoiler.SelectedIndexChanged += new System.EventHandler(this.listViewSpoiler_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "File Name";
            this.name.Width = 362;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 136;
            // 
            // wiiULog
            // 
            this.wiiULog.Location = new System.Drawing.Point(6, 349);
            this.wiiULog.Name = "wiiULog";
            this.wiiULog.Size = new System.Drawing.Size(104, 56);
            this.wiiULog.TabIndex = 14;
            this.wiiULog.Text = "Wii U Logs";
            this.wiiULog.UseVisualStyleBackColor = true;
            this.wiiULog.Click += new System.EventHandler(this.wiiULog_Click);
            // 
            // pcLog
            // 
            this.pcLog.Location = new System.Drawing.Point(116, 349);
            this.pcLog.Name = "pcLog";
            this.pcLog.Size = new System.Drawing.Size(110, 56);
            this.pcLog.TabIndex = 15;
            this.pcLog.Text = "PC Logs";
            this.pcLog.UseVisualStyleBackColor = true;
            this.pcLog.Click += new System.EventHandler(this.pcLog_Click);
            // 
            // plandoBrowse
            // 
            this.plandoBrowse.Location = new System.Drawing.Point(248, 125);
            this.plandoBrowse.Name = "plandoBrowse";
            this.plandoBrowse.Size = new System.Drawing.Size(59, 23);
            this.plandoBrowse.TabIndex = 16;
            this.plandoBrowse.Text = "Browse";
            this.plandoBrowse.UseVisualStyleBackColor = true;
            this.plandoBrowse.Click += new System.EventHandler(this.plandoBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Path to the plandomizer file on your computer";
            // 
            // plandoPath
            // 
            this.plandoPath.Location = new System.Drawing.Point(31, 129);
            this.plandoPath.Name = "plandoPath";
            this.plandoPath.Size = new System.Drawing.Size(210, 20);
            this.plandoPath.TabIndex = 14;
            this.plandoPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // plandoDialog
            // 
            this.plandoDialog.Filter = "Plandomizer file (*.yaml)|*.yaml";
            this.plandoDialog.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 502);
            this.Controls.Add(this.plandoBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plandoPath);
            this.Controls.Add(this.spoilerLog);
            this.Controls.Add(this.plandoSwitch);
            this.Controls.Add(this.spoilerLogSwitch);
            this.Controls.Add(this.preferencesSwitch);
            this.Controls.Add(this.configSwitch);
            this.Controls.Add(this.message);
            this.Controls.Add(this.ipCheck);
            this.Controls.Add(this.pcAppBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.toPc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toWiiU);
            this.Controls.Add(this.wiiuIpTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Config Transfer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.spoilerLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox wiiuIpTextbox;
		private System.Windows.Forms.Button toWiiU;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button toPc;
		private System.Windows.Forms.TextBox pathTextbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button pcAppBrowse;
		private System.Windows.Forms.Button ipCheck;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Label message;
		private System.Windows.Forms.CheckBox configSwitch;
		private System.Windows.Forms.CheckBox preferencesSwitch;
        private System.Windows.Forms.Button spoilerLogSwitch;
        private System.Windows.Forms.CheckBox plandoSwitch;
        private System.Windows.Forms.GroupBox spoilerLog;
        private System.Windows.Forms.ListView listViewSpoiler;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button openLog;
        private System.Windows.Forms.Button delLog;
        private System.Windows.Forms.Button wiiULog;
        private System.Windows.Forms.Button pcLog;
        private System.Windows.Forms.Button plandoBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox plandoPath;
        private System.Windows.Forms.OpenFileDialog plandoDialog;
    }
}

