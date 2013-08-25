//Write a program that finds the biggest of three integers using nested if statements.
using System;

class BiggestOfThreeInts
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("The largest number is {0}", firstNumber);
            }
            
            else
            {
                Console.WriteLine("The largest number is {0}", thirdNumber);
            }
        }

        else
        {
            
            if (secondNumber < thirdNumber)
            {
                Console.WriteLine("The largest number is {0}", thirdNumber);
            }
            
            else
            {
                Console.WriteLine("The largest number is {0}", secondNumber);
            }
        }
    }
}

