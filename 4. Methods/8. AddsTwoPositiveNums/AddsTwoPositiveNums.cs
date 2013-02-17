using System;

class AddsTwoPositiveNums
{

    static int[] SumArr(int[] arr1, int[] arr2)
    {
        int minLength = Math.Min(arr1.Length, arr2.Length);
        int maxLength = Math.Max(arr1.Length, arr2.Length);
        int[] result = new int[maxLength + 1];
        result[0] = 0;
        for (int i = 0; i < minLength; i++)
        {
            result[i] += arr1[i] + arr2[i];
            if (result[i] > 9)
            {
                result[i] %= 10;
                result[i + 1] = 1;
            }
        }
        if (arr1.Length > arr2.Length)
        {
            for (int i = minLength; i < maxLength; i++)
            {
                result[i] += arr1[i];
                if (result[i] > 9)
                {
                    result[i] %= 10;
                    result[i + 1] = 1;
                }
            }
        }
        else
        {
            for (int i = minLength; i < maxLength; i++)
            {
                result[i] += arr2[i];
                if (result[i] > 9)
                {
                    result[i] %= 10;
                    result[i + 1] = 1;
                }
            }
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter the length of the 1st array = ");
        int n = int.Parse(Console.ReadLine());
        int[] newArray1 = new int[n];
        for (int j = 0; j < n; j++)
        {
            Console.Write("Array1[{0}] = ", j);
            newArray1[j] = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter the length of 2nd array = ");
        int m = int.Parse(Console.ReadLine());
        int[] newArray2 = new int[m];
        for (int j = 0; j < m; j++)
        {
            Console.Write("Array2[{0}] = ", j);
            newArray2[j] = int.Parse(Console.ReadLine());
        }
        int[] result = SumArr(newArray1, newArray2);
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
