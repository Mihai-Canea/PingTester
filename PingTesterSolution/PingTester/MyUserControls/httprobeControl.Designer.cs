namespace PingTester.MyUserControls
{
    partial class httprobeControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestUrls = new System.Windows.Forms.Button();
            this.txtUrls = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrls);
            this.groupBox1.Controls.Add(this.btnTestUrls);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "httprobe";
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
            // httprobeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "httprobeControl";
            this.Size = new System.Drawing.Size(462, 270);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrls;
        private System.Windows.Forms.Button btnTestUrls;
    }
}
