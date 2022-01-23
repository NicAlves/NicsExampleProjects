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

        void Questionair()
        {
            Console.WriteLine("Welcome to your handy monthly budget calculator\n" +
                "Lets start with a couple questions about numbers to get an idea of your monthly budget.\n" +
                "If you do not pay a particular bill then simply input '0'");

            //Gather the float value for monthly income after tax
            Console.WriteLine("What is your monthly income after tax?  ");
            IncomeAfterTax = float.Parse(Console.ReadLine());

            //Gather the float value for monthly housing cost
            Console.WriteLine("What are you paying for your accomodation? ei rent or mortgage  ");
            HousingCost = float.Parse(Console.ReadLine());

            //Gather the float value for monthy utility costing
            Console.WriteLine("What is your total utility bill cost P/M? Water, Electrics, Gass..  ect?  ");
            UtiliyCost = float.Parse(Console.ReadLine());

            //Gather monthly cost for Car finance
            Console.WriteLine("What is the payment on your car?  ");
            CarFinance = float.Parse(Console.ReadLine());



            Console.ReadKey();
        }

        void Main(string[] args)
        {
            Questionair(); 


        }        
    }
}
