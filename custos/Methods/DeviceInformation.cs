using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace custos.Methods
{
    public class DeviceInformation
    {
       

        public class DeviceInformationDTO
        {
            public double TotalVirtualMemoryMB { get; set; }
            public double AvailableVirtualMemoryMB { get; set; }
            

            public string DisplayManufacturer { get; set; }

            public string DisplayDetails { get; set; } 
            
            public string DisplayName { get; set; }
        }

        public DeviceInformationDTO DeviceInfo()
        {
            PerformanceCounter totalVirtualMemoryCounter = new PerformanceCounter("Memory", "Committed Bytes");
            PerformanceCounter availableVirtualMemoryCounter = new PerformanceCounter("Memory", "Available Bytes");

            ManagementScope scope = new ManagementScope("\\\\.\\root\\cimv2");
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_BaseBoard");
            ObjectQuery displayquery = new ObjectQuery("SELECT * FROM Win32_VideoController");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher dissearcher = new ManagementObjectSearcher(scope, displayquery);

            long totalVirtualMemory = (long)totalVirtualMemoryCounter.NextValue();
            long availableVirtualMemory = (long)availableVirtualMemoryCounter.NextValue();

            // Convert bytes to megabytes for better readability
            double totalVirtualMemoryMB = totalVirtualMemory / (1024.0 * 1024.0);
            double availableVirtualMemoryMB = availableVirtualMemory / (1024.0 * 1024.0);

            
            string DisplayManufacturer = ""; // Initialize the variable outside the loop
            string DisplayDetails = ""; // Initialize the variable outside the loop
            string displayname = ""; // Initialize the variable outside the loop

            foreach (ManagementObject queryObj in searcher.Get())
            {
                DisplayManufacturer = queryObj["Manufacturer"].ToString();


            }

            foreach (ManagementObject querydis in dissearcher.Get())
            {

                DisplayDetails = querydis["Description"].ToString();
                
                displayname = querydis["Name"].ToString();

            }

            return new DeviceInformationDTO
            {
                TotalVirtualMemoryMB = totalVirtualMemoryMB,
                AvailableVirtualMemoryMB = availableVirtualMemoryMB,
                DisplayManufacturer = DisplayManufacturer,
                DisplayDetails = DisplayDetails,
                DisplayName = displayname

            };
        }


    }
}
