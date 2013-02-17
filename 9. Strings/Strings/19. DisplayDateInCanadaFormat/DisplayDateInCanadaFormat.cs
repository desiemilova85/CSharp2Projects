using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

class DisplayDateInCanadaFormat
{
    /*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
     * Display them in the standard date format for Canada.
*/
    static void Main(string[] args)
    {
        string format = "dd.MM.yyyy";
        Console.WriteLine("Please enter text:");
        string str = Console.ReadLine();
        foreach (var item in Regex.Matches(str, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            string newStr = Convert.ToString(item);

            DateTime date = DateTime.ParseExact(newStr, format, CultureInfo.InvariantCulture);

            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
        }

    }
    
}