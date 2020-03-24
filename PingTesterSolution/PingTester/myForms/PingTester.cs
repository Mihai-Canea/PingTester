using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PingTester.myForms
{
    public partial class PingTester : DockContent
    {
        private bool stopPinging = false;

        public PingTester(string PATH)
        {
            InitializeComponent();
            toolStripLblPath.Text = PATH;
            cmbTimer.SelectedIndex = 1;
        }

        private async void StartToolStripButton_Click(object sender, EventArgs e)
        {
            IPStatus status;
            Func<string, Task<IPStatus>> func =
                    async (localUrl) =>
                    {
                        Random random = new Random();
                        Ping ping = new Ping();
                        PingReply pingReply =
                            await ping.SendPingAsync(localUrl,Convert.ToInt32(cmbTimer.SelectedItem));
                        return pingReply.Status;
                    };

            for (int i = 0; i < dgvData.Rows.Count - 1; i++)
            {
                if (dgvData.Rows[i].Cells[0].Value.ToString() != "")
                {
                    try
                    {
                        if (!stopPinging)
                        {
                            toolStripLblPinging.Text = $">>> Ping... {i + 1}/{(dgvData.Rows.Count - 1)}";
                            status = await func(dgvData.Rows[i].Cells[0].Value.ToString());
                            dgvData.Rows[i].Cells[1].Value = status;
                        }
                        else
                            break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Errore alla riga :{i} {dgvData.Rows[i].ToString()}");
                    }
                }
            }
            toolStripLblPinging.Text = ">>> Complete";
        }

        private void toolStripLblPath_TextChanged(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();
            using (StreamReader sr = new StreamReader($"{Properties.Settings.Default.WORKING_PATH}\\{toolStripLblPath.Text}"))
            {
                string line;
                while (sr.Peek() != -1)
                {
                    line = sr.ReadLine();
                    dgvData.Rows.Add(line, "");
                }
                sr.Close();
            }
        }

        private void ExportToolStripButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter($"{Properties.Settings.Default.WORKING_PATH}\\PingOutputSuccess.txt"))
            {
                for (int i = 0; i < dgvData.RowCount - 1; i++)
                    if (dgvData.Rows[i].Cells[1].Value.ToString() == "Success")
                        sw.WriteLine(dgvData.Rows[i].Cells[0].Value);
                sw.Close();
            }
        }

        private void StopToolStripButton_Click(object sender, EventArgs e)
        {
            stopPinging = true;
        }

        private void PingTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopPinging = true;
        }
    }
}
