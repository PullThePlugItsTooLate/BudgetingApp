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
    abstract public class Expense//expense parent class
    {
        protected string description;//expense class attributes
        protected DateTime date;
        protected double purchasePrice;
        protected double deposit;
        protected double interestRate;
        protected int months;
        protected double monthlyCost;

        public Expense()//default contructor
        {

        }

        protected Expense(string description, DateTime date, double purchasePrice, double deposit, double interestRate)//expense contructor
        {
            this.description = description;
            this.date = date;
            this.purchasePrice = purchasePrice;
            this.deposit = deposit;
            this.interestRate = interestRate;
        }

        protected Expense(string description, DateTime date, double deposit, double interestRate, int months)//expense altered contructor, excludes purchase price
        {
            this.description = description;
            this.date = date;
            this.deposit = deposit;
            this.interestRate = interestRate;
            this.months = months;
        }

        protected Expense(string description, DateTime date, double purchasePrice, double deposit, double interestRate, int months)//expense constructor (includes all attributes)
        {
            this.description = description;
            this.date = date;
            this.purchasePrice = purchasePrice;
            this.deposit = deposit;
            this.interestRate = interestRate;
            this.months = months;
        }

        public string Description { get => description; set => description = value; }//get and set methods for the attributes
        public DateTime Date { get => date; set => date = value; }
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double Deposit { get => deposit; set => deposit = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public int Months { get => months; set => months = value; }
        public double MonthlyCost { get => monthlyCost; set => monthlyCost = value; }
    }
}
