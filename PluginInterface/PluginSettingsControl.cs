﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Win32;

namespace PluginInterface
{
	public class PluginSettingsControl : UserControl 
	{
		private PluginWithSettings _owner;
		private RegistryKey _settingsKey;

		public PluginWithSettings Owner
		{
			set { _owner = value; }
		}

		/* TODO: These should be abstract!! Can't have abstract stuff in a class
		 * that's not abstract, and the Form Designer *requires* that this class
		 * is not abstract. Must think about how to do this...
		 */
		/// <summary>
		/// Save settings for this plugin. Return a Dictionary of the settings
		/// you want to save. Used by the GUI.
		/// </summary>
		/// <returns>Hashtable of settings to save</returns>
		public virtual Dictionary<String, String> SaveSettings()
		{
			
			Debug.WriteLine("ERROR: SaveSettings() called, but no implementation!", "PluginSettingsControl");
			return new Dictionary<string,string>();
		}

		/// <summary>
		/// Called when the plugin should load the settings. Load all your
		/// settings using GetSetting() in here. Used by the GUI.
		/// </summary>
		public virtual void LoadSettings()
		{
			Debug.WriteLine("ERROR: LoadSettings() called, but no implementation!", "PluginSettingsControl");
		}

		/// <summary>
		/// Get a particular setting. Used in the GUI.
		/// </summary>
		/// <param name="key">Setting to get</param>
		/// <param name="defaultValue">Default value to use</param>
		/// <returns>What the setting is set to, or defaultValue if not set</returns>
		protected string GetSetting(string key, string defaultValue)
		{
			return (string)_settingsKey.GetValue(key, defaultValue);
		}

		/// <summary>
		/// Internal property that should not be used by you. :P
		/// </summary>
		public string SettingsRegKey
		{
			set
			{
				_settingsKey = Registry.LocalMachine.OpenSubKey(value);
				Debug.WriteLine(String.Format("Set _settingsKey to {0}", value), "PluginWithSettings");
			}
		}
	}
}
