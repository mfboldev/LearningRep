using System;
using static System.Console;

namespace _8._Checking_for_Overflow {

    class Program {

        static void Main(string[] args) {

            int x = int.MaxValue -1;

            try {

                //The checked keyword is used to explicitly enable overflow checking for 
                //integral-type arithmetic operations and conversions
                checked {
                    
                    WriteLine($"intial value: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                }
            } catch (OverflowException) {

                WriteLine("The code overflowed but I caught it");
            }

            //"Unchecked" Explicitly does not check for exceptions
            unchecked{
            
                int y = int.MaxValue + 1;
                WriteLine($"initial value: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
            }

        }
    }
}
