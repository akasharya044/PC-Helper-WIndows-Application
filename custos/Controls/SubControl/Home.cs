using custos.Methods;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static custos.Methods.SystemInfoDTO;

namespace custos.Controls.SubControl
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //AdditionalInfo info = new AdditionalInfo();
                //info.Visible = true;

                Dashboard dash = new Dashboard();
                dash.InitializeComponent();
                dash.tabControl1.SelectedIndex = 1;
                dash.Show();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private async void  Home_Load(object sender, EventArgs e)
        {
            WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
            label1.Text = "Welcome " + currentIdentity.Name;
            await Thought();

            // Assuming 'quotesData' is a class-level variable containing the fetched quotes
            if (quotesData != null && quotesData.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, quotesData.Count);
                QuoteModel randomQuote = quotesData[randomIndex];

                // Display the random quote in label2
                label2.Text = $"{randomQuote.Text} - {randomQuote.Author}";
                
            }
        }


        string apiUrl = "https://type.fit/api/quotes";
        List<QuoteModel> quotesData;

        public async Task Thought()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        quotesData = JsonConvert.DeserializeObject<List<QuoteModel>>(responseBody);
                    }
                    else
                    {
                        // Handle the error response
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        // Handle the error as needed
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public class QuoteModel
        {
            public string Text { get; set; }
            public string Author { get; set; }
        }



    }
}
