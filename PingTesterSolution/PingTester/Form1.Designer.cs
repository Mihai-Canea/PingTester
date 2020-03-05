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
            this.treeFiles = new System.Windows.Forms.TreeView();
            this.cmbFiles = new System.Windows.Forms.ComboBox();
            this.pingTester = new Recon.PingTester();
            this.httprobeControl1 = new PingTester.MyUserControls.httprobeControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addPath);
            this.groupBox1.Controls.Add(this.treeFiles);
            this.groupBox1.Controls.Add(this.cmbFiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 415);
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
            // pingTester
            // 
            this.pingTester.Location = new System.Drawing.Point(183, 0);
            this.pingTester.Name = "pingTester";
            this.pingTester.Size = new System.Drawing.Size(409, 401);
            this.pingTester.TabIndex = 2;
            // 
            // httprobeControl1
            // 
            this.httprobeControl1.Location = new System.Drawing.Point(598, 0);
            this.httprobeControl1.Name = "httprobeControl1";
            this.httprobeControl1.Size = new System.Drawing.Size(462, 401);
            this.httprobeControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 415);
            this.Controls.Add(this.httprobeControl1);
            this.Controls.Add(this.pingTester);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ping tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeFiles;
        private System.Windows.Forms.ComboBox cmbFiles;
        private System.Windows.Forms.Button addPath;
        private Recon.PingTester pingTester;
        private MyUserControls.httprobeControl httprobeControl1;
    }
}

