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

            Questionair questionair = new Questionair(); //to instantiate the Questionair Class
            Calculations calculations = new Calculations(); //to instantiate the Calculations Class

            questionair.AgeQuestion();
            Console.Clear();
            questionair.SalaryQuestion();
            Console.Clear();
            questionair.LoanAmountQuestion();
            Console.Clear();
            questionair.LoanDurationQuestion();
            Console.Clear();
            questionair.InterestCalculator();
            Console.Clear();
            calculations.Quote();

            Console.ReadKey(); //Just to close the console on keypress at the end
        }
    }   

    public class Questionair
    {
        public int Age;
        public float Salary;
        public float LoanAmount;
        public int loanDurationInMonths;
        public float InterestRate;

        public void AgeQuestion() //Gather the value for Age
        {
            Console.WriteLine("How old are you?");
            Age = Convert.ToInt32(Console.ReadLine());
            
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
            Salary = float.Parse(Console.ReadLine());

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
            LoanAmount = float.Parse(Console.ReadLine());

            if (LoanAmount > Salary)
            {
                Console.WriteLine("Sorry but that loan amount is too much.\n" +
                    "Would you like to enter in a new value?");
                string LoanAmountAnswer = Console.ReadLine();

                if (LoanAmountAnswer == "yes")
                {
                    Console.WriteLine("Lets try again shall we?");
                    LoanAmountQuestion();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Sweet lets continue!");
            }
        }
        public void LoanDurationQuestion() //Gather the value for LoanDuration
        {
            Console.WriteLine("How long in months would you like to take the loan out for?");
            loanDurationInMonths = int.Parse(Console.ReadLine());

            if (loanDurationInMonths > 60)
            {
                Console.WriteLine("Sorry but we do not offer loans over more than a 60 month period of time\n" +
                    "Would you like to enter a new value in?");
                string LoanDurationAnswer = Console.ReadLine();

                if (LoanDurationAnswer == "yes")
                {
                    Console.WriteLine("Sweet lets try again!");
                    LoanDurationQuestion();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
        public void InterestCalculator() //a simple system to determine interest rate
        {
            //Console.WriteLine("So your interest rate will be:");
            

            if (Age >= 18 && Age < 21)
            {
                InterestRate = 0.26f;
            }
            else if (Age >= 21 && Age < 24)
            {
                InterestRate = 0.20f;
            }
            else if (Age >= 24 && Age < 35)
            {
                InterestRate = 0.15f;
            }
            else if (Age >= 35)
            {
                InterestRate = 0.10f;
            }
            //float InterestRateAnswer = InterestRate * 100; 

            //Console.WriteLine(InterestRateAnswer + "%");
        } 
        
    }
    public class Calculations //A place to store all the calculation types for this program
    {
        public float QuoteAmount;

        public void Quote()
        {
            Questionair questionair = new Questionair();

            QuoteAmount = questionair.LoanAmount + (questionair.LoanAmount * questionair.InterestRate);

            Console.WriteLine("You quotation: £" + QuoteAmount);
        }
    }
}
