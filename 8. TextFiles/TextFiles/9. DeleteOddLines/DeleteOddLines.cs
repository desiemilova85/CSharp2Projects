using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class DeleteOddLines
{
    /*Write a program that deletes from given text file all odd lines. The result should be in the same file.*/
    static void Main(string[] args)
    {
        using (StreamReader Reader = new StreamReader("../../myfile.txt"))
        {
            using (StreamWriter Writer = new StreamWriter("../../newfile.txt"))
            {
                int Count = 0;
                string line = Reader.ReadLine();

                while (line != null)
                {
                    if (Count % 2 == 0)
                    {
                        Count++;
                    }
                    else
                    {
                        Writer.WriteLine(line);
                        Count++;
                    }
                    line = Reader.ReadLine();
                }
            }

        }
    }
}
