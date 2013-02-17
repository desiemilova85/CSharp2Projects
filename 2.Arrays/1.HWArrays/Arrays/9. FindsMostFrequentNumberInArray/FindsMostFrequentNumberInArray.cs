using System;

    class FindsMostFrequentNumberInArray
    {
        /*Write a program that finds the most frequent number in an array. Example:
{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4(5 times)*/
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

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        int number = arr[i];
                        arr[i] = arr[j];
                        arr[j] = number;
                    }
                }
            }
            int sum = 0;
            int maxSum = 0;
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    sum++;
                    if (maxSum <= sum)
                    {
                        maxSum = sum;
                        index = arr[i];
                    }
                }
                else
                {
                    sum = 0;
                }
            }
            Console.WriteLine("The {0} coould be seen {1} times in the array", index, maxSum + 1);
        }
    }
