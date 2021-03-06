using System;

//can reference any array of strings 
string[] names;

//allocating memory for four strings in an array
names = new string[4];

//storing names at index positions
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Karen";

//loop through the array and write it
for (int i = 0; i < names.Length; i++) {
    
    //output the item at index position i
    Console.WriteLine(names[i]);
}

Console.WriteLine(names.Length);