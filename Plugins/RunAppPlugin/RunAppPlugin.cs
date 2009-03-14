using System;
using System.Windows.Forms;
using PluginInterface;
using System.Collections.Generic;

namespace RunAppPlugin
{
	public class RunAppPlugin : PluginWithSettings
	{
		public override string Name { get { return "Run Application"; } }
		public override string Description { get { return "Run a chosen application"; } }
		public override string Author { get { return "Daniel15"; } }
		public override string Version { get { return "0.1"; } }

		public override void InitializeGUI()
		{
			ConfigInterface = new frmSettings();
		}

		public override void Execute()
		{
			string app = GetSetting("app", "");

		}
	}
}
