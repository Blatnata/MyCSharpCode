// 06. Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0
//     and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
using System;
class QuadricEquation
{
    static void Main()
    {
        Console.WriteLine("Enter value of a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of c: ");
        int c = int.Parse(Console.ReadLine());
        int discriminant = (b * b) - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("No real roots exist");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("the root is: {0}", -(b / 2.0 * a));
        }
        else if (discriminant > 0)
        {
            Console.WriteLine("First root is: {0}, second root is: {1}", (-b - Math.Sqrt(discriminant)) / (2.0 * a), (-b + Math.Sqrt(discriminant)) / (2.0 * a));
        }
    }
}



