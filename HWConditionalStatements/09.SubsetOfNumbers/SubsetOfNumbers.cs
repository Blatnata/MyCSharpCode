//We are given 5 integer numbers. Write firstNumber program that checks 
// if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
using System;
class SubsetOfNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());

        if ((firstNumber + secondNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) = 0", firstNumber, secondNumber);
        }
        if ((firstNumber + thirdNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", firstNumber, thirdNumber);
        }
        if ((firstNumber + fourthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", firstNumber, fourthNumber);
        }
        if ((firstNumber + fifthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", firstNumber, fifthNumber);
        }
        if ((secondNumber + thirdNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", secondNumber, thirdNumber);
        }
        if ((secondNumber + fourthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", secondNumber, fourthNumber);
        }
        if ((secondNumber + fifthNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) = 0", secondNumber, fifthNumber);
        }
        if ((thirdNumber + fourthNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) = 0", thirdNumber, fourthNumber);
        }
        if ((thirdNumber + fifthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", thirdNumber, fifthNumber);
        }
        if ((fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", fourthNumber, fifthNumber);
        }
        if ((fifthNumber + secondNumber + thirdNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", firstNumber, secondNumber, thirdNumber);
        }
        if ((firstNumber + secondNumber + fourthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", firstNumber, secondNumber, fourthNumber);
        }
        if ((firstNumber + secondNumber + fifthNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) + ({2}) = 0", firstNumber, secondNumber, fifthNumber);
        }
        if ((secondNumber + thirdNumber + fourthNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) + ({2}) = 0", secondNumber, thirdNumber, fourthNumber);
        }
        if ((secondNumber + thirdNumber + fifthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", secondNumber, thirdNumber, fifthNumber);
        }
        if ((secondNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", secondNumber, fourthNumber, fifthNumber);
        }
        if ((thirdNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) + ({2}) = 0", thirdNumber, fourthNumber, fifthNumber);
        }
        if ((thirdNumber + firstNumber + fourthNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) + ({2})= 0", thirdNumber, firstNumber, fourthNumber);
        }
        if ((thirdNumber + firstNumber + fifthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", thirdNumber, firstNumber, fifthNumber);
        }
        if ((fourthNumber + firstNumber + fifthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", fourthNumber, firstNumber, fifthNumber);
        }
        if ((firstNumber + secondNumber + thirdNumber + fourthNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) + ({2}) + ({3}) = 0", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }
        if ((firstNumber + thirdNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) = 0", firstNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        if ((firstNumber + secondNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) + ({2}) + ({3}) = 0", firstNumber, secondNumber, fourthNumber, fifthNumber);
        }
        if ((secondNumber + thirdNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine(" ({0}) + ({1}) + ({2}) + ({3}) = 0", secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        if ((secondNumber + firstNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine(" ({0})+ ({1}) + ({2}) + ({3}) = 0", secondNumber, firstNumber, fourthNumber, fifthNumber);
        }
        if ((firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) + ({4}) = 0", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        else
        {
            Console.WriteLine("There aren't such numbers!");
        }
    }

}

