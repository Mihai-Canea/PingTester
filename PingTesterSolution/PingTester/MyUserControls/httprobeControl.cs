using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PingTester.MyUserControls
{
    public partial class httprobeControl : UserControl
    {
        public httprobeControl()
        {
            InitializeComponent();
        }

        private void btnTestUrls_Click(object sender, EventArgs e)
        {
            Thread threadUrl = new Thread(threadmethod);
            threadUrl.Start();
        }

        public void threadmethod()
        {
            Process process;
            process = new Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.Arguments = "/c cat sas.txt | httprobe -p http:8080 -p https:8443";

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
            process.Close();
        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            try
            {
                SetTextBoxText(outLine.Data.ToString());

            }
            catch (Exception)
            {
            }
        }

        private delegate void SetTextBoxTextInvoker(string text);
        private void SetTextBoxText(string text)
        {

            if (this.txtUrls.InvokeRequired)
            {
                this.txtUrls.Invoke(new SetTextBoxTextInvoker(SetTextBoxText), text);
            }
            else
            {
                this.txtUrls.Text += text + Environment.NewLine;
            }
        }
    }
}
