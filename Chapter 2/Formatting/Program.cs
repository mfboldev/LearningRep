//imported only the console method from the System namespace
using System;
using static System.Console;

namespace Formatting
{

    class Program {

        static void Main(string[] args) {

            //A quick fix for the Unicode in the console that shows no currency symbol
            OutputEncoding = System.Text.Encoding.Unicode;

            int numberOfApples = 12;
            decimal pricePerApple = 0.35m;

            WriteLine(
                format: "{0} apples cost {1:c}", 
                arg0: numberOfApples, 
                arg1: pricePerApple * numberOfApples);

            //the string "formatted" can also be pasted into WriteLine
            string formatted = string.Format(
                format: "{0} apples cost {1:c}", 
                arg0: numberOfApples, 
                arg1: pricePerApple * numberOfApples);

            //writes the string into a file (WriteToFile is a non-existent method to show the idea)
            //WriteToFile(formatted);

            //alignment code
            string applesText = "Apples";
            string bananasText = "Bananas";
            int applesCount = 1234;
            int bananasCount = 56789;

            /*
            {0, 8} -> argument 0 is aligned on -8 in the console
            {1,9:N0} -> argument 1 is aligned on 9 in the console 
            and the numbers are formatted in thousand seperators and no decimals
            */
            WriteLine(format:"{0,-8}{1,9:N0}",
            arg0:"Name",
            arg1:"Count");

            WriteLine(format:"{0,-8}{1,9:N0}",
            arg0:applesText,
            arg1:applesCount);

            WriteLine(format:"{0,-8}{1,9:N0}",
            arg0:bananasText,
            arg1:bananasCount);

            //Get input from the user
            WriteLine("What is your name?");
            string firstName = ReadLine();
            WriteLine("What is your age?");
            string age = ReadLine();
            WriteLine($"Hello {firstName}, you are {age} years old.");

            //get key input from the user
            WriteLine("Don't touch that key");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine(
                "You couldn't keep yourself pressing {0}, could you..?", 
                arg0:key.Key);
            WriteLine(
                "Anyway, here are the specifications: Char -> {0}, Modifier -> {1}, Key ->{2}",
                arg0:key.KeyChar,
                arg1:key.Modifiers,
                arg2:key.Key);
        }
    }
}