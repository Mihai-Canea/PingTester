namespace PingTester
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSuccess = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupElements = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numPingTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblPinging = new System.Windows.Forms.Label();
            this.btnExportSuccess = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRecon = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAmass = new System.Windows.Forms.CheckBox();
            this.chkSubFinder = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.treeFiles = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccess)).BeginInit();
            this.groupElements.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeout)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSuccess
            // 
            this.dgvSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuccess.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSuccess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuccess.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuccess.Location = new System.Drawing.Point(3, 96);
            this.dgvSuccess.Name = "dgvSuccess";
            this.dgvSuccess.RowHeadersVisible = false;
            this.dgvSuccess.Size = new System.Drawing.Size(434, 227);
            this.dgvSuccess.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "URL";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Status";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupElements
            // 
            this.groupElements.Controls.Add(this.dgvSuccess);
            this.groupElements.Controls.Add(this.panel1);
            this.groupElements.Location = new System.Drawing.Point(0, 0);
            this.groupElements.Name = "groupElements";
            this.groupElements.Size = new System.Drawing.Size(440, 329);
            this.groupElements.TabIndex = 2;
            this.groupElements.TabStop = false;
            this.groupElements.Text = "Ping Tester";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numPingTimeout);
            this.panel1.Controls.Add(this.lblPinging);
            this.panel1.Controls.Add(this.btnExportSuccess);
            this.panel1.Controls.Add(this.lblPath);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 74);
            this.panel1.TabIndex = 1;
            // 
            // numPingTimeout
            // 
            this.numPingTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numPingTimeout.Location = new System.Drawing.Point(3, 17);
            this.numPingTimeout.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numPingTimeout.Name = "numPingTimeout";
            this.numPingTimeout.Size = new System.Drawing.Size(75, 20);
            this.numPingTimeout.TabIndex = 5;
            this.numPingTimeout.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lblPinging
            // 
            this.lblPinging.AutoSize = true;
            this.lblPinging.Location = new System.Drawing.Point(119, 48);
            this.lblPinging.Name = "lblPinging";
            this.lblPinging.Size = new System.Drawing.Size(25, 13);
            this.lblPinging.TabIndex = 4;
            this.lblPinging.Text = ">>>";
            // 
            // btnExportSuccess
            // 
            this.btnExportSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportSuccess.Location = new System.Drawing.Point(29, 43);
            this.btnExportSuccess.Name = "btnExportSuccess";
            this.btnExportSuccess.Size = new System.Drawing.Size(75, 23);
            this.btnExportSuccess.TabIndex = 3;
            this.btnExportSuccess.Text = "Export";
            this.btnExportSuccess.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(3, 1);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(3, 43);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(29, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "V";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnRecon
            // 
            this.btnRecon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecon.Location = new System.Drawing.Point(947, 12);
            this.btnRecon.Name = "btnRecon";
            this.btnRecon.Size = new System.Drawing.Size(100, 31);
            this.btnRecon.TabIndex = 10;
            this.btnRecon.Text = "Recon";
            this.btnRecon.UseVisualStyleBackColor = true;
            // 
            // txtDomain
            // 
            this.txtDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.Location = new System.Drawing.Point(712, 12);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(266, 31);
            this.txtDomain.TabIndex = 7;
            this.txtDomain.Text = "tesla.com";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(712, 59);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(534, 328);
            this.flowLayoutPanel.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.treeFiles);
            this.groupBox1.Location = new System.Drawing.Point(446, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 437);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(13, 371);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 7;
            this.btnFolder.Text = "Show";
            this.btnFolder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAmass);
            this.groupBox2.Controls.Add(this.chkSubFinder);
            this.groupBox2.Location = new System.Drawing.Point(0, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 66);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // chkAmass
            // 
            this.chkAmass.AutoSize = true;
            this.chkAmass.Location = new System.Drawing.Point(12, 42);
            this.chkAmass.Name = "chkAmass";
            this.chkAmass.Size = new System.Drawing.Size(57, 17);
            this.chkAmass.TabIndex = 1;
            this.chkAmass.Text = "Amass";
            this.chkAmass.UseVisualStyleBackColor = true;
            // 
            // chkSubFinder
            // 
            this.chkSubFinder.AutoSize = true;
            this.chkSubFinder.Location = new System.Drawing.Point(12, 19);
            this.chkSubFinder.Name = "chkSubFinder";
            this.chkSubFinder.Size = new System.Drawing.Size(69, 17);
            this.chkSubFinder.TabIndex = 0;
            this.chkSubFinder.Text = "subfinder";
            this.chkSubFinder.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(0, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // treeFiles
            // 
            this.treeFiles.BackColor = System.Drawing.SystemColors.Control;
            this.treeFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFiles.Location = new System.Drawing.Point(0, 48);
            this.treeFiles.Name = "treeFiles";
            this.treeFiles.Size = new System.Drawing.Size(254, 244);
            this.treeFiles.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 562);
            this.Controls.Add(this.btnRecon);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupElements);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccess)).EndInit();
            this.groupElements.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupElements;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numPingTimeout;
        private System.Windows.Forms.Label lblPinging;
        private System.Windows.Forms.Button btnExportSuccess;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRecon;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAmass;
        private System.Windows.Forms.CheckBox chkSubFinder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TreeView treeFiles;
    }
}