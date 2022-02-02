using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Montly Budget Calculator";//setting the title of the application window



            Console.ReadKey();//this is just to close the application at the end of the user experiance
        }        
    }
    public class Questionair //this is to store all the questions as methods for more effective calling
    {
        public float IncomeAfterTax;
        public float LivingCost;

        public void IncomeAfterTaxQuestion()//creating the question to store the users income
        {
            Console.Write("What is your monthly income after tax? £");
            answer = Console.ReadLine();
        }
        public void LivingCostQuestion()//creating a question to store the users total living bills
        {

        }
    }
}
