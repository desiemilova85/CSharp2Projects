using System;


class CalculateNFactorial
{
    private static void Factorial(int n)
    {
        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("The result for {0}! is = {1}", n, factorial);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n.It should be in borders: 0 to 100: ");
        int n = int.Parse(Console.ReadLine());
        Factorial(n);
    }
}
