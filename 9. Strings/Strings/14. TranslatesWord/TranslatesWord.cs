using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TranslatesWord
{
    static void Main(string[] args)
    {
        var arr = new Dictionary<string, string>()
        {
            { ".NET", "platform for applications from Microsoft" },
            { "CLR", "managed execution environment for .NET" },
            { "namespace", "hierarchical organization of classes" }
        };

        string str = Console.ReadLine();

        Console.WriteLine("{0} - {1}", str, arr[str]);
    }
}
