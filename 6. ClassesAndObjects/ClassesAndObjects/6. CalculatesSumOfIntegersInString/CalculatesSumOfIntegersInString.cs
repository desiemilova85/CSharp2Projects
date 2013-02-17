using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculatesSumOfIntegersInString
{
    /*You are given a sequence of positive integer values written into a string, separated by spaces. 
     * Write a function that reads these values from given string and calculates their sum.
     * Example:
		string = "43 68 9 23 318"  result = 461*/

    static void Main(string[] args)
    {
        Console.Write("Type numbers separated by space: ");
        string inputString = Console.ReadLine();
        string[] numbers = inputString.Split(' ');
        int sum = 0;
        foreach (string n in numbers)
        {
            sum += int.Parse(n);
        }
        Console.WriteLine("The sum of the entered numbers in the string is  {0}", sum);
    }
}