//Write an if-statement that examins 2 int numbers and exchange their values if the first one is bigger than the second one. 

using System;

class ExaminTwoVariables
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            int thirdNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;

        }
        Console.WriteLine("The value of your first number is: {0}. The value of your second number is {1}.", firstNumber, secondNumber);
    }
}

