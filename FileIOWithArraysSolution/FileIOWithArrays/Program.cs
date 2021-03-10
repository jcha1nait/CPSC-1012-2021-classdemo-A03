using System;
using System.IO;

namespace FileIOWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //your code goes here
            const int ARRAYSIZE = 100;
            int logicalSize = 0;
            int[] Marks = new int[100];

            string inputTemp = "";
            string FullFilePathName = "";
            do
            {
                inputTemp = MenuPrompt();
                switch (inputTemp.ToUpper())
                {
                    case "A":
                        {
                            FullFilePathName = HardCodedFileName();
                            logicalSize = ProcessFile(FullFilePathName,Marks,ARRAYSIZE);
                            break;
                        }
                    case "B":
                        {
                            //your code goes here
                            //pass the array to the method along with the number of active
                            //  elements in the array (logical size)
                            DisplayArray(Marks, logicalSize);
                            break;
                        }
                    case "C":
                        {
                            WriteToFile();
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you. Have a nice day.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($" {inputTemp} is not a valid menu option. Try again.");
                            break;
                        }
                }
            } while (inputTemp.ToUpper() != "X");
        }

        static string HardCodedFileName()
        {

            string Folder_Pathname = @"E:\GitHub\CPSC-1012\FileProcessing\";
            string Full_Path_Filename;
            Full_Path_Filename = Folder_Pathname + @"OneColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"TwoColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"VariableColums.txt";
            //Full_Path_Filename = Folder_Pathname + @"BadFileDoesNotExist.txt";
            return Full_Path_Filename;
        }

        static int ProcessFile(string paramFullFilePathName, int[] Marks, int physicalSize)
        {
            //each record will represent an element in the array Marks
            //therefore the variable "records" will represent the logical number of elements used in the array
            int records = 0;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(paramFullFilePathName);
                string readline = "";
                readline = reader.ReadLine();
                while (readline != null)
                {
                    Console.WriteLine($"\nContents of file record\t{readline}");
                    int columncounter = 0;
                    foreach (string value in readline.Split(','))
                    {
                        columncounter++;
                        Console.WriteLine($"Column {columncounter} contains the value {value}");

                        //add the data to the appropriate array
                        //Concerns:
                        //  is there enough room in the array for another value
                        //  does the string input need to be converted
                        if (records < physicalSize)
                        {
                            //there is room for the value in the array
                            //ADD the value to the array
                            Marks[records] = int.Parse(value);
                            records++;
                        }
                        else
                        {
                            //creating your own error to handle a "logical" run problem
                            //this is NOT bad logic, it is a user generated problem
                            throw new Exception("Insufficient room for more data in the program.");
                        }
                    }
                    readline = reader.ReadLine();
                }
                Console.WriteLine($"\nYou read {records} records");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"You had a problem reading the file. \nError:\t{ex.Message}");
            }
            finally
            {
                reader.Close();
            }

            return records;
        }

        static string MenuPrompt()
        {
            string inputTempLocal = "";
            Console.WriteLine("File I/O options:");
            Console.WriteLine("a) Hard-coded file name.");
            Console.WriteLine("b) Using Windows Environment (DeskTop, Documents, Download) path file name.");
            Console.WriteLine("c) Writing to a file.");
            Console.WriteLine("x) Exit.\n");
            Console.Write("Enter the menu option for File I/O\t");
            inputTempLocal = Console.ReadLine();
            return inputTempLocal;
        }

        static void WriteToFile()
        {
            string PathName = @"E:\\GitHub\\CPSC-1012\\";
            string FullPathName = PathName + @"NewFile.txt";
            StreamWriter writer;
            try
            {
                writer = new StreamWriter(FullPathName, false);
                Random rnd = new Random();
                int linesout = rnd.Next(1, 6);
                for (int looper = 0; looper < linesout; looper++)
                {
                    writer.Write($"line {looper}, terry\n");
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\nError: {ex.Message}\n\n");
            }
        }

        static void DisplayArray(int[] Marks, int logicalSize)
        {
            //Traverse the array from the beginning to the end
            //Write each element contents to the screen

            //with the while loop, YOU are responsible for all control of looping
            //  ensuring that you do NOT go beyond the contents of the array
            //the index is the position within the array (which element position)
            //  calculation of element position is arrayAddress + (index * element size)
            //the logical size is a natural count of the number of active elements in the array
            int index = 0;
            while (index < logicalSize)
            {
                Console.WriteLine($"Element at index {index} has a value of {Marks[index]}");
                index++;
            }

            //all of the separate lines of looping count used for the while loop exists in the setup for the for loop
            for (index = 0; index < logicalSize; index++)
            {
                Console.WriteLine($"Element at index {index} has a value of {Marks[index]}");
            }

            //all control of the loop is embedded within the software of foreach
            //foreach does the following:
            //  checks if theres anything to process
            //  processes the collection (array) from the start to the end!!
            //  after an iteraton, automatically checks to see if another iteration is required
            //  stops automatically when there is nothing more to process
            //the foreach isolates a single instance of your collection using a placeholder variable
            //during the processing, use the placeholder to obtain the contents of the element
            //  in your array that is currently being processed
            //WARNING!!!
            //the foreach loop will process your ENTIRE collection INCUDING any unused array elements.
            //if you wish to use this looping and ONLY process the used array elements
            //  YOU MUST still supply logic to NOT do certain processing for unused elements
            foreach (int currentElement in Marks)
            {
                Console.WriteLine($"Element at index {index} has a value of {currentElement}");
            }
        }
    }
}
