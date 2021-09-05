namespace BudgetingApp
{
    partial class frmVehicle
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
            this.txbModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblInsurancePremium = new System.Windows.Forms.Label();
            this.lblVehicleTotalDeposit = new System.Windows.Forms.Label();
            this.lblVehicleInterestRate = new System.Windows.Forms.Label();
            this.lblVehiclePurchasePrice = new System.Windows.Forms.Label();
            this.txbPurchasePrice = new System.Windows.Forms.TextBox();
            this.txbTotalDeposit = new System.Windows.Forms.TextBox();
            this.txbInterestRate = new System.Windows.Forms.TextBox();
            this.txbInsurance = new System.Windows.Forms.TextBox();
            this.btnCalculateMonthlyCost = new System.Windows.Forms.Button();
            this.txbMake = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txbMerchant = new System.Windows.Forms.TextBox();
            this.lblMerchant = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCloseAppFormPnl = new System.Windows.Forms.Button();
            this.lblVehicleHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbModel
            // 
            this.txbModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModel.ForeColor = System.Drawing.Color.Turquoise;
            this.txbModel.Location = new System.Drawing.Point(388, 84);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(238, 27);
            this.txbModel.TabIndex = 44;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblModel.Location = new System.Drawing.Point(70, 82);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(72, 25);
            this.lblModel.TabIndex = 43;
            this.lblModel.Text = "Model:";
            // 
            // lblInsurancePremium
            // 
            this.lblInsurancePremium.AutoSize = true;
            this.lblInsurancePremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsurancePremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblInsurancePremium.Location = new System.Drawing.Point(70, 425);
            this.lblInsurancePremium.Name = "lblInsurancePremium";
            this.lblInsurancePremium.Size = new System.Drawing.Size(274, 25);
            this.lblInsurancePremium.TabIndex = 38;
            this.lblInsurancePremium.Text = "Estimated insurance premium:";
            // 
            // lblVehicleTotalDeposit
            // 
            this.lblVehicleTotalDeposit.AutoSize = true;
            this.lblVehicleTotalDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleTotalDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblVehicleTotalDeposit.Location = new System.Drawing.Point(70, 327);
            this.lblVehicleTotalDeposit.Name = "lblVehicleTotalDeposit";
            this.lblVehicleTotalDeposit.Size = new System.Drawing.Size(130, 25);
            this.lblVehicleTotalDeposit.TabIndex = 37;
            this.lblVehicleTotalDeposit.Text = "Total deposit:";
            // 
            // lblVehicleInterestRate
            // 
            this.lblVehicleInterestRate.AutoSize = true;
            this.lblVehicleInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleInterestRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblVehicleInterestRate.Location = new System.Drawing.Point(70, 376);
            this.lblVehicleInterestRate.Name = "lblVehicleInterestRate";
            this.lblVehicleInterestRate.Size = new System.Drawing.Size(237, 25);
            this.lblVehicleInterestRate.TabIndex = 36;
            this.lblVehicleInterestRate.Text = "Interest rate (percentage):";
            // 
            // lblVehiclePurchasePrice
            // 
            this.lblVehiclePurchasePrice.AutoSize = true;
            this.lblVehiclePurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiclePurchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblVehiclePurchasePrice.Location = new System.Drawing.Point(70, 278);
            this.lblVehiclePurchasePrice.Name = "lblVehiclePurchasePrice";
            this.lblVehiclePurchasePrice.Size = new System.Drawing.Size(235, 25);
            this.lblVehiclePurchasePrice.TabIndex = 35;
            this.lblVehiclePurchasePrice.Text = "Purchase price of vehicle:";
            // 
            // txbPurchasePrice
            // 
            this.txbPurchasePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbPurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPurchasePrice.ForeColor = System.Drawing.Color.Turquoise;
            this.txbPurchasePrice.Location = new System.Drawing.Point(388, 280);
            this.txbPurchasePrice.Name = "txbPurchasePrice";
            this.txbPurchasePrice.Size = new System.Drawing.Size(238, 27);
            this.txbPurchasePrice.TabIndex = 45;
            this.txbPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPurchasePrice_KeyPress);
            // 
            // txbTotalDeposit
            // 
            this.txbTotalDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbTotalDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTotalDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalDeposit.ForeColor = System.Drawing.Color.Turquoise;
            this.txbTotalDeposit.Location = new System.Drawing.Point(388, 329);
            this.txbTotalDeposit.Name = "txbTotalDeposit";
            this.txbTotalDeposit.Size = new System.Drawing.Size(238, 27);
            this.txbTotalDeposit.TabIndex = 46;
            this.txbTotalDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTotalDeposit_KeyPress);
            // 
            // txbInterestRate
            // 
            this.txbInterestRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInterestRate.ForeColor = System.Drawing.Color.Turquoise;
            this.txbInterestRate.Location = new System.Drawing.Point(388, 378);
            this.txbInterestRate.Name = "txbInterestRate";
            this.txbInterestRate.Size = new System.Drawing.Size(238, 27);
            this.txbInterestRate.TabIndex = 47;
            this.txbInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInterestRate_KeyPress);
            // 
            // txbInsurance
            // 
            this.txbInsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInsurance.ForeColor = System.Drawing.Color.Turquoise;
            this.txbInsurance.Location = new System.Drawing.Point(388, 427);
            this.txbInsurance.Name = "txbInsurance";
            this.txbInsurance.Size = new System.Drawing.Size(238, 27);
            this.txbInsurance.TabIndex = 48;
            this.txbInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInsurance_KeyPress);
            // 
            // btnCalculateMonthlyCost
            // 
            this.btnCalculateMonthlyCost.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCalculateMonthlyCost.FlatAppearance.BorderSize = 2;
            this.btnCalculateMonthlyCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateMonthlyCost.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateMonthlyCost.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnCalculateMonthlyCost.Image = global::BudgetingApp.Properties.Resources.car_2_;
            this.btnCalculateMonthlyCost.Location = new System.Drawing.Point(467, 490);
            this.btnCalculateMonthlyCost.Name = "btnCalculateMonthlyCost";
            this.btnCalculateMonthlyCost.Size = new System.Drawing.Size(265, 54);
            this.btnCalculateMonthlyCost.TabIndex = 49;
            this.btnCalculateMonthlyCost.Text = "Calculate Monthly Cost";
            this.btnCalculateMonthlyCost.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalculateMonthlyCost.UseVisualStyleBackColor = true;
            this.btnCalculateMonthlyCost.Click += new System.EventHandler(this.btnCalculateMonthlyCost_Click);
            // 
            // txbMake
            // 
            this.txbMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMake.ForeColor = System.Drawing.Color.Turquoise;
            this.txbMake.Location = new System.Drawing.Point(388, 133);
            this.txbMake.Name = "txbMake";
            this.txbMake.Size = new System.Drawing.Size(238, 27);
            this.txbMake.TabIndex = 50;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblMake.Location = new System.Drawing.Point(70, 131);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(67, 25);
            this.lblMake.TabIndex = 51;
            this.lblMake.Text = "Make:";
            // 
            // txbMerchant
            // 
            this.txbMerchant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbMerchant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMerchant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMerchant.ForeColor = System.Drawing.Color.Turquoise;
            this.txbMerchant.Location = new System.Drawing.Point(388, 182);
            this.txbMerchant.Name = "txbMerchant";
            this.txbMerchant.Size = new System.Drawing.Size(238, 27);
            this.txbMerchant.TabIndex = 52;
            // 
            // lblMerchant
            // 
            this.lblMerchant.AutoSize = true;
            this.lblMerchant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblMerchant.Location = new System.Drawing.Point(70, 180);
            this.lblMerchant.Name = "lblMerchant";
            this.lblMerchant.Size = new System.Drawing.Size(100, 25);
            this.lblMerchant.TabIndex = 53;
            this.lblMerchant.Text = "Merchant:";
            // 
            // txbDescription
            // 
            this.txbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescription.ForeColor = System.Drawing.Color.Turquoise;
            this.txbDescription.Location = new System.Drawing.Point(388, 231);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(238, 27);
            this.txbDescription.TabIndex = 54;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblDescription.Location = new System.Drawing.Point(70, 229);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 25);
            this.lblDescription.TabIndex = 55;
            this.lblDescription.Text = "Description:";
            // 
            // btnCloseAppFormPnl
            // 
            this.btnCloseAppFormPnl.FlatAppearance.BorderSize = 0;
            this.btnCloseAppFormPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAppFormPnl.ForeColor = System.Drawing.Color.White;
            this.btnCloseAppFormPnl.Location = new System.Drawing.Point(722, 12);
            this.btnCloseAppFormPnl.Name = "btnCloseAppFormPnl";
            this.btnCloseAppFormPnl.Size = new System.Drawing.Size(25, 25);
            this.btnCloseAppFormPnl.TabIndex = 56;
            this.btnCloseAppFormPnl.Text = "X";
            this.btnCloseAppFormPnl.UseVisualStyleBackColor = true;
            this.btnCloseAppFormPnl.Click += new System.EventHandler(this.btnCloseAppFormPnl_Click);
            // 
            // lblVehicleHeader
            // 
            this.lblVehicleHeader.AutoSize = true;
            this.lblVehicleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblVehicleHeader.Location = new System.Drawing.Point(25, 24);
            this.lblVehicleHeader.Name = "lblVehicleHeader";
            this.lblVehicleHeader.Size = new System.Drawing.Size(290, 39);
            this.lblVehicleHeader.TabIndex = 57;
            this.lblVehicleHeader.Text = "Vehicle Expense";
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(759, 574);
            this.Controls.Add(this.lblVehicleHeader);
            this.Controls.Add(this.btnCloseAppFormPnl);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.lblMerchant);
            this.Controls.Add(this.txbMerchant);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txbMake);
            this.Controls.Add(this.btnCalculateMonthlyCost);
            this.Controls.Add(this.txbInsurance);
            this.Controls.Add(this.txbInterestRate);
            this.Controls.Add(this.txbTotalDeposit);
            this.Controls.Add(this.txbPurchasePrice);
            this.Controls.Add(this.txbModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblInsurancePremium);
            this.Controls.Add(this.lblVehicleTotalDeposit);
            this.Controls.Add(this.lblVehicleInterestRate);
            this.Controls.Add(this.lblVehiclePurchasePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVehicle";
            this.Text = "Budget for a Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblInsurancePremium;
        private System.Windows.Forms.Label lblVehicleTotalDeposit;
        private System.Windows.Forms.Label lblVehicleInterestRate;
        private System.Windows.Forms.Label lblVehiclePurchasePrice;
        private System.Windows.Forms.TextBox txbPurchasePrice;
        private System.Windows.Forms.TextBox txbTotalDeposit;
        private System.Windows.Forms.TextBox txbInterestRate;
        private System.Windows.Forms.TextBox txbInsurance;
        private System.Windows.Forms.Button btnCalculateMonthlyCost;
        private System.Windows.Forms.TextBox txbMake;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txbMerchant;
        private System.Windows.Forms.Label lblMerchant;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCloseAppFormPnl;
        private System.Windows.Forms.Label lblVehicleHeader;
    }
}