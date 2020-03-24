using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PingTester
{
    public partial class VisualizeSubsForm : DockContent
    {
        public VisualizeSubsForm(String fileName)
        {
            InitializeComponent();
            this.Text = fileName;
            this.ToolStripLblPath.Text = fileName;
            string[] arr = fileName.Split('\\');
            arr = arr.Skip(1).ToArray();
            using (StreamReader sr = new StreamReader($"{Properties.Settings.Default.WORKING_PATH}\\{string.Join("\\", arr)}"))
            {
                string line;
                while (sr.Peek() != -1)
                {
                    line = sr.ReadLine();
                    txtVisual.Text += $"{line}{Environment.NewLine}";
                }
                sr.Close();
            }
        }

        private void FilterToolStripButton_Click(object sender, EventArgs e)
        {
            txtVisual.Text = "";
            using (StreamReader sr = new StreamReader($"{Properties.Settings.Default.WORKING_PATH}\\{ToolStripLblPath.Text}"))
            {
                string line;
                while (sr.Peek() != -1)
                {
                    line = sr.ReadLine();
                    if (!line.Contains(StripTxtFilter.Text))
                        txtVisual.Text += $"{line}{Environment.NewLine}";
                }
                sr.Close();
            }
        }

        private void ExportStripButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter($"{Properties.Settings.Default.WORKING_PATH}\\SubsFiltered.txt"))
            {
                for (int i = 0; i < txtVisual.Lines.Length; i++)
                    if (txtVisual.Lines[i] != "")
                        sw.WriteLine(txtVisual.Lines[i]);
            }
        }
    }
}
