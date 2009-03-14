/*
 * HTCButton GUI configuration form
 * By Daniel15 - http://d15.biz/
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PluginInterface;
using Microsoft.Win32;

namespace HTCButton
{
	public partial class frmMain : Form
	{
		private const string REGISTRY_KEY = @"SOFTWARE\Daniel15\HTCButton";

		private class ComboBoxValue
		{
			public string key;
			public AvailablePlugin value;

			public ComboBoxValue(string key, AvailablePlugin value)
			{
				this.key = key;
				this.value = value;
			}

			public override string ToString()
			{
				return this.value.ToString();
			}
		}

		public frmMain()
		{
			InitializeComponent();
			// TODO: Remove this when this feature works.
			tabsMain.TabPages.RemoveAt(1);
			tabsMain.SelectedIndex = 0;

			// Set the version string
			lblVersion.Text = String.Format(lblVersion.Text, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);

			// Get a list of all the plugins we have
			PluginServices.FindPlugins();
			foreach (KeyValuePair<string, AvailablePlugin> kvp in PluginServices.Plugins)
			{
				cmbDoubleTap.Items.Add(new ComboBoxValue(kvp.Key, kvp.Value));
				//cmbHold.Items.Add(new ComboBoxValue(kvp.Key, kvp.Value));
			}

			// Now, what plugins have we chosen?
			RegistryKey regKey = Registry.LocalMachine.OpenSubKey(REGISTRY_KEY, true);

			RegistryKey doubleTapKey = regKey.CreateSubKey("DoubleTap");
			// Do we have some info on double tap?
			if (doubleTapKey != null && (string)doubleTapKey.GetValue("File", "") != "")
			{
				string dllFile = (string)doubleTapKey.GetValue("File", "");
				string className = (string)doubleTapKey.GetValue("Class", "");

				//cmbDoubleTap.SelectedValue = dllFile + "/" + className;
				for (int i = 0; i < cmbDoubleTap.Items.Count; i++)
				{
					if (((ComboBoxValue)cmbDoubleTap.Items[i]).key == dllFile + "/" + className)
					{
						cmbDoubleTap.SelectedIndex = i;
						break;
					}
				}
			}
		}

		private void menuItemExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void cmbDoubleTap_SelectedIndexChanged(object sender, EventArgs e)
		{
			AvailablePlugin plugin = ((ComboBoxValue)cmbDoubleTap.SelectedItem).value;
			lblDoubleTapDesc.Text = String.Format((string)lblDoubleTapDesc.Tag, plugin.Plugin.Description);
			lblDoubleTapAuthor.Text = String.Format((string)lblDoubleTapAuthor.Tag, plugin.Plugin.Author);
			lblDoubleTapVersion.Text = String.Format((string)lblDoubleTapVersion.Tag, plugin.Plugin.Version);

			pnlDoubleTap.Controls.Clear();

			// Is this a plugin with a GUI?
			if (plugin.Plugin is PluginWithSettings)
			{
				PluginWithSettings pws = (PluginWithSettings)plugin.Plugin;
				pws.ConfigInterface.Dock = DockStyle.Fill;
				// Before we add it, let's tell it to load the settings.
				pws.SettingsRegKey = REGISTRY_KEY + "\\DoubleTap";
				pws.LoadSettings();
				pnlDoubleTap.Controls.Add(pws.ConfigInterface);
			}
		}

		private void menuItemSave_Click(object sender, EventArgs e)
		{
			RegistryKey regKey = Registry.LocalMachine.OpenSubKey(REGISTRY_KEY, true);

			// Settings for "Double Tap".
			//RegistryKey doubleTapKey = regKey.OpenSubKey("DoubleTap", true);
			RegistryKey doubleTapKey = regKey.CreateSubKey("DoubleTap");
			// Delete all the current values
			foreach (string value in doubleTapKey.GetValueNames())
				doubleTapKey.DeleteValue(value);

			// Get the plugin we're using.
			AvailablePlugin doubleTap = ((ComboBoxValue)cmbDoubleTap.SelectedItem).value;

			// If it has settings, we need to save those
			if (doubleTap.Plugin is PluginWithSettings)
			{
				PluginWithSettings doubleTapPlugin = (PluginWithSettings)doubleTap.Plugin;
				Dictionary<string, string> settings = doubleTapPlugin.SaveSettings();
				foreach (KeyValuePair<string, string> kvp in settings)
				{
					doubleTapKey.SetValue(kvp.Key, kvp.Value);
				}

				doubleTapPlugin.LoadSettings();

			}
			// Save info on the plugin itself.
			doubleTapKey.SetValue("File", doubleTap.FileName);
			doubleTapKey.SetValue("Class", doubleTap.Class);
			// All done!
			doubleTapKey.Close();

			MessageBox.Show("The settings were saved.", "HTCButton", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
		}
	}
}