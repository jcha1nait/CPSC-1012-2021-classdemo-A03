using System;

namespace BasicProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //West Coast Sales
            //declare 3 double variables
            //Assign value to SalesUnitPercentage
            //Asiggn value to totalSales
            //Calculate totalSalesofSalesUnits = totalSales * SalesUnitPercentage / 100
            //Display calculated value

            double SalesUnitPercentage = 43.0;
            double totalSales = 5.3;
            double totalSalesofSalesUnits;

            totalSalesofSalesUnits = (totalSales * SalesUnitPercentage) / 100;

            Console.WriteLine($"The West Coast sales unit generated {Math.Round(totalSalesofSalesUnits,2)} million in revenue this year.");

            //Land Calculator
            //declare 4 double variables
            //declare string variable for user input
            //Prompt and read value for user input
            //Convert user input value into double datatype
            //Calculate landvalue = AcreSize/AcretoFeet * feetValue
            //display calculated value

            double AcreSize = 1.0;
            double AcretoFeet = 43560.0;
            double feetValue;
            double landValue;

            string inputFeet;
            Console.Write("How big is the size of the land in square feet?\t");
            inputFeet = Console.ReadLine();

            feetValue = double.Parse(inputFeet);

            landValue = (AcreSize / AcretoFeet) * feetValue;

            Console.WriteLine($"The size of the land of {feetValue} square feet in acres is {Math.Round(landValue,2)} acres.");

            //Calories Consumed
            //declare 3 int variables and 4 double variables
            //Calculate totalCalories = ServingsValue * CalorieValue
            //declare string value for user input
            //Prompt and read value for user input
            //Convert user input value into double datatype
            //Calculate servingsEaten = cookiesEaten*ServingsValue / TotalCookies
            //Calculate caloriesConsumed = servingsEaten*totalCalories / ServingsValue
            //use a two way if condition statement to display calculated value depending on the value of user input
            int TotalCookies = 26;
            int ServingsValue = 10;
            int CalorieValue = 175;
            double cookiesEaten;
            double servingsEaten;
            double caloriesConsumed;
            double totalCalories = ServingsValue * CalorieValue;

            string inputCookies;
            Console.Write("How many cookies have you eaten?\t");
            inputCookies = Console.ReadLine();

            cookiesEaten = double.Parse(inputCookies);

            servingsEaten = (cookiesEaten * ServingsValue) / TotalCookies;
            caloriesConsumed = (servingsEaten * totalCalories) / ServingsValue;

            if (cookiesEaten >= 0)
            {
                if (cookiesEaten == 1)
                {
                    Console.WriteLine($"The amount of calories consumed if you ate {cookiesEaten} cookie is {caloriesConsumed} calories.");
                }
                else
                {
                    Console.WriteLine($"The amount of calories consumed if you ate {cookiesEaten} cookies is {caloriesConsumed} calories.");
                }
            }

            



        }
    }
}
