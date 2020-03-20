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
using System.Resources;
using System.Diagnostics;
using WeifenLuo.WinFormsUI.Docking;

namespace PingTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); var theme = new VS2015LightTheme();
            this.dockPanel1.Theme = theme;
            this.IsMdiContainer = true;

            myForms.FileExplorer fe = new myForms.FileExplorer();
            fe.Show(dockPanel1, DockState.DockLeft);

            myForms.ReconTools rt = new myForms.ReconTools();
            rt.Show(dockPanel1, DockState.DockRight);

            for (int i = 0; i < 10; i++)
            {
                VisualizeSubsForm vs = new VisualizeSubsForm("\\test.txt");
                vs.Show(dockPanel1, DockState.Document);
            }
        }

        TreeNode nodeSelect;

        private void Form1_Load(object sender, EventArgs e)
        {
            //FormDockingTest ff = new FormDockingTest();
            //ff.Show();

            //loadPathElements();

        }



        private void treeFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                nodeSelect = e.Node;
            }
        }


        private void loadPathElements()
        {
            //string pathRes = Properties.Settings.Default.WORKING_PATH;
            //if (pathRes == "NULL")
            //{
            //    MessageBox.Show("Choose a working path");
            //}
            //else
            //{
            //    ListDirectory(treeFiles, Properties.Settings.Default.WORKING_PATH);
            //    treeFiles.ExpandAll();
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPathElements();
        }

        private void treeFiles_DoubleClick(object sender, EventArgs e)
        {
            //string[] arr = treeFiles.SelectedNode.FullPath.Split('\\');
            //arr = arr.Skip(1).ToArray();
            //FileAttributes attr = File.GetAttributes($"{Properties.Settings.Default.WORKING_PATH}\\{ string.Join("\\", arr)}");
            //if (!attr.HasFlag(FileAttributes.Directory))
            //{
            //    VisualizeSubsForm vsf = new VisualizeSubsForm(treeFiles.SelectedNode.FullPath);
            //    vsf.Show();
            //}
            //else
            //    MessageBox.Show("That is a directory");
        }

        //public string PATH
        //{
        //    get { return treeFiles.SelectedNode.Text; }
        //}

        private void settingsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        private void chkSubFinder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAmass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRecon_Click(object sender, EventArgs e)
        {
            //if (chkAmass.Checked)
            //{
            //    MyUserControls.ToolTestingControl am = new MyUserControls.ToolTestingControl();
            //    am.ToolName = "amass";
            //    // amass enum -v -brute -min-for-recursive 2 -d tesla.com
            //    am.CommandTool = $"/c amass enum -v -brute -min-for-recursive 2 -d {txtDomain.Text}";
            //    flowLayoutPanel.Controls.Add(am);
            //}
            //if (chkSubFinder.Checked)
            //{
            //    MyUserControls.ToolTestingControl sub = new MyUserControls.ToolTestingControl();
            //    sub.ToolName = "subfinder";
            //    sub.CommandTool = $"/c subfinder -d {txtDomain.Text}";
            //    flowLayoutPanel.Controls.Add(sub);
            //}
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            //ListDirectory(treeFiles, Properties.Settings.Default.WORKING_PATH);
            //treeFiles.ExpandAll();
        }

    }
}
