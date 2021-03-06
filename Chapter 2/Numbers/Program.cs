using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //unsigned integers are positive whole numbers, including 0
            uint naturalNumber = 24;

            //integer is either or positive whole number, including 0
            int integerNumber = -42;

            //floats are single precision floating point. F suffix makes it a float literal(not accurate)
            float realNumber = 2.3F;

            //double means double precision floating point (not accurate)
            double anotherRealNumber = 2.9;

            //Decimal stores numbers as integers and then shifts the comma. used for accuracy
            decimal theRealestNumber = 12.75M;
            
            //booleans are either true or false, 0 or 1
            bool happy = true;
            bool sad = false;

            //three numbers that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            //check wether the variables have the same value
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            //check the numbers
            Console.WriteLine($"{decimalNotation}\n{binaryNotation}\n{hexadecimalNotation}");

        }
    }
}
