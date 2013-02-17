using System;

    class MaxElemInPortion
    {
        public static int SortedArr(int[] arr)
        {
            int temp, min;

            for (int j = 0; j < arr.Length - 1; j++)
            {
                min = j;

                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[k] < arr[min])
                    {
                        min = k;
                    }
                }

                temp = arr[min];
                arr[min] = arr[j];
                arr[j] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("array["+i+"] = " + arr[i]);
            }
        }

        static int GetMax(int start, int[] arr)
        {

            int max = arr[start];
            int maxIndex = start;

            for (int i = start; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
  


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter the elements of an array", n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the start index:");
            int m = int.Parse(Console.ReadLine());
            SortedArr(arr);
            GetMax(m, arr);
        }
    }
