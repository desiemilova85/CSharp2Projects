using System;

    class MaxSequenceOfEqualElements
    {
        /*Write a program that finds the maximal sequence of equal elements in an array.
    Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/
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
            int sum = 0;
            int biggerSum = 0;
            int number = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    sum++;
                    if (biggerSum <= sum)
                    {
                        biggerSum = sum;
                        number = arr[i];
                    }
                }
                else
                {
                    sum = 0;
                }
            }

            Console.WriteLine("There are  {0} times of consecutive {1}", biggerSum+1, number);
        }
    }
