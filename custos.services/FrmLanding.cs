using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text;
using Newtonsoft.Json;
using custos.services.Services;


namespace custos.services
{
	public partial class FrmLanding : Form
	{
		private string _ticketID = string.Empty;
		private int rating = 0;
		private List<TicketRecord> feedBacks = new List<TicketRecord>();
		private string currentincidentid = string.Empty;

		private string systemid = System.Environment.MachineName;
		string basepath = AppDomain.CurrentDomain.BaseDirectory;
		bool close5 = false;

		public FrmLanding()
		{
			try
			{
				LogWriter.LogWrite("try block of frmlanding constructor");
				InitializeComponent();
				string settingspath = "";


#if (DEBUG)
                settingspath = Path.Combine(basepath, "appsettings.Development.json");

#else
				settingspath = Path.Combine(basepath, "appsettings.Production.json");

#endif
				string jsondata = File.ReadAllText(settingspath);
				dynamic output = JsonConvert.DeserializeObject<object>(jsondata);
				TicketApi.GET_TICKET_URL = output.GET_TICKET_URL;
				TicketApi.UPDATE_TICKET_URL = output.UPDATE_TICKET_URL;
			}
			catch (Exception ex)
			{
				LogWriter.LogWrite("exception in frmlanding constructor - " + ex.Message);
			}
		}


		private async void FrmLanding_Load(object sender, EventArgs e)
		{

			GetTicketCount();

		}

		private async Task GetTicketCount()
		{
			try
			{
				LogWriter.LogWrite("try block of getticketcount method");
				var systemid = System.Environment.MachineName;
				HttpClient httpClient = new HttpClient();
				var response = await httpClient.GetAsync(new Uri(TicketApi.GET_TICKET_URL + "?systemid=" + systemid));
				var dbdata = await response.Content.ReadFromJsonAsync<Response>();
				if (dbdata != null && dbdata.Status == "Success")
				{
					feedBacks = JsonConvert.DeserializeObject<List<TicketRecord>>(dbdata.Data.ToString());
					LoadFeedback();
				}

			}
			catch (Exception ex)
			{
				LogWriter.LogWrite("exception in getticketcount method- " + ex.Message.ToString());
				feedBacks = new List<TicketRecord>();


			}

		}
		// rik        private async Task LoadFeedback()
		private void LoadFeedback()
		{
			try
			{
				LogWriter.LogWrite("try block of loadfeedback");
				if (feedBacks.Count == 0 || feedBacks == null)
				{
					// pnlfeddback.Visible = false;
					currentincidentid = string.Empty;
					this.Hide();
				}
				else
				{
					pnlfeddback.Visible = true;
					if (feedBacks[0].TicketId == null)
					{
						currentincidentid = string.Empty;
						this.Hide();
					}
					else
					{
						currentincidentid = feedBacks[0].TicketId.ToString();
						if (feedBacks[0].close_count == 0)
						{
							lblincidentno.Text = feedBacks[0].TicketId.ToString();

						}
						if (feedBacks[0].close_count <= 4 && feedBacks[0].close_count > 0)
						{

							lblincidentno.Text = feedBacks[0].TicketId.ToString() + " " + "(Reminder" + feedBacks[0].close_count.ToString() + ")";
						}
						else
						{
							lblincidentno.Text = feedBacks[0].TicketId.ToString() + " " + "(final Reminder" + feedBacks[0].close_count.ToString() + ")";

						}
						lblsubject.Text = feedBacks[0].Description;
						lblresolvedon.Text = feedBacks[0].ResolvedDateTime.ToString();
						lblassignedto.Text = feedBacks[0].ExpertAssigneeName;
					}
				}
			}
			catch (Exception ex)
			{
				LogWriter.LogWrite("exception in loadfeedback method - " + ex.Message);
			}

		}
		private void btn1_Click(object sender, EventArgs e)
		{

			UpdateRating(1);
		}
		private void UpdateRating(int ratings)
		{
			rating = ratings;
			TicketApi.starcount = rating;
			foreach (var control in this.pnlcontrols.Controls)
			{
				string ctlname = control.GetType().Name;
				Console.WriteLine("Control Name " + ctlname);
				if (control.GetType().Name == "Button")
				{
					var ctl = (Button)control;
					if (ctl.Tag == "feedback")
					{
						ctl.BackgroundImage = global::custos.services.Properties.Resources.b_star;
					}
					if (ctl.Tag == "feedback" && Convert.ToInt32(ctl.Name.Split("_")[1]) <= rating)
					{
						ctl.BackgroundImage = global::custos.services.Properties.Resources.y_star;
					}

				}
			}

		}

		private void pnlfeddback_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btn_2_Click(object sender, EventArgs e)
		{
			UpdateRating(2);
		}

		private void btn_3_Click(object sender, EventArgs e)
		{
			UpdateRating(3);
		}

		private void btn_4_Click(object sender, EventArgs e)
		{
			UpdateRating(4);
		}

		private void btn_5_Click(object sender, EventArgs e)
		{
			UpdateRating(5);
		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void cmdclose_Click(object sender, EventArgs e)
		{
			CloseAction();

		}
		private async Task CloseAction()
		{
			try
			{
				LogWriter.LogWrite("try block of closeaction");
				foreach (var item in feedBacks)
				{
					if (item.close_count == 5)
					{
						close5 = true;
						TicketApi.starcount = 4;
						textBox1.Text = "Feedback form is AutoSumbit due to 5 time close..";
						SubmitFeedback();
					}
				}
				if (close5 == false)
				{
					if (currentincidentid != null)
					{
						//Add api for recording of close action and increament count 
						UpdateTicket updateTicket = new UpdateTicket();
						updateTicket.starcount = TicketApi.starcount;
						updateTicket.action = "close";
						updateTicket.IncidentId = Convert.ToInt32(currentincidentid);
						updateTicket.Remarks = textBox1.Text;
						string jsonData = JsonConvert.SerializeObject(updateTicket);
						HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

						//TicketApi.action = "close";
						//TicketApi.IncidentId = 318472;
						HttpClient httpClient = new HttpClient();
						//var response = await httpClient.PostAsync(new Uri(TicketApi.UPDATE_TICKET_URL + "?incidentid=" + TicketApi.IncidentId + "&Remarks=" + TicketApi.Remarks + "&StarCount=" + TicketApi.starcount + "&action=" + TicketApi.action), content);
						var response = await httpClient.PostAsync(new Uri(TicketApi.UPDATE_TICKET_URL), content);
						var dbdata = await response.Content.ReadFromJsonAsync<Response>();
						if (dbdata != null && dbdata.Status == "Success")
						{
							feedBacks = JsonConvert.DeserializeObject<List<TicketRecord>>(dbdata.Data.ToString());
							MessageBox.Show(updateTicket.IncidentId + " Ticket Close Successfully...");
							clear();
							LoadFeedback();
						}

					}

				}

			}
			catch (Exception ex)
			{
				LogWriter.LogWrite("Exception in CloseAction Method- " + ex.Message);
			}
		}


		private void FrmLanding_FormClosing(object sender, FormClosingEventArgs e)
		{
			CloseAction();


		}

		private async Task SubmitFeedback()
		{
			try
			{
				LogWriter.LogWrite("try block of submitfeedback");
				if (currentincidentid != null)
				{

					//Add api for recording of close action and increament count 
					UpdateTicket updateTicket = new UpdateTicket();
					updateTicket.starcount = TicketApi.starcount;// TicketApi.starcount;
					updateTicket.action = "submit";
					updateTicket.IncidentId = Convert.ToInt32(currentincidentid);
					updateTicket.Remarks = textBox1.Text;
					if (updateTicket.starcount <= 3)
					{
						MessageBox.Show("Remarks is Mandatory");
						return;
					}
					string jsonData = JsonConvert.SerializeObject(updateTicket);
					HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");


					HttpClient httpClient = new HttpClient();
					var response = await httpClient.PostAsync(new Uri(TicketApi.UPDATE_TICKET_URL), content);
					var dbdata = await response.Content.ReadFromJsonAsync<Response>();
					if (dbdata != null && dbdata.Status == "Success")
					{

						feedBacks = JsonConvert.DeserializeObject<List<TicketRecord>>(dbdata.Data.ToString());
						MessageBox.Show(updateTicket.IncidentId + " Ticket Sumbit Successfully...");
						clear();

						LoadFeedback();
					}


				}
			}
			catch (Exception ex)
			{
				LogWriter.LogWrite("Exception in Submit Feedback - " + ex.Message);
			}

		}

		private void clear()
		{
			TicketApi.starcount = 0;
			textBox1.Text = "";
			UpdateRating(0);
		}

		private void cmdsubmit_Click(object sender, EventArgs e)
		{
			SubmitFeedback();
		}

		private void FrmLanding_FormClosed(object sender, FormClosedEventArgs e)
		{
			base.OnClosed(e);

			GC.WaitForFullGCComplete();
		}

		private void CIPL_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}
	}
}