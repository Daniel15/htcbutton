namespace HTCAudioManagerPlugin
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
			this.radPrev = new System.Windows.Forms.RadioButton();
			this.radNext = new System.Windows.Forms.RadioButton();
			this.radPlayPause = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// radPrev
			// 
			this.radPrev.Location = new System.Drawing.Point(4, 4);
			this.radPrev.Name = "radPrev";
			this.radPrev.Size = new System.Drawing.Size(457, 40);
			this.radPrev.TabIndex = 0;
			this.radPrev.Text = "Go to previous song";
			// 
			// radNext
			// 
			this.radNext.Location = new System.Drawing.Point(4, 50);
			this.radNext.Name = "radNext";
			this.radNext.Size = new System.Drawing.Size(457, 40);
			this.radNext.TabIndex = 1;
			this.radNext.Text = "Go to next song";
			// 
			// radPlayPause
			// 
			this.radPlayPause.Location = new System.Drawing.Point(4, 96);
			this.radPlayPause.Name = "radPlayPause";
			this.radPlayPause.Size = new System.Drawing.Size(457, 40);
			this.radPlayPause.TabIndex = 2;
			this.radPlayPause.Text = "Play/Pause";
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.radPlayPause);
			this.Controls.Add(this.radNext);
			this.Controls.Add(this.radPrev);
			this.Name = "frmSettings";
			this.Size = new System.Drawing.Size(464, 178);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton radPrev;
		private System.Windows.Forms.RadioButton radNext;
		private System.Windows.Forms.RadioButton radPlayPause;
	}
}
