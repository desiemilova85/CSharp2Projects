using System;
    class SortsArrayByElLenght
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of strings in the array = ");
            int n = Int32.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("string {0} = ", i);
                arr[i] = Console.ReadLine();
            }
            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                    if (arr[i].Length > arr[j].Length)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
