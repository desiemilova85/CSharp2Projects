using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertToAnyNumSys
{
    static void Main(string[] args)
    {

        Console.Write("Please enter first numeral base from which you want to convert: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter second numeral base to which you want to convert: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number: ");
        string number = Console.ReadLine();
        string convertedNum = Convert.ToString(Convert.ToInt64(number, n), m);
        Console.WriteLine("The representation of the number is: {0}", convertedNum);
    }
}