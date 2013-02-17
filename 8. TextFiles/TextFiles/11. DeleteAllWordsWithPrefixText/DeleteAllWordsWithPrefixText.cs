using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class DeleteAllWordsWithPrefixText
{
    /*Write a program that deletes from a text file all words that start with the prefix "test". 
     * Words contain only the symbols 0...9, a...z, A…Z, _.*/

    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../myfile.txt");
        StreamWriter writer = new StreamWriter("../../newfile.txt");
        string line = "";

        using (reader)
        {
            using (writer)
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*(\s|\S)\b", "");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
