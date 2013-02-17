using System;

    class SelectionSortArrayAlgorithm
    {
        /*Sorting an array means to arrange its elements in increasing order.
         * Write a program to sort an array. Use the "selection sort" algorithm: 
         * Find the smallest element, move it at the first position, 
         * find the smallest from the rest, move it at the second position, etc.*/
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
    }

