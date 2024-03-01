
namespace custos.Controls
{
	public partial class SystemControl : UserControl
	{
		public SystemControl()
		{
			InitializeComponent();
		}
		private void SoftwareInfo_Load(object sender, EventArgs e)
		{
			softwareInfo1.Show();
			hardwareInfo1.Show();
		}
	}
}
