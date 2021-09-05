namespace BudgetingApp
{
    partial class frmAccommodation
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
            this.lblMonthsToRepay = new System.Windows.Forms.Label();
            this.lblTotalDeposit = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblPropertyPrice = new System.Windows.Forms.Label();
            this.lblRentalAmount = new System.Windows.Forms.Label();
            this.txbRentalAmount = new System.Windows.Forms.TextBox();
            this.txbPurchasePrice = new System.Windows.Forms.TextBox();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.txbInterestRate = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblMerchant = new System.Windows.Forms.Label();
            this.txbMerchant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lblRealtorsNum = new System.Windows.Forms.Label();
            this.txbRealtorsNum = new System.Windows.Forms.TextBox();
            this.nudNumMonths = new System.Windows.Forms.NumericUpDown();
            this.lblAccommodationHeader = new System.Windows.Forms.Label();
            this.btnBuyProp = new System.Windows.Forms.Button();
            this.btnRentProp = new System.Windows.Forms.Button();
            this.pnlPropertyPurchase = new System.Windows.Forms.Panel();
            this.btnCloseAppFormPnl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumMonths)).BeginInit();
            this.pnlPropertyPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMonthsToRepay
            // 
            this.lblMonthsToRepay.AutoSize = true;
            this.lblMonthsToRepay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthsToRepay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblMonthsToRepay.Location = new System.Drawing.Point(73, 155);
            this.lblMonthsToRepay.Name = "lblMonthsToRepay";
            this.lblMonthsToRepay.Size = new System.Drawing.Size(260, 25);
            this.lblMonthsToRepay.TabIndex = 30;
            this.lblMonthsToRepay.Text = "Months to repay (240 - 360):";
            // 
            // lblTotalDeposit
            // 
            this.lblTotalDeposit.AutoSize = true;
            this.lblTotalDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTotalDeposit.Location = new System.Drawing.Point(73, 65);
            this.lblTotalDeposit.Name = "lblTotalDeposit";
            this.lblTotalDeposit.Size = new System.Drawing.Size(130, 25);
            this.lblTotalDeposit.TabIndex = 29;
            this.lblTotalDeposit.Text = "Total deposit:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblInterestRate.Location = new System.Drawing.Point(73, 110);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(237, 25);
            this.lblInterestRate.TabIndex = 28;
            this.lblInterestRate.Text = "Interest rate (percentage):";
            // 
            // lblPropertyPrice
            // 
            this.lblPropertyPrice.AutoSize = true;
            this.lblPropertyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblPropertyPrice.Location = new System.Drawing.Point(73, 20);
            this.lblPropertyPrice.Name = "lblPropertyPrice";
            this.lblPropertyPrice.Size = new System.Drawing.Size(245, 25);
            this.lblPropertyPrice.TabIndex = 27;
            this.lblPropertyPrice.Text = "Purchase price of property:";
            // 
            // lblRentalAmount
            // 
            this.lblRentalAmount.AutoSize = true;
            this.lblRentalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblRentalAmount.Location = new System.Drawing.Point(73, 65);
            this.lblRentalAmount.Name = "lblRentalAmount";
            this.lblRentalAmount.Size = new System.Drawing.Size(143, 25);
            this.lblRentalAmount.TabIndex = 25;
            this.lblRentalAmount.Text = "Rental amount:";
            // 
            // txbRentalAmount
            // 
            this.txbRentalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbRentalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRentalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRentalAmount.ForeColor = System.Drawing.Color.Turquoise;
            this.txbRentalAmount.Location = new System.Drawing.Point(388, 67);
            this.txbRentalAmount.Name = "txbRentalAmount";
            this.txbRentalAmount.Size = new System.Drawing.Size(238, 27);
            this.txbRentalAmount.TabIndex = 36;
            this.txbRentalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRentalAmount_KeyPress);
            // 
            // txbPurchasePrice
            // 
            this.txbPurchasePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbPurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPurchasePrice.ForeColor = System.Drawing.Color.Turquoise;
            this.txbPurchasePrice.Location = new System.Drawing.Point(388, 22);
            this.txbPurchasePrice.Name = "txbPurchasePrice";
            this.txbPurchasePrice.Size = new System.Drawing.Size(238, 27);
            this.txbPurchasePrice.TabIndex = 37;
            this.txbPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPurchasePrice_KeyPress);
            // 
            // txbDeposit
            // 
            this.txbDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDeposit.ForeColor = System.Drawing.Color.Turquoise;
            this.txbDeposit.Location = new System.Drawing.Point(388, 67);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.Size = new System.Drawing.Size(238, 27);
            this.txbDeposit.TabIndex = 38;
            this.txbDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDeposit_KeyPress);
            // 
            // txbInterestRate
            // 
            this.txbInterestRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInterestRate.ForeColor = System.Drawing.Color.Turquoise;
            this.txbInterestRate.Location = new System.Drawing.Point(388, 112);
            this.txbInterestRate.Name = "txbInterestRate";
            this.txbInterestRate.Size = new System.Drawing.Size(238, 27);
            this.txbInterestRate.TabIndex = 39;
            this.txbInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInterestRate_KeyPress);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblDescription.Location = new System.Drawing.Point(73, 245);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 25);
            this.lblDescription.TabIndex = 59;
            this.lblDescription.Text = "Description:";
            // 
            // txbDescription
            // 
            this.txbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescription.ForeColor = System.Drawing.Color.Turquoise;
            this.txbDescription.Location = new System.Drawing.Point(388, 247);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(238, 27);
            this.txbDescription.TabIndex = 58;
            // 
            // lblMerchant
            // 
            this.lblMerchant.AutoSize = true;
            this.lblMerchant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblMerchant.Location = new System.Drawing.Point(73, 200);
            this.lblMerchant.Name = "lblMerchant";
            this.lblMerchant.Size = new System.Drawing.Size(100, 25);
            this.lblMerchant.TabIndex = 57;
            this.lblMerchant.Text = "Merchant:";
            // 
            // txbMerchant
            // 
            this.txbMerchant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbMerchant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMerchant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMerchant.ForeColor = System.Drawing.Color.Turquoise;
            this.txbMerchant.Location = new System.Drawing.Point(388, 202);
            this.txbMerchant.Name = "txbMerchant";
            this.txbMerchant.Size = new System.Drawing.Size(238, 27);
            this.txbMerchant.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Image = global::BudgetingApp.Properties.Resources.home_1_;
            this.button1.Location = new System.Drawing.Point(472, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 54);
            this.button1.TabIndex = 60;
            this.button1.Text = "Calculate Monthly Cost";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblAddress.Location = new System.Drawing.Point(73, 290);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 25);
            this.lblAddress.TabIndex = 61;
            this.lblAddress.Text = "Address:";
            // 
            // txbAddress
            // 
            this.txbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.ForeColor = System.Drawing.Color.Turquoise;
            this.txbAddress.Location = new System.Drawing.Point(388, 292);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(238, 27);
            this.txbAddress.TabIndex = 62;
            // 
            // lblRealtorsNum
            // 
            this.lblRealtorsNum.AutoSize = true;
            this.lblRealtorsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealtorsNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblRealtorsNum.Location = new System.Drawing.Point(73, 335);
            this.lblRealtorsNum.Name = "lblRealtorsNum";
            this.lblRealtorsNum.Size = new System.Drawing.Size(236, 25);
            this.lblRealtorsNum.TabIndex = 63;
            this.lblRealtorsNum.Text = "Realtors Contact Number:";
            // 
            // txbRealtorsNum
            // 
            this.txbRealtorsNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txbRealtorsNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRealtorsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRealtorsNum.ForeColor = System.Drawing.Color.Turquoise;
            this.txbRealtorsNum.Location = new System.Drawing.Point(388, 337);
            this.txbRealtorsNum.Name = "txbRealtorsNum";
            this.txbRealtorsNum.Size = new System.Drawing.Size(238, 27);
            this.txbRealtorsNum.TabIndex = 64;
            // 
            // nudNumMonths
            // 
            this.nudNumMonths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.nudNumMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNumMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumMonths.ForeColor = System.Drawing.Color.Turquoise;
            this.nudNumMonths.Location = new System.Drawing.Point(388, 157);
            this.nudNumMonths.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudNumMonths.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudNumMonths.Name = "nudNumMonths";
            this.nudNumMonths.Size = new System.Drawing.Size(238, 27);
            this.nudNumMonths.TabIndex = 65;
            this.nudNumMonths.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // lblAccommodationHeader
            // 
            this.lblAccommodationHeader.AutoSize = true;
            this.lblAccommodationHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccommodationHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblAccommodationHeader.Location = new System.Drawing.Point(29, 33);
            this.lblAccommodationHeader.Name = "lblAccommodationHeader";
            this.lblAccommodationHeader.Size = new System.Drawing.Size(310, 39);
            this.lblAccommodationHeader.TabIndex = 68;
            this.lblAccommodationHeader.Text = "How will you pay?";
            // 
            // btnBuyProp
            // 
            this.btnBuyProp.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnBuyProp.FlatAppearance.BorderSize = 2;
            this.btnBuyProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyProp.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyProp.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuyProp.Image = global::BudgetingApp.Properties.Resources.credit_card;
            this.btnBuyProp.Location = new System.Drawing.Point(363, 32);
            this.btnBuyProp.Name = "btnBuyProp";
            this.btnBuyProp.Size = new System.Drawing.Size(152, 54);
            this.btnBuyProp.TabIndex = 67;
            this.btnBuyProp.Text = "Buy";
            this.btnBuyProp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuyProp.UseVisualStyleBackColor = true;
            this.btnBuyProp.Click += new System.EventHandler(this.btnBuyProp_Click);
            // 
            // btnRentProp
            // 
            this.btnRentProp.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnRentProp.FlatAppearance.BorderSize = 2;
            this.btnRentProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentProp.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentProp.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnRentProp.Image = global::BudgetingApp.Properties.Resources.cash_payment;
            this.btnRentProp.Location = new System.Drawing.Point(538, 32);
            this.btnRentProp.Name = "btnRentProp";
            this.btnRentProp.Size = new System.Drawing.Size(152, 54);
            this.btnRentProp.TabIndex = 66;
            this.btnRentProp.Text = "Rent";
            this.btnRentProp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRentProp.UseVisualStyleBackColor = true;
            this.btnRentProp.Click += new System.EventHandler(this.btnRentProp_Click);
            // 
            // pnlPropertyPurchase
            // 
            this.pnlPropertyPurchase.Controls.Add(this.txbRealtorsNum);
            this.pnlPropertyPurchase.Controls.Add(this.lblRentalAmount);
            this.pnlPropertyPurchase.Controls.Add(this.lblPropertyPrice);
            this.pnlPropertyPurchase.Controls.Add(this.lblInterestRate);
            this.pnlPropertyPurchase.Controls.Add(this.txbRentalAmount);
            this.pnlPropertyPurchase.Controls.Add(this.nudNumMonths);
            this.pnlPropertyPurchase.Controls.Add(this.lblTotalDeposit);
            this.pnlPropertyPurchase.Controls.Add(this.lblMonthsToRepay);
            this.pnlPropertyPurchase.Controls.Add(this.lblRealtorsNum);
            this.pnlPropertyPurchase.Controls.Add(this.txbAddress);
            this.pnlPropertyPurchase.Controls.Add(this.txbPurchasePrice);
            this.pnlPropertyPurchase.Controls.Add(this.lblAddress);
            this.pnlPropertyPurchase.Controls.Add(this.txbDeposit);
            this.pnlPropertyPurchase.Controls.Add(this.button1);
            this.pnlPropertyPurchase.Controls.Add(this.txbInterestRate);
            this.pnlPropertyPurchase.Controls.Add(this.lblDescription);
            this.pnlPropertyPurchase.Controls.Add(this.txbMerchant);
            this.pnlPropertyPurchase.Controls.Add(this.txbDescription);
            this.pnlPropertyPurchase.Controls.Add(this.lblMerchant);
            this.pnlPropertyPurchase.Location = new System.Drawing.Point(-1, 93);
            this.pnlPropertyPurchase.Name = "pnlPropertyPurchase";
            this.pnlPropertyPurchase.Size = new System.Drawing.Size(759, 482);
            this.pnlPropertyPurchase.TabIndex = 69;
            // 
            // btnCloseAppFormPnl
            // 
            this.btnCloseAppFormPnl.FlatAppearance.BorderSize = 0;
            this.btnCloseAppFormPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAppFormPnl.ForeColor = System.Drawing.Color.White;
            this.btnCloseAppFormPnl.Location = new System.Drawing.Point(722, 12);
            this.btnCloseAppFormPnl.Name = "btnCloseAppFormPnl";
            this.btnCloseAppFormPnl.Size = new System.Drawing.Size(25, 25);
            this.btnCloseAppFormPnl.TabIndex = 70;
            this.btnCloseAppFormPnl.Text = "X";
            this.btnCloseAppFormPnl.UseVisualStyleBackColor = true;
            this.btnCloseAppFormPnl.Click += new System.EventHandler(this.btnCloseAppFormPnl_Click);
            // 
            // frmAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(759, 574);
            this.Controls.Add(this.btnCloseAppFormPnl);
            this.Controls.Add(this.pnlPropertyPurchase);
            this.Controls.Add(this.lblAccommodationHeader);
            this.Controls.Add(this.btnBuyProp);
            this.Controls.Add(this.btnRentProp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccommodation";
            this.Text = "Budget for property";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumMonths)).EndInit();
            this.pnlPropertyPurchase.ResumeLayout(false);
            this.pnlPropertyPurchase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMonthsToRepay;
        private System.Windows.Forms.Label lblTotalDeposit;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblPropertyPrice;
        private System.Windows.Forms.Label lblRentalAmount;
        private System.Windows.Forms.TextBox txbRentalAmount;
        private System.Windows.Forms.TextBox txbPurchasePrice;
        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.TextBox txbInterestRate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblMerchant;
        private System.Windows.Forms.TextBox txbMerchant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lblRealtorsNum;
        private System.Windows.Forms.TextBox txbRealtorsNum;
        private System.Windows.Forms.NumericUpDown nudNumMonths;
        private System.Windows.Forms.Button btnRentProp;
        private System.Windows.Forms.Button btnBuyProp;
        private System.Windows.Forms.Label lblAccommodationHeader;
        private System.Windows.Forms.Panel pnlPropertyPurchase;
        private System.Windows.Forms.Button btnCloseAppFormPnl;
    }
}