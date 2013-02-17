using System;

    class FindMaxSumInArray
    {
        /*Write a program that finds the sequence of maximal sum in given array. Example:
  {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  ->  {2, -1, 6, 4}*/
        static void Main()
        {
            Console.WriteLine("Enter the lenght of the array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter the elements of an array", n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int end = 0;
            int sum = 0;
            int maxSum = 0;
            int step = 0;
            int kStep = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (sum > 0)
                {
                    step++;
                }
                else
                {
                    sum = 0;
                    step = 0;
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    end = i;
                    kStep = step;
                }

            }

            for (int i = end - kStep + 1; i <= end; i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Sum = " + maxSum);
        }
    }

