using System;

namespace FileIO
{
    class Program
    {
        /*
             * Methods
             * 
             * Why?????
             *     reduce code redundancy
             *     break up your code into smaller manageable pieces
             * 
             * Where do methods go?
             *     methods go into your program class
             * 
             * Syntax for a method
             *     accesstype returndatatype MethodName ([List of parameters])
             *     {
             *     coding block
             *     }
             *     
             *     accesstype?
             *     This is dependant on what is the Main access type or if the class is NOT
             *     the entry point to your entire application, could be public, private, internal, protected,...
             *     
             *     returndatatype?
             *     Methods have been called by many names
             *     Methods have been called subroutines, functions, methods
             *     Subroutines and functions are different in that subroutines return no data
             *     to the calling statement; whereas functions will return data to the calling statement.
             *     The return datatype must be a valid language datatype
             *     The return datatype in C$ that returns nothing is the keyword void
             *     
             *     MethodName?
             *     This is what the method is called
             *     The method name is usually unique
             *     The method names that are not uniques are paired with their list of
             *     parameters to create a method signature.
             *     The method signature MUST be unique.
             *     This is referred to as overload methods.
             *     
             *     [list of parameters] (optional)
             *     What is a parameter?
             *     datatype parametername
             *     consider the parameter a variable within your method that has already been
             *     declared and can be used on other variables
             *     
             *     What is a list of parameters?
             *     datatype parametername, datatype parametername, .....
        */
        // Main() is a method
        // special method
        // entry point into your program execution
        static void Main(string[] args)
        {
            /*
             * process
             * 
             * this program will demonstrate methods, menu ooping and various styles of File I/O
             * 
             * create a post-loop (do/while) to handle the menu
             *     the menu will have 3 options, one for each type of File I/O style
             *     
             * methods will be used to obtain the file name to be read for this program
             *     the methods will have no incoming parameter, will return a string datatype
             * 
             * the reading and display of the file will be placed in a separate method
             *     the method will have a string incoming parameter, 
             *     the method will not return anything (void datatype),
             *     the method demonstrates error handling using Try/Catch/Final
             */

            string inputTemp;

            //post-loop structure used to control menu
            do
            {
                Console.WriteLine("File I/O options:");
                Console.WriteLine("a) Hard-coded file name");
                Console.WriteLine("b) Using Windows Environment (Desktop, Documents, Download) path file name");
                Console.WriteLine("c) Using Openfile dialog to obtain file name");
                Console.WriteLine("x) Exit\n");
                Console.Write("Enter the menu option for File I/O:\t");
                inputTemp = Console.ReadLine();
                switch(inputTemp.ToUpper())
                {
                    case "A":
                        {
                            break;
                        }
                    case "B":
                        {
                            break;
                        }
                    case "C":
                        {
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you. Have a nice day.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"{inputTemp} is not a valid menu option. Try again.");
                            break;
                        }
                }
                
            } while (inputTemp.ToUpper() != "X");

            
        }
        static string HardCodedFileName()
        {   
            //setup a path name to the folder on your machine that contains the file to be read
            string Folder_PathName = @"E:\GitHub\CPSC-1012\FileProcessing\";

            //concatenate a file name to the pathname
            string Full_Path_FileName = Folder_PathName + @"OneColumn.txt";

            //BECAUSE the method indicates a returned datatype of string (anything but void),
            //the method REQUIRES a return xxxx; statement
            return Full_Path_FileName;
        }
    }
}
