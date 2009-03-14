namespace HTCButton
{
	partial class frmMain
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
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.lblWebsite = new System.Windows.Forms.LinkLabel();
			this.lblVersion = new System.Windows.Forms.Label();
			this.tabsMain = new System.Windows.Forms.TabControl();
			this.tabDoubleTap = new System.Windows.Forms.TabPage();
			this.lblDoubleTapAuthor = new System.Windows.Forms.Label();
			this.pnlDoubleTap = new System.Windows.Forms.Panel();
			this.lblDoubleTapDesc = new System.Windows.Forms.Label();
			this.cmbDoubleTap = new System.Windows.Forms.ComboBox();
			this.lblDoubleTap = new System.Windows.Forms.Label();
			this.tabHold = new System.Windows.Forms.TabPage();
			this.cmbHold = new System.Windows.Forms.ComboBox();
			this.lblHold = new System.Windows.Forms.Label();
			this.menuMain = new System.Windows.Forms.MainMenu();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItemSave = new System.Windows.Forms.MenuItem();
			this.lblDoubleTapVersion = new System.Windows.Forms.Label();
			this.tabGeneral.SuspendLayout();
			this.tabsMain.SuspendLayout();
			this.tabDoubleTap.SuspendLayout();
			this.tabHold.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.lblWebsite);
			this.tabGeneral.Controls.Add(this.lblVersion);
			this.tabGeneral.Location = new System.Drawing.Point(0, 0);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Size = new System.Drawing.Size(480, 492);
			this.tabGeneral.Text = "About";
			// 
			// lblWebsite
			// 
			this.lblWebsite.Location = new System.Drawing.Point(7, 229);
			this.lblWebsite.Name = "lblWebsite";
			this.lblWebsite.Size = new System.Drawing.Size(466, 43);
			this.lblWebsite.TabIndex = 5;
			this.lblWebsite.Text = "http://d15.biz/";
			this.lblWebsite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblVersion
			// 
			this.lblVersion.Location = new System.Drawing.Point(7, 166);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(466, 63);
			this.lblVersion.Text = "HandsfreeButton version {0}\r\nBy Daniel15";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tabsMain
			// 
			this.tabsMain.Controls.Add(this.tabDoubleTap);
			this.tabsMain.Controls.Add(this.tabHold);
			this.tabsMain.Controls.Add(this.tabGeneral);
			this.tabsMain.Location = new System.Drawing.Point(0, 0);
			this.tabsMain.Name = "tabsMain";
			this.tabsMain.SelectedIndex = 0;
			this.tabsMain.Size = new System.Drawing.Size(480, 536);
			this.tabsMain.TabIndex = 0;
			// 
			// tabDoubleTap
			// 
			this.tabDoubleTap.Controls.Add(this.lblDoubleTapVersion);
			this.tabDoubleTap.Controls.Add(this.lblDoubleTapAuthor);
			this.tabDoubleTap.Controls.Add(this.pnlDoubleTap);
			this.tabDoubleTap.Controls.Add(this.lblDoubleTapDesc);
			this.tabDoubleTap.Controls.Add(this.cmbDoubleTap);
			this.tabDoubleTap.Controls.Add(this.lblDoubleTap);
			this.tabDoubleTap.Location = new System.Drawing.Point(0, 0);
			this.tabDoubleTap.Name = "tabDoubleTap";
			this.tabDoubleTap.Size = new System.Drawing.Size(480, 492);
			this.tabDoubleTap.Text = "Double-tap Options";
			// 
			// lblDoubleTapAuthor
			// 
			this.lblDoubleTapAuthor.Location = new System.Drawing.Point(7, 91);
			this.lblDoubleTapAuthor.Name = "lblDoubleTapAuthor";
			this.lblDoubleTapAuthor.Size = new System.Drawing.Size(466, 40);
			this.lblDoubleTapAuthor.Tag = "Author: {0}";
			this.lblDoubleTapAuthor.Text = "Author: {0}";
			// 
			// pnlDoubleTap
			// 
			this.pnlDoubleTap.Location = new System.Drawing.Point(7, 294);
			this.pnlDoubleTap.Name = "pnlDoubleTap";
			this.pnlDoubleTap.Size = new System.Drawing.Size(466, 195);
			// 
			// lblDoubleTapDesc
			// 
			this.lblDoubleTapDesc.Location = new System.Drawing.Point(7, 171);
			this.lblDoubleTapDesc.Name = "lblDoubleTapDesc";
			this.lblDoubleTapDesc.Size = new System.Drawing.Size(466, 120);
			this.lblDoubleTapDesc.Tag = "Description: {0}";
			this.lblDoubleTapDesc.Text = "Description: {0}";
			// 
			// cmbDoubleTap
			// 
			this.cmbDoubleTap.DisplayMember = "value";
			this.cmbDoubleTap.Location = new System.Drawing.Point(7, 47);
			this.cmbDoubleTap.Name = "cmbDoubleTap";
			this.cmbDoubleTap.Size = new System.Drawing.Size(466, 41);
			this.cmbDoubleTap.TabIndex = 3;
			this.cmbDoubleTap.ValueMember = "key";
			this.cmbDoubleTap.SelectedIndexChanged += new System.EventHandler(this.cmbDoubleTap_SelectedIndexChanged);
			// 
			// lblDoubleTap
			// 
			this.lblDoubleTap.Location = new System.Drawing.Point(7, 4);
			this.lblDoubleTap.Name = "lblDoubleTap";
			this.lblDoubleTap.Size = new System.Drawing.Size(466, 40);
			this.lblDoubleTap.Text = "Plugin to use on double tap:";
			// 
			// tabHold
			// 
			this.tabHold.Controls.Add(this.cmbHold);
			this.tabHold.Controls.Add(this.lblHold);
			this.tabHold.Location = new System.Drawing.Point(0, 0);
			this.tabHold.Name = "tabHold";
			this.tabHold.Size = new System.Drawing.Size(480, 492);
			this.tabHold.Text = "Hold Options";
			// 
			// cmbHold
			// 
			this.cmbHold.DisplayMember = "value";
			this.cmbHold.Location = new System.Drawing.Point(7, 47);
			this.cmbHold.Name = "cmbHold";
			this.cmbHold.Size = new System.Drawing.Size(466, 41);
			this.cmbHold.TabIndex = 5;
			this.cmbHold.ValueMember = "key";
			// 
			// lblHold
			// 
			this.lblHold.Location = new System.Drawing.Point(7, 4);
			this.lblHold.Name = "lblHold";
			this.lblHold.Size = new System.Drawing.Size(466, 40);
			this.lblHold.Text = "Plugin to use on hold:";
			// 
			// menuMain
			// 
			this.menuMain.MenuItems.Add(this.menuItemExit);
			this.menuMain.MenuItems.Add(this.menuItemSave);
			// 
			// menuItemExit
			// 
			this.menuItemExit.Text = "Exit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItemSave
			// 
			this.menuItemSave.Text = "Save Changes";
			// 
			// lblDoubleTapVersion
			// 
			this.lblDoubleTapVersion.Location = new System.Drawing.Point(7, 131);
			this.lblDoubleTapVersion.Name = "lblDoubleTapVersion";
			this.lblDoubleTapVersion.Size = new System.Drawing.Size(466, 40);
			this.lblDoubleTapVersion.Tag = "Version: {0}";
			this.lblDoubleTapVersion.Text = "Version: {0}";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(480, 536);
			this.Controls.Add(this.tabsMain);
			this.KeyPreview = true;
			this.Location = new System.Drawing.Point(0, 52);
			this.Menu = this.menuMain;
			this.Name = "frmMain";
			this.Text = "HandsfreeButton";
			this.tabGeneral.ResumeLayout(false);
			this.tabsMain.ResumeLayout(false);
			this.tabDoubleTap.ResumeLayout(false);
			this.tabHold.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.LinkLabel lblWebsite;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.TabControl tabsMain;
		private System.Windows.Forms.MainMenu menuMain;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItemSave;
		private System.Windows.Forms.TabPage tabDoubleTap;
		private System.Windows.Forms.TabPage tabHold;
		private System.Windows.Forms.Panel pnlDoubleTap;
		private System.Windows.Forms.Label lblDoubleTapDesc;
		private System.Windows.Forms.ComboBox cmbDoubleTap;
		private System.Windows.Forms.Label lblDoubleTap;
		private System.Windows.Forms.ComboBox cmbHold;
		private System.Windows.Forms.Label lblHold;
		private System.Windows.Forms.Label lblDoubleTapAuthor;
		private System.Windows.Forms.Label lblDoubleTapVersion;

	}
}