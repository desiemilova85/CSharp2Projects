using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadStringWithMax20Chars
{
    /*Write a program that reads from the console a string of maximum 20 characters. 
     * If the length of the string is less than 20, the rest of the characters should be filled with '*'.
     * Print the result string into the console.*/

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter text");
        string str = Console.ReadLine();

        if (str.Length > 20)
        {
            Console.WriteLine(str.Remove(20));
        }
        else if (str.Length == 20)
        {
            Console.WriteLine(str);
        }
        else
        {
            Console.WriteLine(str.PadRight(20, '*'));
        }

    }
}