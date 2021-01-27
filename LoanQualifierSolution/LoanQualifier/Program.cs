using System;

namespace LoanQualifier
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MINWAGEAMOUNT = 30000.00;
            const int MINYEARSWORKED = 2;
            double wageAmount = 30000.00;
            int yearsWorked = 2;


            //Use a nested if statement here
            if (wageAmount < MINWAGEAMOUNT)
            {
                if (yearsWorked < MINYEARSWORKED)
                {
                    Console.WriteLine("You are not qualified for a loan due to low wages and years worked.");
                }
                else
                {
                    Console.WriteLine("You are not qualified for a loan due to low wages.");
                }
            }
            else
            {
                if (yearsWorked < MINYEARSWORKED)
                {
                    Console.WriteLine("You are not qualified for a loan due to low amount of years worked.");
                }
                else
                {
                    Console.WriteLine("You have qualified for a loan, congratulations!");
                }
            }
        }
    }
}
