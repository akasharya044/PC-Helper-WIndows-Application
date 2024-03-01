
using System.Text.Json.Serialization;
using System.Windows.Forms;
using custos.Methods;
using Microsoft.Win32;
using static custos.Methods.SystemInfoDTO;

namespace custos.Controls;


public partial class SoftwareInfo : UserControl
{
    SystemInfoMethod systemInfoMethod = new SystemInfoMethod();
    public SoftwareInfo()
    {
        InitializeComponent();

    }
    private async void SoftwareInfo_Load(object sender, EventArgs e)
    {
        await Task.Delay(5000);
        GetSoftwareInfo();
    }
    public async void GetSoftwareInfo()
    {
        try
        {


            var data = await systemInfoMethod.SoftwareData();
            var groupedData = data.GroupBy(item => item.moduleName).Select(group => new
            {
                ProcessName = group.Key,
                WindowTitle = group.Select(item => item.WindowTitle).FirstOrDefault(),
                SystemId = group.Select(item => item.SystemId).FirstOrDefault(),
                MemorySize = group.Sum(item => item.MemorySize),
                Size = group.Select(item => item.Size).FirstOrDefault(),
                Pid = string.Join(", ", group.Select(item => item.pid)),
                StartTime = group.Select(item => item.starttime).FirstOrDefault(),
                Module = group.Select(item => item.moduleName).FirstOrDefault(),
                CPU = group.Select(item => item.CpuUsage).FirstOrDefault()
            }).ToList();


            dataGridView1.Columns.Add("ProcessName", "Process Name");
            dataGridView1.Columns.Add("WindowTitle", "Window Title");
            dataGridView1.Columns.Add("SystemId", "Host Name");
            dataGridView1.Columns.Add("MemorySize", "Memory Size");
            dataGridView1.Columns.Add("CPU", "CPU");
            dataGridView1.Columns.Add("Pid", "PID");
            dataGridView1.Columns.Add("StartTime", "Start Time");

            // Add data to the grid
            foreach (var item in groupedData)
            {
                dataGridView1.Rows.Add(item.ProcessName, item.WindowTitle, item.SystemId, item.MemorySize.ToString() + " MB", item.CPU + " %", item.Pid, item.StartTime);
            }

            // Optional: Auto-size columns based on content
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);



        }
        catch (Exception ex)
        {

        }
    }
}
