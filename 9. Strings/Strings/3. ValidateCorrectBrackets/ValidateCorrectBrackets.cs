using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ValidateCorrectBrackets
{
    /*Write a program to check if in a given expression the brackets are put correctly.
    Example of correct expression: ((a+b)/5-d).
    Example of incorrect expression: )(a+b)).*/

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter expression:");
        string expr = Console.ReadLine();
        int openBrackets = 0;
        int closedBrackets = 0;

        if ((expr.IndexOf("(") > expr.IndexOf(")")) || (expr.LastIndexOf("(") > expr.LastIndexOf(")")))
        {
            Console.WriteLine("Brackets are not equal or incorrect. Please check the expression once again");
        }

        else
        {
            foreach (char ch in expr)
            {
                if (ch == '(')
                {
                    openBrackets++;
                }
                else if (ch == ')')
                {
                    closedBrackets++;
                }
            }

            if (closedBrackets != openBrackets)
            {
                Console.WriteLine("Brackets are not equal or incorrect. Please check the expression once again");
            }
            else
            {
                Console.WriteLine("Brackets in the expression are correct.");
            }
        }
    }

}