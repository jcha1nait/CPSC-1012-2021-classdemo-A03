using System;

namespace LoopProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            string inputTemp;
            int mySquare = 0;
            int sumSquares = 0;


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

            //        pre - test loop
            //        int loopCount = 1;
            //        string message = "";
            //        while (loopCount <= mySquare)
            //        {
            //            message = message + $"{loopCount}x{loopCount}+";
            //            sumSquares += (int)Math.Pow(loopCount, 2);
            //            loopCount++;
            //        }
            //        using the string methods called Substring() and Length()
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

            //2.
            //Write a progra that reads in a value N and then prints its digits in a column, starting
            //with the last digits E.g. if N = 3456, then the program should print out the following:
            //6
            //5
            //4
            //3
            Console.Write("Enter a number and display digits in reverse order:\t");
            inputTemp = Console.ReadLine();
            int aNumber;
            if (int.TryParse(inputTemp,out aNumber))
            {
                int aNumberLength = inputTemp.Length;

                //use the for{...} loop syntax
                //the for loop is a pre-test structure
                //for(declare loop counter; end condition; increment/decrement)
                //{
                //  coding block
                //}
                for (int loopCounter = aNumberLength - 1; loopCounter >= 0; loopCounter--)
                {
                    Console.WriteLine($"{inputTemp.Substring(loopCounter, 1)}");
                }
            }
            else
            {
                Console.WriteLine($"{inputTemp} is invalid. Enter a number.");
            }
        }
    }
}
