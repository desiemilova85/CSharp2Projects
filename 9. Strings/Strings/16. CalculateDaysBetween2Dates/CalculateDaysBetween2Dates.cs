using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CalculateDaysBetween2Dates
    {
        /*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. */

        static void Main(string[] args)
        {
            string format = "dd.MM.yyyy";
            Console.WriteLine("Please enter first date in format dd.MM.yyyy:");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter second date in format dd.MM.yyyy:");
            string second = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(first, format, CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(second, format, CultureInfo.InvariantCulture);
            Console.WriteLine((secondDate - firstDate).TotalDays);

        }
    }
