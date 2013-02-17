using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class ReadsTFPrintOddLines
{
    /*Write a program that reads a text file and prints on the console its odd lines.*/

    static void Main(string[] args)
    {

        using (StreamReader fileInput = new StreamReader("../../myfile.txt"))
        {
            int lineNum = 1;
            string line = fileInput.ReadLine();
            while (line != null)
            {
                if (lineNum % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                lineNum++;
                line = fileInput.ReadLine();
            }
        }
    }
}
