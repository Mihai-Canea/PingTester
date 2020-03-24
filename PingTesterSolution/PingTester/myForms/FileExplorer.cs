using PingTester.Properties;
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
        DockPanel dockPanel;
        public FileExplorer(DockPanel dock)
        {
            InitializeComponent();
            dockPanel = dock;
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

            ImageList list = new ImageList();
            Image img = Resources.FolderClosed_grey_16x ;
            list.Images.Add(img);
            img = Resources.TextFile_16x;
            list.Images.Add(img);
            treeView.ImageList = list;
            foreach (TreeNode node in this.treeView.Nodes)
            {
                SetIconForNode(node, 1);
            }

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("httprobe", new EventHandler(httprobe_Click));
            cm.MenuItems.Add("Ping domains", new EventHandler(PingDomains_Click));
            cm.MenuItems.Add("-");
            cm.MenuItems.Add("Show in directory");
            cm.MenuItems.Add("Delete", new EventHandler(DeleteFile_Click));
            treeView.ContextMenu = cm;
        }

        void SetIconForNode(TreeNode node, int imageindex)
        {
            node.ImageIndex = imageindex;
            node.SelectedImageIndex = imageindex;
            if (node.Nodes.Count != 0)
            {
                foreach (TreeNode tn in node.Nodes)
                {
                    string[] arr = tn.FullPath.Split('\\');
                    arr = arr.Skip(1).ToArray();
                    FileAttributes attr = File.GetAttributes($"{Properties.Settings.Default.WORKING_PATH}\\{ string.Join("\\", arr)}");
                    if (!attr.HasFlag(FileAttributes.Directory))
                        SetIconForNode(tn, 1);
                    else
                        SetIconForNode(tn, 0);
                }
            }

        }

        private void httprobe_Click(object sender, EventArgs e)
        {
            var clickedMenuItem = sender as MenuItem;
            var menuText = clickedMenuItem.Text;
            //MessageBox.Show(nodeSelect.Text + " " + menuText);

            string[] arr = nodeSelect.FullPath.Split('\\');
            arr = arr.Skip(1).ToArray();
            //FileAttributes attr = File.GetAttributes($"{Properties.Settings.Default.WORKING_PATH}\\{ string.Join("\\", arr)}");

            //MyUserControls.ToolTestingControl ht = new MyUserControls.ToolTestingControl();
            myForms.ToolTesting ht = new ToolTesting();
            ht.ToolName = "httprobe";
            ht.CommandTool = $"/c cat {Properties.Settings.Default.WORKING_PATH}\\{ string.Join("\\", arr)} | httprobe -p http:8080 -p https:8443";
            ht.Show(dockPanel, DockState.Document);
            //flowLayoutPanel.Controls.Add(ht);

        }

        private void PingDomains_Click(object sender, EventArgs e)
        {
            //pingTester.PATH = PATH;
            string[] arr = nodeSelect.FullPath.Split('\\');
            arr = arr.Skip(1).ToArray();
            myForms.PingTester pt = new PingTester($"{ string.Join("\\", arr)}");
            pt.Show(dockPanel, DockState.Document);
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

        public string TheValue
        {
            get { return "visualize"; }
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            string[] arr = treeView.SelectedNode.FullPath.Split('\\');
            arr = arr.Skip(1).ToArray();
            FileAttributes attr = File.GetAttributes($"{Properties.Settings.Default.WORKING_PATH}\\{ string.Join("\\", arr)}");
            if (!attr.HasFlag(FileAttributes.Directory))
            {
                VisualizeSubsForm vsf = new VisualizeSubsForm(treeView.SelectedNode.FullPath);
                vsf.Show(dockPanel,DockState.Document);
            }
            //else
            //    MessageBox.Show("That is a directory");
        }

    }
}
