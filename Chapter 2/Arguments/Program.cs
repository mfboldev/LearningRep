using System;
using static System.Console;

namespace Arguments {
    class Program {
        static void Main(string[] args) {

            //displays the arguments you put in the console after dotnet run
            WriteLine($"There are {args.Length} arguments");

            //for each argument in the console, put it in a string and display it
            foreach(string arg in args) {

                WriteLine(arg);
            }

            //check whether there are 3 or more arguments in the console otherwise exit code.
            if(args.Length < 3){

                WriteLine("dotnet run red yellow 50");
                return;
            }

            //Change the console according to the arguments in the console (cursor size only works on linux)
            ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
            BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);

            //exception handeling.
            try {

                CursorSize = int.Parse(args[2]);
            } catch(PlatformNotSupportedException) {

                WriteLine("The current platform does not support the changing of the size of the cursor");
            }
        }
    }
}
