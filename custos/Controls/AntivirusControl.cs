using System.Diagnostics;
using System.IO;
using System;
using System.Management;
using System.Windows.Forms;
using System.Text;
using custos.Methods;
using Newtonsoft.Json;
using static custos.Methods.AntivirusDTO;

namespace custos.Controls;

public partial class AntivirusControl : UserControl
{
    AntivirusMethod antivirusMethod = new AntivirusMethod();
    public AntivirusControl()
    {
        InitializeComponent();
    }

    private void Antivirus_Load(object sender, EventArgs e)
    {
        GetAntiviruInfo();

    }
    public void GetAntiviruInfo()
    {
        try
        {
            var outputData = antivirusMethod.AntivirusInfo();

            var antivirusData = new List<string>();


            foreach (var result in outputData.Get())
            {
                antivirusData.Add(result["displayName"].ToString());
            }
            int baseFontSize = 10;
            int productNumber = 1;
            AVList.ReadOnly = true;
            AVList.Text = "";
            AVList.SelectionFont = new Font(AVList.Font.FontFamily, 13, FontStyle.Bold);
            AVList.AppendText(antivirusData.Count + " Antivirus Products Found\n");
            AVList.AppendText(Environment.NewLine);
            AVList.SelectionIndent = 0;

            AVList.SelectionFont = new Font(AVList.Font, FontStyle.Regular);

            foreach (string product in antivirusData)
            {
                Font productFont = new Font(AVList.Font.FontFamily, baseFontSize, FontStyle.Regular);
                AVList.SelectionFont = productFont;

                AVList.AppendText($"{productNumber}. {product}{Environment.NewLine}");
                productNumber++;
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message.ToString());
        }
    }
}
