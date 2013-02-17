using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class ReplaceStringWithAnotherOne
{
    /*Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
     * Ensure it will work with large files (e.g. 100 MB).*/
    static void Main(string[] args)
    {
        string start = "start";
        string finish = "finish";           
        string line = "";

        using (StreamReader reader = new StreamReader("../../myfile.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../newfile.txt"))
            {
                line = reader.ReadLine().ToLower();
                while (line != null)
                {
                    line = line.Replace(start, finish);
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
