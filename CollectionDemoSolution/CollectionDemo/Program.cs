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
            List<Opening> Openings = new List<Opening>();
            WriteLine($"Before Load: Number of Walls: {Walls.Count,5} Number of Openings: {Openings.Count,-5}");
            //loading using a returned List<T>
            Walls = InputWallsForRoom();
            //loading using a List<T> as a method parameter argument
            InputOpeningsForRoom(Openings);
            WriteLine($"After Load: Number of Walls: {Walls.Count,5} Number of Openings: {Openings.Count,-5}");

            //create and load a class called Room
            //Room is a composite class
            //a composite class is identified by using other classes within its definition
            string name = GetNonEmptyString("Enter the name of the room:");
            string color = GetNonEmptyString("Enter the color of the room:");
            Room myRoom = null;
            try
            {
                //third way of creating and loading an instance
                //attach a coding block to your new statement
                //it DOES NOT MATTER if your class OR has not got
                //  coded constructors to be able to use this technique
                //NOTE: not well formed if you are trying to use a "greedy" constructor
                myRoom = new Room()
                {   
                    //syntax
                    // class propertyname = value[,]
                    Name = name,
                    Color = color,
                    Walls = Walls,
                    Openings = Openings
                };

                //find the net surface area of the room
                //sum up all the room wall areas
                //sum up all the opening areas
                //surfaceArea = roomSurfaceArea - openingArea
                double wallSurfaceArea = 0.00;
                double openingArea = 0.00;
                //by using the Property Walls in the class Room, we prove
                //  that the List<T> Walls was truly loading to the instance of Room
                foreach (Wall item in myRoom.Walls)
                {
                    //item is an instance of the List<Walls> in the collection loading to the Room instance myRoom
                    wallSurfaceArea += item.WallArea();
                }
                foreach (Opening item in myRoom.Openings)
                {
                    //item is an instance of the List<Walls> in the collection loading to the Room instance myRoom
                   openingArea += item.OpeningArea();
                }
                WriteLine($"\nTotal wall area {wallSurfaceArea} Total opening area {openingArea} giving a net surface area to paint the color {myRoom.Color}: {wallSurfaceArea - openingArea}");
            }
            catch(Exception ex)
            {
                WriteLine($"\nError: {ex.Message}\n");
            }
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

        static void InputOpeningsForRoom(List<Opening> openings)
        {
            Opening anOpening = null;
            bool finished = false;
            double width = 0.0;
            double height = 0.0;
            string description = null;

            do
            {
                //loading using the "greedy" constructor
                //need to have all values for the instance BEFORE creating the actual instance (via new)

                //step 1: collect data
                width = GetPositiveDouble("Enter the width of your wall:");
                height = GetPositiveDouble("Enter the height of your wall:");
                description = GetNonEmptyString("Enter a description of the opening (such as window, door, fireplace, etc):");

                //step 2: create and load new instance using greedy constructor
                anOpening = new Opening(width, height, description);

                //step 3: save the instance
                openings.Add(anOpening);
                if (GetNonEmptyString("Do you have another wall(y/n):").ToUpper() == ("N"))
                {
                    finished = true;
                }
            } while (!finished);
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
                //the new operator will use the Wall default constructor

                //steps 1: create the instance
                aWall = new Wall();

                //step 2: collect data and load the instance
                //obtain the width for the wall
                aWall.Width = GetPositiveDouble("Enter the width of your wall:");
                //obtain the height for the wall
                aWall.Height = GetPositiveDouble("Enter the height of your wall:");
                //add the instance to the wall collection

                //step 3: save the instance
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
