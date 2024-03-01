namespace custos.Controls;

	partial class HardwareInfo
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
        HdList = new DataGridView();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)HdList).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.HighlightText;
        panel1.Controls.Add(HdList);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(702, 399);
        panel1.TabIndex = 0;
        // 
        // HdList
        // 
        HdList.BackgroundColor = SystemColors.ButtonHighlight;
        HdList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        HdList.Dock = DockStyle.Fill;
        HdList.Location = new Point(0, 0);
        HdList.Name = "HdList";
        HdList.RowHeadersWidth = 51;
        HdList.Size = new Size(702, 399);
        HdList.TabIndex = 0;
        // 
        // HardwareInfo
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        BorderStyle = BorderStyle.FixedSingle;
        Controls.Add(panel1);
        Margin = new Padding(4, 5, 4, 5);
        Name = "HardwareInfo";
        Size = new Size(702, 399);
        Load += HardewareInfo_Load;
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)HdList).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
	private DataGridView HdList;
}
