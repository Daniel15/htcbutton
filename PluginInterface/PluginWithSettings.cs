/*
 * HTCButton Plugin (With Settings)
 * By Daniel15 - http://d15.biz/
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace PluginInterface
{
	abstract public class PluginWithSettings : Plugin
	{

		protected PluginSettingsControl _configInterface;
		private RegistryKey _settingsKey;

		public PluginSettingsControl ConfigInterface
		{
			get { return _configInterface; }
			set
			{ 
				_configInterface = value;
				_configInterface.Owner = this;
			}
		}

		public abstract void InitializeGUI();

		public Dictionary<String, String> SaveSettings()
		{
			return _configInterface.SaveSettings();
		}

		public string GetSetting(string key, string defaultValue)
		{
			return (string)_settingsKey.GetValue(key, defaultValue);
		}

		public void LoadSettings()
		{
			_configInterface.LoadSettings();
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
