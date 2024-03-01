using System.Collections;
using System.Diagnostics;
using System.Management;
using System.Net.NetworkInformation;
using custos.Common;
using Microsoft.Win32;
using Newtonsoft.Json;
using static custos.Methods.SystemInfoDTO;

namespace custos.Methods;

public class SystemInfoMethod
{
    List<SoftwareDTO> softwareInfo { get; set; } = new List<SoftwareDTO>();
    SoftwareDTO softwaredto { get; set; } = new SoftwareDTO();

    SoftwareDTONew software { get; set; } = new SoftwareDTONew();
    List<HardwareDTO> hardwareInfo { get; set; } = new List<HardwareDTO>();
    HardwareDTO hardwaredto { get; set; } = new HardwareDTO();

    public async Task<List<SoftwareDTONew>> SoftwareData()
    {
        List<SoftwareDTONew> softwareInf = new List<SoftwareDTONew>();

        Process[] processCollection = Process.GetProcesses();
        foreach (Process p in processCollection)
        {
            try
            {
                // Access additional process information
                string processName = p.ProcessName;
                string MainWindowTitle = string.IsNullOrEmpty(p.MainWindowTitle) ? "N/A" : p.MainWindowTitle;
                long memorySize = p.WorkingSet64;
                string moduleName = p.MainModule.ModuleName.ToString();
                DateTime dateTime = p.StartTime;
                long processid = p.Id;
                float cpuUsage = GetRoundedCpuUsageForProcess(p);

                SoftwareDTONew software = new SoftwareDTONew();
                software.WindowTitle = MainWindowTitle.ToString() + Environment.NewLine;
                software.Name = processName;
                software.SystemId = System.Environment.MachineName;
                software.MemorySize = memorySize;
                software.moduleName = moduleName;
                software.starttime = dateTime;
                software.pid = processid;
                software.CpuUsage = cpuUsage;

                softwareInf.Add(software);
            }
            catch (Exception ex)
            {
                // Handle exceptions if any
                Console.WriteLine($"Error processing {p.ProcessName}: {ex.Message}");
            }
        }

        // Call the SendSoftwareInfo method 
        await SendSoftwareInfo(softwareInfo);

        return softwareInf;
    }

    private int GetRoundedCpuUsageForProcess(Process process)
    {
        using (PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"))
        {
            cpuCounter.NextValue(); // Call NextValue() at least once before reading the value
            System.Threading.Thread.Sleep(100);
            int roundedCpuUsage = (int)Math.Round(cpuCounter.NextValue());
            return roundedCpuUsage;
        }
    }











    public async Task<List<HardwareDTO>> HardwareData()
    {
        ManagementObjectSearcher searcher;
        int i = 0;
        ArrayList arrayListInformationCollactor = new ArrayList();
        try
        {
            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in searcher.Get())
            {
                i++;
                PropertyDataCollection searcherProperties = mo.Properties;
                foreach (PropertyData sp in searcherProperties)
                {
                    hardwaredto = new();
                    hardwaredto.SystemId = System.Environment.MachineName;
                    hardwaredto.Name = sp.Name;
                    hardwaredto.IsArray = sp.IsArray;
                    hardwaredto.IsLocal = sp.IsLocal;
                    hardwaredto.Origin = sp.Origin;
                    hardwaredto.Type = sp.Type != null ? sp.Type.ToString() : "";
                    hardwaredto.value = sp.Value != null ? sp.Value.ToString() : "";
                    hardwaredto.Qualifires = sp.Qualifiers != null ? sp.Qualifiers.ToString() : "";
                    hardwareInfo.Add(hardwaredto);
                    arrayListInformationCollactor.Add(sp);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        await SendHardwareInfo(hardwareInfo);
        return hardwareInfo;
    }
    public async Task SendSoftwareInfo(List<SoftwareDTO> data)
    {
        try
        {
            var jsonData = JsonConvert.SerializeObject(data);
            using (HttpClient httpClient = new HttpClient())
            {
                var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(SystemInfoAPI.Software_url, content);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Response responseModel = JsonConvert.DeserializeObject<Response>(responseBody);
                    if (responseModel != null)
                    {

                    }
                }
            }
        }
        catch (Exception ex)
        {

        }

    }
    public async Task SendHardwareInfo(List<HardwareDTO> data)
    {
        try
        {
            var jsonData = JsonConvert.SerializeObject(data);
            using (HttpClient httpClient = new HttpClient())
            {
                var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(SystemInfoAPI.Hardware_url, content);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Response responseModel = JsonConvert.DeserializeObject<Response>(responseBody);
                    if (responseModel != null)
                    {

                    }
                }
            }
        }
        catch (Exception ex)
        {

        }

    }

}

public class SystemInfoAPI
{

    public static string Software_url = "http://65.2.100.52:1007/api/system/softwareinfo";
    public static string Hardware_url = "http://65.2.100.52:1007/api/system/hardwareinfo";

}

public class SystemInfoDTO
{
    public class HardwareDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string value { get; set; }
        public string Type { get; set; }
        public bool IsLocal { get; set; }
        public bool IsArray { get; set; }
        public string Origin { get; set; }
        public string Qualifires { get; set; }
        public string SystemId { get; set; }
    }
    public class SoftwareDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public DateTime InstalledOn { get; set; }
        public int Size { get; set; }
        public string SystemId { get; set; }
        public string IpAddress { get; set; }
        public long MemorySize { get; set; }
    }

    public class SoftwareDTONew
    {
        public string WindowTitle { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string SystemId { get; set; }

        public long MemorySize { get; set; }

        public string moduleName { get; set; }

        public DateTime starttime { get; set; }
        public long pid { get; set; }

        public float CpuUsage { get; set; }
    }
}
