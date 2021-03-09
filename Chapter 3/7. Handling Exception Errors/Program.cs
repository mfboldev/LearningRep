/* 
Common Exception Classes
The following exceptions are thrown by certain C# operations.

COMMON EXCEPTION CLASSES
System.ArithmeticException	        A base class for exceptions that occur during arithmetic operations, such as System.DivideByZeroException and System.OverflowException.
System.ArrayTypeMismatchException	Thrown when a store into an array fails because the actual type of the stored element is incompatible with the actual type of the array.
System.DivideByZeroException	    Thrown when an attempt to divide an integral value by zero occurs.
System.IndexOutOfRangeException	    Thrown when an attempt to index an array via an index that is less than zero or outside the bounds of the array.
System.InvalidCastException	        Thrown when an explicit conversion from a base type or interface to a derived type fails at run time.
System.NullReferenceException	    Thrown when a null reference is used in a way that causes the referenced object to be required.
System.OutOfMemoryException	        Thrown when an attempt to allocate memory (via new) fails.
System.OverflowException	        Thrown when an arithmetic operation in a checked context overflows.
System.StackOverflowException	    Thrown when the execution stack is exhausted by having too many pending method calls; typically indicative of very deep or unbounded recursion.
System.TypeInitializationException	Thrown when a static constructor throws an exception, and no catch clauses exists to catch it. 
*/

using System;
using static System.Console;

namespace _7._Handling_Exception_Errors {

    class Program {

        static void Main(string[] args) {

            WriteLine("Before parsing");
            WriteLine("What is your age?");

            string input = ReadLine();

            try {

                int age = int.Parse(input);
                WriteLine($"Your age is {age}");
            } catch(OverflowException) {

                WriteLine("The number is either too big or too small for this type");
            } catch(FormatException) {

                WriteLine("The age you entered is not a valid number format");
            } catch(Exception ex) {

                WriteLine($"{ex.GetType()} says: {ex.Message}");
            }

            WriteLine("After parsing");
        }
    }
}
