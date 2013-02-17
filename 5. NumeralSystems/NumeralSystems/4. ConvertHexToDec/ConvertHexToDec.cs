using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertHexToDec
{
    static void Main(string[] args)
    {
        Console.Write("Please enter binary number : ");
        string hexVal = Console.ReadLine();
        int decimalVal = Convert.ToInt32(hexVal, 16);
        Console.WriteLine("If hex is = {0}, then dec is {1}",hexVal,decimalVal);
    }
}
