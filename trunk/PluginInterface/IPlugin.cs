/*
 * HandsfreeButton Plugin interface
 * 
 * This was influenced by several tutorials for plugins in C# on the internet
 * (notably, http://www.codeproject.com/KB/cs/pluginsincsharp.aspx), but all the
 * code is my original code.
 */

using System;

namespace PluginInterface
{
	public interface IPlugin
	{
		// Various description things.
		string Name { get; }
		string Description { get; }
		string Author { get; }
		string Version { get; }
		// The GUI to configure the plugin.
		System.Windows.Forms.UserControl ConfigInterface { get; }
		// When we're actually going!
		void Execute();
	}
}
