using System;
using System.Windows.Forms;
using PluginInterface;
using System.Collections.Generic;
using HTCAudioManagerControl;

namespace HTCAudioManagerPlugin
{
	public class HTCAudioManagerPlugin : PluginWithSettings
	{
		public override string Name { get { return "HTC AudioManager Controller"; } }
		public override string Description { get { return "Plugin to control the HTC TouchFLO3D AudioManager"; } }
		public override string Author { get { return "Daniel15"; } }
		public override string Version { get { return "0.0.2"; } }

		public override void InitializeGUI()
		{
			ConfigInterface = new frmSettings();
		}

		public override void Execute()
		{
			AudioManagerControl amc;

			// Try to connect to AudioManager
			try
			{
				amc = new AudioManagerControl();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not connect to AudioManager - " + ex.Message, "HTCAudioManagerPlugin");
				return;
			}

			// What are we actually doing?
			switch (GetSetting("action", "playpause"))
			{
				case "next":
					amc.Next();
					break;
				case "prev":
					amc.Prev();
					break;
				default:
					amc.PlayPause();
					break;
			}
		}
	}
}
