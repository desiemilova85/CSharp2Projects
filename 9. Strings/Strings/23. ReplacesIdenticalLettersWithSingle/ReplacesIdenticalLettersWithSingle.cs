using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplacesIdenticalLettersWithSingle
{
    /*Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
     * Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".*/

    static void Main(string[] args)
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder sb = new StringBuilder(text);

        for (int letter = 0; letter < sb.Length - 1; letter++)
        {
            if (sb[letter] == sb[letter + 1])
            {
                sb.Remove(letter, 1);
                letter--;
            }
        }
        Console.WriteLine(sb);
    }
}
