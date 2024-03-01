using custos.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static custos.Methods.DeviceInformation;

namespace custos.Controls.SubControl
{
    public partial class Deviceinfo : UserControl
    {
        //DeviceInformation device = new DeviceInformation();
        public Deviceinfo()
        {
            InitializeComponent();
        }

        private async void device_load(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            devicedata();

        }

        public void devicedata()
        {
            DeviceInformation device = new DeviceInformation();
            DeviceInformationDTO dev = device.DeviceInfo();  // Assign the result of DeviceInfo() to dev

            

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Device Version: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(Environment.OSVersion.Platform.ToString() + "\n\n");

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Device Name: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(Environment.MachineName.ToString() + "\n\n");


            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("BIOS NO: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(GetBiosSerialNumber().ToString() + "\n\n");

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("MAC Address: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(GetMacAddress().ToString() + "\n\n");

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("IP Address: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(GetIpAddress().ToString() + "\n\n");


            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Total Virtual Memory: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(dev.TotalVirtualMemoryMB.ToString("N2") + " MB" + "\n\n");

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Total AvailabeVirtualMemory: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(dev.AvailableVirtualMemoryMB.ToString("N2") + " MB" + "\n\n");


            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Display Manufacturer: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(dev.DisplayManufacturer + "\n\n");

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Display Name: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(dev.DisplayName + "\n\n");

            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.AppendText("Display Details: ");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
            richTextBox1.AppendText(dev.DisplayDetails + "\n\n");



            
        }



        static string GetBiosSerialNumber()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS"))
            {
                ManagementObjectCollection biosCollection = searcher.Get();
                foreach (ManagementObject bios in biosCollection)
                {
                    return bios["SerialNumber"].ToString();
                }
            }
            return "N/A";
        }

        static string GetMacAddress()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                //if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                //	networkInterface.OperationalStatus == OperationalStatus.Up)
                //{
                //	return networkInterface.GetPhysicalAddress().ToString();
                //}
                string tempMac = networkInterface.GetPhysicalAddress().ToString();
                if (!string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= 8)
                {
                    return tempMac;
                    //return macAddress;
                }

            }
            return "N/A";
        }

        static string GetIpAddress()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(hostName);

            foreach (IPAddress ipAddress in ipEntry.AddressList)
            {
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ipAddress.ToString();
                }
            }

            return "N/A";
        }
    }
}
