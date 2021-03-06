using System;

//storing a double in an object
object heigth = 1.75;

//storing a string in an object
object name = "Furkan";

//gives compile error!
Console.WriteLine($"{name} is {heigth} meters tall.");

//tell compiler it is a string
//int length1 = name.Length;
int length2 = ((string)name).Length;

Console.WriteLine($"{name} has {length2} characters.");

//storing a string in a dynamic object
dynamic anotherName = "Ahmed";

/*
This compiles but would throw an exception at run-time
if you later store a datatype that does not have a property named length 
*/
//int length = anotherName.length;
//Console.WriteLine($"{length}");

//the default() operator shows what is already in a type
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

