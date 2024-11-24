namespace WWHDR_configloader
{
    partial class FileSelecter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSelecter));
            this.label1 = new System.Windows.Forms.Label();
            this.customPath = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.fileExists = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.fileTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the path of the file to modify, starting with a slash\r\n(e.g. /content/Cafe/" +
    "US/AudioRes/JAudioRes/JaiInit.aaf)";
            // 
            // customPath
            // 
            this.customPath.Location = new System.Drawing.Point(16, 53);
            this.customPath.Name = "customPath";
            this.customPath.Size = new System.Drawing.Size(275, 20);
            this.customPath.TabIndex = 1;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(298, 53);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 2;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(265, 168);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 32);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // fileExists
            // 
            this.fileExists.AutoSize = true;
            this.fileExists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fileExists.Location = new System.Drawing.Point(13, 76);
            this.fileExists.Name = "fileExists";
            this.fileExists.Size = new System.Drawing.Size(55, 13);
            this.fileExists.TabIndex = 4;
            this.fileExists.Text = "File exists!";
            this.fileExists.Visible = false;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(298, 118);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 7;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // fileTextbox
            // 
            this.fileTextbox.Location = new System.Drawing.Point(16, 118);
            this.fileTextbox.Name = "fileTextbox";
            this.fileTextbox.Size = new System.Drawing.Size(275, 20);
            this.fileTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "The file will be patched using this file";
            // 
            // fileDialog
            // 
            this.fileDialog.RestoreDirectory = true;
            // 
            // FileSelecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 212);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.fileTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileExists);
            this.Controls.Add(this.add);
            this.Controls.Add(this.check);
            this.Controls.Add(this.customPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileSelecter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "File Selecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customPath;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label fileExists;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox fileTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}