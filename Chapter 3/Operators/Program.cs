using System;
using static System.Console;

namespace Operators {

    class Program {

        static void Main(string[] args) {

            int a = 3;                                          //UNARY OPERATORS
            int b = a++;                                        //postfix operator ++ increments AFTER assigning value to b

            WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c;                                        //prefix operator ++ increments BEFORE assigning value to c

            WriteLine($"c is {c}, d is {d}");

            int e = 11;
            int f = 3;

            WriteLine($"e is {e}, f is {f}");                   //BINARY OPERATORS
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e x f = {e * f}");
            WriteLine($"e : f = {e / f}");
            WriteLine($"e % f = {e % f}");                      //Modulo figures out what the remainder is after dividing

            double g = 11.0;                                    //real number

            WriteLine($"g is {g:N1}, f is {f}");                //{g:N1} formatter shows the amount of decimals
            WriteLine($"g / f = {g / f:N1}");                   //when a number is a double floating point, then it shows decimals

            int p = 6;                                          //ASSIGNMENT OPERATOR
            WriteLine(p += 3);
            WriteLine(p -= 3);                                  
            WriteLine(p *= 3);
            WriteLine(p /= 3);
        }
    }

}

