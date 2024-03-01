namespace custos.services
{
    partial class FrmLanding
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pnlfeddback = new Panel();
			pnlcontrols = new Panel();
			lblresolvedon = new Label();
			lblassignedto = new Label();
			lblsubject = new Label();
			lblincidentno = new Label();
			cmdsubmit = new Button();
			cmdclose = new Button();
			label12 = new Label();
			textBox1 = new TextBox();
			pictureBox1 = new PictureBox();
			btn_5 = new Button();
			btn_4 = new Button();
			btn_3 = new Button();
			btn_2 = new Button();
			btn_1 = new Button();
			label11 = new Label();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			pnlfeddback.SuspendLayout();
			pnlcontrols.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pnlfeddback
			// 
			pnlfeddback.BackColor = Color.Green;
			pnlfeddback.Controls.Add(pnlcontrols);
			pnlfeddback.Controls.Add(label1);
			pnlfeddback.Location = new Point(-1, 3);
			pnlfeddback.Name = "pnlfeddback";
			pnlfeddback.Size = new Size(928, 554);
			pnlfeddback.TabIndex = 0;
			pnlfeddback.Paint += pnlfeddback_Paint;
			// 
			// pnlcontrols
			// 
			pnlcontrols.BackColor = Color.MintCream;
			pnlcontrols.Controls.Add(lblresolvedon);
			pnlcontrols.Controls.Add(lblassignedto);
			pnlcontrols.Controls.Add(lblsubject);
			pnlcontrols.Controls.Add(lblincidentno);
			pnlcontrols.Controls.Add(cmdsubmit);
			pnlcontrols.Controls.Add(cmdclose);
			pnlcontrols.Controls.Add(label12);
			pnlcontrols.Controls.Add(textBox1);
			pnlcontrols.Controls.Add(pictureBox1);
			pnlcontrols.Controls.Add(btn_5);
			pnlcontrols.Controls.Add(btn_4);
			pnlcontrols.Controls.Add(btn_3);
			pnlcontrols.Controls.Add(btn_2);
			pnlcontrols.Controls.Add(btn_1);
			pnlcontrols.Controls.Add(label11);
			pnlcontrols.Controls.Add(label10);
			pnlcontrols.Controls.Add(label9);
			pnlcontrols.Controls.Add(label8);
			pnlcontrols.Controls.Add(label7);
			pnlcontrols.Controls.Add(label6);
			pnlcontrols.Controls.Add(label5);
			pnlcontrols.Controls.Add(label4);
			pnlcontrols.Controls.Add(label3);
			pnlcontrols.Controls.Add(label2);
			pnlcontrols.Location = new Point(16, 44);
			pnlcontrols.Name = "pnlcontrols";
			pnlcontrols.Size = new Size(897, 495);
			pnlcontrols.TabIndex = 1;
			// 
			// lblresolvedon
			// 
			lblresolvedon.AutoSize = true;
			lblresolvedon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblresolvedon.Location = new Point(217, 143);
			lblresolvedon.Name = "lblresolvedon";
			lblresolvedon.Size = new Size(20, 28);
			lblresolvedon.TabIndex = 23;
			lblresolvedon.Text = "-";
			// 
			// lblassignedto
			// 
			lblassignedto.AutoSize = true;
			lblassignedto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblassignedto.Location = new Point(217, 104);
			lblassignedto.Name = "lblassignedto";
			lblassignedto.Size = new Size(20, 28);
			lblassignedto.TabIndex = 22;
			lblassignedto.Text = "-";
			// 
			// lblsubject
			// 
			lblsubject.AutoSize = true;
			lblsubject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblsubject.Location = new Point(217, 65);
			lblsubject.Name = "lblsubject";
			lblsubject.Size = new Size(20, 28);
			lblsubject.TabIndex = 21;
			lblsubject.Text = "-";
			// 
			// lblincidentno
			// 
			lblincidentno.AutoSize = true;
			lblincidentno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblincidentno.Location = new Point(217, 23);
			lblincidentno.Name = "lblincidentno";
			lblincidentno.Size = new Size(20, 28);
			lblincidentno.TabIndex = 20;
			lblincidentno.Text = "-";
			// 
			// cmdsubmit
			// 
			cmdsubmit.BackColor = Color.FromArgb(0, 192, 0);
			cmdsubmit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			cmdsubmit.ForeColor = Color.White;
			cmdsubmit.Location = new Point(716, 427);
			cmdsubmit.Name = "cmdsubmit";
			cmdsubmit.Size = new Size(123, 50);
			cmdsubmit.TabIndex = 19;
			cmdsubmit.Text = "SUBMIT";
			cmdsubmit.UseVisualStyleBackColor = false;
			cmdsubmit.Click += cmdsubmit_Click;
			// 
			// cmdclose
			// 
			cmdclose.BackColor = Color.Red;
			cmdclose.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			cmdclose.ForeColor = Color.White;
			cmdclose.Location = new Point(587, 427);
			cmdclose.Name = "cmdclose";
			cmdclose.Size = new Size(123, 50);
			cmdclose.TabIndex = 18;
			cmdclose.Text = "CLOSE";
			cmdclose.UseVisualStyleBackColor = false;
			cmdclose.Click += cmdclose_Click;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label12.Location = new Point(22, 225);
			label12.Name = "label12";
			label12.Size = new Size(95, 28);
			label12.TabIndex = 17;
			label12.Text = "REMARK";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(22, 256);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(849, 153);
			textBox1.TabIndex = 16;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.ongclogo;
			pictureBox1.InitialImage = Properties.Resources.ongclogo;
			pictureBox1.Location = new Point(665, 44);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(184, 169);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 15;
			pictureBox1.TabStop = false;
			// 
			// btn_5
			// 
			btn_5.BackgroundImage = Properties.Resources.b_star;
			btn_5.BackgroundImageLayout = ImageLayout.Stretch;
			btn_5.Location = new Point(389, 185);
			btn_5.Name = "btn_5";
			btn_5.Size = new Size(37, 38);
			btn_5.TabIndex = 14;
			btn_5.Tag = "feedback";
			btn_5.UseVisualStyleBackColor = true;
			btn_5.Click += btn_5_Click;
			// 
			// btn_4
			// 
			btn_4.BackgroundImage = Properties.Resources.b_star;
			btn_4.BackgroundImageLayout = ImageLayout.Stretch;
			btn_4.Location = new Point(346, 185);
			btn_4.Name = "btn_4";
			btn_4.Size = new Size(37, 38);
			btn_4.TabIndex = 13;
			btn_4.Tag = "feedback";
			btn_4.UseVisualStyleBackColor = true;
			btn_4.Click += btn_4_Click;
			// 
			// btn_3
			// 
			btn_3.BackgroundImage = Properties.Resources.b_star;
			btn_3.BackgroundImageLayout = ImageLayout.Stretch;
			btn_3.Location = new Point(303, 185);
			btn_3.Name = "btn_3";
			btn_3.Size = new Size(37, 38);
			btn_3.TabIndex = 12;
			btn_3.Tag = "feedback";
			btn_3.UseVisualStyleBackColor = true;
			btn_3.Click += btn_3_Click;
			// 
			// btn_2
			// 
			btn_2.BackgroundImage = Properties.Resources.b_star;
			btn_2.BackgroundImageLayout = ImageLayout.Stretch;
			btn_2.Location = new Point(260, 185);
			btn_2.Name = "btn_2";
			btn_2.Size = new Size(37, 38);
			btn_2.TabIndex = 11;
			btn_2.Tag = "feedback";
			btn_2.UseVisualStyleBackColor = true;
			btn_2.Click += btn_2_Click;
			// 
			// btn_1
			// 
			btn_1.BackColor = Color.FromArgb(255, 192, 192);
			btn_1.BackgroundImage = Properties.Resources.b_star;
			btn_1.BackgroundImageLayout = ImageLayout.Stretch;
			btn_1.Location = new Point(217, 185);
			btn_1.Name = "btn_1";
			btn_1.Size = new Size(37, 38);
			btn_1.TabIndex = 10;
			btn_1.Tag = "feedback";
			btn_1.UseVisualStyleBackColor = false;
			btn_1.Click += btn1_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label11.Location = new Point(179, 185);
			label11.Name = "label11";
			label11.Size = new Size(17, 28);
			label11.TabIndex = 9;
			label11.Text = ":";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label10.Location = new Point(179, 143);
			label10.Name = "label10";
			label10.Size = new Size(17, 28);
			label10.TabIndex = 8;
			label10.Text = ":";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label9.Location = new Point(179, 104);
			label9.Name = "label9";
			label9.Size = new Size(17, 28);
			label9.TabIndex = 7;
			label9.Text = ":";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label8.Location = new Point(179, 65);
			label8.Name = "label8";
			label8.Size = new Size(17, 28);
			label8.TabIndex = 6;
			label8.Text = ":";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(179, 23);
			label7.Name = "label7";
			label7.Size = new Size(17, 28);
			label7.TabIndex = 5;
			label7.Text = ":";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(22, 185);
			label6.Name = "label6";
			label6.Size = new Size(86, 28);
			label6.TabIndex = 4;
			label6.Text = "RATING";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(22, 143);
			label5.Name = "label5";
			label5.Size = new Size(147, 28);
			label5.TabIndex = 3;
			label5.Text = "RESOLVED ON";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(22, 104);
			label4.Name = "label4";
			label4.Size = new Size(142, 28);
			label4.TabIndex = 2;
			label4.Text = "ASSIGNED TO";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(22, 65);
			label3.Name = "label3";
			label3.Size = new Size(94, 28);
			label3.TabIndex = 1;
			label3.Text = "SUBJECT";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(22, 23);
			label2.Name = "label2";
			label2.Size = new Size(124, 28);
			label2.TabIndex = 0;
			label2.Text = "INCIDENT #";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(294, 6);
			label1.Name = "label1";
			label1.Size = new Size(353, 35);
			label1.TabIndex = 0;
			label1.Text = "INCIDENT TICKET FEEDBACK";
			// 
			// FrmLanding
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(924, 554);
			Controls.Add(pnlfeddback);
			Name = "FrmLanding";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Incident Ticket Feedback V2.0.1";
			FormClosing += FrmLanding_FormClosing;
			FormClosed += FrmLanding_FormClosed;
			Load += FrmLanding_Load;
			pnlfeddback.ResumeLayout(false);
			pnlfeddback.PerformLayout();
			pnlcontrols.ResumeLayout(false);
			pnlcontrols.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlfeddback;
        private Label label1;
        private Panel pnlcontrols;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label10;
        private Button btn_1;
        private Button btn_5;
        private Button btn_4;
        private Button btn_3;
        private Button btn_2;
        private PictureBox pictureBox1;
        private Label label12;
        private TextBox textBox1;
        private Button cmdclose;
        private Label lblresolvedon;
        private Label lblassignedto;
        private Label lblsubject;
        private Label lblincidentno;
        private Button cmdsubmit;
    }
}