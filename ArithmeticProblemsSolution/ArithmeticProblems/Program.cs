using System;

namespace ArithmeticProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate mean average
            //declare 4 double variables
            //declare 1 string variable for input
            //prompt, input and convert number; repeat 3 times
            //add numbers together and divide by 3
            //display mean average

            double numberOne;
            double numberTwo;
            double numberThree;
            double meanAverage;

            //Could technically code the above 4 lines on one physical line
            //double numberOne, numberTwo, numberThree, meanAverage
            string inputNumber;
            Console.Write("Enter a real number:\t");
            inputNumber = Console.ReadLine();
            numberOne = double.Parse(inputNumber);
            Console.Write("Enter a real number:\t");
            inputNumber = Console.ReadLine();
            numberTwo = double.Parse(inputNumber);
            Console.Write("Enter a real number:\t");
            inputNumber = Console.ReadLine();
            numberThree = double.Parse(inputNumber);
            meanAverage = (numberOne + numberTwo + numberThree) / 3.0;
            Console.WriteLine($"{numberOne} + {numberTwo} + {numberThree} has an average of {meanAverage}.");
            
            //Practice Math.Round()
            Console.WriteLine($"{numberOne} + {numberTwo} + {numberThree}" +
                $"has an average of of {Math.Round(meanAverage, 2)}");


            //Pythagorean Theorem
            //declare 3 double variables
            //declare 1 string variable for reuse as input variable
            //prompt and read number for height
            //prompt and read number for base
            //calculate hypotenuse (use Math class methods)
            //formula hypotenuse = squareroot(height squared + base squared)
            //display data

            double triangleHeight;
            double triangleBase;
            double hypotenuse;
            Console.Write("enter the triangle''s height;\t");
           
            //declare and assign a value to a variable
            string inputTriangle = Console.ReadLine();
            triangleHeight = double.Parse(inputTriangle);
            Console.Write("enter the triangle''s base;\t");

            //reuse a declared variable and reassign a value to that variable
            inputTriangle = Console.ReadLine();

            triangleBase = double.Parse(inputTriangle);

            //Math.Sqrt() calculates square root value
            //Math.Pow() calculates a value raised to a specific power
            hypotenuse = Math.Sqrt(Math.Pow(triangleHeight, 2) + Math.Pow(triangleBase, 2));
            Console.WriteLine($"The hypotenuse of a triangle with a height of {triangleHeight}" +
                $" and a base of {triangleBase} is {hypotenuse}");

            //Sum Numbers

            //declare 2 integer variable
            //declare 1 string variable for input
            //prompt, input and convert number
            //divide number by 100 and add to sum integer variable
            //get remainder of number divided by 100, divide remainder by 10, add to sum integer
            //get remainder of number divided by 10, add to sum integer 
            //display three numbers and sum

            int inputNumberTemp;
            int totalSum = 0;
            string inputSumNumber;

            Console.Write("Enter a whole number:\t");
            inputSumNumber = Console.ReadLine();
            inputNumberTemp = int.Parse(inputSumNumber);

            //Modulas division to get remainder
            //345 & 100 -> 45 -> 45/10 -> 4
            totalSum += inputNumberTemp / 100;

            totalSum += (inputNumberTemp % 100) / 10;

            //Modulas division to get remainder
            //345%100 -> 45 -> 45%10 -> 5
            totalSum += (inputNumberTemp % 100) % 10;

            Console.WriteLine($"The digits of {inputNumberTemp} sum to {totalSum}");


        }
    }
}
