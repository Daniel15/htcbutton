/*
 * HTCButton - "Hello World 2" plugin
 * A more advanced plugin showing how to add GUI config
 */

using System;
using System.Windows.Forms;
using PluginInterface;
using System.Collections.Generic;

namespace HelloWorld2Plugin
{
	public class HelloWorld2 : PluginWithSettings
	{
		public override string Name { get { return "Hello World w/GUI config"; } }
		public override string Description { get { return "Just a test plugin demonstrating GUI configuration of plugin."; } }
		public override string Author { get { return "Daniel15"; } }
		public override string Version { get { return "1.0"; } }

		/*
		 * This is the main difference between this plugin and the other "Hello
		 * World": The ConfigInterface. ConfigInterface is a property that 
		 * stores our config GUI. 
		 * 
		 * Take a look at frmSettings.cs to see how the settings are loaded and
		 * saved.
		 */
		public override PluginSettingsControl InitializeGUI()
		{
			return new frmSettings();
		}

		public override void Execute()
		{
			// Here we get the "text" setting!
			string text = GetSetting("text", "nothing");
			MessageBox.Show(String.Format("Hello world! You entered {0}", text));
		}
	}
}
