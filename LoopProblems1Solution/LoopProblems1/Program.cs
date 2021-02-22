using System;

namespace LoopProblems1
{
    class Program
    {
        static void Main(string[] args)
        {
            //pre-test loop structure (Do-While Structure)
            //
            //string inputTemp;
            //int aNumber;

            //Console.Write("Enter a number:\t");
            //inputTemp = Console.ReadLine();
            //aNumber = int.Parse(inputTemp);
            //int loopExecutions = 0;

            ////pre-test loop
            //while (aNumber != 0)
            //{
            //    //all code within this coding block belongs to the loop

            //    //a fast way of adding 1 to a counter
            //    loopExecutions++;

            //    Console.WriteLine($"You entered the number {aNumber}");
            //    Console.Write("Enter a number:\t");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //}
            ////next statement is the 1st executable statement after the loop
            //Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions} times.");

            ////post-test loop
            //do
            //{
            //    //all code within this coding block belongs to the loop

            //    //a fast way of adding 1 to a counter
            //    loopExecutions++;

            //    Console.Write("Enter a number:\t");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //    if (aNumber != 0)
            //    {
            //        Console.WriteLine($"You entered the number {aNumber}");
            //    }

            //} while (aNumber != 0);

            //    //next statement is the 1st executable statement after the loop
            //    Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions} times.");

            //assume you are an instructor
            //enter a mark for each student in your class.
            //continue to enter marks for the students 
            //after all marks have been entered, calculate the average
            //the highest mark for any student is 100
            //the lowest mark for any student is 0

            string inputTemp;
            int studentMark;
            int totalMark = 0;
            int studentAverage;
            int loopExecutions = 0;

            Console.Write("Enter student mark:\t");
            inputTemp = Console.ReadLine();
            studentMark = int.Parse(inputTemp);

            //pre-test loop
            while (studentMark>=0 && studentMark <=100)
            {
                loopExecutions++;

                Console.WriteLine($"The student's mark was: {studentMark}");



                Console.Write("Enter a new student's mark:\t");
                inputTemp = Console.ReadLine();
                studentMark = int.Parse(inputTemp);
            }

            studentAverage = totalMark / loopExecutions;
            Console.WriteLine($"The average of all marks entered is {studentAverage}");
            


            
            
            




        }
    }
}
