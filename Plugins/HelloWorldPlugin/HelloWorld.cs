/*
 * HTCButton - "Hello World" plugin
 * A simple plugin demonstrating how a basic HTCButton plugin is written
 */

using System;
using System.Windows.Forms;
using PluginInterface;

namespace HelloWorldPlugin
{
	public class HelloWorld : Plugin
	{
		public override string Name { get { return "Hello World"; } }
		public override string Description { get { return "Just a test plugin"; } }
		public override string Author { get { return "Daniel15"; } }
		public override string Version { get { return "1.0"; } }

		public override void Execute()
		{
			MessageBox.Show("Hello world!");
		}
	}
}
