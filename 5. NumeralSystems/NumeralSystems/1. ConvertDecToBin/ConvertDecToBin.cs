using System;
using System.Linq;
class ConvertDecToBin
{
    static void Main()
    {
        Console.Write("Please enter number:  ");
        int n = int.Parse(Console.ReadLine());
        int divider = 2;
        int remainder;
        int result;
        string binary = "";

        remainder = n % divider;
        result = n / divider;
        binary += remainder;

        while (result > 0)
        {
            remainder = result % divider;
            result /= divider;
            binary += remainder;
        }

        binary = new string(binary.ToCharArray().Reverse().ToArray());
        Console.WriteLine("Binary representation of {0} is: {1}", n, binary);
    }
}
