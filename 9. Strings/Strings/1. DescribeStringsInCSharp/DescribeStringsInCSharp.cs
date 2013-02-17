using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DescribeStringsInCSharp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Strings are immutable sequences of characters (instances of System.String)");
        Console.WriteLine("- Declared by the keyword string in C#");
        Console.WriteLine("- Can be initialized by string literals");
        Console.WriteLine("- Most important string processing members are:");
        Console.WriteLine("Length, this[], Compare(str1, str2), IndexOf(str), LastIndexOf(str), Substring(startIndex, length), Replace(oldStr, newStr), Remove(startIndex, length), ToLower(), ToUpper(), Trim()");
    }
}
