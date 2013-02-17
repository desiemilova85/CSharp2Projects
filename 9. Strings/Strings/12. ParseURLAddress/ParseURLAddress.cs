using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseURLAddress
{
    /*Write a program that parses an URL address given in the format:and extracts from it the [protocol], 
     * [server] and [resource] elements. */

    static void Main(string[] args)
    {
        Uri uri = new Uri("http://www.devbg.org/forum/index.php");
        Console.WriteLine(uri.Scheme);
        Console.WriteLine(uri.Host);
        Console.WriteLine(uri.AbsolutePath);
    }
}
