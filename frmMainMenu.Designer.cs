namespace BudgetingApp
{
    partial class frmMainMenu
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
            this.lblMonthlyIncome = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAccommodation = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnLifestyle = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbProfileImg = new System.Windows.Forms.PictureBox();
            this.lblDashboardHeader = new System.Windows.Forms.Label();
            this.btnFormClose = new System.Windows.Forms.Button();
            this.pnlDisplayIncome = new System.Windows.Forms.Panel();
            this.pbIncomeIcon = new System.Windows.Forms.PictureBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblIncomeHeading = new System.Windows.Forms.Label();
            this.pnlCalculationForms = new System.Windows.Forms.Panel();
            this.btnCloseAppFormPnl = new System.Windows.Forms.Button();
            this.pnlProperty = new System.Windows.Forms.Panel();
            this.pbProperty = new System.Windows.Forms.PictureBox();
            this.lblPropertyTip = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lblPropertyExpense = new System.Windows.Forms.Label();
            this.pnlLifestyle = new System.Windows.Forms.Panel();
            this.pbLifestyle = new System.Windows.Forms.PictureBox();
            this.lblLifestyleTip = new System.Windows.Forms.Label();
            this.lblLifestyle = new System.Windows.Forms.Label();
            this.lblLifestyleExpense = new System.Windows.Forms.Label();
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.pbVehicle = new System.Windows.Forms.PictureBox();
            this.lblVehicleTip = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblVehicleExpense = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImg)).BeginInit();
            this.pnlDisplayIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncomeIcon)).BeginInit();
            this.pnlCalculationForms.SuspendLayout();
            this.pnlProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProperty)).BeginInit();
            this.pnlLifestyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLifestyle)).BeginInit();
            this.pnlVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblMonthlyIncome.Location = new System.Drawing.Point(16, 47);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(124, 39);
            this.lblMonthlyIncome.TabIndex = 38;
            this.lblMonthlyIncome.Text = "R 0.00";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlNav);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnAccommodation);
            this.pnlMenu.Controls.Add(this.btnVehicle);
            this.pnlMenu.Controls.Add(this.btnLifestyle);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlProfile);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(186, 577);
            this.pnlMenu.TabIndex = 39;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(3, 192);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 41;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::BudgetingApp.Properties.Resources.innovation;
            this.btnSettings.Location = new System.Drawing.Point(0, 516);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 58);
            this.btnSettings.TabIndex = 40;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnAccommodation
            // 
            this.btnAccommodation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccommodation.FlatAppearance.BorderSize = 0;
            this.btnAccommodation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccommodation.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccommodation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAccommodation.Image = global::BudgetingApp.Properties.Resources.home_1_;
            this.btnAccommodation.Location = new System.Drawing.Point(0, 338);
            this.btnAccommodation.Name = "btnAccommodation";
            this.btnAccommodation.Size = new System.Drawing.Size(186, 58);
            this.btnAccommodation.TabIndex = 40;
            this.btnAccommodation.Text = "Property";
            this.btnAccommodation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAccommodation.UseVisualStyleBackColor = true;
            this.btnAccommodation.Click += new System.EventHandler(this.btnAccommodation_Click_1);
            this.btnAccommodation.Leave += new System.EventHandler(this.btnAccommodation_Leave);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicle.FlatAppearance.BorderSize = 0;
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVehicle.Image = global::BudgetingApp.Properties.Resources.car_2_;
            this.btnVehicle.Location = new System.Drawing.Point(0, 280);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(186, 58);
            this.btnVehicle.TabIndex = 40;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click_1);
            this.btnVehicle.Leave += new System.EventHandler(this.btnVehicle_Leave);
            // 
            // btnLifestyle
            // 
            this.btnLifestyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLifestyle.FlatAppearance.BorderSize = 0;
            this.btnLifestyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLifestyle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLifestyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLifestyle.Image = global::BudgetingApp.Properties.Resources.shopping_cart_1_;
            this.btnLifestyle.Location = new System.Drawing.Point(0, 222);
            this.btnLifestyle.Name = "btnLifestyle";
            this.btnLifestyle.Size = new System.Drawing.Size(186, 58);
            this.btnLifestyle.TabIndex = 40;
            this.btnLifestyle.Text = "Lifestyle";
            this.btnLifestyle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLifestyle.UseVisualStyleBackColor = true;
            this.btnLifestyle.Click += new System.EventHandler(this.btnLifestyle_Click);
            this.btnLifestyle.Leave += new System.EventHandler(this.btnLifestyle_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = global::BudgetingApp.Properties.Resources.money_1_;
            this.btnDashboard.Location = new System.Drawing.Point(0, 164);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 58);
            this.btnDashboard.TabIndex = 40;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.lblCurrentDate);
            this.pnlProfile.Controls.Add(this.lblUsername);
            this.pnlProfile.Controls.Add(this.pbProfileImg);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(186, 164);
            this.pnlProfile.TabIndex = 0;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblCurrentDate.Location = new System.Drawing.Point(57, 129);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(69, 15);
            this.lblCurrentDate.TabIndex = 2;
            this.lblCurrentDate.Text = "DateTime";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblUsername.Location = new System.Drawing.Point(41, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "User Name";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProfileImg
            // 
            this.pbProfileImg.Image = global::BudgetingApp.Properties.Resources.Untitled_11;
            this.pbProfileImg.Location = new System.Drawing.Point(60, 22);
            this.pbProfileImg.Name = "pbProfileImg";
            this.pbProfileImg.Size = new System.Drawing.Size(63, 63);
            this.pbProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfileImg.TabIndex = 0;
            this.pbProfileImg.TabStop = false;
            // 
            // lblDashboardHeader
            // 
            this.lblDashboardHeader.AutoSize = true;
            this.lblDashboardHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblDashboardHeader.Location = new System.Drawing.Point(213, 22);
            this.lblDashboardHeader.Name = "lblDashboardHeader";
            this.lblDashboardHeader.Size = new System.Drawing.Size(195, 39);
            this.lblDashboardHeader.TabIndex = 40;
            this.lblDashboardHeader.Text = "Dashboard";
            // 
            // btnFormClose
            // 
            this.btnFormClose.FlatAppearance.BorderSize = 0;
            this.btnFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormClose.ForeColor = System.Drawing.Color.White;
            this.btnFormClose.Location = new System.Drawing.Point(914, 12);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Size = new System.Drawing.Size(25, 25);
            this.btnFormClose.TabIndex = 41;
            this.btnFormClose.Text = "X";
            this.btnFormClose.UseVisualStyleBackColor = true;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            // 
            // pnlDisplayIncome
            // 
            this.pnlDisplayIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlDisplayIncome.Controls.Add(this.pbIncomeIcon);
            this.pnlDisplayIncome.Controls.Add(this.lblTip);
            this.pnlDisplayIncome.Controls.Add(this.lblIncomeHeading);
            this.pnlDisplayIncome.Controls.Add(this.lblMonthlyIncome);
            this.pnlDisplayIncome.Location = new System.Drawing.Point(230, 97);
            this.pnlDisplayIncome.Name = "pnlDisplayIncome";
            this.pnlDisplayIncome.Size = new System.Drawing.Size(396, 130);
            this.pnlDisplayIncome.TabIndex = 42;
            // 
            // pbIncomeIcon
            // 
            this.pbIncomeIcon.Image = global::BudgetingApp.Properties.Resources.cash;
            this.pbIncomeIcon.Location = new System.Drawing.Point(264, 10);
            this.pbIncomeIcon.Name = "pbIncomeIcon";
            this.pbIncomeIcon.Size = new System.Drawing.Size(101, 115);
            this.pbIncomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIncomeIcon.TabIndex = 39;
            this.pbIncomeIcon.TabStop = false;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblTip.Location = new System.Drawing.Point(19, 95);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(185, 20);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "This is your current Income";
            // 
            // lblIncomeHeading
            // 
            this.lblIncomeHeading.AutoSize = true;
            this.lblIncomeHeading.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeHeading.ForeColor = System.Drawing.Color.White;
            this.lblIncomeHeading.Location = new System.Drawing.Point(17, 15);
            this.lblIncomeHeading.Name = "lblIncomeHeading";
            this.lblIncomeHeading.Size = new System.Drawing.Size(94, 32);
            this.lblIncomeHeading.TabIndex = 0;
            this.lblIncomeHeading.Text = "Income";
            // 
            // pnlCalculationForms
            // 
            this.pnlCalculationForms.Controls.Add(this.btnCloseAppFormPnl);
            this.pnlCalculationForms.Location = new System.Drawing.Point(192, 0);
            this.pnlCalculationForms.Name = "pnlCalculationForms";
            this.pnlCalculationForms.Size = new System.Drawing.Size(759, 577);
            this.pnlCalculationForms.TabIndex = 43;
            // 
            // btnCloseAppFormPnl
            // 
            this.btnCloseAppFormPnl.FlatAppearance.BorderSize = 0;
            this.btnCloseAppFormPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAppFormPnl.ForeColor = System.Drawing.Color.White;
            this.btnCloseAppFormPnl.Location = new System.Drawing.Point(722, 12);
            this.btnCloseAppFormPnl.Name = "btnCloseAppFormPnl";
            this.btnCloseAppFormPnl.Size = new System.Drawing.Size(25, 25);
            this.btnCloseAppFormPnl.TabIndex = 43;
            this.btnCloseAppFormPnl.Text = "X";
            this.btnCloseAppFormPnl.UseVisualStyleBackColor = true;
            this.btnCloseAppFormPnl.Click += new System.EventHandler(this.btnCloseAppFormPnl_Click);
            // 
            // pnlProperty
            // 
            this.pnlProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlProperty.Controls.Add(this.pbProperty);
            this.pnlProperty.Controls.Add(this.lblPropertyTip);
            this.pnlProperty.Controls.Add(this.lblProperty);
            this.pnlProperty.Controls.Add(this.lblPropertyExpense);
            this.pnlProperty.Location = new System.Drawing.Point(230, 254);
            this.pnlProperty.Name = "pnlProperty";
            this.pnlProperty.Size = new System.Drawing.Size(303, 116);
            this.pnlProperty.TabIndex = 44;
            // 
            // pbProperty
            // 
            this.pbProperty.Image = global::BudgetingApp.Properties.Resources.work_from_home;
            this.pbProperty.Location = new System.Drawing.Point(238, 12);
            this.pbProperty.Name = "pbProperty";
            this.pbProperty.Size = new System.Drawing.Size(51, 47);
            this.pbProperty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProperty.TabIndex = 39;
            this.pbProperty.TabStop = false;
            // 
            // lblPropertyTip
            // 
            this.lblPropertyTip.AutoSize = true;
            this.lblPropertyTip.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblPropertyTip.Location = new System.Drawing.Point(19, 85);
            this.lblPropertyTip.Name = "lblPropertyTip";
            this.lblPropertyTip.Size = new System.Drawing.Size(242, 19);
            this.lblPropertyTip.TabIndex = 0;
            this.lblPropertyTip.Text = "This is your current Property Expenses";
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperty.ForeColor = System.Drawing.Color.White;
            this.lblProperty.Location = new System.Drawing.Point(17, 12);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(89, 28);
            this.lblProperty.TabIndex = 0;
            this.lblProperty.Text = "Property";
            // 
            // lblPropertyExpense
            // 
            this.lblPropertyExpense.AutoSize = true;
            this.lblPropertyExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyExpense.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPropertyExpense.Location = new System.Drawing.Point(17, 47);
            this.lblPropertyExpense.Name = "lblPropertyExpense";
            this.lblPropertyExpense.Size = new System.Drawing.Size(104, 32);
            this.lblPropertyExpense.TabIndex = 38;
            this.lblPropertyExpense.Text = "R 0.00";
            // 
            // pnlLifestyle
            // 
            this.pnlLifestyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlLifestyle.Controls.Add(this.pbLifestyle);
            this.pnlLifestyle.Controls.Add(this.lblLifestyleTip);
            this.pnlLifestyle.Controls.Add(this.lblLifestyle);
            this.pnlLifestyle.Controls.Add(this.lblLifestyleExpense);
            this.pnlLifestyle.Location = new System.Drawing.Point(230, 394);
            this.pnlLifestyle.Name = "pnlLifestyle";
            this.pnlLifestyle.Size = new System.Drawing.Size(303, 116);
            this.pnlLifestyle.TabIndex = 44;
            // 
            // pbLifestyle
            // 
            this.pbLifestyle.Image = global::BudgetingApp.Properties.Resources.businessman;
            this.pbLifestyle.Location = new System.Drawing.Point(238, 12);
            this.pbLifestyle.Name = "pbLifestyle";
            this.pbLifestyle.Size = new System.Drawing.Size(51, 47);
            this.pbLifestyle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLifestyle.TabIndex = 39;
            this.pbLifestyle.TabStop = false;
            // 
            // lblLifestyleTip
            // 
            this.lblLifestyleTip.AutoSize = true;
            this.lblLifestyleTip.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifestyleTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblLifestyleTip.Location = new System.Drawing.Point(19, 85);
            this.lblLifestyleTip.Name = "lblLifestyleTip";
            this.lblLifestyleTip.Size = new System.Drawing.Size(238, 19);
            this.lblLifestyleTip.TabIndex = 0;
            this.lblLifestyleTip.Text = "This is your current Lifestyle Expenses";
            // 
            // lblLifestyle
            // 
            this.lblLifestyle.AutoSize = true;
            this.lblLifestyle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifestyle.ForeColor = System.Drawing.Color.White;
            this.lblLifestyle.Location = new System.Drawing.Point(17, 12);
            this.lblLifestyle.Name = "lblLifestyle";
            this.lblLifestyle.Size = new System.Drawing.Size(82, 28);
            this.lblLifestyle.TabIndex = 0;
            this.lblLifestyle.Text = "Lifestyle";
            // 
            // lblLifestyleExpense
            // 
            this.lblLifestyleExpense.AutoSize = true;
            this.lblLifestyleExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifestyleExpense.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLifestyleExpense.Location = new System.Drawing.Point(17, 47);
            this.lblLifestyleExpense.Name = "lblLifestyleExpense";
            this.lblLifestyleExpense.Size = new System.Drawing.Size(104, 32);
            this.lblLifestyleExpense.TabIndex = 38;
            this.lblLifestyleExpense.Text = "R 0.00";
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlVehicle.Controls.Add(this.pbVehicle);
            this.pnlVehicle.Controls.Add(this.lblVehicleTip);
            this.pnlVehicle.Controls.Add(this.lblVehicle);
            this.pnlVehicle.Controls.Add(this.lblVehicleExpense);
            this.pnlVehicle.Location = new System.Drawing.Point(567, 254);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Size = new System.Drawing.Size(303, 116);
            this.pnlVehicle.TabIndex = 44;
            // 
            // pbVehicle
            // 
            this.pbVehicle.Image = global::BudgetingApp.Properties.Resources.car_wash;
            this.pbVehicle.Location = new System.Drawing.Point(238, 12);
            this.pbVehicle.Name = "pbVehicle";
            this.pbVehicle.Size = new System.Drawing.Size(51, 47);
            this.pbVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVehicle.TabIndex = 39;
            this.pbVehicle.TabStop = false;
            // 
            // lblVehicleTip
            // 
            this.lblVehicleTip.AutoSize = true;
            this.lblVehicleTip.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblVehicleTip.Location = new System.Drawing.Point(19, 85);
            this.lblVehicleTip.Name = "lblVehicleTip";
            this.lblVehicleTip.Size = new System.Drawing.Size(231, 19);
            this.lblVehicleTip.TabIndex = 0;
            this.lblVehicleTip.Text = "This is your current Vehicle Expenses";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.ForeColor = System.Drawing.Color.White;
            this.lblVehicle.Location = new System.Drawing.Point(17, 12);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(73, 28);
            this.lblVehicle.TabIndex = 0;
            this.lblVehicle.Text = "Vehicle";
            // 
            // lblVehicleExpense
            // 
            this.lblVehicleExpense.AutoSize = true;
            this.lblVehicleExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleExpense.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblVehicleExpense.Location = new System.Drawing.Point(17, 47);
            this.lblVehicleExpense.Name = "lblVehicleExpense";
            this.lblVehicleExpense.Size = new System.Drawing.Size(104, 32);
            this.lblVehicleExpense.TabIndex = 38;
            this.lblVehicleExpense.Text = "R 0.00";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pnlCalculationForms);
            this.Controls.Add(this.pnlDisplayIncome);
            this.Controls.Add(this.btnFormClose);
            this.Controls.Add(this.lblDashboardHeader);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlVehicle);
            this.Controls.Add(this.pnlProperty);
            this.Controls.Add(this.pnlLifestyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.pnlMenu.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImg)).EndInit();
            this.pnlDisplayIncome.ResumeLayout(false);
            this.pnlDisplayIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncomeIcon)).EndInit();
            this.pnlCalculationForms.ResumeLayout(false);
            this.pnlProperty.ResumeLayout(false);
            this.pnlProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProperty)).EndInit();
            this.pnlLifestyle.ResumeLayout(false);
            this.pnlLifestyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLifestyle)).EndInit();
            this.pnlVehicle.ResumeLayout(false);
            this.pnlVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblMonthlyIncome;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.PictureBox pbProfileImg;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAccommodation;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnLifestyle;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblDashboardHeader;
        private System.Windows.Forms.Button btnFormClose;
        private System.Windows.Forms.Panel pnlDisplayIncome;
        private System.Windows.Forms.PictureBox pbIncomeIcon;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblIncomeHeading;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlCalculationForms;
        private System.Windows.Forms.Button btnCloseAppFormPnl;
        private System.Windows.Forms.Panel pnlProperty;
        private System.Windows.Forms.PictureBox pbProperty;
        private System.Windows.Forms.Label lblPropertyTip;
        private System.Windows.Forms.Label lblProperty;
        public System.Windows.Forms.Label lblPropertyExpense;
        private System.Windows.Forms.Panel pnlLifestyle;
        private System.Windows.Forms.PictureBox pbLifestyle;
        private System.Windows.Forms.Label lblLifestyleTip;
        private System.Windows.Forms.Label lblLifestyle;
        public System.Windows.Forms.Label lblLifestyleExpense;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.PictureBox pbVehicle;
        private System.Windows.Forms.Label lblVehicleTip;
        private System.Windows.Forms.Label lblVehicle;
        public System.Windows.Forms.Label lblVehicleExpense;
    }
}

