using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Concatanate2FilesToOne
{
    /*Write a program that concatenates two text files into another text file.*/
    static void Main(string[] args)
    {
        using (StreamWriter newFile = new StreamWriter("../../newfile.txt"))
        {
            using (StreamReader file1 = new StreamReader("../../myfile1.txt"))
            {
                string one = file1.ReadToEnd();
                newFile.WriteLine(one);
            }
            
            using (StreamReader file2 = new StreamReader("../../myfile2.txt"))
            {
                string two = file2.ReadToEnd();
                newFile.WriteLine(two);
            }
        }
    }
}
