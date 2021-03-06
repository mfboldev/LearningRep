/*
Nullable types are enabled
since C# 8.0 you can choose to assign the "null" value to empty types
you can also disable it and not assign the "null" value to empty types
This saves space and makes storing data faster
*/
#nullable enable
using System;

namespace NullHandling {
    class Address{
        
        //the ? after string makes the value nullable if there is nothing in the variable
        public string? Building;
        /*
        Because the nullHandling is enabled, the C# extension in the problems window below warns
        of that the Non-Nullable field must contain a Non-NULL value.
        This is why we assign the strings that are null with "string.Empty"
        */
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;


    }
    class Program{

        static void Main(string[] args){
            
            int thisCannotBeNull = 4;
            //int thisCannotBeNull = null;
            int? thisCouldBeNull = null;

            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;

            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            //notice how "Building" throws no warning and the others do throw a warning
            Address address = new();
            address.Building = null;
            address.Street = null;
            address.City = null;
            address.Region = null;

            //check that the variable is not null before using it
            /* if(thisCouldBeNull != null) {
                //access a member of thisCouldBeNull
                int length = thisCouldBeNull.Value;
            } */

            string authorName = null;
            /* int x = authorName.Length;
            int? y = authorName.Length; */

            var result = authorName?.Length ?? 3;
            Console.WriteLine(result);

        }
    }
}

