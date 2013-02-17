using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class ExtractXMLTextWithoutTags
{
    /*Write a program that extracts from given XML file all the text without the tags. */
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("../../myfile.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../newfile.txt"))
            {
                string line = reader.ReadToEnd();
                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, "<(.*?)>", ""));
                    line = reader.ReadLine();
                }
            }
        }
    }
}
