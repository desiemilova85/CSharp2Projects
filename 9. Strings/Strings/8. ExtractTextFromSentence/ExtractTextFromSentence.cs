using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ExtractTextFromSentence
{

    /*Write a program that extracts from a given text all sentences containing given word.*/
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter text with more than 1 sentence:");
        string str = Console.ReadLine();
        Console.WriteLine("Please enter word you would like to be checked:");
        string ckeckWord = Console.ReadLine();
        string[] sentences = str.Split('.');

        for (int i = 0; i < sentences.Length; i++)
        {
            if (Regex.Matches(sentences[i], @"\b" + ckeckWord + @"\b").Count > 0)
            {
                Console.WriteLine("The sentences where you can find word {0} are {1}",ckeckWord,(sentences[i] + ".").Trim());
            }
        }
    }
}
