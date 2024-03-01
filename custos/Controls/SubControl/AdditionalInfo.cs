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
    public partial class AdditionalInfo : UserControl
    {

        private int totalDuration = 15000;
        private int steps = 100;
        private int currentStep = 0;
        private int stepDuration;
        public AdditionalInfo()
        {
            InitializeComponent();
        }



        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

            //osinformation1.Visible = false;
            //antivirusControl1.Visible = false;
            //deviceinfo1.Visible = false;
            //hardDiskinfo1.Visible = false;
            //softwareInfo1.Visible = true;
            //hardDiskinfo1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //osinformation1.Visible = false;
            //antivirusControl1.Visible = false;
            //deviceinfo1.Visible = false;
            //hardDiskinfo1.Visible = false;
            //softwareInfo1.Visible = false;
            //hardDiskinfo1.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //osinformation1.Visible = false;
            //antivirusControl1.Visible = true;
            //deviceinfo1.Visible = false;
            //hardDiskinfo1.Visible = false;
            //softwareInfo1.Visible = false;
            //hardDiskinfo1.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //osinformation1.Visible = false;
            //antivirusControl1.Visible = false;
            //deviceinfo1.Visible = true;
            //hardDiskinfo1.Visible = false;
            //softwareInfo1.Visible = false;
            //hardDiskinfo1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //osinformation1.Visible = false;
            //antivirusControl1.Visible = false;
            //deviceinfo1.Visible = false;
            //hardDiskinfo1.Visible= true;
            //softwareInfo1.Visible = false;
            //hardDiskinfo1.Visible = false;
        }

        private void additionalinfo_load(object sender, EventArgs e)
        {
            InitializeProgressBar();

            // Start the timer to simulate loading steps
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = stepDuration;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeProgressBar()
        {
            progressBar1.Maximum = steps;
            stepDuration = totalDuration / steps;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentStep <= steps)
            {
                // Perform loading tasks based on the current step
                LoadDataForStep(currentStep);

                // Update the progress bar
                progressBar1.Value = currentStep;

                currentStep++;
            }
            else
            {
                // Stop the timer once all steps are completed
                ((System.Windows.Forms.Timer)sender).Stop();

                // Show or hide controls based on loading completion
                label1.ForeColor = Color.Green;
                label1.Text = "Information Gathered, 'Please Scroll One By One To View All Information'";
                progressBar1.Visible= false;
                loader1.Visible= false;
                osinformation1.Visible = true;
                antivirusControl1.Visible = false;
                deviceinfo1.Visible = false;
                hardDiskinfo1.Visible = false;
                softwareInfo1.Visible = false;
                hardwareInfo1.Visible = false;
            }
        }

        private void LoadDataForStep(int step)
        {
            // Perform loading tasks based on the current step
            switch (step)
            {
                case 0:
                    // Load data for the first step
                    osinformation os = new osinformation();
                    os.InitializeComponent();
                    os.Load += Os_Load;
                    break;

                // Add additional cases for other steps if needed

                default:
                    break;
            }
        }


        private void Device_Load(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Os_Load(object? sender, EventArgs e)
        {
            osinformation os = new osinformation();
            os.osinfo();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void os_click(object sender, EventArgs e)
        {
            osinformation1.Visible = true;
            antivirusControl1.Visible = false;
            deviceinfo1.Visible = false;
            hardDiskinfo1.Visible = false;
            softwareInfo1.Visible = false;
            hardwareInfo1.Visible = false;
        }

        private void anti_click(object sender, EventArgs e)
        {
            osinformation1.Visible = false;
            antivirusControl1.Visible = true;
            deviceinfo1.Visible = false;
            hardDiskinfo1.Visible = false;
            softwareInfo1.Visible = false;
            hardwareInfo1.Visible = false;
        }

        private void device_click(object sender, EventArgs e)
        {
            osinformation1.Visible = false;
            antivirusControl1.Visible = false;
            deviceinfo1.Visible = true;
            hardDiskinfo1.Visible = false;
            softwareInfo1.Visible = false;
            hardwareInfo1.Visible = false;

        }

        private void harddisk_click(object sender, EventArgs e)
        {
            osinformation1.Visible = false;
            antivirusControl1.Visible = false;
            deviceinfo1.Visible = false;
            hardDiskinfo1.Visible = true;
            softwareInfo1.Visible = false;
            hardwareInfo1.Visible = false;
        }

        private void port_click(object sender, EventArgs e)
        {
            osinformation1.Visible = false;
            antivirusControl1.Visible = false;
            deviceinfo1.Visible = false;
            hardDiskinfo1.Visible = false;
            softwareInfo1.Visible = false;
            hardwareInfo1.Visible = false;
        }

        private void system_click(object sender, EventArgs e)
        {
            osinformation1.Visible = false;
            antivirusControl1.Visible = false;
            deviceinfo1.Visible = false;
            hardDiskinfo1.Visible = false;
            softwareInfo1.Visible = true;
            hardwareInfo1.Visible = false;
        }

        private void hardware_click(object sender, EventArgs e)
        {
            osinformation1.Visible = false;
            antivirusControl1.Visible = false;
            deviceinfo1.Visible = false;
            hardDiskinfo1.Visible = false;
            softwareInfo1.Visible = false;
            hardwareInfo1.Visible = true;
        }
    }
}
