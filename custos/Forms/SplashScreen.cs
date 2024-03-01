using custos.Controls.SubControl;
using System;
using System.Windows.Forms;

namespace custos.Forms
{
    public partial class SplashScreen : Form
    {
        private  System.Windows.Forms.Timer timer;
       
        private int progressValue;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50; // Set the interval in milliseconds
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();

           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the progress bar
            progressBar1.Value = progressValue++;

            // Check if the progress is complete
            if (progressValue >= 100)
            {
                // Stop the timer
                timer.Stop();

                // Close the splash screen and open the dashboard
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.Show();
            }
        }
    }
}
