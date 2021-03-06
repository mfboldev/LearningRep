using System;
using static System.Console;

namespace Exercise_2._2 {

    class Program {

        static void Main(string[] args) {
            //Attempt 1

            /* string stripe = "-";
            //string line = string.Empty;

            for(int i = 0; i < 8; i++) {

                
                i++;
            }

            WriteLine(line); */
            
            //Attempt 2

           /*  WriteLine("-----------------------------------------------------------");
            WriteLine(
                format:"{0,0}{1,20}{2,40}{3,60}",
                arg0:"Type",
                arg1:"Byte(s) of memory",
                arg2:"Min",
                arg3:"Max");
            WriteLine(
                format:"{0,-8}{1,9}",
                arg0:"testpos2-8",
                arg1:"testpos2-9"); */

            //Attempt 3
            string line = null;
            string stripe = "-";

            //loop and make a line
            for(int i = 0; i < 150; i++) {

                    
                //WriteLine("Loops: {0}", arg0:i);
                line += stripe;
                
            }

            //format the string with 4 arguments because Console.Writeline can't handle more than three arguments
            string formatted = string.Format(
                "{0,-10}{1,20}{2,60}{3,60}",
                "Type",
                "Byte(s) of memory",
                "Min",
                "Max");

            //Create an array with the type names, byte sizes, minimum- and maximum values
            string[] types = {
                "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"};

            uint[] bytes = {
                sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), 
                sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal)};

            object[] minimum = {
                sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue,
                uint.MinValue, long.MinValue, ulong.MinValue, float.MinValue, double.MinValue, decimal.MinValue
            };

            object[] maximum = {
                sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue,
                uint.MaxValue, long.MaxValue, ulong.MaxValue, float.MaxValue, double.MaxValue, decimal.MaxValue
            };

            WriteLine(line);
            WriteLine(formatted);
            WriteLine(line);

            //loop through the arrays
            for(int i = 0; i < types.Length; i++) {

                WriteLine(format:$"{types[i],-10}{bytes[i],20}{minimum[i],60}{maximum[i], 60}");            }
        }
    }
}
