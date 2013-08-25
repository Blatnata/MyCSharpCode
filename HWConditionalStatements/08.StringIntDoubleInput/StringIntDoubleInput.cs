 //Write a program that, depending on the user's choice inputs int, 
// double or string variable. If the variable is integer or double, increases it with 1. 
// If the variable is string, appends "*" at its end. The program must show the value of that 
// variable as a console output. Use switch statement.
using System;

class StringIntDoubleInput
{
    static void Main()
    {
        Console.WriteLine("Input 1 for int, 2 for double or 3 for string variable:");
        byte variableType = byte.Parse(Console.ReadLine());
        switch(variableType)
        {
            case 1: Console.WriteLine("Input int value:");
                int intVariable =int.Parse(Console.ReadLine());
                Console.WriteLine("Your value is: {0}",intVariable+1);break;
            case 2: Console.WriteLine("Input double value:");
                double doubleVariable=double.Parse(Console.ReadLine());
                Console.WriteLine("Your value is: {0}",doubleVariable+1);break;
            case 3: Console.WriteLine("Input string value:");
                string stringValue = Console.ReadLine();
                Console.WriteLine("Your value is: {0}",stringValue + '*');break;
            default:Console.WriteLine("Your input is wrong. Please choose between 1, 2 or 3.");break;
        }

    }
}

