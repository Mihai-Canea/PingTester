using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace PingTester.MyUserControls
{
    public partial class PingTesterControl : UserControl
    {

        public PingTesterControl()
        {
            InitializeComponent();
        }

        private void PingTesterControl_Load(object sender, EventArgs e)
        {

        }

        public string PATH
        {
            set { lblPath.Text = value; }
        }

        private void lblPath_TextChanged(object sender, EventArgs e)
        {
            dgvSuccess.Rows.Clear();
            using (StreamReader sr = new StreamReader($"{Properties.Settings.Default.WORKING_PATH}\\{lblPath.Text}"))
            {
                string line;
                while (sr.Peek() != -1)
                {
                    line = sr.ReadLine();
                    dgvSuccess.Rows.Add(line, "");
                }
                sr.Close();
            }
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            IPStatus status;
            Func<string, Task<IPStatus>> func =
                    async (localUrl) =>
                    {
                        Random random = new Random();
                        Ping ping = new Ping();
                        PingReply pingReply =
                            await ping.SendPingAsync(localUrl, (int)numPingTimeout.Value);
                        return pingReply.Status;
                    };

            for (int i = 0; i < dgvSuccess.Rows.Count - 1; i++)
            {
                if (dgvSuccess.Rows[i].Cells[0].Value.ToString() != "")
                {
                    try
                    {
                        lblPinging.Text = $">>> Ping... {i + 1}/{(dgvSuccess.Rows.Count - 1)}";
                        status = await func(dgvSuccess.Rows[i].Cells[0].Value.ToString());
                        dgvSuccess.Rows[i].Cells[1].Value = status;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Errore alla riga :{i} {dgvSuccess.Rows[i].ToString()}");
                    }
                }
            }
            lblPinging.Text = ">>> Complete";
        }

        private void btnExportSuccess_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter($"{Properties.Settings.Default.WORKING_PATH}\\PingOutputSuccess.txt"))
            {
                for (int i = 0; i < dgvSuccess.RowCount - 1; i++)
                    if (dgvSuccess.Rows[i].Cells[1].Value.ToString() == "Success")
                        sw.WriteLine(dgvSuccess.Rows[i].Cells[0].Value);
                sw.Close();
            }
        }
    }
}
