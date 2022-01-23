using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    internal class Program
    {
        //This program is super simple, not much to it. Just a little convenient tool that someone like me uses
        //because I dont have much money

        //storing Variables
        float IncomeAfterTax;
        float HousingCost; 
        float UtiliyCost;  
        float CarFinance;  
        float CarInsurance; 
        float MotorCycleFinance; 
        float MotorcycleInsurance; 
        float CreditCostPM;
        float AverageFuelPM;
        float Savings;
        float PlannedSpending;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your handy monthly budget calculator\n" +
                "Lets start with a couple questions about numbers to get an idea of your monthly budget.");

            Console.ReadKey();
        }
    }
}
