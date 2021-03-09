using System;
using static System.Console;

int number = 1;

while(number < 100){

    if(number / 3 == 1){

        ++number;
        Write($"fizz, ");
    } else {

        ++number;
        Write($"{number}, ");
    }

}
