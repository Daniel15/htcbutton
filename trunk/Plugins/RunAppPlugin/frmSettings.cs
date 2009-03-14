using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PluginInterface;

namespace RunAppPlugin
{
	public partial class frmSettings : PluginSettingsControl
	{
		public frmSettings()
		{
			InitializeComponent();
		}

		public override Dictionary<String, String> SaveSettings()
		{
			Dictionary<string, string> settings = new Dictionary<string, string>();
			settings.Add("app", txtApp.Text);
			return settings;
		}

		public override void LoadSettings()
		{
			txtApp.Text = GetSetting("app", "");
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (openFile.ShowDialog() == DialogResult.OK)
				txtApp.Text = openFile.FileName;
		}
	}
}