using System;

namespace InputOutputMath
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Implement a temperature converter from
             * Celsius to Fahrenheit
             * 
             * Jan 2021
             */

            /*
             * input: Celsius temperature
             *        string inputTemp
             *        double theCelsiusTemp
             * output: Fahrenheit temperature
             *         double theFahrenheitTemp
             * expression (calculate): (theCelsiusTemp * (9.0/5.0)) + 32
             * check with theCelsiusTemp = 0 expect theFahrenheitTemp = 32
             * check with theCelsiusTemp = 100 expect theFahrenheitTemp = 212
             * check with theCelsiusTemp = -40 expect theFahrenheitTemp = -40
             */

            //prompt for a Celsius temperature
            //.Write() keeps your cursor on the same line
            Console.Write("Enter a Celsius temperature: ");

            //How does the program pull in the entry from the user
            //To obtain the key strokes that the user types (input)
            // .ReadLine()
            //IMPORTANT data comes into the program as a string
            //DOES NOT matter if you enter a number, it is treated as a string
            
            //declare the variable: datatype variablename;
            string inputTemp;
            //assignment statement: expression on the right is placed into the variable on the left
            //expression (action): read the user input
            //you could do both statements on one line
            //string inputTemp = Console.ReadLine();
            inputTemp = Console.ReadLine();

            //currently the celsius value is a string
            //the value needs to be converted to a number to be used in a math calculation
            //convert the data to a different datatype
            //to do this; you will use technique called parsing
            //syntax: datatypeTo.Parse(string value)

            //WARNING: I am assuming the user will enter valid data
            //If the user does not enter a number, this program will abort on the execution of this line
            double theCelsiusTemp = double.Parse(inputTemp);

            //calculation using the conversion expression
            double theFahrenheitTemp =
                   (theCelsiusTemp * (9.0 / 5.0)) + 32;

            //output
            //.WriteLine() which automatically goes to the next line
            Console.WriteLine($"The Celsius temperature is: {theCelsiusTemp}");
            Console.WriteLine($"The Fahrenheit temperature is: {theFahrenheitTemp}");
        }
    }
}
