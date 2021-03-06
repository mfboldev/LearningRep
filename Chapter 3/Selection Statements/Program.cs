using System;
using static System.Console;
using System.IO;

namespace Selection_Statements {

    class Program {

        static void Main(string[] args) {
            
            if(args.Length == 0) {

                WriteLine("There are no arguments");
            } else {

                WriteLine("There are arguments");
            }
            
            //since C# 7.0 we can use the "is" keyword
            object o = 3;
            int j = 4;

            if(o is int i) {

                WriteLine($"{i} x {j} = {i * j}");
            } else {

                WriteLine($"o is not an int so it cannot multiply!");
            }

            //switch statements compares one condition instead of multiple like the if statement
            A_label: var number = (new Random()).Next(1,7);

            WriteLine($"My random number is {number}");
            switch(number) {

                case 1: 
                    WriteLine("One");
                    break;                          //jumps to the end of the statement
                
                case 2: 
                    WriteLine("Two");
                    goto case 1;

                case 3:
                    return;
                case 4: 
                    WriteLine("Three or four");
                    goto case 1;

                //case 5 go to sleep for half a second
                case 5: 
                    System.Threading.Thread.Sleep(500);
                    goto A_label;

                default: 
                    WriteLine("Default");
                    break;

                //end of switch statement
            }

            //PATTERN MATCHING WITH A SWITCH STATEMENT

            //string path = "/dev/C# book exercises/Chapter 3";
            string path = @"C:\dev\C# book exercises\Chapter 3";

            WriteLine("Press R to readonly or W for write");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();

            Stream s = null;

            if(key.Key == ConsoleKey.R) {

                s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
            } else if(key.Key == ConsoleKey.W) {

                s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);
            }

            string message = string.Empty;

            switch(s) {

                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to";
                    break;
                
                case FileStream readOnlyFile:
                    message = "The stream is a file that I can read";
                    break;

                case MemoryStream ms:
                    message = "The stream is a memory address";
                    break;

                default:                            //position of default doesn't matter, always evaluated as last
                    message = "The stream is some other type";
                    break;
                
                case null:
                    message = "The stream is null";
                    break;

            }

            WriteLine(message);

            //Switch statements since C# 8.0
            WriteLine("press R or W again");
            ReadKey();
            WriteLine();

            message = s switch {
                FileStream writeableFile when s.CanWrite => "The file is writeable",
                FileStream readOnlyFile => "The file is readable",
                MemoryStream ms => "The stream is a memory address stream",
                null => "Stream is null",
                _ => "The stream is some other type"
            };

            WriteLine(message);
        }
    }
}
