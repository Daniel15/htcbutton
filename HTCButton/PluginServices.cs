using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;
using PluginInterface;

namespace HTCButton
{
	class AvailablePlugin
	{
		private Plugin _plugin;
		private string _fileName;
		private string _class;
		
		public Plugin Plugin
		{
			get { return _plugin; }
		}

		public string FileName
		{
			get { return _fileName; }
		}

		public string Class
		{
			get { return _class; }
		}

		public AvailablePlugin(string fileName, string className, Plugin plugin)
		{
			_fileName = fileName;
			_plugin = plugin;
			_class = className;
		}

		public override string ToString()
		{
			return String.Format("{0} ({1})", Plugin.Name, FileName);
		}
	}


	static class PluginServices
	{
		static private string _pluginDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\Plugins";
		//private IDictionary<string, AvailablePluginFile> _pluginFiles;
		static private Dictionary<string, AvailablePlugin> _plugins;

		static public Dictionary<string, AvailablePlugin> Plugins
		{
			get { return _plugins; }
		}

		static public Dictionary<string, AvailablePlugin> FindPlugins()
		{
			// Start with an empty plugins listing
			_plugins = new Dictionary<string, AvailablePlugin>();
			
			// Let's find the files that we have in here!
			string[] files = Directory.GetFiles(_pluginDir, "*.dll");
			foreach (string filePath in files)
			{
				// Get just the name of the file
				string fileName = Path.GetFileName(filePath);

				Debug.WriteLine(String.Format("Searching in {0}...", fileName), "PluginServices");

				// Load this assembly file
				Assembly pluginAssembly = Assembly.LoadFrom(filePath);
				foreach (Type classType in pluginAssembly.GetTypes())
				{
					// If it's private or abstract, we  don't want it.
					if (!classType.IsPublic || classType.IsAbstract)
						continue;

					/*
					 * // Now we look to see if it implements IPlugin
					bool isValid = false;

					foreach (Type interfaceType in classType.GetInterfaces())
					{
						if (interfaceType.FullName == "PluginInterface.IPlugin")
						{
							isValid = true;
							break;
						}
					}

					// No IPlugin? We don't want it.
					if (!isValid)
						continue;*/

					// Make sure it's a plugin
					if (!typeof(Plugin).IsAssignableFrom(classType))
						continue;

					Debug.WriteLine(String.Format("=> Found plugin class {0}", classType), "PluginServices");

					// Load this plugin and add it to our list.
					Plugin pluginInternal = (Plugin)Activator.CreateInstance(pluginAssembly.GetType(classType.FullName));
					AvailablePlugin plugin = new AvailablePlugin(fileName, classType.FullName, pluginInternal);
					_plugins.Add(fileName + '/' + classType.FullName, plugin);

					// Cleanup
					pluginInternal = null;
					plugin = null;
				}
			}
			return _plugins;
		}
	}
}
