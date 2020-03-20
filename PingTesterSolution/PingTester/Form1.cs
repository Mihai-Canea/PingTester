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
            InitializeComponent();
        }

        TreeNode nodeSelect;

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPathElements();

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("httprobe", new EventHandler(httprobe_Click));
            cm.MenuItems.Add("Ping domains", new EventHandler(PingDomains_Click));
            cm.MenuItems.Add("-");
            cm.MenuItems.Add("Show in directory");
            cm.MenuItems.Add("Delete", new EventHandler(DeleteFile_Click));
            treeFiles.ContextMenu = cm;

            //treeFiles.ContextMenuStrip = cm;
            //MyUserControls.ToolTestingControl ht = new MyUserControls.ToolTestingControl();
            //ht.ToolName = "dirsearch";
            //ht.CommandTool = $"/c cd dirsearch | python dirsearch.py -u http://beta-msp.bitdefender.com -e -t";
            //flowLayoutPanel.Controls.Add(ht);

        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            string _fileDel = $"{Properties.Settings.Default.WORKING_PATH}\\{nodeSelect.Text}";
            if (File.Exists(_fileDel))
                File.Delete(_fileDel);
        }

        private void PingDomains_Click(object sender, EventArgs e)
        {
            pingTester.PATH = PATH;
        }

        private void httprobe_Click(object sender, EventArgs e)
        {
            var clickedMenuItem = sender as MenuItem;
            var menuText = clickedMenuItem.Text;
            MessageBox.Show(nodeSelect.Text + " " + menuText);

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
                ListDirectory(treeFiles, Properties.Settings.Default.WORKING_PATH);
                treeFiles.ExpandAll();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPathElements();
        }

        private void treeFiles_DoubleClick(object sender, EventArgs e)
        {
            string[] arr = treeFiles.SelectedNode.FullPath.Split('\\');
            arr = arr.Skip(1).ToArray();
            FileAttributes attr = File.GetAttributes($"{Properties.Settings.Default.WORKING_PATH}\\{ string.Join("\\", arr)}");
            if (!attr.HasFlag(FileAttributes.Directory))
            {
                VisualizeSubsForm vsf = new VisualizeSubsForm(treeFiles.SelectedNode.FullPath);
                vsf.Show();
            }
            else
                MessageBox.Show("That is a directory");
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

        }

        private void chkAmass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRecon_Click(object sender, EventArgs e)
        {
            if (chkAmass.Checked)
            {
                MyUserControls.ToolTestingControl am = new MyUserControls.ToolTestingControl();
                am.ToolName = "amass";
                // amass enum -v -brute -min-for-recursive 2 -d tesla.com
                am.CommandTool = $"/c amass enum -v -brute -min-for-recursive 2 -d {txtDomain.Text}";
                flowLayoutPanel.Controls.Add(am);
            }
            if (chkSubFinder.Checked)
            {
                MyUserControls.ToolTestingControl sub = new MyUserControls.ToolTestingControl();
                sub.ToolName = "subfinder";
                sub.CommandTool = $"/c subfinder -d {txtDomain.Text}";
                flowLayoutPanel.Controls.Add(sub);
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            ListDirectory(treeFiles, Properties.Settings.Default.WORKING_PATH);
            treeFiles.ExpandAll();
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }

            return directoryNode;
        }
    }
}
