using System;

class FirstBiggerNum
{
    static int FirstBiggerNumMethod(int[] arr)
    {
        int index = 0;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if ((arr[i] > arr[i + 1]) && (arr[i] > arr[i - 1]))
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }
        return index;
    }
    static void Main()
    {
        Console.Write("Please enter the length of the array = ");
        int n = int.Parse(Console.ReadLine());
        int[] newArray = new int[n];
        for (int j = 0; j < n; j++)
        {
            Console.Write("Array[{0}] = ", j);
            newArray[j] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The first bigger number at position {0} is {1}:", FirstBiggerNumMethod(newArray), newArray[FirstBiggerNumMethod(newArray)]);
    }
}