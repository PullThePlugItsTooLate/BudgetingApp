using System;
using System.Collections.Generic;
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
    class StaticValues
    {
        public static double monthlyIncome;//stores the gross income 
        public static double currentMonthlyIncome;//stores the current income after expenses
        public static string username;//stores the users username
        public static bool isBuyClickTrue;//helps determine if the user wants to buy or rent
        public static double vehicleExpense;//stores the vehicle expense
        public static double propertyExpense;//stores the property expense
        public static double lifestyleExpense;//stores the lifestyle expense
        public static List<Expense> lstExpenses = new List<Expense>();//keeps objects of the different expenses that the user calculates, This is a Generic Collection


        public static void CheckGenericList(string message, string type, Expense objExpense)
        {
            bool canAdd = false;//used for determining whether to add an object or overwrite it 

            for (int i = 0; i < lstExpenses.Count; i++)//foreach expense in the expense list
            {
                if (lstExpenses[i].GetType().ToString().Equals(type))//if the object that just came in has the same type as an object in the list
                {
                    currentMonthlyIncome += lstExpenses[i].MonthlyCost;//return the money that was intially deducted
                    lstExpenses[i] = objExpense;//overwrite the expense
                    MessageBox.Show(message);//tell the user that the expense was overwritten
                    canAdd = false;//dont add the object to the list because it was just overwritten
                }
                else
                {
                    canAdd = true;//else if theres no object in the list with that type then add it 
                }
            }

            if (canAdd)
            {
                lstExpenses.Add(objExpense);//if the bool is true then add the obj to the list
            }

            if (lstExpenses.Count == 0)
            {
                lstExpenses.Add(objExpense);//if there is nothing in the list then immediately add the object that came in, into the list
            }
        }
    }
}
