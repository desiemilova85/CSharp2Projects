using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class InsertsLineNumbers
{
    /*Write a program that reads a text file and inserts line numbers in front of each of its lines. 
     * The result should be written to another text file.*/

    static void Main(string[] args)
    {
        using (StreamReader inputLine = new StreamReader("../../myfile.txt"))
        {
            int index = 1;
            string line;

            using (StreamWriter writeLine = new StreamWriter("../../newIndexedfile.txt"))
            {
                while ((line = inputLine.ReadLine()) != null)
                {
                    writeLine.Write("line {0}: ", index);
                    writeLine.WriteLine(line);
                    index++;
                }
            }
        }
    }
}
