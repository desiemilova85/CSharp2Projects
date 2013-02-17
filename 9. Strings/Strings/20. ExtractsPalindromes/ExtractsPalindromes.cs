using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractsPalindromes
{
    /*Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

    static void Main(string[] args)
    {
        string str = @"Nice blue sky. No exe flying in the sky. ABBA will not come in Bulgaria.
       I don`t know what is lamal, maybe I will find some day. mouseesuom";
        char[] separatedStr = { ' ', ',', '.', '!', '\n', '\r' };
        string[] newStr = str.Split(separatedStr, StringSplitOptions.RemoveEmptyEntries);


        foreach (string word in newStr)
        {
            bool isPalindrome = true;
            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}
