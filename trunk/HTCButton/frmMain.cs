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

namespace HTCButton
{
	public partial class frmMain : Form
	{
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
			// Set the version string
			lblVersion.Text = String.Format(lblVersion.Text, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);

			// Get a list of all the plugins we have
			PluginServices.FindPlugins();
			foreach (KeyValuePair<string, AvailablePlugin> kvp in PluginServices.Plugins)
			{
				cmbDoubleTap.Items.Add(new ComboBoxValue(kvp.Key, kvp.Value));
				cmbHold.Items.Add(new ComboBoxValue(kvp.Key, kvp.Value));
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
			/*// Any configuration stuffs?
			if (plugin.Plugin.ConfigInterface != null)
			{
				plugin.Plugin.ConfigInterface.Dock = DockStyle.Fill;
				pnlDoubleTap.Controls.Add(plugin.Plugin.ConfigInterface);
			}*/

			// Is this a plugin with a GUI?
			if (plugin.Plugin is PluginWithSettings)
			{
				PluginWithSettings pws = (PluginWithSettings)plugin.Plugin;
				pws.ConfigInterface.Dock = DockStyle.Fill;
				pnlDoubleTap.Controls.Add(pws.ConfigInterface);
			}
		}
	}
}