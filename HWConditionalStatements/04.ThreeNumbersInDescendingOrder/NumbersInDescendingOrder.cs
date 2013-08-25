// Sort 3 real values in descending order using nested if statements.
using System;
class NumbersInDescendingOrder
{
    static void Main()
    {

        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int smallestNum;
        int mediumNum;
        int largestNum;

        if (firstNumber > secondNumber)
        {

            if (secondNumber > thirdNumber)
            {
                largestNum = firstNumber;
                mediumNum = secondNumber;
                smallestNum = thirdNumber;
            }
            else
            {
                if (firstNumber > thirdNumber)
                {
                    largestNum = firstNumber;
                    mediumNum = thirdNumber;
                    smallestNum = secondNumber;
                }
                else
                {
                    largestNum = thirdNumber;
                    mediumNum = firstNumber;
                    smallestNum = secondNumber;
                }
            }
        }
        else
        {
            if (secondNumber < thirdNumber)
            {
                largestNum = thirdNumber;
                mediumNum = secondNumber;
                smallestNum = firstNumber;
            }
            else
            {
                if (firstNumber > thirdNumber)
                {
                    largestNum = secondNumber;
                    mediumNum = firstNumber;
                    smallestNum = thirdNumber;
                }
                else
                {
                    largestNum = secondNumber;
                    mediumNum = thirdNumber;
                    smallestNum = firstNumber;
                }
            }
        }
        Console.WriteLine("{0} {1} {2}", largestNum, mediumNum, smallestNum);
    }
}


      