using custos.Methods;


namespace custos.Controls;

public partial class HardwareInfo : UserControl
{
	SystemInfoMethod systemInfoMethod = new SystemInfoMethod();
	public HardwareInfo()
	{
		InitializeComponent();
	}
	private async void HardewareInfo_Load(object sender, EventArgs e)
	{
		await Task.Delay(5000);
		GetHardwareInfo();
	}
	public async void GetHardwareInfo()
	{
		try
		{
			var data = await systemInfoMethod.HardwareData();
			HdList.DataSource = data;
		}
		catch(Exception ex)
		{

		}
	}
}
