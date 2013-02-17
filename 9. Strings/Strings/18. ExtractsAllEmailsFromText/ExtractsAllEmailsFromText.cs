using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _18.ExtractsAllEmailsFromText
{
    class ExtractsAllEmailsFromText
    {
        static void Main(string[] args)
        {
            string str = @"Please contact us by phone (+359 222 222 222) or
                       by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk.
                       This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string[] newStr = str.Split(' ');

            for (int i = 0; i < newStr.Length; i++)
            {
                if (Regex.IsMatch(newStr[i], @"[\w., \-]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
                {
                    Console.WriteLine("{0} are valid emails", newStr[i]);
                }
            }
        }
    }
}
