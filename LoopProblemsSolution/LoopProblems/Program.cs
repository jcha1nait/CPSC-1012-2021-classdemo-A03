using System;

namespace LoopProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.
            //string inputTemp;
            //int mySquare = 0;
            //int sumSquares = 0;


            //Console.WriteLine("Please enter a number and find out its sum of squares:\t");
            //inputTemp = Console.ReadLine();
            ////
            ////Validate the incoming value
            ////
            ////tryParse takes the input string and attempts to convert the string
            ////to the requested numeric datatype
            ////if the attempt is good then the value is placed in the out variable AND a true is returned
            ////
            //if (int.TryParse(inputTemp, out mySquare))
            //{
            //    if (mySquare > 0)
            //    {
            //        //    //one needs to do the iteration at least once, seems a good candidate for a post-test loop
            //        //    int loopCount = 1;
            //        //    do
            //        //    {
            //        //        sumSquares += loopCount * loopCount;
            //        //        //sumSquares += (int)Math.Pow(loopCount, 2);

            //        //        loopCount++;
            //        //    } while (loopCount <= mySquare);
            //        //    Console.WriteLine($"The sum of squares from 1 to {mySquare} is {sumSquares}.");

            //        //pre - test loop
            //        int loopCount = 1;
            //        string message = "";
            //        while (loopCount <= mySquare)
            //        {
            //            message = message + $"{loopCount}x{loopCount}+";
            //            sumSquares += (int)Math.Pow(loopCount, 2);
            //            loopCount++;
            //        }
            //        //using the string methods called Substring() and Length()
            //        int msgLength = message.Length;
            //        message = message.Substring(0, msgLength - 1);

            //        Console.WriteLine($"The sum of squares for {mySquare} is {message} = {sumSquares}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{inputTemp} is invalid. Enter a positive number.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid. Enter a number.");
            //}

            ////2.
            ////Write a program that reads in a value N and then prints its digits in a column, starting
            ////with the last digits E.g. if N = 3456, then the program should print out the following:
            ////6
            ////5
            ////4
            ////3
            //Console.Write("Enter a number and display digits in reverse order:\t");
            //inputTemp = Console.ReadLine();
            //int aNumber;
            //if (int.TryParse(inputTemp, out aNumber))
            //{
            //    int aNumberLength = inputTemp.Length;

            //    //use the for{...} loop syntax
            //    //the for loop is a pre-test structure
            //    //for(declare loop counter; end condition; increment/decrement)
            //    //{
            //    //  coding block
            //    //}
            //    for (int loopCounter = aNumberLength - 1; loopCounter >= 0; loopCounter--)
            //    {
            //        Console.WriteLine($"{inputTemp.Substring(loopCounter, 1)}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid. Enter a number.");
            //}

            //MoneyMaker
            //This program will accept a principal investment amoun, a monthly interest rate,
            //and a investment time in months.
            //This program will display a monthly investment report using the incoming data
            //This program will continue until the user enters an x to exit.

            //process: declare / assignment starting variables
            //         request execution or exit from the user
            //              on exit terminate program
            //              on execution
            //                  input investment values
            //                  iternate monthly earnings and report
            //                  on termination of investment period, display a summary

            //this example is one of using nested loops
            //menu is a good candidate for a post-test loop
            //investment loop is a good candidate for a pre-test loop using a for () loop
            // output will demonstrate formatting of values and columns

            decimal myPrincipal = 0.0m; //the m "types" this numeric as a decimal
            decimal myMonthlyInterestRate = 0.0m;
            Int32 myInvestmentTime = 0; //Int32 is equivalent to int

            string menuChoice = "";

            do
            {
                Console.WriteLine("Welcome to CPSC Investments:\n\n");
                Console.WriteLine("a) investment:");
                Console.WriteLine("x) to exit\n");
                Console.Write("Enter your menu choice:\t");
                menuChoice = Console.ReadLine();

                switch (menuChoice.ToUpper())
                {
                    case "A":
                        {
                            //for this example, I will assume valid data is entered.
                            Console.Write("\nEnter your principal investment amount:\t");
                            string inputTemp = Console.ReadLine();
                            myPrincipal = decimal.Parse(inputTemp);
                            Console.Write("\nEnter your investment monthly rate (3% -> 0.03):\t");
                            inputTemp = Console.ReadLine();
                            myMonthlyInterestRate = decimal.Parse(inputTemp);
                            Console.Write("\nEnter your investment period in months:\t");
                            inputTemp = Console.ReadLine();
                            myInvestmentTime = Int32.Parse(inputTemp);

                            //use a loop for a fixed amount of iterations
                            //best candidate would be a pre-test loop
                            // a) While with a counter
                            // b) for (...) loops
                            for (int counter = 0; counter < myInvestmentTime; counter++)
                            {
                                // the {0} is referred to as a placeholder
                                // the string.Format(format pattern, value for the pattern)
                                // the pattern in this case is currency and the 0 indicates a placeholder for the value
                                // in the .Format method
                                Console.WriteLine("\nOpening; {0}", string.Format("{0:c}", myPrincipal));

                                //.ToString("pattern")
                                //# indicates a digit position and is optional, printed if NOT zero (0)
                                //0 indicates a digit position and is required, zeroes are printed
                                Console.Write("Interest Paid: {0}\t", (myPrincipal * myMonthlyInterestRate).ToString("$###,##0.00"));
                                myPrincipal += myPrincipal * myMonthlyInterestRate;

                                //{variable,xcolumnwidth:pattern}
                                // in this case the variable is myPrincipal, x column width is 15 spaces,
                                // positive value is right alligned, negative value is left alligned.
                                // c stands for currency with a $ sign
                                Console.Write($"Closing: {myPrincipal,15:c}\n");

                            }

                            Console.WriteLine($"Closing {myPrincipal.ToString("c"),20}");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("\nThank you. Good bye.\n");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nYour input for the menu choice is invalid. Try again.\n");
                            break;
                        }
                }

            } while (menuChoice.ToLower() != "x");
            string msg = "Good luck on your future investments.";
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine($"\n{msg}\n");
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write("*");
            }

            ////Bacterial Looping Problem
            //string inputTemp;
            //double finalPopulation = 0.0;
            //double initialPopulation = 0.0;
            //double growthRate = 0.0;
            //const int MAXDAYS = 10;


            ////will need the Math library value for e (2.71828)
            //Console.Write("Enter your initial bacterial population:\t");
            //inputTemp = Console.ReadLine();
            //if (double.TryParse(inputTemp, out initialPopulation))
            //{
            //    Console.Write("Enter your bacterial growth rate as a percentage (3% = 3.0):\t");
            //    inputTemp = Console.ReadLine();
            //    if (double.TryParse(inputTemp, out growthRate))
            //    {
            //        growthRate /= 100.0;
            //        //we have a known number of iterations
            //        //create column headers and report title
            //        Console.WriteLine($"Bacterial Growth Rate for {initialPopulation} on {MAXDAYS} growth.\n");
                    
            //        for (int i = 1; i <= MAXDAYS; i++)
            //        {
            //            finalPopulation = initialPopulation * Math.Pow(Math.E, (growthRate * (double)i));
            //            Console.WriteLine($"{i,5} {finalPopulation,25:0.000}");
            //            //Console.WriteLine("{0,5} {1,25:0.000}", i, finalPopulation);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Invalid growth rate input {inputTemp}; not a valid numeric.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Invalid input {inputTemp}; not a valid numeric.");
            //}
        }
    }
}
