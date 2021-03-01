using System;
using System.IO; //clarifies the requirement for File I/O
//using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        [STAThread]
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
            string FullFilePathName = "";

            //post-loop structure used to control menu
            do
            {
                Console.WriteLine("File I/O options:");
                Console.WriteLine("a) Hard-coded file name");
                Console.WriteLine("b) Using Windows Environment (Desktop, Documents, Download) path file name");
                Console.WriteLine("x) Exit\n");
                Console.Write("Enter the menu option for File I/O:\t");
                inputTemp = Console.ReadLine();
                switch(inputTemp.ToUpper())
                {
                    case "A":
                        {
                            //Hard coded file-name
                            //
                            //The calling statement
                            //
                            //[receiving variable] = MethodName([list of arguments])
                            //
                            //on the calling statement your method's list of parameters
                            //are properly referred to as arguments
                            FullFilePathName = HardCodedFileName();
                            break;
                        }
                    case "B":
                        {
                            FullFilePathName = WindowEnvironmentFileName();
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
                            Console.WriteLine($"{inputTemp} is not a valid menu option. Try again.");
                            break;
                        }
                }
                //Console.WriteLine($"Your full path name is {FullFilePathName}");

                //pass an argument value into a method
                if (!inputTemp.ToUpper().Equals("X") || inputTemp.ToUpper().Equals("C"))
                {   
                    //A calling statement which is supplying a single argument value
                    //to the method.
                    //There is NO assignment operator which indicates a) nothing
                    //is being returned from the method OR b) a logic decision
                    //has been made to ignore any returned value.
                    ProcessFile(FullFilePathName);
                }
            } while (inputTemp.ToUpper() != "X");

            
        }
        static string HardCodedFileName()
        {   
            //Any locally created variables are DESTROYED when the method terminates
            //setup a path name to the folder on your machine that contains the file to be read
            string Folder_PathName = @"E:\GitHub\CPSC-1012\FileProcessing\";

            //concatenate a file name to the pathname
            string Full_Path_FileName = Folder_PathName + @"TwoColumn.txt";

            //BECAUSE the method indicates a returned datatype of string (anything but void),
            //the method REQUIRES a return xxxx; statement
            //The returned value is a physical copy of the contents of the variable on the statement
            //You may return ONLY one value 
            return Full_Path_FileName;
        }

        static string WindowEnvironmentFileName()
        {
            //Using Environment.GetFolderPath allows the program to get to the 
            //special folders of your Windows file system(Desktop, Documents, Download,...)
            string myMachinePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //if you have a folder structure on your Desktop where the file is located
            //them add that path to the MachinePath
            myMachinePath += @"\CPSC1012-FileIO\TempData\";
            //add the actual file name to the Full path
            string Full_Path_FileName = myMachinePath + @"TwoColumn.txt";
            return Full_Path_FileName;
        }

        static void ProcessFile(string paramFullFilePathName)
        {
            //The parameter on the method header SHOULD be treated as a local variable
            //DO NOT redeclare parameter variables as local variables
            //If your parameter variable is a VALUE type variable then the name given 
            //to the passing of data into this method is called "Pass By Value"

            //Pass By Value
            //A physical copy of the data from the call statement is passed into
            //the parameter variable

            //Read the contents of a single column record from a file
            //The number of records on the file is unknown
            //Include User Friendly Error Handling

            int records = 0;

            //StreamReader is used to create a "pipeline" to your physical file
            //The StreamReader is one of the System.IO classes
            //You need to create (request) an "instance" of the class
            //Syntax is datatype (classname)StreamReader
            //Creating the instance: new theclassname([list of parameters(OPTIONAL)])
            //the parameter required is the complete file path name 
            StreamReader reader = new StreamReader(paramFullFilePathName);

            //User Friendly Error Handling
            //Use the structure called Try/Catch/Finally
            //Syntax structure
            //try
            //{
            //     coding to try and execute
            //}
            //catch (Exception ex)
            //{
            //     code used to handle the run time error
            //}
            //finally(optional)
            //{
            //     code to execute whether there is no error or if there was an error
            //}
            try
            {
                //logic of your program
                string readLine = "";
                //read the first record from your StreamReader pipeline
                readLine = reader.ReadLine();
                //Your program will know when you have reached the end of the file
                //when it receives a null value from the StreamReader method .ReadLine()
                //Use pre-test loop
                while (readLine != null)
                {
                    //a line has been returned from the physical file
                    records++;
                    Console.WriteLine($"Contents of file record:\t{readLine}");

                    //This code demonstrates a technique to handle multiple values
                    //on a single record which are separated by the comma (',') character
                    //This technique uses:
                    //  a) the string method .Split('delimiter')
                    //  b) the pre-test loop called foreach()
                    //A file with records containing multiple values separated by a comma
                    //is often referred to as a CSV file (Comma Separated Values)
                    int columncounter = 0;
                    //The foreach loop is preferred because
                    //  a) handles an unknown number of times for looping
                    //  b) the while condition is embedded within the loop and is handled
                    //     as "is there any more to do?"
                    //  c) stops automatically if there is no more to do
                    //  d) the "item" (data) to process is located in the local loop 
                    //     variable declared in the for each syntax.
                    //     In this example, the local loop variable is string value
                    //  e) the "in" variable specifies the data source location 
                    foreach(string value in readLine.Split(','))
                    {
                        columncounter++;
                        Console.WriteLine($"Column {columncounter} contains the value {value}");
                    }
                    //read the next line in the file
                    readLine = reader.ReadLine();
                }
                Console.WriteLine($"\nYou've read {records} records.");
            }
            catch (Exception ex)
            {
                //display a message indicating the problem
                Console.WriteLine($"You had a problem reading the file. \nError:\t{ex.Message}");
            }
            finally
            {
                //due to the fact that we are reading a file
                //the file must be closed when you have finished reading all that you desire
                reader.Close();
            }
        }

        static void WriteToFile()
        {
            string PathName = @"E:\\GitHub\\CPSC-1012\\";
            string FullPathName = PathName + @"NewFile.txt";
            //declare "pipeline" variable to the output file
            StreamWriter writer;

            //create the pipeline
            // a) the file path name
            // b) a true or false indicating type of appending
            //    true: append to an existing file or create the file if it does not exist
            //    false: recreate the file as a new file (overwrite of existing file if file exists)
            try //user friendly error handling
            {
                writer = new StreamWriter(FullPathName, true);
                Random rnd = new Random();
                int linesout = rnd.Next(1, 6); //desire numbers 1 through 5
                for (int looper = 0; looper < linesout; looper++)
                {   
                    //Writing a line to your file
                    //NOTE: the \n at the end of the string to force the next line in the file
                    writer.Write($"line {looper}, don\n");
                }
                //remember to close the file when you are finished
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}\n\n");
            }
        }
    }
}
