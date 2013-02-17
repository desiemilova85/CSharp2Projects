using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


class ReplaceWholeWords
{
    /*Modify the solution of the previous problem to replace only whole words (not substrings).*/
    static void Main(string[] args)
    {
       
        using (StreamReader reader = new StreamReader("../../myfile.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../newfile.txt"))
            {
                string line = reader.ReadToEnd();
                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = reader.ReadLine();
                }
            }
        }
    }
}
