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

            Console.WriteLine("Welcome to your friendly budget Calculator!");

            // Calling/Instantiating the Questionair class in order to be able to use all within it!
            Questionair InstQuestionair = new Questionair();
            InstQuestionair.IncomeAfterTaxQuestion();
            InstQuestionair.LivingCostQuestion();

            Console.ReadKey();//this is just to close the application at the end of the user experiance
        }        
    }
    public class Questionair //this is to store all the questions as methods for more effective calling
    {
        //Storing Values in for use in the calculations
        public float IncomeAfterTax;
        public float LivingCost;

        public void IncomeAfterTaxQuestion()//creatsdaing the question to store the users income
        {
            Console.Write("What is your monthly income after tax?   £");
            IncomeAfterTax = float.Parse(Console.ReadLine());
        }
        public void LivingCostQuestion()//creating a question to store the users total living bills
        {
            Console.Write("What is your monthly living costs? i.e Rent, Utility and food?   £");
            LivingCost = float.Parse(Console.ReadLine());
        }
    }
}
