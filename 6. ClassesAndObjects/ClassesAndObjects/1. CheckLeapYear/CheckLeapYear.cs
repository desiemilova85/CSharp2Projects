using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckLeapYear
{
    /*Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.*/
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter year from the console:");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        if (isLeap)
        {
            Console.WriteLine("Year is Leap");
        }
        else
        {
            Console.WriteLine("Year is NOT Leap");
        }
    }
}
