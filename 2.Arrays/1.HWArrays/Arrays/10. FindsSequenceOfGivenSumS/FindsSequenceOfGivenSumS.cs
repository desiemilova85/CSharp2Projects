using System;

    class FindsSequenceOfGivenSumS
    {
        /*Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:  {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5} */
        static void Main()
        {
            Console.WriteLine("Enter sum Number");
            int intSum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lenght of the array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter the elements of an array", n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int start = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                start = i;
                sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == intSum)
                    {
                        for (int k = start; k <= arr[j]; k++)
                        {
                            Console.WriteLine(arr[k]);
                        }
                    }
                }
            }
        }
    }
