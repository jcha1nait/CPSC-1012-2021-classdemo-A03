using System;

namespace HighLowGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //driver

            //any local variable within a menu is "alive" only as long as the method is "alive"
            //variables between method may have the same name BUT are local to the method the variable exists in (term is called: scope)
            string inputTemp = "";
            int lowerRange = 1;
            int highRange = 10;

            string guessResult = "";
            int target = 0;
            Random rnd = new Random();
            do
            {
                inputTemp = DisplayMenu();
                switch (inputTemp.ToLower())
                {
                    case "a":
                        {

                            //prompt for the game's lower range
                            lowerRange = InputNumeric("Enter the number for the lower range limit");
                            //prompt for the game's higher range
                            highRange = InputNumeric("Enter the number for the higher range limit");

                            Console.WriteLine($"Your range is from {lowerRange} to {highRange}");
                            //could test to see if lower + 1 < higher
                            //ensures that you  have a spread of 3 possible numbers (lower 4, upper 6)
                            //ensures that the player did not enter the high number then the low number just to mess up your program

                            break;
                        }
                    case "b":
                        {   
                            //scope: within the case coding block
                            int guessCount = 0;
                            
                            // a ramdom number within the range
                            target = rnd.Next(lowerRange, highRange + 1);
                            
                            while (!guessResult.Equals("Correct"))
                            {
                                guessCount++;
                                guessResult = MakeGuess(lowerRange, highRange, target);
                                if (!guessResult.Equals("Correct"))
                                {
                                    Console.WriteLine($"You did not guess correctly. Your guess is too {guessResult}");
                                }
                                else
                                {
                                    Console.WriteLine($"\nYour guess is correct. The secret number was {target}. You guessed {guessCount} times.\n");
                                }
                            }
                            break;
                        }
                    case "x":
                        {
                            Console.WriteLine("Thank you for playing. Please play again.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu choice. Try again.");
                            break;
                        }
                }
            } while (!inputTemp.ToLower().Equals("x"));
        }

        //A method stub is the method header and any return statement that is required
        //There is no logic in the method stub
        //It is a skeleton setup for the required method
        //This allows the call statement to the method to be coded elsewhere in your program
        //so the program will compile
        static string DisplayMenu ()
        {   
            //methods that return a value are also known as functions
            //methods that do not return a value are also known as subroutines
            //string inputTemp = "";
            Console.WriteLine("\nHigh/Low Guessing Game\n");
            Console.WriteLine("a) Set range");
            Console.WriteLine("b) Play game");
            Console.WriteLine("x) Exit\n");
            Console.Write("Enter your menu choice: ");
            //inputTemp = Console.ReadLine();
            //return inputTemp;
            return Console.ReadLine();
        }

        static int InputNumeric (string prompt)
        {
            string inputTemp = "";
            int aNumber = 0;

            //you might see logic that sets a boolean value (commonly call a flag)
            //and the loop condition tests to see if the boolean indicates another iteration is required
            bool flag = false;

            while (flag == false)   
            {
                Console.Write($"{prompt}:\t");
                inputTemp = Console.ReadLine();

                //xxx.TryParse(input string, output conversion variable)
                //returns true if successful and does the conversion
                //returns false if not able to convert and does not do the conversion
                if (int.TryParse(inputTemp, out aNumber))
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine($"Your input of >{inputTemp} is not a whole number (ex. 5)");
                    flag = false;
                }
            }

            return aNumber;
        }

        static string MakeGuess (int low, int high, int target)
        {
            int guessNumber = 0;
            string guessResult = "";
            guessNumber = InputNumeric($"Guess a number between {low} and {high}");
            if (guessNumber == target)
            {
                guessResult = "Correct";
            }
            else if (guessNumber < target)
            {
                guessResult = "low";
            }
            else
            {
                guessResult = "high";
            }
            return guessResult;
        }
    }
}
