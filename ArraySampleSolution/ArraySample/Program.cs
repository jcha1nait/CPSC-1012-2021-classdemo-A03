using System;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays are fixed-size
            //Each element in the array is the same datatype

            //An integer array of size 6
            //This array will simulate a single dice(die)
            //This array will simulate a single dice(die)
            //The size indicates that there are 6 faces on this die

            int[] dieFace; //I have a variable representing an integer array which has NOT been assigned size
                           //This variable CANNOT hold data at this time

            dieFace = new int[6]; //This statement assigned an area in memory of 6 int size elements
                                  //This variable CAN hold data at this time

            int[] die2Face = new int[6]; //Declaring array AND allocating (requesting) an area in memory to be set aside for 6 int size elements

            int[] die3Face = new int[6] { 1, 2, 3, 4, 5, 6 }; //Declare, allocate AND assign my own initial values to the array

            int[] die3Alternative = { 1, 2, 3, 4, 5, 6 }; //Declare, allocate and assign
                                                          //Array size was determined by the number of initial values

            string[] dieFaceName = { "One", "Two", "Three", "Four", "Five", "Six" };

            //Traverse an array
            //What is needed to know: size of the array
            //How does one reference a particular element in the array: by index (starts at 0)
            //How does one change index: use iteration (looping) logic

            for (int index = 0; index < 6; index++)
            {
                Console.WriteLine($"Default value {die2Face[index]} Assigned value" +
                    $" {die3Alternative[index]} Face Name {dieFaceName[index]}" +
                    $" data at index {index}");
            }
        }
    }
}
