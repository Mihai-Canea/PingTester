namespace PingTester
{
    partial class SettingsForm
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
            this.lblWorkingPath = new System.Windows.Forms.Label();
            this.txtWorkingPath = new System.Windows.Forms.TextBox();
            this.btnWorkingPath = new System.Windows.Forms.Button();
            this.btnToolPath = new System.Windows.Forms.Button();
            this.txtToolPath = new System.Windows.Forms.TextBox();
            this.lblToolPath = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWorkingPath
            // 
            this.lblWorkingPath.AutoSize = true;
            this.lblWorkingPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingPath.Location = new System.Drawing.Point(12, 9);
            this.lblWorkingPath.Name = "lblWorkingPath";
            this.lblWorkingPath.Size = new System.Drawing.Size(76, 13);
            this.lblWorkingPath.TabIndex = 1;
            this.lblWorkingPath.Text = "Working folder";
            // 
            // txtWorkingPath
            // 
            this.txtWorkingPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkingPath.Location = new System.Drawing.Point(97, 6);
            this.txtWorkingPath.Name = "txtWorkingPath";
            this.txtWorkingPath.ReadOnly = true;
            this.txtWorkingPath.Size = new System.Drawing.Size(334, 20);
            this.txtWorkingPath.TabIndex = 2;
            // 
            // btnWorkingPath
            // 
            this.btnWorkingPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkingPath.Location = new System.Drawing.Point(437, 6);
            this.btnWorkingPath.Name = "btnWorkingPath";
            this.btnWorkingPath.Size = new System.Drawing.Size(34, 20);
            this.btnWorkingPath.TabIndex = 3;
            this.btnWorkingPath.Text = "...";
            this.btnWorkingPath.UseVisualStyleBackColor = true;
            this.btnWorkingPath.Click += new System.EventHandler(this.btnWorkingPath_Click);
            // 
            // btnToolPath
            // 
            this.btnToolPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolPath.Location = new System.Drawing.Point(437, 35);
            this.btnToolPath.Name = "btnToolPath";
            this.btnToolPath.Size = new System.Drawing.Size(34, 20);
            this.btnToolPath.TabIndex = 6;
            this.btnToolPath.Text = "...";
            this.btnToolPath.UseVisualStyleBackColor = true;
            this.btnToolPath.Click += new System.EventHandler(this.btnToolPath_Click);
            // 
            // txtToolPath
            // 
            this.txtToolPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolPath.Location = new System.Drawing.Point(97, 35);
            this.txtToolPath.Name = "txtToolPath";
            this.txtToolPath.ReadOnly = true;
            this.txtToolPath.Size = new System.Drawing.Size(334, 20);
            this.txtToolPath.TabIndex = 5;
            // 
            // lblToolPath
            // 
            this.lblToolPath.AutoSize = true;
            this.lblToolPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolPath.Location = new System.Drawing.Point(12, 38);
            this.lblToolPath.Name = "lblToolPath";
            this.lblToolPath.Size = new System.Drawing.Size(62, 13);
            this.lblToolPath.TabIndex = 4;
            this.lblToolPath.Text = "Tools folder";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 66);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset all";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 98);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnToolPath);
            this.Controls.Add(this.txtToolPath);
            this.Controls.Add(this.lblToolPath);
            this.Controls.Add(this.btnWorkingPath);
            this.Controls.Add(this.txtWorkingPath);
            this.Controls.Add(this.lblWorkingPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWorkingPath;
        private System.Windows.Forms.TextBox txtWorkingPath;
        private System.Windows.Forms.Button btnWorkingPath;
        private System.Windows.Forms.Button btnToolPath;
        private System.Windows.Forms.TextBox txtToolPath;
        private System.Windows.Forms.Label lblToolPath;
        private System.Windows.Forms.Button btnReset;
    }
}