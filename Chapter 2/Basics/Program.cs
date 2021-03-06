using System;
using System.Linq;
using System.Reflection;

// #error version

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Literal string
            Console.WriteLine("Hello\n this is a Literal string!\n");

            //verbatim string
            Console.WriteLine(@"This is a verbatim string \n escaping doesn't work here!");

            //interpolated string
            string word = "I am a variable!";
            Console.WriteLine($"This is an interpolated string. This is a variable -> {word} \n");
            
            //composite formatting
            var date = DateTime.Now;
            Console.WriteLine("Composite formatting: Today is {0}, it's {1:HH:mm} now", date.DayOfWeek, date);

            //declare some unused variables using types in additional assemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;

            //loop throug assemblies that this app references
            foreach(var r in Assembly.GetEntryAssembly().GetReferencedAssemblies()) {

                //load the Assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));

                //declare a variable to count the number of methods
                int methodCount = 0;

                //loop through all the types in the assembly
                foreach(var t in a.DefinedTypes) {

                    //add up the counts of methods
                    methodCount += t.GetMethods().Count();

                }

                //output the count of types and their methods
                Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", 
                arg0:a.DefinedTypes.Count(), 
                arg1:methodCount, 
                arg2:r.Name);
            }

        }
    }
}
