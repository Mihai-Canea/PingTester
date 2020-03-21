using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PingTester.myForms
{
    public partial class ToolTesting : DockContent
    {

        Thread threadUrl;
        Process process;
        string CommandsProcess;

        public ToolTesting()
        {
            InitializeComponent();
        }

        public string ToolName
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string CommandTool
        {
            get { return CommandsProcess; }
            set { CommandsProcess = value; }
        }

        private void StartToolStripButton_Click(object sender, EventArgs e)
        {
            threadUrl = new Thread(new ParameterizedThreadStart(threadmethod));
            threadUrl.Start(CommandsProcess);
        }

        private void StopToolStripButton_Click(object sender, EventArgs e)
        {
            StatusTxtBox.Text = threadUrl.ThreadState.ToString();
            foreach (var process in Process.GetProcessesByName(this.Text))
            {
                process.Kill();
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            using (StreamWriter sw = new StreamWriter($"{Properties.Settings.Default.WORKING_PATH}\\{dateTime.ToString("dd-MM-yyyy")}{this.Text}-Output.txt"))
            {
                for (int i = 0; i < lstUrls.Items.Count; i++)
                    sw.WriteLine(lstUrls.Items[i]);
            }
            StatusTxtBox.Text = "File exported";
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
                if (outLine.Data != null)
                {
                    //MessageBox.Show(outLine.Data.ToString());
                    SetTextBoxText(outLine.Data.ToString());
                }
                else
                    SetFinishText($"{this.Text} finish");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
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
                this.StatusTxtBox.Text = text + Environment.NewLine;
        }
        
    }
}
