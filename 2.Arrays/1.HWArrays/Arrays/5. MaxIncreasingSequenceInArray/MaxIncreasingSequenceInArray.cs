using System;


    class MaxIncreasingSequenceInArray
    {
        /*Write a program that finds the maximal increasing sequence in an array.
Example: {3, 2, 3, 4, 2, 2, 4} ->{2, 3, 4}.*/

        static void Main()
        {
            Console.WriteLine("Please enter length for array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter the numbers of the array", n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            int start = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int counter = 1;
                while (i < arr.Length - 1 && arr[i] < arr[i + 1])
                {
                    counter++;
                    i++;
                }
                if (counter > max)
                {
                    max = counter;
                    start = i - max + 1;
                }
            }
            Console.WriteLine("The maximal increasing seuqence is {0}", max);
            for (int i = start; i < start + max; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
