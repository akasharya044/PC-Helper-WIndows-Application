namespace custos.Controls
{
	partial class SystemControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			tabControl1 = new TabControl();
			sysPage = new TabPage();
			softwareInfo1 = new SoftwareInfo();
			hardwareInfo1 = new HardwareInfo();
			hardPage = new TabPage();
			panel1.SuspendLayout();
			tabControl1.SuspendLayout();
			sysPage.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(tabControl1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(357, 296);
			panel1.TabIndex = 0;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(sysPage);
			tabControl1.Controls.Add(hardPage);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(357, 296);
			tabControl1.TabIndex = 0;
			// 
			// sysPage
			// 
			sysPage.Controls.Add(softwareInfo1);
			sysPage.Controls.Add(hardwareInfo1);
			sysPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			sysPage.Location = new Point(4, 29);
			sysPage.Name = "sysPage";
			sysPage.Padding = new Padding(3);
			sysPage.Size = new Size(349, 263);
			sysPage.TabIndex = 0;
			sysPage.Text = "Software Information";
			sysPage.UseVisualStyleBackColor = true;
			// 
			// softwareInfo1
			// 
			softwareInfo1.BackColor = SystemColors.Control;
			softwareInfo1.Dock = DockStyle.Fill;
			softwareInfo1.Location = new Point(3, 3);
			softwareInfo1.Margin = new Padding(3, 2, 3, 2);
			softwareInfo1.Name = "softwareInfo1";
			softwareInfo1.Size = new Size(343, 257);
			softwareInfo1.TabIndex = 0;
			Load += SoftwareInfo_Load;

			// 
			// hardwareInfo1
			// 
			hardwareInfo1.BackColor = SystemColors.Control;
			hardwareInfo1.Dock = DockStyle.Fill;
			hardwareInfo1.Location = new Point(3, 3);
			hardwareInfo1.Margin = new Padding(3, 2, 3, 2);
			hardwareInfo1.Name = "hardwareInfo1";
			hardwareInfo1.Size = new Size(343, 257);
			hardwareInfo1.TabIndex = 0;
			// 
			// hardPage
			// 
			hardPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			hardPage.Location = new Point(4, 29);
			hardPage.Name = "hardPage";
			hardPage.Padding = new Padding(3);
			hardPage.Size = new Size(349, 263);
			hardPage.TabIndex = 1;
			hardPage.Text = "Hardware Information";
			hardPage.UseVisualStyleBackColor = true;
			// 
			// SystemControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Name = "SystemControl";
			Size = new Size(357, 296);
			panel1.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			sysPage.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private TabControl tabControl1;
		private TabPage sysPage;
		private TabPage hardPage;
		private SoftwareInfo softwareInfo1;
		private HardwareInfo hardwareInfo1;
	}
}
