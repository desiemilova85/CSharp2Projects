using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintCurrentDay
{
    /*Write a program that prints to the console which day of the week is today. Use System.DateTime.*/

    static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        object currentDay = today.DayOfWeek;
        Console.WriteLine("Today is {0}",currentDay );
    }
}
