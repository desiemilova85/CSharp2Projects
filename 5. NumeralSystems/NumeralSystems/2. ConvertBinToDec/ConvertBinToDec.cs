using System;
using System.Linq;


class ConvertBinToDec
{
    static void Main(string[] args)
    {
        Console.Write("Please enter binary number : ");
        string n = Console.ReadLine();
        long number = Convert.ToInt32(n);
        long digit, temp;
        int decimalN = 0;

        for (int i = 0; i < n.Length; i++)
        {
            digit = number % 10;
            decimalN += (int)(digit * Math.Pow(2, i));
            temp = number / 10;
            number = temp;
        }

        Console.WriteLine("The Decimal representation of the given number is: {0}", decimalN);
    }
}