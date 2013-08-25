//Write program that asks for a digit and depending on the 
// input shows the name of that digit (in English) using a switch statement.
using System;

class DigitName
{
    static void Main()
    {
        Console.WriteLine("Enter letter of the alphabet: ");
        char digit = char.Parse(Console.ReadLine());
        Console.WriteLine("Your letter is pronounced as: ");
        switch(digit)
        {
            case'a':Console.WriteLine("[ei]");break;
            case'b':Console.WriteLine("[bi]"); break;
            case 'c': Console.WriteLine("[si]"); break;
            case 'd': Console.WriteLine("[di]"); break;
            case 'e': Console.WriteLine("[i:]"); break;
            case 'f': Console.WriteLine("[ef]"); break;
            case 'g': Console.WriteLine("[dji]"); break;
            case 'h': Console.WriteLine("[eitch]"); break;
            case 'i': Console.WriteLine("[ai]"); break;
            case 'j': Console.WriteLine("[djei]"); break;
            case 'k': Console.WriteLine("[kei]"); break;
            case 'l': Console.WriteLine("[el]"); break;
            case 'm': Console.WriteLine("[em]"); break;
            case 'n': Console.WriteLine("[en]"); break;
            case 'o': Console.WriteLine("[ou]"); break;
            case 'p': Console.WriteLine("[pi]"); break;
            case 'q': Console.WriteLine("[kju]"); break;
            case 'r': Console.WriteLine("[a:]"); break;
            case 's': Console.WriteLine("[es]"); break;
            case 't': Console.WriteLine("[ti]"); break;
            case 'u': Console.WriteLine("[iu]"); break;
            case 'v': Console.WriteLine("[vi]"); break;
            case 'w': Console.WriteLine("[dabl iu]"); break;
            case 'x': Console.WriteLine("[eks]"); break;
            case 'y': Console.WriteLine("[uai]"); break;
            case 'z': Console.WriteLine("[zet]"); break;
            default: Console.WriteLine("Wrong input!"); break;
        }
    }
}

