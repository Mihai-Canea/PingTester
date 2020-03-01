using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace Recon
{
    public partial class PingTester : UserControl
    {
        const string WORKING_PATH = @"C:\Users\miche\Desktop\Projects\BurpFiles\Targets\TEST_RECON";

        public PingTester()
        {
            InitializeComponent();
        }

        private void PingTester_Load(object sender, EventArgs e)
        {

        }

        public string PATH
        {
            set { lblPath.Text = value; }
        }

        private void lblPath_TextChanged(object sender, EventArgs e)
        {
            lstUrls.Items.Clear();
            //textBox1.Text = File.ReadAllText();
            using (StreamReader sr = new StreamReader($"{WORKING_PATH}\\{lblPath.Text}"))
            {
                string line;
                while (sr.Peek() != -1)
                {
                    line = sr.ReadLine();
                    lstUrls.Items.Add(line);
                }
                sr.Close();
            }
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();
            IPStatus status;
            Func<string, Task<IPStatus>> func =
                    async (localUrl) =>
                    {
                        Random random = new Random();
                        Ping ping = new Ping();
                        PingReply pingReply =
                            await ping.SendPingAsync(localUrl, 100);
                        return pingReply.Status;
                    };

            for (int i = 0; i < lstUrls.Items.Count; i++)
            {
                //MessageBox.Show(lstUrls.Items[i].ToString());
                if (lstUrls.Items[i].ToString() != "")
                {
                    try
                    {
                        lblPinging.Text = $"Pinging... {i}";
                        status = await func(lstUrls.Items[i].ToString());
                        dgvResults.Rows.Add(lstUrls.Items[i].ToString(), status);
                        dgvResults.FirstDisplayedScrollingRowIndex = dgvResults.RowCount - 1;
                        lstUrls.SetItemChecked(i, true);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Errore alla riga :{i} {lstUrls.Items[i].ToString()}");
                    }
                }
            }
            //lblPinging.Text = "";
        }


        private void cmbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlFilterText.Visible = false;
            dgvSuccess.Rows.Clear();
            switch (cmbFilters.Text)
            {
                case "Text":
                    pnlFilterText.Visible = true;
                    break;
                case "Success":
                    btnExportSuccess.Visible = true;
                    for (int i = 0; i < dgvResults.RowCount - 1; i++)
                    {
                        if (dgvResults.Rows[i].Cells[1].Value.ToString() == "Success")
                        {
                            dgvSuccess.Rows.Add(dgvResults.Rows[i].Cells[0].Value, "Success");
                        }
                    }
                    break;
                case "TimedOut":
                    break;
            }
        }

        private void btnExportSuccess_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("OutputSuccess.txt"))
            {
                for (int i = 0; i < dgvSuccess.RowCount - 1; i++)
                    sw.WriteLine(dgvSuccess.Rows[i].Cells[0].Value);
            }
        }
    }
}
