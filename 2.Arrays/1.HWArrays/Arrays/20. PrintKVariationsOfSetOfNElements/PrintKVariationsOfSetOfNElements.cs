using System;

    class PrintKVariationsOfSetOfNElements
    {
        /*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
*/
        private static void Variations(int[] arr, int k, int n)
        {
            if (k == arr.Length)          
            {
                PrintArray(arr);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    arr[k] = i;
                    Variations(arr, k + 1, n);     
                }
            }
        }
        private static void PrintArray(int[] arr)
        {
            foreach (var number in arr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[k];

            Variations(arr, 0, n);            
        }
    }