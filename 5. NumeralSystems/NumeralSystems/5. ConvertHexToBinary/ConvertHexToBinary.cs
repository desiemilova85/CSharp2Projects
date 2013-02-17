using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertHexToBinary
{

    static void Main(string[] args)
    {
        Console.Write("Please enter hex number : ");
        string hex = Console.ReadLine();
        string bin = "";
        bin = Convert.ToString(Convert.ToInt32(hex, 16), 2);
        Console.WriteLine("Binary number of hex= {0} is = {1}",hex, bin);
    }
}
