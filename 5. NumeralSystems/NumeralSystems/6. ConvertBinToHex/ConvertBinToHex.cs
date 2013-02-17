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
        string binar = Console.ReadLine();
        string hexadec = "";
        hexadec = Convert.ToString(Convert.ToInt32(binar, 2), 16);
        Console.WriteLine("Binary number of bin= {0} is hex= {1}", binar, hexadec);
    }
}
