using System;
using static System.Console;
using static System.Convert;

namespace Casting_Converting {

    class Program {

        static void Main(string[] args) {

            //converting an int to a double is safe because no information is lost
            int a = 10;
            double b = a;
            WriteLine(b);

            //this line gives an error because it is potentially unsafe
            /*double c = 9.8;
            int d = c;
            WriteLine(d);*/

            //to cast a double to an int you have to put int between brackets -> () CAST OPERATOR
            //you agree that some information gets lost like the number after the comma
            double c = 9.8;
            int d = (int)c;
            WriteLine(d);
            
            WriteLine();

            //same applies to other types integers because of size
            long e = 5_000_000_000;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");


            //System.Convert can convert every type to other types
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            WriteLine();

            //System.Convert rounds numbers up or down and casting trims numbers

            /*
            C# uses the Banker's Rounding to reduce bias when it rounds up or down
            Other languages like JavaScript uses the primary school rule

            -> It always rounds down if the decimal part is less than the midpoint .5-
            -> It always rounds up if the decimal part is more than the midpoint .5-
            -> It will round up if the decimal part is the midpoint .5 and the non decimal part is odd
            -> but it will round down if the non-decimal part is even
            */
            double[] doubles = new[] {9.49, 9.5, 10.49, 10.5, 10.51};

            foreach(double n in doubles) {

                WriteLine($"ToInt({n}) is {ToInt32(n)}");
            }

            WriteLine();

            //MidPointRounding.AwayFromZero rounds the numbers according the primary school rule.
            foreach(double n in doubles) {

                WriteLine(format: "Math.Round({0}, 0, MidPointRounding.AwayFromZero) is {1}",
                arg0: n,
                arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
            }

            WriteLine();

            //converting types to a string
            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime date = DateTime.Now;
            WriteLine(date.ToString());
            object me = new();
            WriteLine(me.ToString());
            WriteLine();

            //Converting binary items to bas64 string to encrypt

            //Allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            //populate array with random bytes
            (new Random()).NextBytes(binaryObject);
            WriteLine("Binary object as bytes:\n");

            for(int index = 0; index < binaryObject.Length; index++){

                Write($"{binaryObject[index]}.");
            }
            
            WriteLine("\n");
            //convert to base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary object as Base64:\n{encoded}");

            WriteLine();

            //Parsing strings to numbers or dates and times
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("23 Augustus 1996");
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");
            WriteLine();

            //Parsing doesn't work when the type is not correlated
            //int count = int.Parse("abc");
            //We can use TryParse instead to check whether a value can be parsed to an int.
            WriteLine("How many eggs are there?");
            int count;
            string input = ReadLine();

            //the out keyword gets the input value from input and sets it to the count int
            if(int.TryParse(input, out count)) {

                WriteLine($"There are {count} eggs");
            } else {

                WriteLine("Letters can't be eggs, stupid");
            }

            //branching purposes
            
        }
    }
}
