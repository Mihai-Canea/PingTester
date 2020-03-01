﻿using System;
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

namespace PingTester
{
    public partial class Form1 : Form
    {
        const string resxFile = @".\Form1.resx"; // relative directory to the executable file
        const bool havePath = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPathElements();
        }

        private void loadPathElements()
        {
            using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
            {
                //MessageBox.Show(resxSet.GetString("WORKING_PATH"));
                string pathRes = resxSet.GetString("WORKING_PATH");
                if (pathRes == "NULL")
                    MessageBox.Show("Choose a working path");
                else
                {
                    treeFiles.Nodes.Clear();
                    foreach (var path in Directory.GetFiles(resxSet.GetString("WORKING_PATH")))
                    {
                        cmbFiles.Items.Add(Path.GetFileName(path));
                        treeFiles.Nodes.Add(Path.GetFileName(path));

                    }
                }

            }
        }

        private void cmbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void treeFiles_DoubleClick(object sender, EventArgs e)
        {
            pingTester.PATH = PATH;
        }

        public string PATH
        {
            get { return treeFiles.SelectedNode.Text; }
        }

        private void addPath_Click(object sender, EventArgs e)
        {
            //AddPathResource();
            using (var fbd = new FolderBrowserDialog())
            {
                ResXResourceWriter resxSet = new ResXResourceWriter(resxFile);
                //resxSet.GetString("WORKING_PATH");
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    resxSet.AddResource("WORKING_PATH", fbd.SelectedPath.ToString());
                    resxSet.Close();
                }
            }

            loadPathElements();
        }

    }
}