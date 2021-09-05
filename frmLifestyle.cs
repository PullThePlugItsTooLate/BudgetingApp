using BudgetCalculationLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class frmLifestyle : Form
    {
        public frmLifestyle()
        {
            InitializeComponent();
        }

        private void txbTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);//allows the user to only enter numbers
        }

        private void txbGroceries_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void txbWaterAndLights_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void txbTravelCosts_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void txbPhoneBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void txbOtherExpenses_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void btnCalculateExpense_Click(object sender, EventArgs e)
        {//scroll horizontally to see comments
            LifestyleExpense objLifeExp = new LifestyleExpense(Convert.ToDouble(txbTax.Text), Convert.ToDouble(txbGroceries.Text), Convert.ToDouble(txbWaterAndLights.Text), Convert.ToDouble(txbTravelCosts.Text), Convert.ToDouble(txbPhoneBill.Text), Convert.ToDouble(txbOtherExpenses.Text), txbDescription.Text, DateTime.Today, 0, 0, 1);//creates an object
            objLifeExp.MonthlyCost = ExpenseCalculation.calcMonthlyRepayment(objLifeExp.PurchasePrice, 0, 0, 1, 0);//calculates the monthly cost using the class lib
            StaticValues.currentMonthlyIncome = ExpenseCalculation.substractExpensesFromIncome(StaticValues.currentMonthlyIncome, objLifeExp.MonthlyCost);
            StaticValues.CheckGenericList("Your previous Lifestyle Expenses calculation has been successfully overwritten", "BudgetingApp.LifestyleExpense", objLifeExp);//checks if there is already an object of this type created
            StaticValues.lifestyleExpense = Math.Truncate(objLifeExp.MonthlyCost * 100 / 100);//stores the value with a max of 2 decimal places
            MessageBox.Show("Calculation Successful! Go to the Dashboard to view the deductions");
        }

        private void btnCloseAppFormPnl_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes the app
        }
    }
}
