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
            this.chkAmass = new System.Windows.Forms.CheckBox();
            this.chkSubFinder = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnSubfinder = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnAmass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAmass
            // 
            this.chkAmass.AutoSize = true;
            this.chkAmass.Location = new System.Drawing.Point(12, 53);
            this.chkAmass.Name = "chkAmass";
            this.chkAmass.Size = new System.Drawing.Size(57, 17);
            this.chkAmass.TabIndex = 1;
            this.chkAmass.Text = "Amass";
            this.chkAmass.UseVisualStyleBackColor = true;
            // 
            // chkSubFinder
            // 
            this.chkSubFinder.AutoSize = true;
            this.chkSubFinder.Location = new System.Drawing.Point(12, 30);
            this.chkSubFinder.Name = "chkSubFinder";
            this.chkSubFinder.Size = new System.Drawing.Size(69, 17);
            this.chkSubFinder.TabIndex = 0;
            this.chkSubFinder.Text = "subfinder";
            this.chkSubFinder.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Sublist3r";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 99);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "httprobe";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 122);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(69, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "dirsearch";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnSubfinder
            // 
            this.btnSubfinder.Location = new System.Drawing.Point(13, 146);
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
            this.btnAmass.Location = new System.Drawing.Point(13, 175);
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
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chkAmass);
            this.Controls.Add(this.chkSubFinder);
            this.Name = "ReconTools";
            this.ShowIcon = false;
            this.Text = "Tools";
            this.Load += new System.EventHandler(this.ReconTools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAmass;
        private System.Windows.Forms.CheckBox chkSubFinder;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btnSubfinder;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnAmass;
    }
}