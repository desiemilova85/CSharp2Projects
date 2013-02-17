using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplaceWordsWithAsteriks
{
    /*We are given a string containing a list of forbidden words and a text containing some of these words.
     * Write a program that replaces the forbidden words with asterisks.*/

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter text:");
        string str = Console.ReadLine();
        string[] forbidenWords = "PHP, CLR, Microsoft".Split(',');

        for (int i = 0; i < forbidenWords.Length; i++)
        {
            forbidenWords[i] = forbidenWords[i].Trim();
            str=str.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
        }
        Console.WriteLine(str);
    }
}
