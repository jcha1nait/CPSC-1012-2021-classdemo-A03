using System;

#region Additional Namespaces
using System.Collections.Generic; //needed for List<T>
using static System.Console; //needed for WriteLine, ReadLine, Write
#endregion


namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicsOfLists();

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
    }
}
