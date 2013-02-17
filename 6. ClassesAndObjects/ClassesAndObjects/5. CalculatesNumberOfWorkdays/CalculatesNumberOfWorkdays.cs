using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculatesNumberOfWorkdays
{
    /*Write a method that calculates the number of workdays between today and given date, passed as parameter. 
     * Consider that workdays are all days from Monday to Friday 
     * except a fixed list of public holidays specified preliminary as array.*/

    static int NumberOfWorkingDays(DateTime startDate, DateTime endDate)
    {
        DateTime[] holidays = {
                                new DateTime(2013, 01, 1),
                                new DateTime(2013, 03, 03),
                                new DateTime(2013, 05, 01),
                                new DateTime(2013, 05, 24),
                                new DateTime(2013, 09, 06),
                                new DateTime(2013, 09, 22),
                                new DateTime(2013, 11, 01),
                                new DateTime(2013, 12, 24),
                                new DateTime(2013, 12, 25),
                                new DateTime(2013, 12, 26),
                              };

         int workdays = 0;
            while (startDate <= endDate)
            {
                if (!((startDate.DayOfWeek == DayOfWeek.Saturday) || (startDate.DayOfWeek == DayOfWeek.Sunday) || holidays.Contains(startDate)))
                {
                    workdays++;
                }
                startDate = startDate.AddDays(1);
            }
 
            return workdays;
        }
   
    static void Main(string[] args)
    {
        Console.Write("Please enter end date in format yyyy/mm/dd: ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        DateTime startDate = DateTime.Today;
        Console.WriteLine("There are {0} working days between {1} and {2}", NumberOfWorkingDays(startDate, endDate), startDate, endDate);
    }
}
