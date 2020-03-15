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

namespace PingTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TreeNode nodeSelect;

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPathElements();
            //MyUserControls.ToolTestingControl am = new MyUserControls.ToolTestingControl();
            //am.ToolName = "amass";
            //am.CommandTool = "/c amass enum -d tesla.com";
            //flowLayoutPanel.Controls.Add(am);

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("httprobe", new EventHandler(httprobe_Click));
            cm.MenuItems.Add("Ping domains", new EventHandler(PingDomains_Click));
            treeFiles.ContextMenu = cm;

            //treeFiles.ContextMenuStrip = cm;
        }

        private void PingDomains_Click(object sender, EventArgs e)
        {
            pingTester.PATH = PATH;
        }

        private void httprobe_Click(object sender, EventArgs e)
        {
            var clickedMenuItem = sender as MenuItem;
            var menuText = clickedMenuItem.Text;
            MessageBox.Show(nodeSelect.Text + " "+ menuText);

            MyUserControls.ToolTestingControl ht = new MyUserControls.ToolTestingControl();
            ht.ToolName = "httprobe";
            ht.CommandTool = $"/c cat {Properties.Settings.Default.WORKING_PATH}\\{nodeSelect.Text} | httprobe -p http:8080 -p https:8443";
            flowLayoutPanel.Controls.Add(ht);
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
            string pathRes = Properties.Settings.Default.WORKING_PATH;
            if (pathRes == "NULL")
            {
                MessageBox.Show("Choose a working path");
            }
            else
            {
                treeFiles.Nodes.Clear();
                foreach (var path in Directory.GetFiles(Properties.Settings.Default.WORKING_PATH))
                {
                    treeFiles.Nodes.Add(Path.GetFileName(path));
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPathElements();
        }

        private void treeFiles_DoubleClick(object sender, EventArgs e)
        {
            VisualizeSubsForm vsf = new VisualizeSubsForm(treeFiles.SelectedNode.Text);
            vsf.Show();
        }

        public string PATH
        {
            get { return treeFiles.SelectedNode.Text; }
        }

        private void settingsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        private void chkSubFinder_CheckedChanged(object sender, EventArgs e)
        {
            MyUserControls.ToolTestingControl sub = new MyUserControls.ToolTestingControl();
            sub.ToolName = "subfinder";
            sub.CommandTool = $"/c subfinder -d {txtDomain.Text}";
            flowLayoutPanel.Controls.Add(sub);
        }


    }
}
