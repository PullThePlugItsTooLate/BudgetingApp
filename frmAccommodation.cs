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
    public partial class frmAccommodation : Form
    {
        public frmAccommodation()
        {
            InitializeComponent();//intializing the components on the form
            pnlPropertyPurchase.Hide();//hides the panel
        }

        private void txbRentalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);//only allows the user to enter numbers
        }

        private void txbPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void txbDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void txbInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {//comments are at the end of the line, scroll horizontally
            if (StaticValues.isBuyClickTrue)//checks if the user clicked the buy button
            {
                HomeLoan objBuyProp = new HomeLoan(txbAddress.Text, txbRealtorsNum.Text, txbMerchant.Text, txbDescription.Text, DateTime.Today, Convert.ToDouble(txbPurchasePrice.Text), Convert.ToDouble(txbDeposit.Text), Convert.ToDouble(txbInterestRate.Text), (int)nudNumMonths.Value);//makes a homeloan object
                objBuyProp.MonthlyCost = ExpenseCalculation.calcMonthlyRepayment(objBuyProp.PurchasePrice, objBuyProp.Deposit, objBuyProp.InterestRate, objBuyProp.Months, 0);//calculates the monthly cost using the class lib and stores the value in the object
                MessageBox.Show(ExpenseCalculation.checkMonthlyPayment(StaticValues.monthlyIncome, objBuyProp.MonthlyCost));//checks the monthly payment and warns the user if its too high
                StaticValues.currentMonthlyIncome = ExpenseCalculation.substractExpensesFromIncome(StaticValues.currentMonthlyIncome, objBuyProp.MonthlyCost);//substracts the monthly cost from the users income
                StaticValues.CheckGenericList("Your previous Accommodation calculation has been successfully overwritten", "BudgetingApp.HomeLoan", objBuyProp);//checks if the user already calculated this before
                StaticValues.propertyExpense = Math.Truncate(objBuyProp.MonthlyCost * 100 / 100);//stores the value with a max of 2 decimal places
                MessageBox.Show("Calculation Successful! Go to the Dashboard to view the deductions");
            }
            else
            {
                if (StaticValues.isBuyClickTrue == false)//checks if the user clicked the rent button
                {
                    HomeLoan objRentProp = new HomeLoan(txbAddress.Text, txbRealtorsNum.Text, txbMerchant.Text, txbDescription.Text, DateTime.Today, Convert.ToDouble(txbRentalAmount.Text), 0, 0, 1);
                    objRentProp.MonthlyCost = ExpenseCalculation.calcMonthlyRepayment(objRentProp.PurchasePrice, objRentProp.Deposit, objRentProp.InterestRate, objRentProp.Months, 0);
                    StaticValues.currentMonthlyIncome = ExpenseCalculation.substractExpensesFromIncome(StaticValues.currentMonthlyIncome, objRentProp.MonthlyCost);
                    StaticValues.CheckGenericList("Your previous Accommodation calculation has been successfully overwritten", "BudgetingApp.HomeLoan", objRentProp);
                    StaticValues.propertyExpense = Math.Truncate(objRentProp.MonthlyCost * 100 / 100);
                    MessageBox.Show("Calculation Successful! Go to the Dashboard to view the deductions");
                }
            }
        }

        private void btnBuyProp_Click(object sender, EventArgs e)
        {
            StaticValues.isBuyClickTrue = true;//tells the program that the user clicked this button
            pnlPropertyPurchase.Show();//shows the panel for input
            lblRentalAmount.Hide();//hides the rental input controls
            txbRentalAmount.Hide();
            lblTotalDeposit.Show();//shows the needed input controls
            txbDeposit.Show();
            lblPropertyPrice.Show();
            txbPurchasePrice.Show();
            lblInterestRate.Show();
            txbInterestRate.Show();
            lblMonthsToRepay.Show();
            nudNumMonths.Show();

            lblRealtorsNum.Location = new Point(73, 335);//sets the location of the controls that were moved
            txbRealtorsNum.Location = new Point(388, 337);

            lblAddress.Location = new Point(73, 290);
            txbAddress.Location = new Point(388, 292);

            lblMerchant.Location = new Point(73, 200);
            txbMerchant.Location = new Point(388, 202);

            lblDescription.Location = new Point(73, 245);
            txbDescription.Location = new Point(388, 247);
        }

        private void btnRentProp_Click(object sender, EventArgs e)
        {
            StaticValues.isBuyClickTrue = false;//tells the app that the user clicked the rent button
            pnlPropertyPurchase.Show();//shows the panel for input
            lblRentalAmount.Show();//shows the needed controls and hides the ones that arent needed
            txbRentalAmount.Show();
            lblTotalDeposit.Hide();
            txbDeposit.Hide();
            lblPropertyPrice.Hide();
            txbPurchasePrice.Hide();
            lblInterestRate.Hide();
            txbInterestRate.Hide();
            lblMonthsToRepay.Hide();
            nudNumMonths.Hide();

            lblRealtorsNum.Location = lblDescription.Location;//moves the controls for visual appeal
            txbRealtorsNum.Location = txbDescription.Location;

            lblAddress.Location = lblMerchant.Location;
            txbAddress.Location = txbMerchant.Location;

            lblMerchant.Location = lblInterestRate.Location;
            txbMerchant.Location = txbInterestRate.Location;

            lblDescription.Location = lblMonthsToRepay.Location;
            txbDescription.Location = nudNumMonths.Location;
        }

        private void btnCloseAppFormPnl_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes the app
        }
    }
}
