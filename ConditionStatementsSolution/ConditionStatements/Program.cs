using System;

namespace ConditionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int MIN_NUMBER = 1;
            //const int MAX_NUMBER = 9;

            //Random keyrad = new Random();

            //int number1 = keyrad.Next(MIN_NUMBER, MAX_NUMBER + 1);
            //int number2 = keyrad.Next(MIN_NUMBER, MAX_NUMBER + 1);

            //Console.Write($"THe sum of {number1} + {number2} = ?\t");

            //string inputTemp = Console.ReadLine();
            //int answer = int.Parse(inputTemp);
            ////int answer = int.Parse(Console.ReadLine());

            ////the conditional test is {(number1 + number2} == answer}
            ////where the left argument is (number1 + number2)
            ////the relational operator is == (equals)
            ////the right argument is answer
            ////this condition will result in true or false
            //Console.WriteLine($"{number1} + {number2} = {answer}" +
            //    $" your answer is {(number1 + number2) == answer}");

            ////the one-way if statement
            ////has only a true path
            //double radius = 4.5;
            //if (radius>0)
            //{
            //    double area = Math.Pow(radius, Math.PI);
            //    Console.WriteLine($"The area of a circle with a radius of {radius} is {area}.");
            //}

            ////a two-way if statement
            ////has a true path and a false path
            ////the true path is coded first
            ////the false path is coded second
            ////the true path coding block is separated from the false path
            ////coding block by the key word -> else
            //if (radius > 0)
            //{
            //    double area = Math.Pow(radius, Math.PI);
            //    if (area >= 100.0)
            //    {
            //        //true path
            //        //executed when the condition resolves to the boolean value TRUE
            //        Console.WriteLine($"The area of a circle with a radius of {radius} is {Math.Round(area,2)}. Your radius is big enough.");

            //        //at the end of this TRUE coding block you exit to the
            //        //next statement AFTER the end of the if
            //    }   //this closing bracket indicates the end of the two-way if
            //    else
            //    {
            //        //false path
            //        //executed when the condition resolves to the boolean value FALSE
            //        Console.WriteLine($"The area of a circle with a radius of {radius} is {Math.Round(area, 2)}. Increase the size of your radius.");
            //    }
            //    Console.WriteLine("This is the next statement after the two-way if.");

            ////Nested If algorithm
            ////a nested if is an if statement within an if statement
            //string inputTemp1 = "";
            //string racerName1;                          //just declared
            //string racerName2, racerName3;              //just declared
            //double racerTime1 = 0.0;                    //declared and assigned
            //double racerTime2 = 0.0, racerTime3 = 0.0;  //declared and assigned
            //string firstPlace, secondPlace, thirdPlace; //just declared

            ////this is technically legal in C#
            //firstPlace = secondPlace = thirdPlace = ""; //variables assigned same value

            //Console.Write("Enter racer 1 name:\t");
            //racerName1 = Console.ReadLine();
            //Console.Write("Enter racer 1 time in minutes (12.3):\t");
            //inputTemp1 = Console.ReadLine();
            //racerTime1 = double.Parse(inputTemp1);
            //Console.Write("Enter racer 2 name:\t");
            //racerName2 = Console.ReadLine();
            //Console.Write("Enter racer 2 time in minutes (12.3):\t");
            ////inputTemp = Console.ReadLine();
            //racerTime2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter racer 3 name:\t");
            //racerName3 = Console.ReadLine();
            //Console.Write("Enter racer 3 time in minutes (12.3):\t");
            //inputTemp1 = Console.ReadLine();
            //racerTime3 = double.Parse(inputTemp1);
            ////conditional logic 
            ////a Nested IF
            ////an IF within another IF

            //if (racerTime1 < racerTime2)
            //{
            //    //racer1 faster than racer2
            //    firstPlace = $"{racerName1} ({racerTime1})";
            //    secondPlace = $"{racerName2} ({racerTime2})";
            //    if (racerTime1 < racerTime3)
            //    {
            //        //racer1 faster than racer3
            //        if (racerTime2 < racerTime3)
            //        {
            //            //racer2 faster than racer3
            //            thirdPlace = $"{racerName3} ({racerTime3})";
            //        }
            //        else
            //        {
            //            //racer3 faster than racer2
            //            thirdPlace = secondPlace;
            //            secondPlace = $"{racerName3} ({racerTime3})";
            //        }
            //    }
            //    else
            //    {
            //        //racer3 faster than racer1
            //        thirdPlace = secondPlace;
            //        secondPlace = firstPlace;
            //        firstPlace = $"{racerName3} ({racerTime3})";


            //        if (racerTime2 < racerTime3)
            //        {
            //            if (racerTime1 < racerTime3)
            //            {
            //                thirdPlace = $"{racerName3} ({racerTime3})";
            //            }
            //            else
            //            {
            //                thirdPlace = secondPlace;
            //                secondPlace = $"{racerName3} ({racerTime3})";
            //            }
            //        }
            //        else
            //        {
            //            thirdPlace = secondPlace;
            //            secondPlace = firstPlace;
            //            firstPlace = $"{racerName3} ({racerTime3})";
            //        }
            //    }
            //}
            //else
            //{
            //    //racer2 faster than racer1
            //    firstPlace = $"{racerName2} ({racerTime2})";
            //    secondPlace = $"{racerName1} ({racerTime1})";
            //}

            //Console.WriteLine($"First place {firstPlace}\n");
            //Console.WriteLine($"Second place {secondPlace}\n");
            //Console.WriteLine($"Third place {thirdPlace}\n");
            //}

            //int testScore = 75;

            ////coded using a nested if statement
            //if (testScore < 50)
            //{
            //    Console.WriteLine("Your grade is an F.");
            //}
            //else
            //{
            //    if(testScore < 60)
            //    {
            //        Console.WriteLine("Your Grade is a D.");
            //    }
            //    else
            //    {
            //        if (testScore < 70)
            //        {
            //            Console.WriteLine("Your grade is a C.");
            //        }
            //        else
            //        {
            //            if (testScore < 80)
            //            {
            //                Console.WriteLine("Your grade is a B.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Your grade is an A.");
            //            }
            //        }
            //    }
            //}

            ////using an if else if structure
            //if (testScore < 50)
            //{
            //    Console.WriteLine("Your grade is an F.");
            //}
            //else if (testScore < 60)
            //{
            //    Console.WriteLine("Your Grade is a D.");
            //}
            //else if (testScore < 70)
            //{
            //    Console.WriteLine("Your grade is a C.");
            //}
            //else if (testScore < 80)
            //{
            //    Console.WriteLine("Your grade is a B.");
            //}
            //else
            //{
            //    Console.WriteLine("Your grade is an A.");
            //}//end of if structure


            ////Weather Translation
            //int fahrenheitTemp = 75;
            //int celsiusTemp = 0;

            //celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;

            //if (celsiusTemp < 0)
            //{
            //    Console.WriteLine("It's freezing out!");
            //}
            //else if (celsiusTemp < 15)
            //{
            //    Console.WriteLine("Wear a jacket");
            //}
            //else if (celsiusTemp < 30)
            //{
            //    Console.WriteLine("It's a lovely day!");
            //}
            //else
            //{
            //    Console.WriteLine("It's finally summer!");
            //}//end of if structure

            //practice logical operators
            string inputTemp;
            Console.Write("Enter an integer:\t");
            inputTemp = Console.ReadLine();
            int number = int.Parse(inputTemp);

            ////&& test
            ////all conditions must be true to execute the true path
            ////if any of your conditions are false it will execute the false path
            //if (number % 2 == 0 && number % 3 == 0)
            //{
            //    Console.WriteLine($"{number} is divisible by 2 or 3.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not divisible by 2 or 3.");
            //}

            ////|| test
            ////One of the conditions must be true to execute the true path
            ////if all of your conditions are false it will execute the false path
            //if (number % 2 == 0 || number % 3 == 0)
            //{
            //    Console.WriteLine($"{number} is divisible by 2 or 3.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not divisible by 2 or 3.");
            //}

            ////combining && and ||
            ////when combining conditions it is important that you bracket appropriately
            ////Yes
            ////T || T && T
            ////F || T && T
            ////T || F && T
            //if ((number % 2 == 0 || number % 3 == 0) && number < 10)
            //{
            //    Console.WriteLine($"{number} is divisible by 2 or 3 and is less than 10.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not divisible by 2 or 3 and is not less than 10.");
            //}


            //Case Structure
            //examines a value/expression against another value in the == scenario
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine($"You entered a number for 1 to 3: {number}");
                        break;//break takes you to the next executable statement after the switch
                    }
                case 2:
                    {
                        Console.WriteLine($"You entered a number for 1 to 3: {number}");
                        break;//break takes you to the next executable statement after the switch
                    }
                case 3:
                    {
                        Console.WriteLine($"You entered a number for 1 to 3: {number}");
                        break;//break takes you to the next executable statement after the switch
                    }
                default:
                    {
                        //this last coding block is executed if all other cases have failed
                        Console.WriteLine($"You entered a number outside of 1 to 3: {number}");
                        break;
                    }
            }//eo of switch

            if (number == 1)
            {
                Console.WriteLine($"You entered a number for 1 to 3: {number}");
            }
            else if (number == 2)
            {
                Console.WriteLine($"You entered a number for 1 to 3: {number}");
            }
            else if (number == 3)
            {
                Console.WriteLine($"You entered a number for 1 to 3: {number}");
            }
            else
            {
                Console.WriteLine($"You entered a number outside of 1 to 3: {number}");
            }
        }
    }
}
