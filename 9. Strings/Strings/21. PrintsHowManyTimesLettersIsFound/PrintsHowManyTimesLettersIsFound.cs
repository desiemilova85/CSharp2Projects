using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintsHowManyTimesLettersIsFound
{
    /*Write a program that reads a string from the console and prints all different letters
     * in the string along with information how many times each letter is found. */

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter text:");
        string str = Console.ReadLine();

        int[] nums = new int['z' - 'a' + 1];

        foreach (char c in str.ToLower())
        {
            if ('a' <= c && c <= 'z')
            {
                nums[c - 'a']++;
            }
        }

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != 0) Console.WriteLine("{0}: {1}", (char)(i + 'a'), nums[i]);
    }
}