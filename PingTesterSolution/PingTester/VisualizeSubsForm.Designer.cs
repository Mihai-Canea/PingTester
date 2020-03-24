namespace PingTester
{
    partial class VisualizeSubsForm
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
            this.txtVisual = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLblPath = new System.Windows.Forms.ToolStripLabel();
            this.StripTxtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.ExportStripButton = new System.Windows.Forms.ToolStripButton();
            this.FilterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVisual
            // 
            this.txtVisual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisual.BackColor = System.Drawing.SystemColors.Control;
            this.txtVisual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisual.Location = new System.Drawing.Point(6, 28);
            this.txtVisual.Multiline = true;
            this.txtVisual.Name = "txtVisual";
            this.txtVisual.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVisual.Size = new System.Drawing.Size(623, 341);
            this.txtVisual.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLblPath,
            this.toolStripSeparator,
            this.ExportStripButton,
            this.toolStripSeparator1,
            this.FilterToolStripButton,
            this.StripTxtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(629, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLblPath
            // 
            this.ToolStripLblPath.Name = "ToolStripLblPath";
            this.ToolStripLblPath.Size = new System.Drawing.Size(43, 22);
            this.ToolStripLblPath.Text = "[PATH]";
            // 
            // StripTxtFilter
            // 
            this.StripTxtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StripTxtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StripTxtFilter.Name = "StripTxtFilter";
            this.StripTxtFilter.Size = new System.Drawing.Size(200, 25);
            // 
            // ExportStripButton
            // 
            this.ExportStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExportStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportStripButton.Image = global::PingTester.Properties.Resources.TransferDownload_16x;
            this.ExportStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportStripButton.Name = "ExportStripButton";
            this.ExportStripButton.Size = new System.Drawing.Size(23, 22);
            this.ExportStripButton.Text = "&Export";
            this.ExportStripButton.Click += new System.EventHandler(this.ExportStripButton_Click);
            // 
            // FilterToolStripButton
            // 
            this.FilterToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FilterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilterToolStripButton.Image = global::PingTester.Properties.Resources.Filter_16x;
            this.FilterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterToolStripButton.Name = "FilterToolStripButton";
            this.FilterToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FilterToolStripButton.Text = "&Filter";
            this.FilterToolStripButton.Click += new System.EventHandler(this.FilterToolStripButton_Click);
            // 
            // VisualizeSubsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 381);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtVisual);
            this.Name = "VisualizeSubsForm";
            this.ShowIcon = false;
            this.Text = "VisualizeSubsForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVisual;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton FilterToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExportStripButton;
        private System.Windows.Forms.ToolStripLabel ToolStripLblPath;
        private System.Windows.Forms.ToolStripTextBox StripTxtFilter;
    }
}