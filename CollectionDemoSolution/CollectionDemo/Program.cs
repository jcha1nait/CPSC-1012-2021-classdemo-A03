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
            //declare a List<T>
            List<int> setOfNumbers = new List<int>();
            //add element to a list
            setOfNumbers.Add(55);
            setOfNumbers.Add(41);
            setOfNumbers.Add(100);

            WriteLine($"The list contains {setOfNumbers.Count} elements");
        }
    }
}
