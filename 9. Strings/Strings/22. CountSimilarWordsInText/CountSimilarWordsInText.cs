using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class CountSimilarWordsInText
{
    static void Main(string[] args)
    {
        /*Write a program that reads a string from the console and lists all different words
         * in the string along with information how many times each word is found.*/


        Console.WriteLine("Please enter text:");
        string text = Console.ReadLine();
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (var str in Regex.Matches(text, @"\w+"))
        {
 
            string word= Convert.ToString(str);
 
            if (word.Length > 2)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
        }
        foreach (KeyValuePair<string, int> num in dict)
        {
            Console.WriteLine("{0,15} - {1}", num.Key, num.Value);
        }
 
    }
}