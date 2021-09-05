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
    class HomeLoan : Expense//homeloan extends the expense class
    {
        private string merchant;//homeloan attributes
        private string address;
        private string realtorsNumber;
        private bool feasible;

        public HomeLoan() : base()//default contructor, base is using the default contructor from the parent class
        {

        }

        public HomeLoan(string address, string realtorsNumber, string merchant, string description, DateTime date, double purchasePrice, double deposit, double interestRate, int months) : base(description, date, purchasePrice, deposit, interestRate, months)
        {//contructor, base is using the contructor from the parent class
            this.merchant = merchant;
            this.description = description;
            this.date = date;
            this.purchasePrice = purchasePrice;
            this.deposit = deposit;
            this.interestRate = interestRate;
            this.months = months;
            this.address = address;//child attributes
            this.realtorsNumber = realtorsNumber;
        }

        public string Address { get => address; set => address = value; }//get and sets for the homeloan attributes
        public string RealtorsNumber { get => realtorsNumber; set => realtorsNumber = value; }
        public bool Feasible { get => feasible; set => feasible = value; }
        public string Merchant { get => merchant; set => merchant = value; }
    }
}
