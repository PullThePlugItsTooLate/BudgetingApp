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
/// Task: Task1
/// Semester: 2
/// </summary>

namespace BudgetingApp
{
    public partial class frmMonthlyIncome : Form
    {
        
        public frmMonthlyIncome()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(ComponentManipulation.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));//makes the form rounded at the edges
        }

        private void btnSubmitIncome_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbMonthlyIncome.Text))//checks if the text box has nothing
            {
                MessageBox.Show("Please enter your monthly income");
                txbMonthlyIncome.Focus();
            }
            else 
            {
                if (String.IsNullOrEmpty(txbUsername.Text) || String.IsNullOrWhiteSpace(txbUsername.Text))//checks if there is only spaces or if its empty
                {
                    MessageBox.Show("Please enter your name");
                    txbUsername.Focus();
                }
                else 
                {
                    StaticValues.monthlyIncome = Convert.ToDouble(txbMonthlyIncome.Text);//if the user inputs everything correctly then extract the values
                    StaticValues.currentMonthlyIncome = Convert.ToDouble(txbMonthlyIncome.Text);
                    StaticValues.username = txbUsername.Text;
                    ComponentManipulation.FormTransitions(this, new frmMainMenu());//go the main menu
                }
            }
        }

        private void txbMonthlyIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.EnterOnlyNumbersInTextBox(sender, e);//only allows the user to enter numbers
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes the app
        }
    }
}
