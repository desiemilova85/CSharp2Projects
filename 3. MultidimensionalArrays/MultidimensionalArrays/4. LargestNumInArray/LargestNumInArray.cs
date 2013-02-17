using System;

class LargestNumInArray
{
    static void Main()
    {
        Console.WriteLine("Please enter dimension of matrix:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number K:");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Please enter elements of the matrix:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int index = Array.BinarySearch(array, k);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }

        if (index < -1) Console.WriteLine(array[~index - 1]);
        else if (~index == 0) Console.WriteLine("No number exist");
        else Console.WriteLine("The largest number which is smaller than {0} is = {1}",k,array[index]);        

    }
}
