//Write a program that finds the greatest of given 5 variables
using System;
class GreatestOfFiveNumbers
{
    static void Main()
    {
        int i;
        int largestNumber;
        int[] array = new int[5];
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter number {0}: ", i + 1);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        largestNumber = array[0];
        for (i = 0; i < 5; i++)
        {
            if (array[i] > largestNumber)
            {
                largestNumber = array[i];
            }
        }
        Console.WriteLine("The Largest number is :{0}", largestNumber);
        Console.ReadLine();
    }
}

