using System;
using static System.Console;

namespace Bitwise_and_Shift_Operators 
{
    class Program {

        static void Main(string[] args) {

            //bitwise operators affect the bits in a number for faster calculations.
            int a = 10;                             //0000 1010
            int b = 6;                              //0000 0110

            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}");          //2-bit column only
            WriteLine($"a | b = {a | b}");
            WriteLine($"a ^ b = {a ^ b}");

            WriteLine($"a << 3 = {a << 3}");        //0101 0000 left-shit a by three bit columns
            WriteLine($"a * 8 = {a * 8}");          //multiply by 8
            WriteLine($"b >> 1 = {b >> 1}");        //right-shift b by one bit column 0000 0011

            //0000 0000
            //1111 1111 = 128 + 64 + 32 + 16 + 8 + 4 + 2 + 1 = 255

            //MISCELLANEOUS OPERATORS

            //nameof operator returns the short name of a variable
            //sizeof operator returns the size in bytes of simple types

            int age = 47; //How many operators in the following statement?
            char firstDigit = age.ToString()[0]; //there are four operators: = is the assignment operator
                                                 //. is the member access operator. () is the invocation operator
                                                 //[] is the indexer access operator
            
            WriteLine(firstDigit);
        }
    }
}