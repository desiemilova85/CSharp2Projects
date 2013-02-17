using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class PrintEqualDifferentLines
{
    /*Write a program that compares two text files line by line 
     * and prints the number of lines that are the same and the number of lines that are different. 
     * Assume the files have equal number of lines.*/

    static void Main(string[] args)
    {
        StringBuilder same = new StringBuilder();
        StringBuilder different = new StringBuilder();
        using (StreamReader readFile1 = new StreamReader("../../myfile1.txt"))
        {
            using (StreamReader readFile2 = new StreamReader("../../myfile2.txt"))
            {

                int count = 0;                    
                string lFile1 = readFile1.ReadLine();
                string lFile2 = readFile2.ReadLine();
                while (lFile1 != null && lFile2 != null)
                {
                    count++;
                    if (lFile1 == lFile2)
                    {
                        same.Append(count).Append(" ");
                    }
                    else
                    {
                        different.Append(count).Append(" ");
                    }

                    lFile1 = readFile1.ReadLine();
                    lFile2 = readFile2.ReadLine();
                }
            }
            Console.WriteLine("The same line numbers are: {0}", same);
            Console.WriteLine("The different line numbers are: {0}", different);
        }
    }
}
