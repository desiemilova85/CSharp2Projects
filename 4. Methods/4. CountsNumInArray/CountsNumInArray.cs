using System;

public class CountsNumInArray
{
    public static int CountsNumberOfIntInArray(int[] arr, int number)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                count++;
            }
        }
        return count;
    }

    public static void Main(string[] args)
    {
        Console.Write("Please enter the length of the array = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int j = 0; j < n; j++)
        {
            Console.Write("Array[{0}] = ", j);
            array[j] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} is met {1} times in the Array", m, CountsNumberOfIntInArray(array, m));
    }
}

