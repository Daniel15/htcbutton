using System;
using Microsoft.Win32;
using System.Reflection;
using System.Diagnostics;

namespace PluginInterface
{
	public class PluginServices
	{
		private const string REGISTRY_KEY = @"SOFTWARE\Daniel15\HTCButton";
		private static RegistryKey _registryKey = Registry.LocalMachine.OpenSubKey(REGISTRY_KEY);
		private static string _pluginDir = (string)_registryKey.GetValue(
			"PluginPath", System.IO.Path.GetDirectoryName(
					System.Reflection.Assembly.GetExecutingAssembly().
					GetName().CodeBase) 
				+ "\\Plugins");

		/// <summary>
		/// Load and execute a plugin
		/// </summary>
		/// <param name="type">The type of plugin (DoubleTap, etc.) to load</param>
		public bool Load(string type)
		{
			// Get the name of the plugin we're loading.
			RegistryKey regKey = _registryKey.OpenSubKey(type);
			string dllFile = (string)regKey.GetValue("File", "");
			if (dllFile == "")
			{
				System.Windows.Forms.MessageBox.Show(String.Format("Please configure the {0} setting first", type));
				return false;
			}

			// Load it!
			string className = (string)regKey.GetValue("Class");
			Assembly pluginAssembly = Assembly.LoadFrom(_pluginDir + "\\" + dllFile);
			Plugin plugin = (Plugin)pluginAssembly.CreateInstance(className);

			// If it uses settings, tell it where they are
			if (plugin is PluginWithSettings)
			{
				Debug.WriteLine(String.Format("Loading settings from {0}", REGISTRY_KEY + "\\" + type), "PluginServices");
				((PluginWithSettings)plugin).SettingsRegKey = REGISTRY_KEY + "\\" + type;
			}

			// Actually run it.
			plugin.Execute();
			return true;
		}
	}
}
