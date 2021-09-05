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
    public class VehicleLoan : Expense//vehicleloan class extends the expense class
    {
        private string merchant;//attributes for vehicleloan class
        private string model;
        private string make;
        private double insurancePremium;

        public VehicleLoan() : base()//default contructor , base uses the contructor from the parent class
        {
            months = 60;// assigns the payment period to 5 years by  default 
        }

        public VehicleLoan(string model, string make, double insurancePremium, string merchant, string description, DateTime date, double purchasePrice, double deposit, double interestRate) : base(description, date, purchasePrice, deposit, interestRate)
        {//contructor, base uses the contructor from the parent class
            this.description = description;
            this.date = date;
            this.purchasePrice = purchasePrice;
            this.deposit = deposit;
            this.interestRate = interestRate;
            months = 60;
            this.model = model;//child attributes
            this.merchant = merchant;
            this.make = make;
            this.insurancePremium = insurancePremium;
        }

        public double InsurancePremium { get => insurancePremium; set => insurancePremium = value; }//gets and sets for the Vehicle loan class attributes
        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }
        public string Merchant { get => merchant; set => merchant = value; }
    }
}
