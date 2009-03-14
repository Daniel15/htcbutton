namespace RunAppPlugin
{
	partial class frmSettings
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblApp = new System.Windows.Forms.Label();
			this.txtApp = new System.Windows.Forms.TextBox();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblApp
			// 
			this.lblApp.Location = new System.Drawing.Point(4, 4);
			this.lblApp.Name = "lblApp";
			this.lblApp.Size = new System.Drawing.Size(457, 40);
			this.lblApp.Text = "Application to run:";
			// 
			// txtApp
			// 
			this.txtApp.Location = new System.Drawing.Point(4, 48);
			this.txtApp.Name = "txtApp";
			this.txtApp.Size = new System.Drawing.Size(418, 41);
			this.txtApp.TabIndex = 1;
			// 
			// openFile
			// 
			this.openFile.Filter = "EXE files|*.exe";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(428, 48);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(33, 40);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "...";
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtApp);
			this.Controls.Add(this.lblApp);
			this.Name = "frmSettings";
			this.Size = new System.Drawing.Size(464, 178);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblApp;
		private System.Windows.Forms.TextBox txtApp;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.Button btnBrowse;
	}
}
