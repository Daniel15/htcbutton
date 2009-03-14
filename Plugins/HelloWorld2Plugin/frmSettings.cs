using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PluginInterface;

namespace HelloWorld2Plugin
{
	public partial class frmSettings : PluginSettingsControl
	{
		// This is always required in things designed in Visual Studio.
		public frmSettings()
		{
			InitializeComponent();
		}

		// Here's our saving magic
		public override Dictionary<string, string> SaveSettings()
		{
			Dictionary<string, string> settings = new Dictionary<string, string>();
			settings.Add("text", textBox1.Text);
			return settings;
		}

		// And likewise, the loading magic
		public override void LoadSettings()
		{
			textBox1.Text = GetSetting("text", "nothing");
		}
	}
}
