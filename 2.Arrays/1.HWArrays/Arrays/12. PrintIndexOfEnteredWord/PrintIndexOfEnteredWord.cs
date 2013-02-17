using System;

   class PrintIndexOfEnteredWord
    {
        /*Write a program that creates an array containing all letters from the alphabet (A-Z). 
         * Read a word from the console and print the index of each of its letters in the array.
        */
        static void Main()
        {
            char[] arr = new char['Z'-'A'+1]; 
            int index = 65; 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)index;
                index++;
            }
            Console.WriteLine("Please enter a word with capital letters:");
            string word = Console.ReadLine().ToUpper();
            foreach (char letter in word)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == letter)
                    {
                        Console.WriteLine("The index of the letter {0} is {1}", letter, i);
                        break;
                    }
                }
            }
        }
    }