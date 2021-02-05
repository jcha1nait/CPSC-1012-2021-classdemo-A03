using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            ////pre-test loop structure (a.k.a. DO-While structure)
            ////
            //string inputTemp;
            //int aNumber;

            //Console.Write("Enter a number:\t");
            //inputTemp = Console.ReadLine();
            //aNumber = int.Parse(inputTemp);
            //int loopExecutions = 0;
            //// pre-test loop
            //while (aNumber !=  0)
            //{
            //    //all code within this coding block ({....})
            //    //  belongs to the loop

            //    Console.WriteLine($"You entered the number {aNumber}");
            //    Console.Write("Enter a number:\t");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);

            //    //a fast way of adding 1 to a counter
            //    //loopExecutions = loopExecutions + 1;
            //    loopExecutions++;
            //}//eowhile

            ////next statement is the 1st executable statement after the loop
            //Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions}");


            ////post-test loop
            //do
            //{
            //    //all code within this coding block ({....})
            //    //  belongs to the loop

            //    //a fast way of adding 1 to a counter
            //    //loopExecutions = loopExecutions + 1;
            //    loopExecutions++;

            //    Console.Write("Enter a number:\t");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //    if (aNumber != 0) //termination number DO NOT PRINT
            //    {
            //        Console.WriteLine($"You entered the number {aNumber}");
            //    }
            //} while (aNumber != 0);  //eowhile

            //    //next statement is the 1st executable statement after the loop
            //Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions}");

            //Assume you are an instructor.
            //Enter a mark for each student in your class.
            //Continue enter marks for the students and after
            //    all marks have been entered, calculate the average.
            //The highest mark for any student is 100.
            //The lowest mark for any student is 0.

            //requirements
            //data: counter for marks entered (int)
            //      totaling variable (int)
            //      total average variable (rounded(int) or rounded(double,1))
            //processing: iterative logic
            //            prompt, read, sum, check for next entry
            //            what will be the terminating value
            //            could one use a character (string) to terminate i.e. x
            //            calculate and display number of students and total average

            //declare my variables
            string inputTemp;
            int sumOfMarks = 0;
            int countOfStudents = 0;
            int inputNumber = 0;

            ////get first value
            //Console.Write("Enter the student mark or X to exit:\t");
            //inputTemp = Console.ReadLine();

            ////pre-test
            //while (inputTemp.ToUpper() != "X")
            //{
            //    sumOfMarks += int.Parse(inputTemp);
            //    countOfStudents++; //fast way to add 1 to a counter
            //    Console.Write("\nEnter the student mark of X to exit:\t");
            //    inputTemp = Console.ReadLine();
            //}

            //if (countOfStudents > 0)
            //{
            //    Console.WriteLine($"There are {countOfStudents} students. Their average" +
            //        $" mark is {Math.Round((decimal)sumOfMarks / (decimal)countOfStudents, 1)}");
            //}
            //else
            //{
            //    Console.WriteLine("You did not enter a student mark.");
            //}

            //post-test
            do
            {
                Console.Write("Enter the student mark or X to exit:\t");
                inputTemp = Console.ReadLine();

                if (inputTemp.ToUpper() != "X")
                {   
                    //Validating user input data is correct datatype
                    if (int.TryParse(inputTemp,out inputNumber))
                    {
                        //validating the input number is within the range of 0 to 100
                        if (inputNumber >= 0 && inputNumber <= 100)
                        {
                            sumOfMarks += inputNumber;
                            countOfStudents++; //fast way to add 1 to a counter
                        }
                        else
                        {
                            Console.WriteLine("That's not a valid student mark. Value rejected.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That's not a valid student mark. Value rejected.");
                    }
                }

            }while (inputTemp.ToUpper() != "X");

            if (countOfStudents > 0)
            {
                Console.WriteLine($"There are {countOfStudents} students. Their average" +
                    $" mark is {Math.Round((decimal)sumOfMarks / (decimal)countOfStudents, 1)}");
            }
            else
            {
                Console.WriteLine("You did not enter a student mark.");
            }
        }//eoMain
    }
}



