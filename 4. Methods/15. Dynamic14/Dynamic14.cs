using System;

class MaxMinAddProductOfElems
{
    static T Minimum<T>(params T[] array)
    {
        dynamic min = dynamic.MaxValue;
        for (dynamic i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static T Maximum<T>(params T[] array)
    {

        dynamic max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static double T Average<T>(params T[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return (double)(sum/array.Length);
    }

    static T Sum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static T Product<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
    static void Main(string[] args)
    {
        Console.Write("Please enter the length of array = ");
        int n = int.Parse(Console.ReadLine());
        int[] newArray = new int[n];
        for (int j = 0; j < n; j++)
        {
            Console.Write("Array1[{0}] = ", j);
            newArray[j] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Minimum number in the array is {0}", Minimum(newArray));
        Console.WriteLine("Max number in the arrays is {0}", Maximum(newArray));
        Console.WriteLine("Average number in the array is {0}", Average(newArray));
        Console.WriteLine("Sum of elements in the array is {0}", Sum(newArray));
        Console.WriteLine("Product of elements in array is {0}", Product(newArray));
    }
}
