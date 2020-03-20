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

namespace PingTester.myForms
{
    public partial class FileExplorer : DockContent
    {

        TreeNode nodeSelect;
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void FileExplorer_Load(object sender, EventArgs e)
        {
            string pathRes = Properties.Settings.Default.WORKING_PATH;
            if (pathRes == "NULL")
            {
                MessageBox.Show("Choose a working path");
            }
            else
            {
                ListDirectory(treeView, Properties.Settings.Default.WORKING_PATH);
                treeView.ExpandAll();
            }

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("httprobe", new EventHandler(httprobe_Click));
            cm.MenuItems.Add("Ping domains", new EventHandler(PingDomains_Click));
            cm.MenuItems.Add("-");
            cm.MenuItems.Add("Show in directory");
            cm.MenuItems.Add("Delete", new EventHandler(DeleteFile_Click));
            treeView.ContextMenu = cm;
        }

        private void httprobe_Click(object sender, EventArgs e)
        {
            var clickedMenuItem = sender as MenuItem;
            var menuText = clickedMenuItem.Text;
            MessageBox.Show(nodeSelect.Text + " " + menuText);

            MyUserControls.ToolTestingControl ht = new MyUserControls.ToolTestingControl();
            ht.ToolName = "httprobe";
            ht.CommandTool = $"/c cat {Properties.Settings.Default.WORKING_PATH}\\{nodeSelect.Text} | httprobe -p http:8080 -p https:8443";
            //flowLayoutPanel.Controls.Add(ht);
        }

        private void PingDomains_Click(object sender, EventArgs e)
        {
            //pingTester.PATH = PATH;
        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            string _fileDel = $"{Properties.Settings.Default.WORKING_PATH}\\{nodeSelect.Text}";
            if (File.Exists(_fileDel))
                File.Delete(_fileDel);
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                nodeSelect = e.Node;
            }
        }

        public string PATH
        {
            get { return treeView.SelectedNode.Text; }
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

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            string[] arr = treeView.SelectedNode.FullPath.Split('\\');
            arr = arr.Skip(1).ToArray();
            FileAttributes attr = File.GetAttributes($"{Properties.Settings.Default.WORKING_PATH}\\{ string.Join("\\", arr)}");
            if (!attr.HasFlag(FileAttributes.Directory))
            {
                VisualizeSubsForm vsf = new VisualizeSubsForm(treeView.SelectedNode.FullPath);
                vsf.Show();
            }
            else
                MessageBox.Show("That is a directory");
        }

    }
}
