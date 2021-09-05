using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// StudentName: Suvashin
/// Student Number: 19003564
/// Module: PROG6212
/// Task: Task1
/// Semester: 2
/// </summary>

namespace BudgetingApp
{
    class LifestyleExpense : Expense//lifestyle expense class extends the expense class
    {
        private double tax;//attributes for the lifestyle expense class
        private double groceriesCost;
        private double waterAndLightsCost;
        private double travelCost;
        private double phoneBill;
        private double otherExpenses;

        public LifestyleExpense() : base()//defualt contructor, base is using the default contructor from the parent class
        {

        }

        public LifestyleExpense(double tax, double groceriesCost, double waterAndLightsCost, double travelCost, double phoneBill, double otherExpenses, string description, DateTime date, double deposit, double interestRate, int months) : base(description, date, deposit, interestRate, months)
        {//contructor, base is using the contructor from the parent class
            this.description = description;
            this.date = date;
            this.deposit = deposit;
            this.interestRate = interestRate;
            this.months = months;
            this.tax = tax;//child attributes
            this.groceriesCost = groceriesCost;
            this.waterAndLightsCost = waterAndLightsCost;
            this.travelCost = travelCost;
            this.phoneBill = phoneBill;
            this.otherExpenses = otherExpenses;
            purchasePrice = calculateSum();//calls the method to get the sum
        }

        public double Tax { get => tax; set => tax = value; }//gets and sets for the attributes of this class
        public double GroceriesCost { get => groceriesCost; set => groceriesCost = value; }
        public double WaterAndLightsCost { get => waterAndLightsCost; set => waterAndLightsCost = value; }
        public double TravelCost { get => travelCost; set => travelCost = value; }
        public double PhoneBill { get => phoneBill; set => phoneBill = value; }
        public double OtherExpenses { get => otherExpenses; set => otherExpenses = value; }

        private double calculateSum ()//calculates the sum of all the expenditures
        {
            return tax + groceriesCost + waterAndLightsCost + travelCost + phoneBill + otherExpenses;
        }
    }
}
