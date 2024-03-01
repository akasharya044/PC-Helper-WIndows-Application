using custos.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custos.Controls.SubControl
{
    public partial class HardDiskinfo : UserControl
    {

        public HardDiskinfo()
        {
            InitializeComponent();
        }

        public void diskdata()
        {

            Harddiskinfoma disk = new Harddiskinfoma();
            HardDiskDto diskdata = disk.HardDiskInfomation();
            

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Drive Name: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(diskdata.DriveName + "\n\n");


            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Drive Type: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(diskdata.DriveType + "\n\n");


            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Drive Format: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(diskdata.DriveFormat + "\n\n");


            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Drive Total Size: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(diskdata.TotalSize + "\n\n");

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Drive Free Space: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(diskdata.FreeSpace + "\n\n");

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Drive Non System Drive Name: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(diskdata.NonSystemDriveName + "\n\n");


            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Drive Non System Total Space: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(diskdata.NonSystemTotalSpace + "\n\n");


            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Drive Non System Free Space: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(diskdata.NonSystemFreeSpace + "\n\n");



            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Drive Serial Number: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(diskdata.SerialNumber + "\n\n");

            



        }

        private async void Harddisk_Load(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            diskdata();
        }
    }
}
