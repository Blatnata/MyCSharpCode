using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a year from the
//console and checks whether it is a leap. Use DateTime.



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The year {0} is Leap!", year);
        }
        else
        {
            Console.WriteLine("The year {0} is NOT Leap!", year);
        }
    }
}
