using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace PluginInterface
{
	public class PluginSettingsControl : UserControl 
	{
		private PluginWithSettings _owner;

		public PluginWithSettings Owner
		{
			set { _owner = value; }
		}

		/* TODO: These should be abstract!! Can't have abstract stuff in a class
		 * that's not abstract, and the Form Designer *requires* that this class
		 * is not abstract. Must think about how to do this...
		 */
		public virtual Dictionary<String, String> SaveSettings()
		{
			
			Debug.WriteLine("ERROR: SaveSettings() called, but no implementation!", "PluginSettingsControl");
			return new Dictionary<string,string>();	
		}

		public virtual void LoadSettings()
		{
			Debug.WriteLine("ERROR: LoadSettings() called, but no implementation!", "PluginSettingsControl");
			return;
		}

		protected string GetSetting(string key, string defaultValue)
		{
			return _owner.GetSetting(key, defaultValue);
		}
	}
}
