using System;

    class QuickSortArray
    {
        Console.WriteLine("Enter the lenght of the array");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Please enter the elements of an array", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        private int len;

        public  QuickSort()
        {
            sortelem(0, len - 1);
        }

        public  sortelem(int left, int right)
        {
            int pivot, lHolder, rHolder;

            lHolder = left;
            rHolder = right;
            pivot = arr[left];

            while (left < right)
            {
                while ((arr[right]>= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    arr[left]=arr[right];
                    left++;
                }

                while ((arr[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    arr[right] = arr[left];
                    right--;
                }
            }

            arr[left] = pivot;
            pivot = left;
            left = lHolder;
            right = rHolder;

            if (left < pivot)
            {
                sort(left, pivot - 1);
            }

            if (right > pivot)
            {
                sort(pivot + 1, right);
            }
        }

        public static void Main()
        {
            quickSort q_Sort = new quickSort();

            int[] arr = {4,3,1,4,6,7,5,4,3,5,6,87,8};
            q_Sort.arr = arr;
            q_Sort.len = q_Sort.arr.Length;

            // Sort the array
            q_Sort.QuickSort();

            for (int j = 0; j < q_Sort.len; j++)
            {
                Console.WriteLine(q_Sort.arr[j]);
            }
            Console.ReadKey();
        }
        }
    }

