using System;

#region Additional Namespaces
using System.Collections.Generic; //needed for List<T>
using static System.Console; //needed for WriteLine, ReadLine, Write
#endregion


namespace CollectionDemo
{
    class Program
    {   
        //entry point into your console application software
        static void Main(string[] args)
        {
            //BasicsOfLists();

            //using composite classes
            //class Room
            //  within the class: Wall, Opening, List<T>

            //create a collection of Walls for the room
            //when the List<T> is created, the instance will be empty (count = 0)
            List<Wall> Walls = new List<Wall>();
            Walls = InputWallsForRoom();
            List<Opening> Openings = new List<Opening>();
        }

        static void BasicsOfLists()
        {
            //declare a List<T> where <T> is the datatype
            List<int> setOfNumbers = new List<int>();
            //add element to a list
            setOfNumbers.Add(55);
            setOfNumbers.Add(41);
            setOfNumbers.Add(100);
            int number = 78;
            setOfNumbers.Add(number + 1);

            //display the current number of items in the list .Count
            WriteLine($"The list contains {setOfNumbers.Count} elements");

            //traverse a list <T>
            for (int i = 0; i < setOfNumbers.Count; i++)
            {
                WriteLine($"The list item {i + 1} is {setOfNumbers[i]}");
            }

            //Sort a list
            //"for two elements x and y do the following"
            //"=>" means do the following
            //ascending sort is x vs y
            //descending sort is y vs x
            setOfNumbers.Sort((x, y) => x.CompareTo(y));

            //pre-test loop
            //system checks to see if there is an element in the list
            //if there is an element(s) in the list, each element is accessed
            //  one at a time, from start to end, and the element is processed
            //  by the logic in the loop coding block
            //the system checks for the end of the list and stops automatically
            foreach (int listElement in setOfNumbers)
            {
                //while in the loop you reference the current element via your
                //  placeholder(variable)
                WriteLine($"The list item is {listElement}");
            }

            //removing from a list<T>
            setOfNumbers.Remove(number + 1);
        }

        static List<Wall> InputWallsForRoom()
        {   
            //declare a variable capable of holding an instance of
            //  the class Wall;
            Wall aWall = null;
            //you need to create a local List<T> BECAUSE
            //  you DID NOT pass in the collection to be filled
            //you will return the local List<T>
            List<Wall> inputWalls = new List<Wall>();
            bool finished = false;
            do
            {   
                //to create an instance of the class Wall, use the
                //  new operator and the class name.
                aWall = new Wall();
                //obtain the width for the wall
                aWall.Width = GetPositiveDouble("Enter the width of your wall:");
                //obtain the height for the wall
                aWall.Height = GetPositiveDouble("Enter the height of your wall:");
                //add the instance to the wall collection
                inputWalls.Add(aWall);
                if (GetNonEmptyString("Do you have another wall(y/n):").ToUpper() == ("N"))
                {
                    finished = true;
                }
            } while (!finished);
            return inputWalls;
        }

        static double GetPositiveDouble(string prompt)
        {
            double number = 0;
            string inputTemp = null;
            bool valid = false;
            do
            {
                Console.Write($"{prompt}\t");
                inputTemp = Console.ReadLine();
                if (double.TryParse(inputTemp,out number))
                {
                    if (number > 0)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input(must be greater than 0). Try again.");
                    }
                }
                else
                {
                    Console.WriteLine($"Input is invalid {inputTemp}. Try again.");
                }
            } while (!valid);

            return number;
        }

        static string GetNonEmptyString(string prompt)
        {
            string inputTempLocal;
            bool valid = false;

            do
            {
                Console.Write($"\n{prompt}");
                inputTempLocal = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputTempLocal))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("\nThat is not a valid input(can not be empty). Try again.");
                }
            } while (!valid);

            return inputTempLocal;
        }

    }
}
