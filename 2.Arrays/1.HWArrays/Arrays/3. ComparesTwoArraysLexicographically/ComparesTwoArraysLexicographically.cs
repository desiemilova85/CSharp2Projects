using System;

    class ComparesTwoArraysLexicographically
    {
        static void Main()
        {
            Console.WriteLine("Please enter length for the first array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter length for the second array");
            int m = int.Parse(Console.ReadLine());

            char[] firstArr = new char[n];
            char[] secondArr = new char[m];
            
            Console.WriteLine("Please enter the first {0} characters/numbers for the first array", n);
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the first {0} characters/numbers for the second array", m);
            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = char.Parse(Console.ReadLine());
            }
            bool areEqual = true;
            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine("Second arrays is shorter than first array.Arrays are not equal");
            }
            else
            {
                if (firstArr.Length < secondArr.Length)
                {
                    Console.WriteLine("First Array is shorter than second array. Arrays are not equal.");
                }
                else
                {
                    for (int i = 0; i < firstArr.Length; i++)
                    {
                        if (firstArr[i] != secondArr[i])
                        {
                            areEqual = false;
                            Console.WriteLine("The two arrays are  lexicographically the same: {0}", areEqual);
                        }
                        else 
                        Console.WriteLine("The two arrays are  lexicographically the same: {0}",areEqual);
                    }
                }
            }
        }
    }