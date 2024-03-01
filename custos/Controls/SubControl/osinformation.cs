using custos.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custos.Controls.SubControl
{
    public partial class osinformation : UserControl
    {
        OsInfromation os = new OsInfromation();
        public osinformation()
        {
            InitializeComponent();
        }




        public void osinfo()
        {

            var data = os.OsInformation();
            var osdata = new List<string>();
           
            foreach (var item in data.Get())
            {


                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("Os Name: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(item["Caption"].ToString() + "\n\n");

                
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("OSArchitecture: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(item["OSArchitecture"].ToString() + "\n\n");


                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("Os Version: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(item["Version"].ToString() + "\n\n");



                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("Build Number: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(item["BuildNumber"].ToString() + "\n\n");


                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("Manufacturer: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(item["Manufacturer"].ToString() + "\n\n");


               

                var lastBootTimeString = item["LastBootUpTime"].ToString();

               
                DateTime lastBootUpTime = ManagementDateTimeConverter.ToDateTime(lastBootTimeString);


                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("LastBootUpTime: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(lastBootUpTime.ToString() + "\n\n");


               

                if (item["LastBootUpTime"] != null)
                {
                    var lastBootTimeString1 = item["LastBootUpTime"].ToString();
                    DateTime lastBootUpTime1 = ManagementDateTimeConverter.ToDateTime(lastBootTimeString1);

                    
                    TimeSpan lastBootDuration = DateTime.UtcNow - lastBootUpTime1.ToUniversalTime();

                   
                    int noOfDaysLastBoot = (int)Math.Round(lastBootDuration.TotalDays);

                    
                   
                   

                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                    richTextBox1.AppendText("No of Days Last System Boot: ");
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                    richTextBox1.AppendText(noOfDaysLastBoot.ToString()+" Days" + "\n\n");
                }

                

                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("SerialNumber: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(item["SerialNumber"].ToString() + "\n\n");



            }

            var data1 = os.OsInformation1();
            var osdata1 = new List<string>();
            foreach (var items in data1.Get())
            {

                string membershipType = items["DomainRole"].ToString();
                //osdata1.Add(items["DomainRole"]?.ToString());
                if (!string.IsNullOrEmpty(membershipType))
                {

                    if (membershipType == "0" || membershipType == "1")
                    {

                        osdata1.Add("Wrokgroup");
                       


                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        richTextBox1.AppendText("MemberShip Type: ");
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                        richTextBox1.AppendText("Workgroup" + "\n\n");


                    }
                    else if (membershipType == "2" || membershipType == "3" || membershipType == "4" || membershipType == "5")
                    {

                        osdata1.Add("Domain");
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        richTextBox1.AppendText("MemberShip Type: ");
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                        richTextBox1.AppendText("Domain" + "\n\n");

                    }
                    else
                    {

                        osdata1.Add("Unknown");
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        richTextBox1.AppendText("MemberShip Type: ");
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                        richTextBox1.AppendText("Unknown" + "\n\n");

                    }
                }


            }

            
           
            string applicationId = GetWindowsActivationApplicationId();
            if (applicationId != null)
            {
                bool isActivated = IsWindowsActivated(applicationId);
                // Osobj.IsActivated = isActivated;
                


                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("Windows Activation Status: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(isActivated.ToString() + "\n\n");

            }

            string Key = GetWindowsProductKey();

            if (!string.IsNullOrEmpty(Key))
            {
                //Osobj.WindowKey = Key;
                

                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("Windows Product Key: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(Key.ToString() + "\n\n");

            }

            bool isAdmin = IsUserAdministrator();

            WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();


            WindowsPrincipal currentPrincipal = new WindowsPrincipal(currentIdentity);

            if (currentIdentity.Name != null)
            {
                //Osobj.LastLogged = currentIdentity.Name;
                

                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("LastLogged: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText(currentIdentity.Name + "\n\n");
            }

            if (currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                //Osobj.Role = "Admin";
               

                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("LastLogged User Role: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText("Admin" + "\n\n");


            }
            else
            {
                //Osobj.Role = "Non Admin";
               

                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("LastLogged User Role: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText("Non Admin" + "\n\n");
            }
            if (isAdmin)
            {
                //Osobj.AdminStatus = "Current User Is Admin";
               

                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("Current User: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText("Admin" + "\n\n");
            }
            else
            {
               
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("Current User: ");
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font style to regular
                richTextBox1.AppendText("Non Admin" + "\n\n");
            }



        }






        static DateTime GetLastBootTime()
        {
            DateTime lastBootTime = DateTime.MinValue;

            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT LastBootUpTime FROM Win32_OperatingSystem"))
                {
                    ManagementObjectCollection results = searcher.Get();

                    foreach (ManagementObject result in results)
                    {
                        string lastBootTimeString = result["LastBootUpTime"]?.ToString();
                        lastBootTime = ManagementDateTimeConverter.ToDateTime(lastBootTimeString);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving last boot time: {ex.Message}");
            }

            return lastBootTime;
        }

        public static string GetWindowsActivationApplicationId()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM SoftwareLicensingProduct WHERE LicenseStatus = 1");
                ManagementObjectCollection objCollection = searcher.Get();

                foreach (ManagementObject obj in objCollection)
                {
                    // Assuming the first activated product is the one we want
                    return obj["ApplicationID"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving Application ID: {ex.Message}");
            }

            return null;
        }

        public static bool IsWindowsActivated(string applicationId)
        {
            if (string.IsNullOrEmpty(applicationId))
            {
                Console.WriteLine("Application ID is null or empty.");
                return false;
            }

            ManagementScope scope = new ManagementScope(@"\\" + Environment.MachineName + @"\root\cimv2");
            scope.Connect();

            SelectQuery searchQuery = new SelectQuery($"SELECT * FROM SoftwareLicensingProduct WHERE ApplicationID = '{applicationId}' AND LicenseStatus = 1");
            ManagementObjectSearcher searcherObj = new ManagementObjectSearcher(scope, searchQuery);

            using (ManagementObjectCollection obj = searcherObj.Get())
            {
                return obj.Count > 0;
            }
        }


        public static string GetWindowsProductKey()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("wmic", "path softwarelicensingservice get OA3xOriginalProductKey");
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                using (Process process = new Process() { StartInfo = psi })
                {
                    process.Start();
                    string result = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    string input = result;

                    // Define the pattern for the product key
                    string pattern = @"\b([A-Z0-9]{5}-[A-Z0-9]{5}-[A-Z0-9]{5}-[A-Z0-9]{5}-[A-Z0-9]{5})\b";

                    // Use Regex.Match to find the first match in the input string
                    Match match = Regex.Match(input, pattern);

                    // Check if a match is found
                    if (match.Success)
                    {
                        // Extract the matched product key
                        string productKey = match.Groups[1].Value;
                        return productKey;
                        // Print the extracted product key
                        //Console.WriteLine(productKey);
                    }
                    else
                    {
                        Console.WriteLine("No product key found in the input string.");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving Windows Product Key: {ex.Message}");
            }

            return null;
        }

        static bool IsUserAdministrator()
        {
            try
            {
                // Get the identity of the current user
                System.Security.Principal.WindowsIdentity currentIdentity = System.Security.Principal.WindowsIdentity.GetCurrent();

                // Get the principal representing the current user
                System.Security.Principal.WindowsPrincipal currentPrincipal = new System.Security.Principal.WindowsPrincipal(currentIdentity);

                // Check if the user is a member of the Administrator group
                return currentPrincipal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
            catch (Exception)
            {
                // If an exception occurs, return false (not an administrator)
                return false;
            }
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private async void os_load(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            osinfo();
        }
    }
}
