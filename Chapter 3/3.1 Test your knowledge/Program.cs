using System;
using static System.Console;

//1. What happens when you divide int variable with 0?

int zero = 0;
int one = 1;
try {
    
    WriteLine(one / zero);
} catch(Exception ex) {

    WriteLine($"Exception caught\nType: {ex.GetType()}");
}

//1.a System throws an exception called "SystemDivideByZeroException"
//2. what happens when you divide a double variable by 0?

double twoPointTwo = 2.2;
double onePointZero = 1.0;

WriteLine(twoPointTwo / zero);
WriteLine(onePointZero / zero);

double infinity = double.PositiveInfinity;

WriteLine(infinity);

//2.a The double goes into positive infinity
//3. What happens when you overflow an int variable beyond its range?

int overflow = int.MaxValue;

WriteLine($"not overflown: {overflow}");
WriteLine($"overflown: {overflow + 1}");

//3.a the int value goes to minValue and starts counting from there
//4. What is the difference between x = y++ and x = ++y

/* int i = 0;
while(i < 10 ) {

    WriteLine($"i++ {i}");
    WriteLine("New increment");
    i++;
}

int j = 0;
while(j < 10) {

    WriteLine($"++j {j}");
    WriteLine("New increment");
    ++j;
} */

//4.a prefix (++j) increments before appointing - suffix (i++) increments after appointing
//5. What is the difference between break, continue and return in a loop statement

int returns = 1;
while(returns < 10) {

    WriteLine("How many times do you read me? You read me ten times");
    returns++;
    //return;
}

int breaks = 1;
while(breaks < 10) {

    WriteLine("How many times do you read me? you read me once");
    breaks++;
    break;
}

int continues = 1;
while(continues < 10) {

    WriteLine("Mine?");
    continues++;
    continue;
}

//5.a return stops the whole program, break stops the loop, continue continues
//6. what three parts do you need for a for loop?

for (int i = 0; i < 3; i++){}

//6.a initializer, condition, iterator
//7. what is the difference between = and ==

int two = 2;
int three = 3;
if(three == 3){}

//7.a = is an appointer, == is a checker
//8 Does the following statement compile? for(; true;);

for(;true;);

//8.a yes, it is an infinite loop
//9 What does the underscore _ represent in a switch expression
//9.a the default keyword, which executes always last regardless of position
//10 what interface does the foreach loop iterate? arrays and lists
 