using custos.Methods;
using System.Windows.Forms;

namespace custos
{
    public partial class Dashboard : Form
    {
        
        SystemInfoMethod systemInfoMethod = new SystemInfoMethod();
        SelfHealMethod checkagain = new SelfHealMethod();
        public Dashboard()
        {
            InitializeComponent();
            
        }
        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //additionalInfo1.Visible = true;
            home1.Visible = true;
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //home1.Visible = true;
            //additionalInfo1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //home1.Visible = false;
            //additionalInfo1.Visible = true;
        }

        private void additionalInfo2_Load(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
