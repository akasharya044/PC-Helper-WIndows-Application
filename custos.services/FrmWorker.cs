using System.Net.Http.Json;
using custos.services.Services;
using Newtonsoft.Json;

namespace custos.services
{
    public partial class FrmWorker : Form
    {

        private List<FeedBack> feedBacks = new List<FeedBack>();
        private readonly IBus _busControl;
        private string systemid = System.Environment.MachineName;
        string basepath = AppDomain.CurrentDomain.BaseDirectory;
        string settingspath = "";
        //        FrmLanding a = new FrmLanding();
        public FrmWorker()
        {
            try
            {
                LogWriter.LogWrite("Enter in try block of frmworker constructor");
                InitializeComponent();
                this.Resize += SetMinimizeState;

                // When tray icon clicked, trigger window state change.       
                CIPL.DoubleClick += ToggleMinimizeState;

                //_busControl = RabbitConnector.CreateBus("65.2.100.52"); production IP

#if (DEBUG)
                settingspath = Path.Combine(basepath, "appsettings.Development.json");

#else
                settingspath = Path.Combine(basepath, "appsettings.Production.json");

#endif
                string jsondata = File.ReadAllText(settingspath);
                dynamic output = JsonConvert.DeserializeObject<object>(jsondata);

                _busControl = RabbitConnector.CreateBus(output.RabittMqHost.ToString());

                Scheduler();
                Task.Run(async () =>
                {
                    await _busControl.ReceiveFromExchangeAsync<string>("feedbackdata", async x =>
                    {
                        await OnFeedBackReceived(x);

                    });
                }, CancellationToken.None);
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Exception in Frmworker constructor - " + ex.Message);
            }
        }
        public void RegisterDevice()
        {
            Task.Factory.StartNew(async () =>
            {
                try
                {
                    LogWriter.LogWrite("try block of registerdevice");
                    DeviceDetailsDto deviceDetailsDto = new DeviceDetailsDto();
                    deviceDetailsDto.entity_type = "Device";
                    deviceDetailsDto.properties.IsDeleted = false;
                    deviceDetailsDto.properties.DisplayLabel = System.Environment.MachineName;
                    deviceDetailsDto.properties.LastUpdateTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    deviceDetailsDto.properties.SubType = "Desktop";
                    HttpClient httpClient = new HttpClient();
                    string jsondata = File.ReadAllText(settingspath);
                    dynamic output = JsonConvert.DeserializeObject<object>(jsondata);
                    string registerurl = output.REGISTER_DEVICE.ToString();

                    var response = await httpClient.PostAsJsonAsync(registerurl, deviceDetailsDto);
                    var data = await response.Content.ReadFromJsonAsync<Response>();
                    string test = "T";


                }
                catch (Exception ex)
                {

                    LogWriter.LogWrite("enter in register device catch exception " + ex.Message);
                    Console.WriteLine(ex.ToString());

                }
            }, CancellationToken.None);
        }
        public static Form globalForm;
        public void GoToTicket()
        {
            try
            {
                FrmLanding landing = new FrmLanding();
                landing.ShowDialog();
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Exception in Gototicket Method - " + ex.Message);
            }

            //            this.Hide();
            //try
            //{
            //    globalForm.Invoke((MethodInvoker)delegate ()
            //    {

            //        a.Show();
            //        //this.Hide();
            //    });
            //}
            //catch (Exception ex)
            //{

            //}


        }
        public void WriteTolblhb(string text)
        {
            try
            {
                if (lblhb.InvokeRequired)
                {
                    // Call this same method but append THREAD2 to the text
                    Action safeWrite = delegate { WriteTolblhb($"{text}"); };
                    lblhb.Invoke(safeWrite);
                }
                else
                    lblhb.Text = text;
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Exception in WriteTolblhb Method - " + ex.Message);

            }
        }
        public void WriteToFd(string text)
        {
            try
            {
                if (lblfb.InvokeRequired)
                {
                    // Call this same method but append THREAD2 to the text
                    Action safeWrite = delegate { WriteToFd($"{text}"); };
                    lblfb.Invoke(safeWrite);
                }
                else
                    lblfb.Text = text;
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Exception in WriteToFd Method - " + ex.Message);
            }
        }
        private async Task OnFeedBackReceived(string message)
        {
            try
            {
                //MessageBox.Show("enter in try block of OnFeedBackReceived method");

                if (message.ToLower() != null && message.ToLower() == System.Environment.MachineName.ToLower())
                {
                    //Console.WriteLine("Feedback received");
                    WriteToFd("Received :" + DateTime.Now.ToString());
                    //await GetTicketCount();
                    // ToggleMinimizeState(null,new EventArgs());

                    GoToTicket();

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("enter in catch block of OnFeedBackReceived");
                LogWriter.LogWrite("Exception in OnFeedBackReceived Method - " + ex.Message);

                Console.WriteLine(ex.Message);
            }
        }

        private void Scheduler()
        {
            // MessageBox.Show("enter in scheduler method");

            Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        //MessageBox.Show("enter in try block of scheduler");
                        await SendHeartBeat();

                    }
                    catch (Exception ex)
                    {
                        LogWriter.LogWrite("Exception in Scheduler Method - " + ex.Message);

                        //MessageBox.Show("enter in catch block of scheduler");
                        //MessageBox.Show(ex.Message);

                    }


                    await Task.Delay(30000);
                }
            });
        }
        private async Task SendHeartBeat()
        {
            try
            {
                //MessageBox.Show("enter in sendheartbeat block");

                await _busControl.SendAsync<string>("deviceshb", systemid);
                WriteTolblhb("Heartbeat- " + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Exception in SendHeartBeat Method - " + ex.Message);

                Console.WriteLine();
            }
            //lblhb.Text = "HB : " +DateTime.Now.ToString();
            // Console.WriteLine("heartbeat sent");
        }
        private void ToggleMinimizeState(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Your System is Online and Connected With Microfocus");
                bool isMinimized = this.WindowState == FormWindowState.Minimized;
                this.WindowState = (isMinimized) ? FormWindowState.Normal : FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Exception in ToggleMinimizeState Method - " + ex.Message);

                Console.WriteLine();
            }
        }
        // Show/Hide window and tray icon to match window state.
        private void SetMinimizeState(object sender, EventArgs e)
        {

            bool isMinimized = this.WindowState == FormWindowState.Minimized;
            this.ShowInTaskbar = !isMinimized;
            CIPL.Visible = isMinimized;
            //if (isMinimized) notifyIcon1.ShowBalloonTip(500, "CIPL IT Assist", "CIPL IT Assist minimized to tray.", ToolTipIcon.Info);
        }

        private void FrmWorker_Load(object sender, EventArgs e)
        {
            try
            {
                // MessageBox.Show("Enter in FrmWorker_Load");
                this.WindowState = FormWindowState.Minimized;//
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 1000;
                toolTip1.ReshowDelay = 500;
                toolTip1.IsBalloon = true;
                toolTip1.ToolTipTitle = "CIPL IT Assist";
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.UseAnimation = true;
                toolTip1.UseFading = true;
                // Force the ToolTip text to be displayed whether or not the form is active.
                toolTip1.ShowAlways = true;
                // ToolTip
                CIPL.BalloonTipText = "CIPL IT Assist [Working]";
                CIPL.BalloonTipTitle = "CIPL IT Assist";
                globalForm = new Form();
                globalForm.Show();
                globalForm.Hide();
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Exception in FrmWorker_Load Method - " + ex.Message);
                Console.WriteLine();
            }

        }

        private void FrmWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false;
            }
        }

        private void FrmWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.OnClosed(e);
            CIPL.Dispose();
            GC.WaitForFullGCComplete();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            Close();
            //            ParentForm.Hide();
        }
    }
}
