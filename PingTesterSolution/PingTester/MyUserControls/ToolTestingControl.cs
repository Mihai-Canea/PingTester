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
    public partial class ToolTestingControl : UserControl
    {
        Thread threadUrl;
        Process process;
        string CommandsProcess;

        public ToolTestingControl()
        {
            InitializeComponent();
        }

        public string ToolName
        {
            get { return groupBoxTool.Text; }
            set { groupBoxTool.Text = value; }
        }

        public string CommandTool
        {
            get { return CommandsProcess; }
            set { CommandsProcess = value; }
        }

        private void btnTestUrls_Click(object sender, EventArgs e)
        {
            threadUrl = new Thread(new ParameterizedThreadStart(threadmethod));
            // C:\Users\{}\Desktop\Projects\BurpFiles\Targets\Sophos\subfinder_out.txt
            //threadUrl.Start(@"/c cat sas.txt | httprobe -p http:8080 -p https:8443");
            //threadUrl.Start(@"/c amass enum -d tesla.com");
            threadUrl.Start(CommandsProcess);
            //threadUrl.Start(@"/c subfinder -d tesla.com");
        }

        public void threadmethod(object path)
        {
            process = new Process();
            process.StartInfo.WorkingDirectory = @"C:\ReconTools\";
            process.StartInfo.FileName = "cmd";
            //process.StartInfo.Arguments = "/c dir";
            process.StartInfo.Arguments =path.ToString();

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
                SetFinishText("httprobe finish");
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

        private delegate void SetFinishTextInvoker(string text);
        private void SetFinishText(string text)
        {

            if (this.txtFinish.InvokeRequired)
            {
                this.txtFinish.Invoke(new SetFinishTextInvoker(SetFinishText), text);
            }
            else
            {
                this.txtFinish.Text = text + Environment.NewLine;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            txtFinish.Text = threadUrl.ThreadState.ToString();
            foreach (var process in Process.GetProcessesByName(groupBoxTool.Text))
            {
                process.Kill();
            }
        }
    }
}
