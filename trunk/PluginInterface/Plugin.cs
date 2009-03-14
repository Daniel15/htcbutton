/*
 * HandsfreeButton Plugin interface
 * By Daniel15 - http://d15.biz/
 * 
 * This was influenced by several tutorials for plugins in C# on the internet
 * (notably, http://www.codeproject.com/KB/cs/pluginsincsharp.aspx), but all the
 * code is my original code.
 */

using System;

namespace PluginInterface
{
	abstract public class Plugin
	{
		// Various description things.
		public abstract string Name { get; }
		public abstract string Description { get; }
		public abstract string Author { get; }
		public abstract string Version { get; }
		// When we're actually going!
		public abstract void Execute();
	}
}
