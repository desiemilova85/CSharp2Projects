using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinRepresentationOfShort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter short number = ");
        short number = short.Parse(Console.ReadLine());
        short sing = number;

        if (sing <= 0) { number = (short)(number + 1); }

        Console.Write("Binary = ");

        for (int i = 15; i >= 0; i--)
        {
            short num = (short)Math.Pow(2, i);
            short result = (short)(number / num);
            number = (short)(number % num);

            if (sing < 0) { Console.Write(1 + result); }
            else { Console.Write(result); }
        }
        Console.WriteLine();
    }
}

