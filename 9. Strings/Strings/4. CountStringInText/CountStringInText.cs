using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountStringInText
{
    /*Write a program that finds how many times a substring is contained in a given text 
        * (perform case insensitive search).*/

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter text:");
        string str = Console.ReadLine();
        Console.WriteLine("Please enter string which you would like to counter in the text:");
        string subStr = Console.ReadLine();
        int count=0;
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str.Substring(i, 2).ToLower() ==subStr)
            {
                count++;
                i++;
            }
        }
        Console.WriteLine(count);
    }
}
