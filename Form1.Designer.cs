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
			this.wiiuIpTextbox = new System.Windows.Forms.TextBox();
			this.toWiiU = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.toPc = new System.Windows.Forms.Button();
			this.pathTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.ipCheck = new System.Windows.Forms.Button();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.message = new System.Windows.Forms.Label();
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
			this.toWiiU.Location = new System.Drawing.Point(56, 256);
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
			this.toPc.Location = new System.Drawing.Point(56, 186);
			this.toPc.Name = "toPc";
			this.toPc.Size = new System.Drawing.Size(210, 54);
			this.toPc.TabIndex = 3;
			this.toPc.Text = "Wii U -> PC";
			this.toPc.UseVisualStyleBackColor = true;
			this.toPc.Click += new System.EventHandler(this.toPc_Click);
			// 
			// pathTextbox
			// 
			this.pathTextbox.Location = new System.Drawing.Point(32, 94);
			this.pathTextbox.Name = "pathTextbox";
			this.pathTextbox.Size = new System.Drawing.Size(210, 20);
			this.pathTextbox.TabIndex = 4;
			this.pathTextbox.TextChanged += new System.EventHandler(this.pathTextbox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Path to the desktop application";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(249, 90);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(59, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Browse";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
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
			this.message.Location = new System.Drawing.Point(29, 143);
			this.message.Name = "message";
			this.message.Size = new System.Drawing.Size(0, 13);
			this.message.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 356);
			this.Controls.Add(this.message);
			this.Controls.Add(this.ipCheck);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pathTextbox);
			this.Controls.Add(this.toPc);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toWiiU);
			this.Controls.Add(this.wiiuIpTextbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Config Transfer";
			this.Load += new System.EventHandler(this.Form1_Load);
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
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button ipCheck;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Label message;
	}
}

