using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PluginInterface;

namespace HTCAudioManagerPlugin
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

			if (radNext.Checked)
				settings.Add("action", "next");
			else if (radPrev.Checked)
				settings.Add("action", "prev");
			else
				settings.Add("action", "playpause");

			return settings;
		}
	}
}
