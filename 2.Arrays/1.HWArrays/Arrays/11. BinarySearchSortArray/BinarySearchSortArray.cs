using System;

    class BinarySearchSortArray
    {
        /*Write a program that finds 
         * the index of given element in a sorted array of integers by using 
         * the binary search algorithm (find it in Wikipedia).*/
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

            Console.WriteLine("Please enter the value we are going to search");
            int enteredNum = int.Parse(Console.ReadLine());

            int middle = n / 2;
            int searchNum = middle;
            while (arr[middle] != enteredNum)
            {
                searchNum = searchNum / 2;
                if (searchNum == 0)
                {
                    searchNum = 1;
                }

                if (arr[middle] > enteredNum)
                {
                    middle -= searchNum;
                }
                else
                {
                    middle += searchNum;
                }

            }
            Console.WriteLine("The entered number {0} is on {1} position in the sorted array", enteredNum, middle);
        }
    }
