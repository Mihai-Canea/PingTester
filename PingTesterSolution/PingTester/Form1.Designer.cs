namespace PingTester
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addPath = new System.Windows.Forms.Button();
            this.pingTester = new Recon.PingTester();
            this.treeFiles = new System.Windows.Forms.TreeView();
            this.cmbFiles = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addPath);
            this.groupBox1.Controls.Add(this.treeFiles);
            this.groupBox1.Controls.Add(this.cmbFiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 595);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // addPath
            // 
            this.addPath.Location = new System.Drawing.Point(7, 270);
            this.addPath.Name = "addPath";
            this.addPath.Size = new System.Drawing.Size(164, 23);
            this.addPath.TabIndex = 5;
            this.addPath.Text = "Add path";
            this.addPath.UseVisualStyleBackColor = true;
            this.addPath.Click += new System.EventHandler(this.addPath_Click);
            // 
            // pingTester
            // 
            this.pingTester.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pingTester.Location = new System.Drawing.Point(698, 0);
            this.pingTester.Name = "pingTester";
            this.pingTester.Size = new System.Drawing.Size(595, 583);
            this.pingTester.TabIndex = 2;
            // 
            // treeFiles
            // 
            this.treeFiles.Location = new System.Drawing.Point(0, 47);
            this.treeFiles.Name = "treeFiles";
            this.treeFiles.Size = new System.Drawing.Size(177, 216);
            this.treeFiles.TabIndex = 4;
            this.treeFiles.DoubleClick += new System.EventHandler(this.treeFiles_DoubleClick);
            // 
            // cmbFiles
            // 
            this.cmbFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiles.FormattingEnabled = true;
            this.cmbFiles.Location = new System.Drawing.Point(7, 20);
            this.cmbFiles.Name = "cmbFiles";
            this.cmbFiles.Size = new System.Drawing.Size(164, 21);
            this.cmbFiles.TabIndex = 0;
            this.cmbFiles.SelectedIndexChanged += new System.EventHandler(this.cmbFiles_SelectedIndexChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(183, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(509, 583);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 595);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pingTester);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ping tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeFiles;
        private System.Windows.Forms.ComboBox cmbFiles;
        private System.Windows.Forms.Button addPath;
        private Recon.PingTester pingTester;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label1;
    }
}

