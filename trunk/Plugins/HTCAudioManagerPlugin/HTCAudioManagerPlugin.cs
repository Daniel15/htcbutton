using System;
using System.Windows.Forms;
using PluginInterface;

namespace HTCAudioManagerPlugin
{
	public class HTCAudioManagerPlugin : PluginWithSettings
	{
		public override string Name { get { return "HTC AudioManager Controller"; } }
		public override string Description { get { return "Plugin to control the HTC TouchFLO3D AudioManager"; } }
		public override string Author { get { return "Daniel15"; } }
		public override string Version { get { return "0.1 prerelease"; } }

		public override UserControl ConfigInterface { get { return new settings(); } }

		public override void Execute()
		{
			MessageBox.Show("Hello world!");
		}
	}
}
