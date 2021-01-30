﻿using System;

namespace DecisionMakingProblems2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.
            //char servicePackage;
            //double hoursUsed;
            //double costPackageA;
            //double costPackageB;
            //double costPackageC;

            //string inputPackage;
            //Console.WriteLine("Which service package do you have: A, B, or C\t");
            //inputPackage = Console.ReadLine();
            //servicePackage = char.Parse(inputPackage);

            //string inputTemp;
            //Console.WriteLine("How many hours have you used the ISP?\t");
            //inputTemp = Console.ReadLine();
            //hoursUsed = double.Parse(inputTemp);

            //costPackageA = 9.95 + (2 * (hoursUsed - 10));
            //costPackageB = 13.95 + (1 * (hoursUsed - 20));
            //costPackageC = 19.95;

            //switch (servicePackage)
            //{
            //    case 'A':
            //        if (hoursUsed > 10)
            //        {
            //            Console.WriteLine($"Your bill this month is ${costPackageA}.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your bill this month is $9.95.");
            //        }
            //        break;

            //    case 'B':
            //        if (hoursUsed > 20)
            //        {
            //            Console.WriteLine($"Your bill this month is ${costPackageB}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your bill this month is 13.95");
            //        }
            //        break;
            //    case 'C':
            //        Console.WriteLine($"Your bill this month is ${costPackageC}");
            //        break;
            //    default:
            //        Console.WriteLine("That's not a valid package we have. Please pick between packages A, B, and C.");
            //        break;

            //}

            //2.
            double unitValue;
            double poundsToKilograms;
            double ouncesToLiters;
            double inchesToCentimeters;
            double fahrenheitToCelsius;

            string inputConversion;
            Console.WriteLine("Which unit conversion are you looking for: Pounds to Kilograms," +
                "Ounces to Liters, Inches to Centimeters, or Fahrenheit to Celsius?\t");
            inputConversion = Console.ReadLine();

            string inputTemp;
            Console.WriteLine("What's the value of the unit you would like to convert to:\t");
            inputTemp = Console.ReadLine();

            unitValue = double.Parse(inputTemp);

            poundsToKilograms = unitValue / 2.2046;
            ouncesToLiters = unitValue * 33.8140226;
            inchesToCentimeters = unitValue / 0.39370;
            fahrenheitToCelsius = (unitValue - 32) / 1.800;

            switch (inputConversion)
            {
                case "Pounds to Kilograms":
                    Console.WriteLine($"{unitValue} pounds in kilograms is {Math.Round(poundsToKilograms,2)} kg.");
                    break;
                case "Ounces to Liters":
                    Console.WriteLine($"{unitValue} ounces in liters is {Math.Round(ouncesToLiters,2)} liters.");
                    break;
                case "Inches to Centimeters":
                    Console.WriteLine($"{unitValue} inches in centimeters is {Math.Round(inchesToCentimeters,2)} cm.");
                    break;
                case "Fahrenheit to Celsius":
                    Console.WriteLine($"{unitValue} degrees fahrenheit in celsius is {Math.Round(fahrenheitToCelsius,2)} degrees celsius.");
                    break;
                default:
                    Console.WriteLine("That is not a valid option, please select again.");
                    break;
            }

        }
    }
}
