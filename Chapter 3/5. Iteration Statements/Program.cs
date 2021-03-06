using System;
using static System.Console;
using System.IO;

namespace _5._Iteration_Statements {

    class Program {

        static void Main(string[] args) {
            
            //WHILE STATEMENT
            int x = 0;

            while(x < 10) {
                
                WriteLine(x);
                x++;
            }

            //DO STATEMENT -> checks boolean at the bottom of the loop
            string password = string.Empty;
            int incorrect = 0;

            do {

                WriteLine("Enter your password!");
                password = ReadLine();
                incorrect++;
            } while(password != "password" && incorrect < 3);

            if(password == "password"){

                WriteLine("Correct");
            } else if(incorrect == 3) {

                WriteLine("Incorrect three times");
            }

            //FOR STATEMENT -> initializer, conditional expression, iterator
            for(int y = 1; y <= 10; y++){

                WriteLine(y);
            }

            //FOREACH STATEMENTS -> e.g. used to check each item in an array
            string[] names = {"Adam", "Barry", "Felix", "Marzia"};

            foreach(string name in names){

                WriteLine($"{name} has {name.Length} characters");
            }
        }
    }
}
