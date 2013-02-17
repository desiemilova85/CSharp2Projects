using System;

using System.Linq;

class ConvertDecToHex
{

    static void ConvertToHex(int n)
    {
        if (n == 0)
        {
            return;
        }
        else
        {
            int remainder = n % 16;
            n = n / 16;
            ConvertToHex(n);

            switch (remainder)
            {
                case 10:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("B");
                    break;
                case 12:
                    Console.Write("C");
                    break;
                case 13:
                    Console.Write("D");
                    break;
                case 14:
                    Console.Write("E");
                    break;
                case 15:
                    Console.Write("F");
                    break;
                default:
                    Console.Write(remainder);
                    break;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter decimal number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("The hex representation of {0} is : ", n);
        ConvertToHex(n);      
        Console.ReadKey();

    }
}
