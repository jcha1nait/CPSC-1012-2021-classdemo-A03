using System;

namespace DecisionMakingProblems1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //declare a double variable
            //declare a string variable for user input
            //Prompt and read value for user input
            //Convert user input value into double variable
            //Declare an if statement as following
            /*if the number is greater than 0
             *  if the number is less than 0
             *      Display that the number is negative
             *  else
             *      Display that the number is positive
             *else
             *  if the number is less than 0
             *      Display that the number is negative
             *  else
             *      Display that the number is equal to zero
            */

            //double number;

            //string inputTemp;
            //Console.Write("Write a number:\t");
            //inputTemp = Console.ReadLine();

            //number = double.Parse(inputTemp);

            //if (number > 0)
            //{
            //    if (number < 0)
            //    {
            //        Console.WriteLine($"{number} is negative.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is positive.");
            //    }
            //}
            //else
            //{
            //    if (number < 0)
            //    {
            //        Console.WriteLine($"{number} is negative.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is zero.");
            //    }
            //}

            //2.
            //Declare 1 int variable and 4 double variables
            //Declare a string variable for user input
            //Prompt and read user input value
            //Convert user input value into int variable
            //Declare an if else if statement as following
            /*if customerAge <= 6
             *Display child price
             *else if customerAge <= 17
             *Display student price
             *else if customerAge <= 54
             *Display adult price
             *else
             *Display senior price
            */

            //double ChildrenPrice = 0.00;
            //double StudentPrice = 9.80;
            //double AdultPrice = 11.35;
            //double SeniorPrice = 10.00;

            //int customerAge;

            //string inputTemp;
            //Console.WriteLine("What is your age:\t");
            //inputTemp = Console.ReadLine();

            //customerAge = int.Parse(inputTemp);

            //if (customerAge <= 6)
            //{
            //    Console.WriteLine($"Your admission price is ${ChildrenPrice}.");
            //}
            //else if (customerAge <= 17)
            //{
            //    Console.WriteLine($"Your admission price is ${StudentPrice}.");
            //}
            //else if (customerAge <= 54)
            //{
            //    Console.WriteLine($"Your admission price is ${AdultPrice}");
            //}
            //else
            //{
            //    Console.WriteLine($"Your admission price is ${SeniorPrice}");
            //}


            //3.
            //declare 1 double variable
            //declare 1 string variable for student's name
            //Prompt and read user input value
            //declare 1 string variable for test score
            //Prompt and read user input value
            //Convert user input value into double variable
            //Declare if statement as following
            /*if testScore<50
             *Display grade is an F
             *else if testScore<70
             *Display grade is a D
             *else if testScore<80
             *Display grade is a C
             *else if testScore<90
             *Display grade is a B
             *else
             *Display grade is an A
            */

            //double testScore;

            //string inputName;
            //Console.WriteLine("What is your name?\t");
            //inputName = Console.ReadLine();

            //string inputTemp;
            //Console.WriteLine("What is your test score:\t");
            //inputTemp = Console.ReadLine();

            //testScore = double.Parse(inputTemp);

            //if (testScore < 50)
            //{
            //    Console.WriteLine($"{inputName} your grade is an F.");
            //}
            //else if (testScore < 70)
            //{
            //    Console.WriteLine($"{inputName} your grade is a D.");
            //}
            //else if (testScore < 80)
            //{
            //    Console.WriteLine($"{inputName} your grade is a C.");
            //}
            //else if (testScore < 90)
            //{
            //    Console.WriteLine($"{inputName} your grade is a B.");
            //}
            //else
            //{
            //    Console.WriteLine($"{inputName} your grade is an A.");
            //}

            //4.
            //declare a 4 double variables
            //for incomeTax1 calculation: 0.00 + (0.05 * taxAmount)
            //for incomeTax2 calculation: 2500.00 + (0.07 * (taxAmount - 50000))
            //for incomeTax3 calculation: 6000.00 + (0.09 * (taxAmount - 100000))
            //declare a string variable for user input
            //Prompt and read user input value
            //Convert user input value into double variable
            //Declare if else if statement as following
            /*if taxAmount <= 50000
             *Display incomeTax1
             *else if taxAmount <= 100000
             *Display incomeTax2
             *else
             *Display incomeTax3
            */


            double taxAmount;

            string inputTemp;
            Console.WriteLine("How much taxable income do you have?\t");
            inputTemp = Console.ReadLine();

            taxAmount = double.Parse(inputTemp);

            double incomeTax1 = 0.00 + (0.05 * taxAmount);
            double incomeTax2 = 2500.00 + (0.07 * (taxAmount - 50000));
            double incomeTax3 = 6000.00 + (0.09 * (taxAmount - 100000));

            if (taxAmount <= 50000)
            {
                Console.WriteLine($"Your income tax due is ${Math.Round(incomeTax1, 2)}.");
            }
            else if (taxAmount <= 100000)
            {
                Console.WriteLine($"Your income tax due is ${Math.Round(incomeTax2, 2)}.");
            }
            else
            {
                Console.WriteLine($"Your income tax due is ${Math.Round(incomeTax3, 2)}.");
            }
        }
    }
}
