namespace PingTester.MyUserControls
{
    partial class PingTesterControl
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupElements = new System.Windows.Forms.GroupBox();
            this.dgvSuccess = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numPingTimeout = new System.Windows.Forms.NumericUpDown();
            this.btnExportSuccess = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblPinging = new System.Windows.Forms.Label();
            this.groupElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccess)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // groupElements
            // 
            this.groupElements.Controls.Add(this.dgvSuccess);
            this.groupElements.Controls.Add(this.panel1);
            this.groupElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupElements.Location = new System.Drawing.Point(0, 0);
            this.groupElements.Name = "groupElements";
            this.groupElements.Size = new System.Drawing.Size(361, 307);
            this.groupElements.TabIndex = 1;
            this.groupElements.TabStop = false;
            this.groupElements.Text = "Ping Tester";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuccess.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuccess.Location = new System.Drawing.Point(3, 96);
            this.dgvSuccess.Name = "dgvSuccess";
            this.dgvSuccess.RowHeadersVisible = false;
            this.dgvSuccess.Size = new System.Drawing.Size(355, 205);
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
            this.panel1.Size = new System.Drawing.Size(355, 74);
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
            // btnExportSuccess
            // 
            this.btnExportSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportSuccess.Location = new System.Drawing.Point(29, 43);
            this.btnExportSuccess.Name = "btnExportSuccess";
            this.btnExportSuccess.Size = new System.Drawing.Size(75, 23);
            this.btnExportSuccess.TabIndex = 3;
            this.btnExportSuccess.Text = "Export";
            this.btnExportSuccess.UseVisualStyleBackColor = true;
            this.btnExportSuccess.Click += new System.EventHandler(this.btnExportSuccess_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(3, 1);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path";
            this.lblPath.TextChanged += new System.EventHandler(this.lblPath_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(3, 43);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(29, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "V";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
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
            // PingTesterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupElements);
            this.Name = "PingTesterControl";
            this.Size = new System.Drawing.Size(361, 307);
            this.Load += new System.EventHandler(this.PingTesterControl_Load);
            this.groupElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupElements;
        private System.Windows.Forms.DataGridView dgvSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numPingTimeout;
        private System.Windows.Forms.Button btnExportSuccess;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblPinging;
    }
}
