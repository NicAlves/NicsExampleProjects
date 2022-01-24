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
        static float IncomeAfterTax;
        static float HousingCost;
        static float UtiliyCost;
        static float CarFinance;
        static float CarInsurance;
        static float MotorCycleFinance;
        static float MotorcycleInsurance;
        static float CreditCostPM;
        static float AverageFuelPM;
        static float Savings;
        static float PlannedSpending;

        static void Questionair()
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

            //Gather the monthly cost for Car finance
            Console.WriteLine("What is the payment on your car?  ");
            CarFinance = float.Parse(Console.ReadLine());

            //Gather the monthly cost for car insurance
            Console.WriteLine("What is your monthly payment on car insurance?  ");
            CarInsurance = float.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a motorcycle? yes or no?");
            string OwnMotorcycle = Console.ReadLine();

            if (OwnMotorcycle != null || OwnMotorcycle == "yes")
            {
                //Gather the monthly cost of MotorCycle finance payments
                Console.WriteLine("How much do you pay for motorcycle finance?  ");
                MotorCycleFinance = float.Parse(Console.ReadLine());

                //Gather the monthly cost of MotorCycle Insurance payments               
                Console.WriteLine("How much do you pay for motorcycle insurance?  ");
                MotorcycleInsurance = float.Parse(Console.ReadLine());

            }
            else
            {
                return;
            }

            //Gather the monthly cost of credit payments
            Console.WriteLine("What is your monthly cost of credit payments  ");
            CreditCostPM = float.Parse(Console.ReadLine());

            //Gather the average fuel spending P/M
            Console.WriteLine("What is your monthly average spent on fuel?  ");
            AverageFuelPM = float.Parse(Console.ReadLine());

            //Gather planned spending
            Console.WriteLine("Do you have any planned spending this month? like a gift or something?  ");
            PlannedSpending = float.Parse(Console.ReadLine());


        }

        static void TestValues()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            //testing to make sure the values display correctly
            Console.WriteLine("£" + IncomeAfterTax);
            Console.WriteLine("£" + HousingCost);
            Console.WriteLine("£" + UtiliyCost);
            Console.WriteLine("£" + CarFinance);
            Console.WriteLine("£" + CarInsurance);
            Console.WriteLine("£" + MotorCycleFinance);
            Console.WriteLine("£" + MotorcycleInsurance);
            Console.WriteLine("£" + CreditCostPM);
            Console.WriteLine("£" + AverageFuelPM);
            Console.WriteLine("£" + Savings);
            Console.WriteLine("£" + PlannedSpending);
        }

        static void TotalBills()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            float TotallBills = IncomeAfterTax - (HousingCost + UtiliyCost + CarFinance + CarInsurance + MotorCycleFinance + MotorcycleInsurance + CreditCostPM + AverageFuelPM + PlannedSpending);
            string TotalBillsString = Convert.ToString(TotallBills);

            Console.WriteLine("Your Total spending on bills is: " + TotalBillsString);
        }

        static void Main(string[] args)
        {
            Console.Title = "MontlyBudgetCalculator";

            Questionair();

            TotalBills();   

            TestValues();  

            Console.ReadKey();
        }        
    }
}
