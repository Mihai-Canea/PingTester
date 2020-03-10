namespace PingTester.MyUserControls
{
    partial class ToolTestingControl
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
            this.groupBoxTool = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.btnTestUrls = new System.Windows.Forms.Button();
            this.lstUrls = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBoxTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.Controls.Add(this.btnExport);
            this.groupBoxTool.Controls.Add(this.lstUrls);
            this.groupBoxTool.Controls.Add(this.btnStop);
            this.groupBoxTool.Controls.Add(this.txtFinish);
            this.groupBoxTool.Controls.Add(this.btnTestUrls);
            this.groupBoxTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTool.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTool.Name = "groupBoxTool";
            this.groupBoxTool.Size = new System.Drawing.Size(462, 270);
            this.groupBoxTool.TabIndex = 0;
            this.groupBoxTool.TabStop = false;
            this.groupBoxTool.Text = "httprobe";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(87, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(43, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtFinish
            // 
            this.txtFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinish.Enabled = false;
            this.txtFinish.Location = new System.Drawing.Point(322, 21);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.ReadOnly = true;
            this.txtFinish.Size = new System.Drawing.Size(134, 20);
            this.txtFinish.TabIndex = 2;
            // 
            // btnTestUrls
            // 
            this.btnTestUrls.Location = new System.Drawing.Point(6, 19);
            this.btnTestUrls.Name = "btnTestUrls";
            this.btnTestUrls.Size = new System.Drawing.Size(75, 23);
            this.btnTestUrls.TabIndex = 0;
            this.btnTestUrls.Text = "Test urls";
            this.btnTestUrls.UseVisualStyleBackColor = true;
            this.btnTestUrls.Click += new System.EventHandler(this.btnTestUrls_Click);
            // 
            // lstUrls
            // 
            this.lstUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUrls.FormattingEnabled = true;
            this.lstUrls.Location = new System.Drawing.Point(6, 48);
            this.lstUrls.Name = "lstUrls";
            this.lstUrls.Size = new System.Drawing.Size(450, 212);
            this.lstUrls.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(265, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(51, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ToolTestingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTool);
            this.Name = "ToolTestingControl";
            this.Size = new System.Drawing.Size(462, 270);
            this.groupBoxTool.ResumeLayout(false);
            this.groupBoxTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTool;
        private System.Windows.Forms.Button btnTestUrls;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lstUrls;
        private System.Windows.Forms.Button btnExport;
    }
}
