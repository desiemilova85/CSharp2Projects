using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class MaxSumInFile
{
    /*Write a program that reads a text file containing a square matrix of numbers
     * and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
     * The first line in the input file contains the size of matrix N.
     * Each of the next N lines contain N numbers separated by space. 
     * The output should be a single number in a separate text file. */

    static void Main(string[] args)
    {
        string filename = "..//..//myfile.txt";
        StreamReader reader = new StreamReader(filename);
        string row = "";
        List<string> rows = new List<string>();
        while (row != null)
        {
            row = reader.ReadLine();
            if (row != null)
            {
                rows.Add(row);
            }
        }
        reader.Close();

        rows.Sort();

        string outputfile = "..//..//newfile.txt";
        StreamWriter writer = new StreamWriter(outputfile, false);
        for (int i = 0; i < rows.Count; i++)
        {
            writer.WriteLine(rows[i]);
        }
        writer.Close();
    }
}
