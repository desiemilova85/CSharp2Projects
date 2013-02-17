using System;

class CompareElementsOf2Arrays
{
    static void Main()
    {
        Console.Write("Enter lenght of 1st array:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter lenght of 2nd array:");
        int m = int.Parse(Console.ReadLine());

        int[] firstArr = new int[n];
        int[] secondArr = new int[m];

        Console.WriteLine("Enter {0} elements for first array", n);
        for (int i = 0; i < n; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter {0} elements for second array", m);
        for (int i = 0; i < m; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        if (n == m)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        else
        {
            areEqual = false;
        }

        Console.WriteLine("The two arrays are equal: {0}", areEqual);
    }

}
