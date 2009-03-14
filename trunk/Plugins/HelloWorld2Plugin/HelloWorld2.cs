/*
 * HTCButton - "Hello World 2" plugin
 * A more advanced plugin showing how to add GUI config
 */

using System;
using System.Windows.Forms;
using PluginInterface;

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
		 * World": The ConfigInterface. The UserControl returned here will be 
		 * shown in the GUI config
		 */
		public override UserControl ConfigInterface { get { return new settings(); } }

		public override void Execute()
		{
			MessageBox.Show("Hello world!");
		}
	}
}
