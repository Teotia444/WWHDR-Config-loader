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
            this.advancedSwitch = new System.Windows.Forms.Button();
            this.plandoSwitch = new System.Windows.Forms.CheckBox();
            this.spoilerLog = new System.Windows.Forms.GroupBox();
            this.openLog = new System.Windows.Forms.Button();
            this.delLog = new System.Windows.Forms.Button();
            this.listViewSpoiler = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wiiULog = new System.Windows.Forms.Button();
            this.pcLog = new System.Windows.Forms.Button();
            this.fileRepView = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gameInstall = new System.Windows.Forms.ComboBox();
            this.patchMessage = new System.Windows.Forms.Label();
            this.addPatch = new System.Windows.Forms.Button();
            this.patchOne = new System.Windows.Forms.Button();
            this.patchAll = new System.Windows.Forms.Button();
            this.removePatch = new System.Windows.Forms.Button();
            this.fileRep = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plandoBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.plandoPath = new System.Windows.Forms.TextBox();
            this.plandoDialog = new System.Windows.Forms.OpenFileDialog();
            this.spoilerLogSwitch = new System.Windows.Forms.Button();
            this.fileRepToggle = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.spoilerLog.SuspendLayout();
            this.fileRepView.SuspendLayout();
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
            // advancedSwitch
            // 
            this.advancedSwitch.Location = new System.Drawing.Point(56, 362);
            this.advancedSwitch.Name = "advancedSwitch";
            this.advancedSwitch.Size = new System.Drawing.Size(210, 56);
            this.advancedSwitch.TabIndex = 11;
            this.advancedSwitch.Text = "Toggle Advanced view";
            this.advancedSwitch.UseVisualStyleBackColor = true;
            this.advancedSwitch.Click += new System.EventHandler(this.advancedSwitch_Click);
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
            this.spoilerLog.Location = new System.Drawing.Point(345, 45);
            this.spoilerLog.Name = "spoilerLog";
            this.spoilerLog.Size = new System.Drawing.Size(517, 387);
            this.spoilerLog.TabIndex = 13;
            this.spoilerLog.TabStop = false;
            this.spoilerLog.Text = "Spoiler Logs";
            // 
            // openLog
            // 
            this.openLog.Enabled = false;
            this.openLog.Location = new System.Drawing.Point(401, 317);
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
            this.delLog.Location = new System.Drawing.Point(285, 317);
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
            this.wiiULog.Location = new System.Drawing.Point(6, 317);
            this.wiiULog.Name = "wiiULog";
            this.wiiULog.Size = new System.Drawing.Size(104, 56);
            this.wiiULog.TabIndex = 14;
            this.wiiULog.Text = "Wii U Logs";
            this.wiiULog.UseVisualStyleBackColor = true;
            this.wiiULog.Click += new System.EventHandler(this.wiiULog_Click);
            // 
            // pcLog
            // 
            this.pcLog.Location = new System.Drawing.Point(116, 317);
            this.pcLog.Name = "pcLog";
            this.pcLog.Size = new System.Drawing.Size(110, 56);
            this.pcLog.TabIndex = 15;
            this.pcLog.Text = "PC Logs";
            this.pcLog.UseVisualStyleBackColor = true;
            this.pcLog.Click += new System.EventHandler(this.pcLog_Click);
            // 
            // fileRepView
            // 
            this.fileRepView.Controls.Add(this.label5);
            this.fileRepView.Controls.Add(this.label4);
            this.fileRepView.Controls.Add(this.gameInstall);
            this.fileRepView.Controls.Add(this.patchMessage);
            this.fileRepView.Controls.Add(this.addPatch);
            this.fileRepView.Controls.Add(this.patchOne);
            this.fileRepView.Controls.Add(this.patchAll);
            this.fileRepView.Controls.Add(this.removePatch);
            this.fileRepView.Controls.Add(this.fileRep);
            this.fileRepView.Enabled = false;
            this.fileRepView.Location = new System.Drawing.Point(345, 47);
            this.fileRepView.Name = "fileRepView";
            this.fileRepView.Size = new System.Drawing.Size(517, 387);
            this.fileRepView.TabIndex = 18;
            this.fileRepView.TabStop = false;
            this.fileRepView.Text = "File Replacement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Game install:";
            // 
            // gameInstall
            // 
            this.gameInstall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameInstall.FormattingEnabled = true;
            this.gameInstall.Items.AddRange(new object[] {
            "NAND (Wii U Internal Memory)",
            "USB Drive"});
            this.gameInstall.Location = new System.Drawing.Point(7, 75);
            this.gameInstall.Name = "gameInstall";
            this.gameInstall.Size = new System.Drawing.Size(279, 21);
            this.gameInstall.TabIndex = 7;
            this.gameInstall.SelectedIndexChanged += new System.EventHandler(this.gameInstall_SelectedIndexChanged);
            // 
            // patchMessage
            // 
            this.patchMessage.AutoSize = true;
            this.patchMessage.Location = new System.Drawing.Point(7, 124);
            this.patchMessage.Name = "patchMessage";
            this.patchMessage.Size = new System.Drawing.Size(0, 13);
            this.patchMessage.TabIndex = 6;
            // 
            // addPatch
            // 
            this.addPatch.Location = new System.Drawing.Point(6, 342);
            this.addPatch.Name = "addPatch";
            this.addPatch.Size = new System.Drawing.Size(148, 37);
            this.addPatch.TabIndex = 5;
            this.addPatch.Text = "Add new patch";
            this.addPatch.UseVisualStyleBackColor = true;
            this.addPatch.Click += new System.EventHandler(this.addPatch_Click);
            // 
            // patchOne
            // 
            this.patchOne.Location = new System.Drawing.Point(186, 342);
            this.patchOne.Name = "patchOne";
            this.patchOne.Size = new System.Drawing.Size(147, 39);
            this.patchOne.TabIndex = 4;
            this.patchOne.Text = "Patch selected";
            this.patchOne.UseVisualStyleBackColor = true;
            this.patchOne.Click += new System.EventHandler(this.patchOne_Click);
            // 
            // patchAll
            // 
            this.patchAll.Location = new System.Drawing.Point(370, 342);
            this.patchAll.Name = "patchAll";
            this.patchAll.Size = new System.Drawing.Size(147, 39);
            this.patchAll.TabIndex = 3;
            this.patchAll.Text = "Patch all";
            this.patchAll.UseVisualStyleBackColor = true;
            this.patchAll.Click += new System.EventHandler(this.patchAll_Click);
            // 
            // removePatch
            // 
            this.removePatch.Location = new System.Drawing.Point(364, 102);
            this.removePatch.Name = "removePatch";
            this.removePatch.Size = new System.Drawing.Size(147, 39);
            this.removePatch.TabIndex = 2;
            this.removePatch.Text = "Remove selected patch";
            this.removePatch.UseVisualStyleBackColor = true;
            this.removePatch.Click += new System.EventHandler(this.removePatch_Click);
            // 
            // fileRep
            // 
            this.fileRep.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.fileRep.CheckBoxes = true;
            this.fileRep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.fileRep.HideSelection = false;
            this.fileRep.Location = new System.Drawing.Point(7, 147);
            this.fileRep.MultiSelect = false;
            this.fileRep.Name = "fileRep";
            this.fileRep.Size = new System.Drawing.Size(510, 186);
            this.fileRep.TabIndex = 1;
            this.fileRep.UseCompatibleStateImageBehavior = false;
            this.fileRep.View = System.Windows.Forms.View.Details;
            this.fileRep.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.fileRep_ItemChecked);
            this.fileRep.SelectedIndexChanged += new System.EventHandler(this.fileRep_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 246;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Patch with";
            this.columnHeader2.Width = 260;
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
            // spoilerLogSwitch
            // 
            this.spoilerLogSwitch.Location = new System.Drawing.Point(345, 5);
            this.spoilerLogSwitch.Name = "spoilerLogSwitch";
            this.spoilerLogSwitch.Size = new System.Drawing.Size(154, 39);
            this.spoilerLogSwitch.TabIndex = 18;
            this.spoilerLogSwitch.Text = "Spoiler Log View";
            this.spoilerLogSwitch.UseVisualStyleBackColor = true;
            this.spoilerLogSwitch.Click += new System.EventHandler(this.spoilerLogSwitch_Click);
            // 
            // fileRepToggle
            // 
            this.fileRepToggle.Location = new System.Drawing.Point(524, 5);
            this.fileRepToggle.Name = "fileRepToggle";
            this.fileRepToggle.Size = new System.Drawing.Size(154, 39);
            this.fileRepToggle.TabIndex = 19;
            this.fileRepToggle.Text = "File Patcher View";
            this.fileRepToggle.UseVisualStyleBackColor = true;
            this.fileRepToggle.Click += new System.EventHandler(this.fileRepToggle_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(702, 5);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(154, 39);
            this.settings.TabIndex = 20;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "You need to have the \"Allow access to system files\"\r\nenabled in ftpiiu in order t" +
    "o use this tab.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 446);
            this.Controls.Add(this.fileRepView);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.fileRepToggle);
            this.Controls.Add(this.spoilerLogSwitch);
            this.Controls.Add(this.plandoBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plandoPath);
            this.Controls.Add(this.spoilerLog);
            this.Controls.Add(this.plandoSwitch);
            this.Controls.Add(this.advancedSwitch);
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
            this.fileRepView.ResumeLayout(false);
            this.fileRepView.PerformLayout();
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
        private System.Windows.Forms.Button advancedSwitch;
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
        private System.Windows.Forms.Button spoilerLogSwitch;
        private System.Windows.Forms.Button fileRepToggle;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.GroupBox fileRepView;
        private System.Windows.Forms.ListView fileRep;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button removePatch;
        private System.Windows.Forms.Button patchOne;
        private System.Windows.Forms.Button patchAll;
        private System.Windows.Forms.Button addPatch;
        private System.Windows.Forms.Label patchMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox gameInstall;
        private System.Windows.Forms.Label label5;
    }
}

