using System;


    class FindKElementsWithMaxSumInArray
    {
        /*Write a program that reads two integer numbers N and K and an array of N elements from the console.
         Find in the array those K elements that have maximal sum.*/
        static void Main()
        {
            Console.WriteLine("Please enter first number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Please enter the elements of an array", n);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            string bestSeq = "";
            int sum = 0;
            int bestSum = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                string currentSeq = "";
                if (i + k > arr.Length)
                {
                    break;
                }
                for (int j = i; j < i + k; j++)
                {
                    sum = sum + arr[j];
                    currentSeq = currentSeq + ' ' + arr[j];
                }
                if (sum > bestSum)
                {
                    bestSeq = currentSeq;
                    bestSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine("The best sequence is : {0}",bestSeq);
            Console.WriteLine("The best sum is :{0}",bestSum);
        }
    }

