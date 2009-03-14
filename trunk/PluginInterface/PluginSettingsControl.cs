using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PluginInterface
{
	public class PluginSettingsControl : UserControl 
	{
		public virtual Dictionary<String, String> SaveSettings()
		{
			return new Dictionary<string,string>();	
		}
	}
}
