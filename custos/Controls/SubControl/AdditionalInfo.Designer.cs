namespace custos.Controls.SubControl
{
    partial class AdditionalInfo
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            panel2 = new Panel();
            panel10 = new Panel();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            panel9 = new Panel();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            panel8 = new Panel();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            splitter2 = new Splitter();
            splitter1 = new Splitter();
            osinformation1 = new osinformation();
            antivirusControl1 = new AntivirusControl();
            deviceinfo1 = new Deviceinfo();
            hardDiskinfo1 = new HardDiskinfo();
            softwareInfo1 = new SoftwareInfo();
            hardwareInfo1 = new HardwareInfo();
            errorProvider1 = new ErrorProvider(components);
            loader1 = new Loader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 37);
            panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(395, 13);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(676, 15);
            progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(10, 3);
            label1.Name = "label1";
            label1.Size = new Size(356, 28);
            label1.TabIndex = 0;
            label1.Text = "Gathering Infromation Please Wait...";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(splitter2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 763);
            panel2.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(pictureBox7);
            panel10.Controls.Add(label8);
            panel10.Location = new Point(7, 288);
            panel10.Name = "panel10";
            panel10.Size = new Size(358, 53);
            panel10.TabIndex = 32;
            panel10.Click += port_click;
            panel10.Paint += panel10_Paint;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.computer;
            pictureBox7.Location = new Point(13, 11);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(36, 34);
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            pictureBox7.Click += port_click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(52, 15);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 0;
            label8.Text = "Port Information";
            label8.Click += port_click;
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox6);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(7, 220);
            panel9.Name = "panel9";
            panel9.Size = new Size(358, 53);
            panel9.TabIndex = 31;
            panel9.Click += harddisk_click;
            panel9.Paint += panel9_Paint;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.hard_disk;
            pictureBox6.Location = new Point(13, 11);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 34);
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            pictureBox6.Click += harddisk_click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(52, 15);
            label7.Name = "label7";
            label7.Size = new Size(184, 25);
            label7.TabIndex = 0;
            label7.Text = "HardDisk Infromation";
            label7.Click += harddisk_click;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox5);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(7, 151);
            panel8.Name = "panel8";
            panel8.Size = new Size(358, 53);
            panel8.TabIndex = 30;
            panel8.Click += device_click;
            panel8.Paint += panel8_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.responsive;
            pictureBox5.Location = new Point(13, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 34);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            pictureBox5.Click += device_click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(52, 15);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 0;
            label6.Text = "Device Details";
            label6.Click += device_click;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(7, 80);
            panel7.Name = "panel7";
            panel7.Size = new Size(358, 53);
            panel7.TabIndex = 29;
            panel7.Click += anti_click;
            panel7.Paint += panel7_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.shield;
            pictureBox4.Location = new Point(13, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 34);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += anti_click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(52, 15);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 0;
            label5.Text = "Antivirus Infromation";
            label5.Click += anti_click;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(7, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(358, 53);
            panel6.TabIndex = 28;
            panel6.Click += os_click;
            panel6.Paint += panel6_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.windows;
            pictureBox3.Location = new Point(13, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 34);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += os_click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(52, 13);
            label4.Name = "label4";
            label4.Size = new Size(253, 25);
            label4.TabIndex = 0;
            label4.Text = "Operating System Infromation";
            label4.Click += os_click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(7, 419);
            panel5.Name = "panel5";
            panel5.Size = new Size(358, 53);
            panel5.TabIndex = 27;
            panel5.Click += hardware_click;
            panel5.Paint += panel5_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tools;
            pictureBox2.Location = new Point(13, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 34);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += hardware_click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(52, 14);
            label3.Name = "label3";
            label3.Size = new Size(187, 25);
            label3.TabIndex = 0;
            label3.Text = "Hardware Infromation";
            label3.Click += hardware_click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(7, 354);
            panel4.Name = "panel4";
            panel4.Size = new Size(358, 53);
            panel4.TabIndex = 26;
            panel4.Click += system_click;
            panel4.Paint += panel4_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.info;
            pictureBox1.Location = new Point(13, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 34);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += system_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(52, 15);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 0;
            label2.Text = "System Infromation";
            label2.Click += system_click;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(376, 763);
            splitter2.TabIndex = 25;
            splitter2.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(323, 37);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 763);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // osinformation1
            // 
            osinformation1.Dock = DockStyle.Fill;
            osinformation1.Location = new Point(327, 37);
            osinformation1.Name = "osinformation1";
            osinformation1.Size = new Size(773, 763);
            osinformation1.TabIndex = 3;
            // 
            // antivirusControl1
            // 
            antivirusControl1.BackColor = SystemColors.Control;
            antivirusControl1.Dock = DockStyle.Fill;
            antivirusControl1.Location = new Point(327, 37);
            antivirusControl1.Name = "antivirusControl1";
            antivirusControl1.Size = new Size(773, 763);
            antivirusControl1.TabIndex = 4;
            // 
            // deviceinfo1
            // 
            deviceinfo1.Dock = DockStyle.Fill;
            deviceinfo1.Location = new Point(327, 37);
            deviceinfo1.Name = "deviceinfo1";
            deviceinfo1.Size = new Size(773, 763);
            deviceinfo1.TabIndex = 5;
            // 
            // hardDiskinfo1
            // 
            hardDiskinfo1.Dock = DockStyle.Fill;
            hardDiskinfo1.Location = new Point(327, 37);
            hardDiskinfo1.Name = "hardDiskinfo1";
            hardDiskinfo1.Size = new Size(773, 763);
            hardDiskinfo1.TabIndex = 6;
            // 
            // softwareInfo1
            // 
            softwareInfo1.BackColor = SystemColors.Control;
            softwareInfo1.Dock = DockStyle.Fill;
            softwareInfo1.Location = new Point(327, 37);
            softwareInfo1.Margin = new Padding(3, 2, 3, 2);
            softwareInfo1.Name = "softwareInfo1";
            softwareInfo1.Size = new Size(773, 763);
            softwareInfo1.TabIndex = 7;
            // 
            // hardwareInfo1
            // 
            hardwareInfo1.BackColor = SystemColors.Control;
            hardwareInfo1.Dock = DockStyle.Fill;
            hardwareInfo1.Location = new Point(327, 37);
            hardwareInfo1.Margin = new Padding(4, 5, 4, 5);
            hardwareInfo1.Name = "hardwareInfo1";
            hardwareInfo1.Size = new Size(773, 763);
            hardwareInfo1.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // loader1
            // 
            loader1.BackColor = SystemColors.ButtonHighlight;
            loader1.Dock = DockStyle.Fill;
            loader1.Location = new Point(327, 37);
            loader1.Name = "loader1";
            loader1.Size = new Size(773, 763);
            loader1.TabIndex = 9;
            // 
            // AdditionalInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(loader1);
            Controls.Add(hardwareInfo1);
            Controls.Add(softwareInfo1);
            Controls.Add(hardDiskinfo1);
            Controls.Add(deviceinfo1);
            Controls.Add(antivirusControl1);
            Controls.Add(osinformation1);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdditionalInfo";
            Size = new Size(1100, 800);
            Load += additionalinfo_load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel9;
        private PictureBox pictureBox6;
        private Label label7;
        private Panel panel8;
        private PictureBox pictureBox5;
        private Label label6;
        private Panel panel7;
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label label4;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label2;
        private Splitter splitter2;
       
        private Panel panel10;
        private PictureBox pictureBox7;
        private Label label8;
        private Splitter splitter1;
        private osinformation osinformation1;
        private AntivirusControl antivirusControl1;
        private Deviceinfo deviceinfo1;
        private HardDiskinfo hardDiskinfo1;
        private SoftwareInfo softwareInfo1;
        private HardwareInfo hardwareInfo1;
        private ProgressBar progressBar1;
        private ErrorProvider errorProvider1;
        private Loader loader1;
    }
}
