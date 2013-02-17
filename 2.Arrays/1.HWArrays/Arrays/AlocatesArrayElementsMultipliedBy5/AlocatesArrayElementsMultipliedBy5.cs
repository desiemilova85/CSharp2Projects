using System;

class AlocatesArrayElementsMultipliedBy5
{
    static void Main()
    {
        int[] arr = new int[20];
        for (int index = 0; index < arr.Length; index++)
        {
            arr[index] = index * 5;
            Console.Write(arr[index] + " ");
        }
    }
}
