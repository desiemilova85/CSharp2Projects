using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class ReplaceHTMLAhrefWithURL
{
    /*Write a program that replaces in a HTML document 
     * given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/

    static void Main(string[] args)
    {
        string str = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        string replacedStr = str.Replace(@"<a href=""", "[URL=");
        replacedStr = replacedStr.Replace(@"</a>", "[/URL");
        replacedStr = replacedStr.Replace(@""">", "]");
        Console.WriteLine(replacedStr);
    }
}
