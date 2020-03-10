using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingTester
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            showSettings();
        }

        private void showSettings()
        {
            txtWorkingPath.Text = Properties.Settings.Default.WORKING_PATH;
            txtToolPath.Text = Properties.Settings.Default.TOOLS_PATH;
        }

        private void btnWorkingPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Properties.Settings.Default.WORKING_PATH = fbd.SelectedPath.ToString();
                    Properties.Settings.Default.Save();
                }
            }
            showSettings();
        }

        private void btnToolPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Properties.Settings.Default.TOOLS_PATH = fbd.SelectedPath.ToString();
                    Properties.Settings.Default.Save();
                }
            }
            showSettings();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WORKING_PATH = "NULL";
            Properties.Settings.Default.TOOLS_PATH = "NULL";
            Properties.Settings.Default.Save();
            showSettings();
        }
    }
}
