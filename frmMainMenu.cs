using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// StudentName: Suvashin
/// Student Number: 19003564
/// Module: PROG6212
/// Task: 1
/// Semester: 2
/// </summary>

namespace BudgetingApp
{
    public partial class frmMainMenu : Form
    {   
        public frmMainMenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(ComponentManipulation.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));//used to give the forms rounded corners
            ComponentManipulation.ClickCurrect(pnlNav, btnDashboard);//helps the user keep track of the current tab they are in
            lblMonthlyIncome.Text = "R " + (Math.Truncate(StaticValues.monthlyIncome * 100) / 100).ToString();//displays the monthly income with a max of 2 decimal places
            lblLifestyleExpense.Text = "R -" + StaticValues.lifestyleExpense;//displayes the costs
            lblVehicleExpense.Text = "R -" + StaticValues.vehicleExpense;
            lblPropertyExpense.Text = "R -" + StaticValues.propertyExpense;
            lblUsername.Text = StaticValues.username;
            lblCurrentDate.Text = ComponentManipulation.GetCurrentDate();
            pnlCalculationForms.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ComponentManipulation.ClickCurrect(pnlNav, btnDashboard);
            pnlCalculationForms.Hide();//hids the expense panel
            lblMonthlyIncome.Text = "R " + (Math.Truncate(StaticValues.currentMonthlyIncome * 100) / 100).ToString();//updates all the values when the user goes back to the dashboard
            lblLifestyleExpense.Text = "R -" + StaticValues.lifestyleExpense;
            lblVehicleExpense.Text = "R -" + StaticValues.vehicleExpense;
            lblPropertyExpense.Text = "R -" + StaticValues.propertyExpense;
        }

        private void btnLifestyle_Click(object sender, EventArgs e)
        {
            ComponentManipulation.ClickCurrect(pnlNav, btnLifestyle);
            pnlCalculationForms.Show();//shows the panel
            ComponentManipulation.ClearFormInstance();//closes all the forms that were opened previously if any
            frmLifestyle frmLife = new frmLifestyle() { TopLevel = false, TopMost = true };//setting the form in which manner it should be displayed
            pnlCalculationForms.Controls.Clear();//clears any added forms (controls)
            pnlCalculationForms.Controls.Add(frmLife);//adds the form to the panel
            frmLife.Show();//shows the form
            ComponentManipulation.lstInstanceForm.Add(frmLife);//keeps tracks of the form that is currently opened
        }

        private void btnVehicle_Click_1(object sender, EventArgs e)
        {
            ComponentManipulation.ClickCurrect(pnlNav, btnVehicle);
            pnlCalculationForms.Show();
            ComponentManipulation.ClearFormInstance();
            frmVehicle frmVeh = new frmVehicle() { TopLevel = false, TopMost = true };
            pnlCalculationForms.Controls.Clear();
            pnlCalculationForms.Controls.Add(frmVeh);
            frmVeh.Show();
            ComponentManipulation.lstInstanceForm.Add(frmVeh);
        }

        private void btnAccommodation_Click_1(object sender, EventArgs e)
        {
            ComponentManipulation.ClickCurrect(pnlNav, btnAccommodation);
            pnlCalculationForms.Show();
            ComponentManipulation.ClearFormInstance();
            frmAccommodation frmAcc = new frmAccommodation() { TopLevel = false, TopMost = true };
            pnlCalculationForms.Controls.Clear();
            pnlCalculationForms.Controls.Add(frmAcc);
            frmAcc.Show();
            ComponentManipulation.lstInstanceForm.Add(frmAcc);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ComponentManipulation.ClickCurrect(pnlNav, btnSettings);
            pnlCalculationForms.Show();
            ComponentManipulation.ClearFormInstance();
            frmSettings frmSett = new frmSettings() { TopLevel = false, TopMost = true };
            pnlCalculationForms.Controls.Clear();
            pnlCalculationForms.Controls.Add(frmSett);
            frmSett.Show();
            ComponentManipulation.lstInstanceForm.Add(frmSett);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            ComponentManipulation.LeaveCurrent(btnDashboard);//reverts back to its normal color
        }

        private void btnLifestyle_Leave(object sender, EventArgs e)
        {
            ComponentManipulation.LeaveCurrent(btnLifestyle);
        }

        private void btnVehicle_Leave(object sender, EventArgs e)
        {
            ComponentManipulation.LeaveCurrent(btnVehicle);
        }

        private void btnAccommodation_Leave(object sender, EventArgs e)
        {
            ComponentManipulation.LeaveCurrent(btnAccommodation);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            ComponentManipulation.LeaveCurrent(btnSettings);
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes the app
        }

        private void btnCloseAppFormPnl_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes the app as well
        }
    }
}
