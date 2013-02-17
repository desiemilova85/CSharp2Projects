using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortsWords
{
    /*Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter text:");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}