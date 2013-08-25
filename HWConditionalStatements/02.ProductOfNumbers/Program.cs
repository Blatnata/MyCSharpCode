//write a program that show the sign of(+) or (-) of the product of 3 real numbers without calculating it.
//use a sequence of if statements
using System;
class ProdustOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int signCounter = 0;
        if (firstNumber < 0)
        {
            signCounter++;
        }

        if (secondNumber < 0)
        {
            signCounter++;
        }

        if (thirdNumber < 0)
        {
            signCounter++;
        }

        if (signCounter % 2 == 0)
        {
            Console.WriteLine("The product of your numbers is positive");
        }
        else
        {
            Console.WriteLine("The product of your numbers is negative");
        }
    }
}
