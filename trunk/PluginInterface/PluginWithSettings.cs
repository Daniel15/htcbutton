/*
 * HTCButton Plugin (With Settings)
 * By Daniel15 - http://d15.biz/
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PluginInterface
{
	abstract public class PluginWithSettings : Plugin
	{
		protected Dictionary<String, String> _settings = new Dictionary<string,string>();
		// The GUI to configure the plugin.
		public abstract UserControl ConfigInterface { get; }
	}
}
