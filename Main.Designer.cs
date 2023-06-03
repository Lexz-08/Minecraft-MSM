namespace Minecraft_MSM
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.lst_Mods = new System.Windows.Forms.ListBox();
			this.lbl_ModName = new System.Windows.Forms.Label();
			this.lbl_ModAuthor = new System.Windows.Forms.Label();
			this.lbl_ModVersion = new System.Windows.Forms.Label();
			this.lbl_MinecraftVersion = new System.Windows.Forms.Label();
			this.lbl_ModNameValue = new System.Windows.Forms.Label();
			this.lbl_ModAuthorValue = new System.Windows.Forms.Label();
			this.lbl_ModVersionValue = new System.Windows.Forms.Label();
			this.lbl_MinecraftVersionValue = new System.Windows.Forms.Label();
			this.tgl_ModStatus = new CometUI.CometToggle();
			this.lbl_ModStatusValue = new CometUI.CometLabel();
			this.lbl_ModDescription = new CometUI.CometLabel();
			this.lbl_ModDescriptionValue = new CometUI.CometLabel();
			this.lbl_ModsNotLoaded = new CometUI.CometLabel();
			this.lbl_ModsNotLoadedValue = new CometUI.CometLabel();
			this.cometRoundGradientButton1 = new CometUI.CometRoundGradientButton();
			this.SuspendLayout();
			// 
			// lst_Mods
			// 
			this.lst_Mods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lst_Mods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lst_Mods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lst_Mods.FormattingEnabled = true;
			this.lst_Mods.ItemHeight = 17;
			this.lst_Mods.Location = new System.Drawing.Point(12, 46);
			this.lst_Mods.Name = "lst_Mods";
			this.lst_Mods.Size = new System.Drawing.Size(222, 359);
			this.lst_Mods.TabIndex = 0;
			this.lst_Mods.SelectedIndexChanged += new System.EventHandler(this.Mods_SelectedIndexChanged);
			// 
			// lbl_ModName
			// 
			this.lbl_ModName.AutoSize = true;
			this.lbl_ModName.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.lbl_ModName.Location = new System.Drawing.Point(240, 46);
			this.lbl_ModName.Name = "lbl_ModName";
			this.lbl_ModName.Size = new System.Drawing.Size(53, 20);
			this.lbl_ModName.TabIndex = 1;
			this.lbl_ModName.Text = "Name:";
			// 
			// lbl_ModAuthor
			// 
			this.lbl_ModAuthor.AutoSize = true;
			this.lbl_ModAuthor.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.lbl_ModAuthor.Location = new System.Drawing.Point(240, 71);
			this.lbl_ModAuthor.Name = "lbl_ModAuthor";
			this.lbl_ModAuthor.Size = new System.Drawing.Size(78, 20);
			this.lbl_ModAuthor.TabIndex = 2;
			this.lbl_ModAuthor.Text = "Author(s):";
			// 
			// lbl_ModVersion
			// 
			this.lbl_ModVersion.AutoSize = true;
			this.lbl_ModVersion.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.lbl_ModVersion.Location = new System.Drawing.Point(240, 96);
			this.lbl_ModVersion.Name = "lbl_ModVersion";
			this.lbl_ModVersion.Size = new System.Drawing.Size(65, 20);
			this.lbl_ModVersion.TabIndex = 3;
			this.lbl_ModVersion.Text = "Version:";
			// 
			// lbl_MinecraftVersion
			// 
			this.lbl_MinecraftVersion.AutoSize = true;
			this.lbl_MinecraftVersion.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.lbl_MinecraftVersion.Location = new System.Drawing.Point(240, 121);
			this.lbl_MinecraftVersion.Name = "lbl_MinecraftVersion";
			this.lbl_MinecraftVersion.Size = new System.Drawing.Size(89, 20);
			this.lbl_MinecraftVersion.TabIndex = 4;
			this.lbl_MinecraftVersion.Text = "MC Version:";
			// 
			// lbl_ModNameValue
			// 
			this.lbl_ModNameValue.AutoSize = true;
			this.lbl_ModNameValue.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.lbl_ModNameValue.Location = new System.Drawing.Point(299, 46);
			this.lbl_ModNameValue.Name = "lbl_ModNameValue";
			this.lbl_ModNameValue.Size = new System.Drawing.Size(111, 20);
			this.lbl_ModNameValue.TabIndex = 5;
			this.lbl_ModNameValue.Text = "PLACEHOLDER";
			// 
			// lbl_ModAuthorValue
			// 
			this.lbl_ModAuthorValue.AutoSize = true;
			this.lbl_ModAuthorValue.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.lbl_ModAuthorValue.Location = new System.Drawing.Point(324, 71);
			this.lbl_ModAuthorValue.Name = "lbl_ModAuthorValue";
			this.lbl_ModAuthorValue.Size = new System.Drawing.Size(111, 20);
			this.lbl_ModAuthorValue.TabIndex = 6;
			this.lbl_ModAuthorValue.Text = "PLACEHOLDER";
			// 
			// lbl_ModVersionValue
			// 
			this.lbl_ModVersionValue.AutoSize = true;
			this.lbl_ModVersionValue.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.lbl_ModVersionValue.Location = new System.Drawing.Point(311, 96);
			this.lbl_ModVersionValue.Name = "lbl_ModVersionValue";
			this.lbl_ModVersionValue.Size = new System.Drawing.Size(111, 20);
			this.lbl_ModVersionValue.TabIndex = 7;
			this.lbl_ModVersionValue.Text = "PLACEHOLDER";
			// 
			// lbl_MinecraftVersionValue
			// 
			this.lbl_MinecraftVersionValue.AutoSize = true;
			this.lbl_MinecraftVersionValue.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.lbl_MinecraftVersionValue.Location = new System.Drawing.Point(335, 121);
			this.lbl_MinecraftVersionValue.Name = "lbl_MinecraftVersionValue";
			this.lbl_MinecraftVersionValue.Size = new System.Drawing.Size(111, 20);
			this.lbl_MinecraftVersionValue.TabIndex = 8;
			this.lbl_MinecraftVersionValue.Text = "PLACEHOLDER";
			// 
			// tgl_ModStatus
			// 
			this.tgl_ModStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tgl_ModStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.tgl_ModStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.tgl_ModStatus.CheckedColor = System.Drawing.Color.DodgerBlue;
			this.tgl_ModStatus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tgl_ModStatus.Location = new System.Drawing.Point(245, 351);
			this.tgl_ModStatus.Name = "tgl_ModStatus";
			this.tgl_ModStatus.Size = new System.Drawing.Size(117, 69);
			this.tgl_ModStatus.TabIndex = 9;
			this.tgl_ModStatus.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.tgl_ModStatus.UseVisualStyleBackColor = false;
			this.tgl_ModStatus.CheckedChanged += new System.EventHandler(this.ModStatus_CheckedChanged);
			// 
			// lbl_ModStatusValue
			// 
			this.lbl_ModStatusValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_ModStatusValue.AutoSize = true;
			this.lbl_ModStatusValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lbl_ModStatusValue.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 16F);
			this.lbl_ModStatusValue.ForeColor = System.Drawing.Color.Goldenrod;
			this.lbl_ModStatusValue.Location = new System.Drawing.Point(240, 320);
			this.lbl_ModStatusValue.Name = "lbl_ModStatusValue";
			this.lbl_ModStatusValue.Size = new System.Drawing.Size(192, 28);
			this.lbl_ModStatusValue.TabIndex = 10;
			this.lbl_ModStatusValue.Text = "NO MOD SELECTED";
			// 
			// lbl_ModDescription
			// 
			this.lbl_ModDescription.AutoSize = true;
			this.lbl_ModDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lbl_ModDescription.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F);
			this.lbl_ModDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lbl_ModDescription.Location = new System.Drawing.Point(240, 151);
			this.lbl_ModDescription.Name = "lbl_ModDescription";
			this.lbl_ModDescription.Size = new System.Drawing.Size(92, 20);
			this.lbl_ModDescription.TabIndex = 11;
			this.lbl_ModDescription.Text = "Description:";
			// 
			// lbl_ModDescriptionValue
			// 
			this.lbl_ModDescriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_ModDescriptionValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.lbl_ModDescriptionValue.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F);
			this.lbl_ModDescriptionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lbl_ModDescriptionValue.Location = new System.Drawing.Point(240, 174);
			this.lbl_ModDescriptionValue.Name = "lbl_ModDescriptionValue";
			this.lbl_ModDescriptionValue.Size = new System.Drawing.Size(480, 124);
			this.lbl_ModDescriptionValue.TabIndex = 12;
			this.lbl_ModDescriptionValue.Text = "PLACEHOLDER";
			// 
			// lbl_ModsNotLoaded
			// 
			this.lbl_ModsNotLoaded.AutoSize = true;
			this.lbl_ModsNotLoaded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lbl_ModsNotLoaded.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F);
			this.lbl_ModsNotLoaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lbl_ModsNotLoaded.Location = new System.Drawing.Point(12, 408);
			this.lbl_ModsNotLoaded.Name = "lbl_ModsNotLoaded";
			this.lbl_ModsNotLoaded.Size = new System.Drawing.Size(111, 17);
			this.lbl_ModsNotLoaded.TabIndex = 13;
			this.lbl_ModsNotLoaded.Text = "Mods Not Loaded:";
			// 
			// lbl_ModsNotLoadedValue
			// 
			this.lbl_ModsNotLoadedValue.AutoSize = true;
			this.lbl_ModsNotLoadedValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lbl_ModsNotLoadedValue.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F);
			this.lbl_ModsNotLoadedValue.ForeColor = System.Drawing.Color.Red;
			this.lbl_ModsNotLoadedValue.Location = new System.Drawing.Point(119, 408);
			this.lbl_ModsNotLoadedValue.Name = "lbl_ModsNotLoadedValue";
			this.lbl_ModsNotLoadedValue.Size = new System.Drawing.Size(15, 17);
			this.lbl_ModsNotLoadedValue.TabIndex = 14;
			this.lbl_ModsNotLoadedValue.Text = "0";
			// 
			// cometRoundGradientButton1
			// 
			this.cometRoundGradientButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cometRoundGradientButton1.BorderRadius = 3;
			this.cometRoundGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cometRoundGradientButton1.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F);
			this.cometRoundGradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.cometRoundGradientButton1.GradientAngle = 45F;
			this.cometRoundGradientButton1.GradientColor1 = System.Drawing.Color.Firebrick;
			this.cometRoundGradientButton1.GradientColor2 = System.Drawing.Color.Coral;
			this.cometRoundGradientButton1.Location = new System.Drawing.Point(594, 320);
			this.cometRoundGradientButton1.Name = "cometRoundGradientButton1";
			this.cometRoundGradientButton1.Size = new System.Drawing.Size(126, 28);
			this.cometRoundGradientButton1.TabIndex = 16;
			this.cometRoundGradientButton1.Text = "Mods Folder";
			this.cometRoundGradientButton1.Click += new System.EventHandler(this.ModsFolder_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CanResize = false;
			this.ClientSize = new System.Drawing.Size(732, 434);
			this.Controls.Add(this.cometRoundGradientButton1);
			this.Controls.Add(this.lbl_ModsNotLoadedValue);
			this.Controls.Add(this.lbl_ModsNotLoaded);
			this.Controls.Add(this.lbl_ModDescriptionValue);
			this.Controls.Add(this.lbl_ModDescription);
			this.Controls.Add(this.lbl_ModStatusValue);
			this.Controls.Add(this.tgl_ModStatus);
			this.Controls.Add(this.lbl_MinecraftVersionValue);
			this.Controls.Add(this.lbl_ModVersionValue);
			this.Controls.Add(this.lbl_ModAuthorValue);
			this.Controls.Add(this.lbl_ModNameValue);
			this.Controls.Add(this.lbl_MinecraftVersion);
			this.Controls.Add(this.lbl_ModVersion);
			this.Controls.Add(this.lbl_ModAuthor);
			this.Controls.Add(this.lbl_ModName);
			this.Controls.Add(this.lst_Mods);
			this.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(233, 131);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Minecraft MSM";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lst_Mods;
		private System.Windows.Forms.Label lbl_ModName;
		private System.Windows.Forms.Label lbl_ModAuthor;
		private System.Windows.Forms.Label lbl_ModVersion;
		private System.Windows.Forms.Label lbl_MinecraftVersion;
		private System.Windows.Forms.Label lbl_ModNameValue;
		private System.Windows.Forms.Label lbl_ModAuthorValue;
		private System.Windows.Forms.Label lbl_ModVersionValue;
		private System.Windows.Forms.Label lbl_MinecraftVersionValue;
		private CometUI.CometToggle tgl_ModStatus;
		private CometUI.CometLabel lbl_ModStatusValue;
		private CometUI.CometLabel lbl_ModDescription;
		private CometUI.CometLabel lbl_ModDescriptionValue;
		private CometUI.CometLabel lbl_ModsNotLoaded;
		private CometUI.CometLabel lbl_ModsNotLoadedValue;
		private CometUI.CometRoundGradientButton cometRoundGradientButton1;
	}
}

