namespace BudgetingApp
{
    partial class frmSettings
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
            this.lblSettingsHeader = new System.Windows.Forms.Label();
            this.btnCloseAppFormPnl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSettingsHeader
            // 
            this.lblSettingsHeader.AutoSize = true;
            this.lblSettingsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblSettingsHeader.Location = new System.Drawing.Point(27, 26);
            this.lblSettingsHeader.Name = "lblSettingsHeader";
            this.lblSettingsHeader.Size = new System.Drawing.Size(270, 39);
            this.lblSettingsHeader.TabIndex = 58;
            this.lblSettingsHeader.Text = "Coming Soon...";
            // 
            // btnCloseAppFormPnl
            // 
            this.btnCloseAppFormPnl.FlatAppearance.BorderSize = 0;
            this.btnCloseAppFormPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAppFormPnl.ForeColor = System.Drawing.Color.White;
            this.btnCloseAppFormPnl.Location = new System.Drawing.Point(722, 12);
            this.btnCloseAppFormPnl.Name = "btnCloseAppFormPnl";
            this.btnCloseAppFormPnl.Size = new System.Drawing.Size(25, 25);
            this.btnCloseAppFormPnl.TabIndex = 59;
            this.btnCloseAppFormPnl.Text = "X";
            this.btnCloseAppFormPnl.UseVisualStyleBackColor = true;
            this.btnCloseAppFormPnl.Click += new System.EventHandler(this.btnCloseAppFormPnl_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(759, 574);
            this.Controls.Add(this.btnCloseAppFormPnl);
            this.Controls.Add(this.lblSettingsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettingsHeader;
        private System.Windows.Forms.Button btnCloseAppFormPnl;
    }
}