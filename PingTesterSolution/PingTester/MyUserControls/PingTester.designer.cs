namespace Recon
{
    partial class PingTester
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupElements = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstUrls = new System.Windows.Forms.CheckedListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSuccess = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPinging = new System.Windows.Forms.Label();
            this.btnExportSuccess = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.pnlFilterText = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.numPingTimeout = new System.Windows.Forms.NumericUpDown();
            this.groupElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccess)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupFilter.SuspendLayout();
            this.pnlFilterText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // groupElements
            // 
            this.groupElements.Controls.Add(this.splitContainer1);
            this.groupElements.Controls.Add(this.panel1);
            this.groupElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupElements.Location = new System.Drawing.Point(0, 0);
            this.groupElements.Name = "groupElements";
            this.groupElements.Size = new System.Drawing.Size(688, 372);
            this.groupElements.TabIndex = 0;
            this.groupElements.TabStop = false;
            this.groupElements.Text = "Ping Tester";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 96);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstUrls);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(688, 276);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 2;
            // 
            // lstUrls
            // 
            this.lstUrls.BackColor = System.Drawing.SystemColors.Control;
            this.lstUrls.CheckOnClick = true;
            this.lstUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUrls.FormattingEnabled = true;
            this.lstUrls.Location = new System.Drawing.Point(0, 0);
            this.lstUrls.Name = "lstUrls";
            this.lstUrls.Size = new System.Drawing.Size(292, 276);
            this.lstUrls.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvResults);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvSuccess);
            this.splitContainer2.Panel2MinSize = 0;
            this.splitContainer2.Size = new System.Drawing.Size(392, 276);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 1;
            // 
            // dgvResults
            // 
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 0);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(392, 150);
            this.dgvResults.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "URL";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            // 
            // dgvSuccess
            // 
            this.dgvSuccess.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.dgvSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuccess.Location = new System.Drawing.Point(0, 0);
            this.dgvSuccess.Name = "dgvSuccess";
            this.dgvSuccess.RowHeadersVisible = false;
            this.dgvSuccess.Size = new System.Drawing.Size(392, 122);
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
            this.panel1.Controls.Add(this.groupFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 74);
            this.panel1.TabIndex = 1;
            // 
            // lblPinging
            // 
            this.lblPinging.AutoSize = true;
            this.lblPinging.Location = new System.Drawing.Point(140, 48);
            this.lblPinging.Name = "lblPinging";
            this.lblPinging.Size = new System.Drawing.Size(0, 13);
            this.lblPinging.TabIndex = 4;
            // 
            // btnExportSuccess
            // 
            this.btnExportSuccess.Location = new System.Drawing.Point(381, 43);
            this.btnExportSuccess.Name = "btnExportSuccess";
            this.btnExportSuccess.Size = new System.Drawing.Size(75, 23);
            this.btnExportSuccess.TabIndex = 3;
            this.btnExportSuccess.Text = "Export";
            this.btnExportSuccess.UseVisualStyleBackColor = true;
            this.btnExportSuccess.Visible = false;
            this.btnExportSuccess.Click += new System.EventHandler(this.btnExportSuccess_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(3, 16);
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
            this.btnCheck.Size = new System.Drawing.Size(119, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check URLs";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.pnlFilterText);
            this.groupFilter.Controls.Add(this.cmbFilters);
            this.groupFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupFilter.Location = new System.Drawing.Point(462, 0);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(220, 74);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter";
            // 
            // pnlFilterText
            // 
            this.pnlFilterText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterText.Controls.Add(this.txtFilter);
            this.pnlFilterText.Controls.Add(this.btnFilter);
            this.pnlFilterText.Location = new System.Drawing.Point(6, 36);
            this.pnlFilterText.Name = "pnlFilterText";
            this.pnlFilterText.Size = new System.Drawing.Size(177, 32);
            this.pnlFilterText.TabIndex = 3;
            this.pnlFilterText.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(0, 7);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(117, 20);
            this.txtFilter.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(123, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(54, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cmbFilters
            // 
            this.cmbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFilters.Items.AddRange(new object[] {
            "Text",
            "Success",
            "TimedOut"});
            this.cmbFilters.Location = new System.Drawing.Point(6, 16);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(177, 21);
            this.cmbFilters.TabIndex = 2;
            this.cmbFilters.SelectedIndexChanged += new System.EventHandler(this.cmbFilters_SelectedIndexChanged);
            // 
            // numPingTimeout
            // 
            this.numPingTimeout.Location = new System.Drawing.Point(128, 46);
            this.numPingTimeout.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numPingTimeout.Name = "numPingTimeout";
            this.numPingTimeout.Size = new System.Drawing.Size(63, 20);
            this.numPingTimeout.TabIndex = 5;
            this.numPingTimeout.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // PingTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupElements);
            this.Name = "PingTester";
            this.Size = new System.Drawing.Size(688, 372);
            this.Load += new System.EventHandler(this.PingTester_Load);
            this.groupElements.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupFilter.ResumeLayout(false);
            this.pnlFilterText.ResumeLayout(false);
            this.pnlFilterText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupElements;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Panel pnlFilterText;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox lstUrls;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnExportSuccess;
        private System.Windows.Forms.Label lblPinging;
        private System.Windows.Forms.NumericUpDown numPingTimeout;
    }
}
