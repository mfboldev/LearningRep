using System;
using static System.Console;

namespace Boolean_Operators {

    class Program {

        static void Main(string[] args) {

            //boolean operators AND, OR, XOR (exclusive or)
            /*
            For the AND & logical operator, both operands must be true for the results
            to be true. For the OR | logical operator, either operand can be true for
            the result to be true. For the XOR ^ logical operator, either operand can
            be true (but not both!) for the result to be true.
            */
            bool a = true;
            bool b = false;

            WriteLine($"AND | a | b");
            WriteLine($"a | {a & a, -5}");
            WriteLine($"b | {b & a, -5} | {b & b, -5}");
            WriteLine();
            WriteLine($"OR | a | b");
            WriteLine($"a | {a | b, -5} | {a | b, -5}");
            WriteLine($"b | {b | a, -5}");
            WriteLine();
            WriteLine($"XOR | a | b");
            WriteLine($"a | {a ^ a, -5} | {a ^ b, -5}");
            WriteLine($"b | {b ^ a, -5} | {b ^ b, -5}");

            //calling the bool class with logical operators
            WriteLine($"a & DoStuff() {a & DoStuff()}");                    //executes
            WriteLine($"b & DoStuff() {b & DoStuff()}");                    //executes but returns false

            //calling the bool class with conditional logical operators
            WriteLine($"a & DoStuff() {a && DoStuff()}");                   //executes
            WriteLine($"b & DoStuff() {b && DoStuff()}");                   //does not execute
        }

        private static bool DoStuff(){

            WriteLine();
            WriteLine("Hello, I am doing stuff");
            return true;
        }
    }
}