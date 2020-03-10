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
using System.IO;

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
            threadUrl.Start(CommandsProcess);
        }

        public void threadmethod(object path)
        {
            process = new Process();
            process.StartInfo.WorkingDirectory = Properties.Settings.Default.TOOLS_PATH;
            process.StartInfo.FileName = "cmd";
            //process.StartInfo.Arguments = "/c dir";
            process.StartInfo.Arguments = path.ToString();

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
                SetFinishText($"{groupBoxTool.Text} finish");
            }
        }

        private delegate void SetTextBoxTextInvoker(string text);
        private void SetTextBoxText(string text)
        {

            if (this.lstUrls.InvokeRequired)
            {
                //this.txtUrls.Invoke(new SetTextBoxTextInvoker(SetTextBoxText), text);
                this.lstUrls.Invoke(new SetTextBoxTextInvoker(SetTextBoxText), text);
            }
            else
            {
                //this.txtUrls.Text += text + Environment.NewLine;
                this.lstUrls.Items.Add(text);
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter($"{Properties.Settings.Default.WORKING_PATH}\\{groupBoxTool.Text}-Output.txt"))
            {
                for (int i = 0; i < lstUrls.Items.Count; i++)
                    sw.WriteLine(lstUrls.Items[i]);
            }
            txtFinish.Text = "File exported";
        }
    }
}
