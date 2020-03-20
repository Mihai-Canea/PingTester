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
            this.SuspendLayout();
            // 
            // chkAmass
            // 
            this.chkAmass.AutoSize = true;
            this.chkAmass.Location = new System.Drawing.Point(12, 35);
            this.chkAmass.Name = "chkAmass";
            this.chkAmass.Size = new System.Drawing.Size(57, 17);
            this.chkAmass.TabIndex = 1;
            this.chkAmass.Text = "Amass";
            this.chkAmass.UseVisualStyleBackColor = true;
            // 
            // chkSubFinder
            // 
            this.chkSubFinder.AutoSize = true;
            this.chkSubFinder.Location = new System.Drawing.Point(12, 12);
            this.chkSubFinder.Name = "chkSubFinder";
            this.chkSubFinder.Size = new System.Drawing.Size(69, 17);
            this.chkSubFinder.TabIndex = 0;
            this.chkSubFinder.Text = "subfinder";
            this.chkSubFinder.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Sublist3r";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ReconTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 309);
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
    }
}