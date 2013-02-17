using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertStringToUnicodeSymbol
{
    /*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. */
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter text:");
        string str = Console.ReadLine();

        foreach (var symbol in str)
        {
            Console.WriteLine("\\u{0:X4}", (int)symbol);
        }
    }
}