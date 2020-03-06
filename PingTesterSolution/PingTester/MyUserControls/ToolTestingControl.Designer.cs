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
            this.txtUrls = new System.Windows.Forms.TextBox();
            this.btnTestUrls = new System.Windows.Forms.Button();
            this.groupBoxTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.Controls.Add(this.btnStop);
            this.groupBoxTool.Controls.Add(this.txtFinish);
            this.groupBoxTool.Controls.Add(this.txtUrls);
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
            this.txtFinish.Location = new System.Drawing.Point(322, 19);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.ReadOnly = true;
            this.txtFinish.Size = new System.Drawing.Size(134, 20);
            this.txtFinish.TabIndex = 2;
            // 
            // txtUrls
            // 
            this.txtUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrls.Location = new System.Drawing.Point(6, 48);
            this.txtUrls.Multiline = true;
            this.txtUrls.Name = "txtUrls";
            this.txtUrls.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUrls.Size = new System.Drawing.Size(450, 216);
            this.txtUrls.TabIndex = 1;
            // 
            // btnTestUrls
            // 
            this.btnTestUrls.Location = new System.Drawing.Point(6, 19);
            this.btnTestUrls.Name = "btnTestUrls";
            this.btnTestUrls.Size = new System.Drawing.Size(75, 23);
            this.btnTestUrls.TabIndex = 0;
            this.btnTestUrls.Text = "Test ulrs";
            this.btnTestUrls.UseVisualStyleBackColor = true;
            this.btnTestUrls.Click += new System.EventHandler(this.btnTestUrls_Click);
            // 
            // httprobeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTool);
            this.Name = "httprobeControl";
            this.Size = new System.Drawing.Size(462, 270);
            this.groupBoxTool.ResumeLayout(false);
            this.groupBoxTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTool;
        private System.Windows.Forms.TextBox txtUrls;
        private System.Windows.Forms.Button btnTestUrls;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.Button btnStop;
    }
}
