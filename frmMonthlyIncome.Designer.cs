namespace BudgetingApp
{
    partial class frmMonthlyIncome
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
            this.txbMonthlyIncome = new System.Windows.Forms.TextBox();
            this.btnFormClose = new System.Windows.Forms.Button();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblMonthlyIncome = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.btnSubmitIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbMonthlyIncome
            // 
            this.txbMonthlyIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbMonthlyIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMonthlyIncome.ForeColor = System.Drawing.Color.Gold;
            this.txbMonthlyIncome.Location = new System.Drawing.Point(62, 110);
            this.txbMonthlyIncome.Name = "txbMonthlyIncome";
            this.txbMonthlyIncome.Size = new System.Drawing.Size(261, 27);
            this.txbMonthlyIncome.TabIndex = 1;
            this.txbMonthlyIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMonthlyIncome_KeyPress);
            // 
            // btnFormClose
            // 
            this.btnFormClose.FlatAppearance.BorderSize = 0;
            this.btnFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormClose.ForeColor = System.Drawing.Color.White;
            this.btnFormClose.Location = new System.Drawing.Point(522, 12);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Size = new System.Drawing.Size(25, 25);
            this.btnFormClose.TabIndex = 42;
            this.btnFormClose.Text = "X";
            this.btnFormClose.UseVisualStyleBackColor = true;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.ForeColor = System.Drawing.Color.Aqua;
            this.txbUsername.Location = new System.Drawing.Point(62, 194);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(163, 27);
            this.txbUsername.TabIndex = 44;
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblMonthlyIncome.Location = new System.Drawing.Point(57, 82);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(364, 25);
            this.lblMonthlyIncome.TabIndex = 45;
            this.lblMonthlyIncome.Text = "Please enter your gross monthly income:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblWelcome.Location = new System.Drawing.Point(22, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(203, 39);
            this.lblWelcome.TabIndex = 46;
            this.lblWelcome.Text = "Welcome...";
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblEnterName.Location = new System.Drawing.Point(57, 166);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(216, 25);
            this.lblEnterName.TabIndex = 47;
            this.lblEnterName.Text = "What shall we call you?";
            // 
            // btnSubmitIncome
            // 
            this.btnSubmitIncome.FlatAppearance.BorderSize = 0;
            this.btnSubmitIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSubmitIncome.Image = global::BudgetingApp.Properties.Resources.income;
            this.btnSubmitIncome.Location = new System.Drawing.Point(344, 180);
            this.btnSubmitIncome.Name = "btnSubmitIncome";
            this.btnSubmitIncome.Size = new System.Drawing.Size(186, 49);
            this.btnSubmitIncome.TabIndex = 2;
            this.btnSubmitIncome.Text = "Proceed";
            this.btnSubmitIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubmitIncome.UseVisualStyleBackColor = true;
            this.btnSubmitIncome.Click += new System.EventHandler(this.btnSubmitIncome_Click);
            // 
            // frmMonthlyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(559, 267);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblMonthlyIncome);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.btnFormClose);
            this.Controls.Add(this.btnSubmitIncome);
            this.Controls.Add(this.txbMonthlyIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMonthlyIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Gross Monthly Income";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbMonthlyIncome;
        private System.Windows.Forms.Button btnSubmitIncome;
        private System.Windows.Forms.Button btnFormClose;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblMonthlyIncome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEnterName;
    }
}