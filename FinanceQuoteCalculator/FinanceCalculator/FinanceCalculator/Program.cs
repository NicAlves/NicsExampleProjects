using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCalculator
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Finance Calculator";
            Questionair questionair = new Questionair();

            questionair.SalaryQuestion();
            
            Console.ReadKey();
        }
    }
    public class Questionair
    {
        public int Age;
        public float Salary;
        public float LoanAmount;
        public int loanDuration;
        public float InterestRate;

        public void AgeQuestion() //Gather the value for Age
        {
            Console.WriteLine("How old are you?");
            int Age = Convert.ToInt32(Console.ReadLine());
            
            if (Age >= 18) //if they are old enough they may continue
            {
                Console.WriteLine("Sweet");
            }
            else //If the user is not old enough the question is repeated
            {
                Console.WriteLine("You are not old enough to recieve a loan from us. Sorry!\n" +
                    "Did you type your correct age?"); //checking if the user inputed the value correctly
                string AgeAnswer = Console.ReadLine();

                if (AgeAnswer == "no") //allows the user to try again
                {
                    Console.WriteLine("Lets try again shall we!");
                    AgeQuestion();
                }
                else //Exits the application
                {
                    Environment.Exit(0);
                }
            } 
        }
        public void SalaryQuestion() //Gather the value for Salary
        {
            Console.WriteLine("What is your annual average income?");
            float Salary = float.Parse(Console.ReadLine());

            if (Salary >= 14000)
            {
                Console.WriteLine("Perfect");
            }
            else
            {
                Console.WriteLine("Did you input the right value?");
                string SalaryAnswer = Console.ReadLine();
                if (SalaryAnswer == "yes")
                {
                    Console.WriteLine("Sorry you dont qualify for a loan.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Okay lets try agian!");
                    SalaryQuestion();
                }
            }
        }
        public void LoanAmountQuestion() //Gather the value for LoanAmount
        {
            Console.WriteLine("How much would you like to borrow?");
        }
        public void LoanDurationQuestion() //Gather the value for LoanDuration
        {
            Console.WriteLine("How long in months would you like to take the loan out for?");
        }
    }
}
