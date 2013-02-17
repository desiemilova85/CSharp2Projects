using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class ChangesTextWithGivenString
{
    /*. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
     * The tags cannot be nested.*/

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter text:");
        string str = Console.ReadLine();
        Console.WriteLine(Regex.Replace(str, "<upcase>(.*?)</upcase>", m => m.Groups[2].Value.ToUpper()));
    }
}
