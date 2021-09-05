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
    public partial class frmVehicle : Form
    {
        public frmVehicle()
        {
            InitializeComponent();
        }

        private void txbPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);//only allows the user to enter numbers
        }

        private void txbTotalDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void txbInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void txbInsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void btnCalculateMonthlyCost_Click(object sender, EventArgs e)
        {//scroll horizontally to see comments
            VehicleLoan objVehicle = new VehicleLoan(txbModel.Text, txbMake.Text, Convert.ToDouble(txbInsurance.Text), txbMerchant.Text, "", DateTime.Today, Convert.ToDouble(txbPurchasePrice.Text), Convert.ToDouble(txbTotalDeposit.Text), Convert.ToDouble(txbInterestRate.Text));//creates an object
            objVehicle.MonthlyCost = ExpenseCalculation.calcMonthlyRepayment(objVehicle.PurchasePrice, objVehicle.Deposit, objVehicle.InterestRate, objVehicle.Months, objVehicle.InsurancePremium);//calculates the monthly cost using the class lib
            StaticValues.currentMonthlyIncome = ExpenseCalculation.substractExpensesFromIncome(StaticValues.currentMonthlyIncome, objVehicle.MonthlyCost);//subtracts the monthly cost from the income
            StaticValues.CheckGenericList("Your previous Vehicle calculation has been successfully overwritten", "BudgetingApp.VehicleLoan", objVehicle);//checks if the user has made this calculation before and overwrites it 
            StaticValues.vehicleExpense = Math.Truncate(objVehicle.MonthlyCost * 100 / 100);//stores the monthly cost with a max of 2 decimal places
            MessageBox.Show("Calculation Successful! Go to the Dashboard to view the deductions");
        }

        private void btnCloseAppFormPnl_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes the app
        }
    }
}
