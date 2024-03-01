using custos.Controls;

namespace custos
{
	partial class Dashboard
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
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            home1 = new Controls.SubControl.Home();
            tabPage2 = new TabPage();
            additionalInfo1 = new Controls.SubControl.AdditionalInfo();
            tabPage3 = new TabPage();
            cleaner1 = new Cleaner();
            tabPage4 = new TabPage();
            selfheal1 = new Selfheal();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.ImageList = imageList1;
            tabControl1.ItemSize = new Size(92, 48);
            tabControl1.Location = new Point(0, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(30, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1082, 687);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ButtonHighlight;
            tabPage1.Controls.Add(home1);
            tabPage1.Location = new Point(4, 52);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1074, 631);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Home";
            // 
            // home1
            // 
            home1.Dock = DockStyle.Fill;
            home1.Location = new Point(0, 0);
            home1.Margin = new Padding(2);
            home1.Name = "home1";
            home1.Size = new Size(1074, 631);
            home1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ButtonHighlight;
            tabPage2.Controls.Add(additionalInfo1);
            tabPage2.Location = new Point(4, 52);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(192, 44);
            tabPage2.TabIndex = 5;
            tabPage2.Text = "Addtional Info";
            // 
            // additionalInfo1
            // 
            additionalInfo1.Dock = DockStyle.Fill;
            additionalInfo1.Location = new Point(0, 0);
            additionalInfo1.Margin = new Padding(2);
            additionalInfo1.Name = "additionalInfo1";
            additionalInfo1.Size = new Size(192, 44);
            additionalInfo1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ButtonHighlight;
            tabPage3.Controls.Add(cleaner1);
            tabPage3.Location = new Point(4, 52);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1074, 631);
            tabPage3.TabIndex = 6;
            tabPage3.Text = "Cleaner";
            // 
            // cleaner1
            // 
            cleaner1.Dock = DockStyle.Fill;
            cleaner1.Location = new Point(0, 0);
            cleaner1.Margin = new Padding(4);
            cleaner1.Name = "cleaner1";
            cleaner1.Size = new Size(1074, 631);
            cleaner1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.ButtonHighlight;
            tabPage4.Controls.Add(selfheal1);
            tabPage4.Location = new Point(4, 52);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1074, 631);
            tabPage4.TabIndex = 7;
            tabPage4.Text = "Self Heal";
            // 
            // selfheal1
            // 
            selfheal1.Dock = DockStyle.Fill;
            selfheal1.Location = new Point(0, 0);
            selfheal1.Margin = new Padding(2);
            selfheal1.Name = "selfheal1";
            selfheal1.Size = new Size(1074, 631);
            selfheal1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home-icon-silhouette (1).png");
            imageList1.Images.SetKeyName(1, "home-icon-silhouette (2).png");
            imageList1.Images.SetKeyName(2, "add.png");
            imageList1.Images.SetKeyName(3, "cleaning.png");
            imageList1.Images.SetKeyName(4, "laptop.png");
            imageList1.Images.SetKeyName(5, "cleaning-service (1).png");
            imageList1.Images.SetKeyName(6, "cleaning-service (2).png");
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 69);
            panel1.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.custos_high_resolution_logo_transparent1;
            pictureBox3.Location = new Point(12, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.Image = Properties.Resources.close__1_;
            pictureBox2.Location = new Point(1033, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 29);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.minimize;
            pictureBox1.Location = new Point(980, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 29);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1082, 753);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Dashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustOS";
            Load += Dashboard_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TabControl tabControl1;
        public TabPage Home;
        public TabPage additionalinfo;
        public TabPage cleaner;
        public TabPage selfheal;
        
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ImageList imageList1;
       
        
        public TabPage tabPage1;
        private Controls.SubControl.Home home1;
        public TabPage tabPage2;
        public TabPage tabPage3;
        public Cleaner cleaner1;
        public TabPage tabPage4;
        public Selfheal selfheal1;
        public Controls.SubControl.AdditionalInfo additionalInfo1;
        public PictureBox pictureBox3;
    }
}