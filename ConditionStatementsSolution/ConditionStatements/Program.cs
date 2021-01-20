using System;

namespace ConditionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 9;

            Random keyrad = new Random();

            int number1 = keyrad.Next(MIN_NUMBER, MAX_NUMBER + 1);
            int number2 = keyrad.Next(MIN_NUMBER, MAX_NUMBER + 1);

            Console.Write($"THe sum of {number1} + {number2} = ?\t");

            string inputTemp = Console.ReadLine();
            int answer = int.Parse(inputTemp);
            //int answer = int.Parse(Console.ReadLine());

            //the conditional test is {(number1 + number2} == answer}
            //where the left argument is (number1 + number2)
            //the relational operator is == (equals)
            //the right argument is answer
            //this condition will result in true or false
            Console.WriteLine($"{number1} + {number2} = {answer}" +
                $" your answer is {(number1 + number2) == answer}");
        }
    }
}
