namespace PingTester.myForms
{
    partial class ReconTools
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
            this.btnSubfinder = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnAmass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubfinder
            // 
            this.btnSubfinder.Location = new System.Drawing.Point(12, 26);
            this.btnSubfinder.Name = "btnSubfinder";
            this.btnSubfinder.Size = new System.Drawing.Size(75, 23);
            this.btnSubfinder.TabIndex = 5;
            this.btnSubfinder.Text = "subfinder";
            this.btnSubfinder.UseVisualStyleBackColor = true;
            this.btnSubfinder.Click += new System.EventHandler(this.btnSubfinder_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDomain.Location = new System.Drawing.Point(0, 0);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(288, 20);
            this.txtDomain.TabIndex = 6;
            this.txtDomain.Text = "tesla.com";
            // 
            // btnAmass
            // 
            this.btnAmass.Location = new System.Drawing.Point(12, 55);
            this.btnAmass.Name = "btnAmass";
            this.btnAmass.Size = new System.Drawing.Size(75, 23);
            this.btnAmass.TabIndex = 7;
            this.btnAmass.Text = "Amass";
            this.btnAmass.UseVisualStyleBackColor = true;
            this.btnAmass.Click += new System.EventHandler(this.btnAmass_Click);
            // 
            // ReconTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 309);
            this.Controls.Add(this.btnAmass);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.btnSubfinder);
            this.Name = "ReconTools";
            this.ShowIcon = false;
            this.Text = "Tools";
            this.Load += new System.EventHandler(this.ReconTools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubfinder;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnAmass;
    }
}