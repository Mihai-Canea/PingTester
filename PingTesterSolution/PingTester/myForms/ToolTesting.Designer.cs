namespace PingTester.myForms
{
    partial class ToolTesting
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
            this.lstUrls = new System.Windows.Forms.ListBox();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StartToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StatusTxtBox = new System.Windows.Forms.ToolStripTextBox();
            this.DownloadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUrls
            // 
            this.lstUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUrls.BackColor = System.Drawing.SystemColors.Control;
            this.lstUrls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUrls.FormattingEnabled = true;
            this.lstUrls.Location = new System.Drawing.Point(12, 29);
            this.lstUrls.Name = "lstUrls";
            this.lstUrls.Size = new System.Drawing.Size(480, 247);
            this.lstUrls.TabIndex = 9;
            // 
            // txtFinish
            // 
            this.txtFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinish.Enabled = false;
            this.txtFinish.Location = new System.Drawing.Point(346, 55);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.ReadOnly = true;
            this.txtFinish.Size = new System.Drawing.Size(134, 20);
            this.txtFinish.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripButton,
            this.StopToolStripButton,
            this.toolStripSeparator1,
            this.StatusTxtBox,
            this.DownloadButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StartToolStripButton
            // 
            this.StartToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartToolStripButton.Image = global::PingTester.Properties.Resources.StartWithoutDebug_16x;
            this.StartToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartToolStripButton.Name = "StartToolStripButton";
            this.StartToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.StartToolStripButton.Text = "&Start";
            this.StartToolStripButton.Click += new System.EventHandler(this.StartToolStripButton_Click);
            // 
            // StopToolStripButton
            // 
            this.StopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopToolStripButton.Image = global::PingTester.Properties.Resources.Stop_16x;
            this.StopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopToolStripButton.Name = "StopToolStripButton";
            this.StopToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.StopToolStripButton.Text = "&Stop";
            this.StopToolStripButton.Click += new System.EventHandler(this.StopToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // StatusTxtBox
            // 
            this.StatusTxtBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StatusTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.StatusTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusTxtBox.Enabled = false;
            this.StatusTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StatusTxtBox.Name = "StatusTxtBox";
            this.StatusTxtBox.ReadOnly = true;
            this.StatusTxtBox.Size = new System.Drawing.Size(100, 25);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DownloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DownloadButton.Image = global::PingTester.Properties.Resources.TransferDownload_16x;
            this.DownloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(23, 22);
            this.DownloadButton.Text = "&Export";
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // ToolTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 280);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lstUrls);
            this.Controls.Add(this.txtFinish);
            this.Name = "ToolTesting";
            this.ShowIcon = false;
            this.Text = "ToolTesting";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstUrls;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StartToolStripButton;
        private System.Windows.Forms.ToolStripButton StopToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DownloadButton;
        private System.Windows.Forms.ToolStripTextBox StatusTxtBox;
    }
}