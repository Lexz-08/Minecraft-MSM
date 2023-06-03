using CometUI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace Minecraft_MSM
{
	public partial class Main : CometForm
	{
		public Main()
		{
			InitializeComponent();

			if (!Directory.Exists(modDir))
			{
				MessageBox.Show("Unable to load mods into manager because mods folder does not exist", "No Mods Folder in Minecraft Directory",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
			else
			{
				foreach (string file in Directory.GetFiles(modDir).Where(path => path.EndsWith(".jar") || path.EndsWith(".jar.disabled")))
				{
					JObject modManifest = ParseModManifest(file);

					if (modManifest != null)
					{
						if (modManifest["mod-type"].ToString() == "foreground_mod")
							lst_Mods.Items.Add(modManifest["name"]);
						else if (modManifest["mod-type"].ToString() == "background_mod")
							lst_Mods.Items.Add($"- ({modManifest["id"]}) -");

						modManifests.Add(modManifest);
						lst_Mods.SelectedIndex = 0;
					}
				}
			}
		}

		private static readonly string modDir = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\AppData\Roaming\.minecraft\mods";

		private List<JObject> modManifests = new List<JObject>();

		private JObject ParseModManifest(string FABFile)
		{
			using (FileStream fileStr = new FileStream(FABFile, FileMode.Open))
			{
				ZipArchive zip = new ZipArchive(fileStr);

				if (zip.GetEntry("fabric.mod.json") == null)
				{
					lbl_ModsNotLoadedValue.Text = (int.Parse(lbl_ModsNotLoadedValue.Text) + 1).ToString();
					return null;
				}
				else
				{
					using (Stream str = zip.GetEntry("fabric.mod.json").Open())
					using (StreamReader reader = new StreamReader(str))
					{
						JObject fabManifest = JObject.Parse(reader.ReadToEnd());
						JObject modManifest = new JObject();

						if (fabManifest.ContainsKey("name"))
						{
							modManifest["mod-type"] = "foreground_mod";
							modManifest["name"] = fabManifest["name"];
							modManifest["id"] = fabManifest["id"];
							if (fabManifest.ContainsKey("authors"))
								modManifest["author"] = fabManifest["authors"];
							else modManifest["author"] = new JArray { "" };
							if (fabManifest.ContainsKey("version"))
								modManifest["version"] = fabManifest["version"];
							else modManifest["version"] = "";
							if (fabManifest.ContainsKey("description"))
								modManifest["description"] = fabManifest["description"];
							else modManifest["description"] = "";
							if (fabManifest.ContainsKey("depends") && ((JObject)fabManifest["depends"]).ContainsKey("minecraft"))
								modManifest["mc-version"] = fabManifest["depends"]["minecraft"];
							else modManifest["mc-version"] = new JArray { "" };
						}
						else
						{
							modManifest["mod-type"] = "background_mod";
							modManifest["id"] = fabManifest["id"];
							if (fabManifest.ContainsKey("authors"))
								modManifest["author"] = fabManifest["authors"];
							else modManifest["author"] = new JArray { "" };
							if (fabManifest.ContainsKey("version"))
								modManifest["version"] = fabManifest["version"];
							else modManifest["version"] = "";
							if (fabManifest.ContainsKey("description"))
								modManifest["description"] = fabManifest["description"];
							else modManifest["description"] = "";
							if (fabManifest.ContainsKey("depends") && ((JObject)fabManifest["depends"]).ContainsKey("minecraft"))
								modManifest["mc-version"] = fabManifest["depends"]["minecraft"];
							else modManifest["mc-version"] = "";
						}

						if (FABFile.EndsWith(".jar"))
							modManifest["status"] = "enabled";
						else if (FABFile.EndsWith(".jar.disabled"))
							modManifest["status"] = "disabled";

						modManifest["filepath"] = FABFile;

						return modManifest;
					}
				}
			}
		}

		private void Mods_SelectedIndexChanged(object sender, EventArgs e)
		{
			JObject modManifest = modManifests[lst_Mods.SelectedIndex];

			if (modManifest["mod-type"].ToString() == "foreground_mod")
			{
				lbl_ModNameValue.Text = modManifest["name"].ToString();
				lbl_ModAuthorValue.Text = modManifest["author"].GetType() == typeof(JArray) ?
					string.Join(", ", (JArray)modManifest["author"]) :
					modManifest["author"].ToString();
				lbl_ModVersionValue.Text = modManifest["version"].ToString();
				lbl_MinecraftVersionValue.Text = modManifest["mc-version"].GetType() == typeof(JArray) ?
					string.Join(", ", (JArray)modManifest["mc-version"]) :
					modManifest["mc-version"].ToString();
				lbl_ModDescriptionValue.Text = modManifest["description"].ToString();
			}
			else if (modManifest["mod-type"].ToString() == "background_mod")
			{
				lbl_ModNameValue.Text = modManifest["id"].ToString();
				lbl_ModAuthorValue.Text = modManifest["author"].GetType() == typeof(JArray) ?
					string.Join(", ", (JArray)modManifest["author"]) :
					modManifest["author"].ToString();
				lbl_ModVersionValue.Text = modManifest["version"].ToString();
				lbl_MinecraftVersionValue.Text = modManifest["mc-version"].GetType() == typeof(JArray) ?
					string.Join(", ", (JArray)modManifest["mc-version"]) :
					modManifest["mc-version"].ToString();
				lbl_ModDescriptionValue.Text = modManifest["description"].ToString();
			}

			tgl_ModStatus.Checked = modManifest["status"].ToString() == "enabled";
			lbl_ModStatusValue.Text = tgl_ModStatus.Checked ? "ENABLED" : "DISABLED";
			lbl_ModStatusValue.ForeColor = tgl_ModStatus.Checked ? Color.SeaGreen : Color.Red;
		}

		private void ModStatus_CheckedChanged(object sender, EventArgs e)
		{
			string file = modManifests[lst_Mods.SelectedIndex]["filepath"].ToString();

			if (!tgl_ModStatus.Checked)
			{
				File.Move(file, file.Replace(".jar", ".jar.disabled"));
				modManifests[lst_Mods.SelectedIndex]["filepath"] = file.Replace(".jar", ".jar.disabled");
			}
			else if (tgl_ModStatus.Checked)
			{
				File.Move(file, file.Replace(".jar.disabled", ".jar"));
				modManifests[lst_Mods.SelectedIndex]["filepath"] = file.Replace(".jar.disabled", ".jar");
			}

			lbl_ModStatusValue.Text = tgl_ModStatus.Checked ? "ENABLED" : "DISABLED";
			lbl_ModStatusValue.ForeColor = tgl_ModStatus.Checked ? Color.SeaGreen : Color.Red;
		}

		private void ModsFolder_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", modDir);
		}
	}
}
