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
		// This is used when actually running the plugin.
		private RegistryKey _settingsKey;
		// An array of our config interfaces
		private Dictionary<String, PluginSettingsControl> _configInterfaces = new Dictionary<string,PluginSettingsControl>();

		/// <summary>
		/// Initialise our array of GUI configuration panels. Each "type" of 
		/// plugin (double tap, tap and hold, etc.) require one panel, so as to
		/// keep them all separate. If the same plugin is used on two types, 
		/// their settings are both different.
		/// </summary>
		/// <param name="guiNames"></param>
		public void InitializeGUIs(string[] guiNames)
		{
			// Delete any existing ones.
			_configInterfaces.Clear();
			// Now we need to go through all the ones we need to create.
			foreach (string guiName in guiNames)
				_configInterfaces.Add(guiName, InitializeGUI());
		}

		public PluginSettingsControl ConfigInterface(string interfaceName)
		{
			return _configInterfaces[interfaceName];
		}

		public abstract PluginSettingsControl InitializeGUI();

		/// <summary>
		/// Get a particular setting. Used in the plugin itself.
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
