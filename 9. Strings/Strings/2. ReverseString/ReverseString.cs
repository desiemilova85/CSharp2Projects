using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    /*Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample"  "elpmas".*/
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter string: ");
        string str = Console.ReadLine();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
        Console.WriteLine();
    }
}