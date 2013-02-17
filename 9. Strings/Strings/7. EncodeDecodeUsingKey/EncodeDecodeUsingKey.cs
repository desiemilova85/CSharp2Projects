using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class EncodeDecodeUsingKey
    {
        /*Write a program that encodes and decodes a string using given encryption key (cipher). 
         * The key consists of a sequence of characters. 
         * The encoding/decoding is done by performing XOR (exclusive or) operation 
         * over the first letter of the string with the first of the key, the second – with the second, etc.
         * When the last key character is reached, the next is the first.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text:");
            string str = Console.ReadLine();
            Console.WriteLine("Please enter chiper:");
            string key = Console.ReadLine();

            string encode = EncodeDecode(str, key);
            Console.WriteLine("The encoded text is: {0}",encode);

            string decode = EncodeDecode(encode, key);
            Console.WriteLine("The decoded text is {0}", decode);
        }

        private static string EncodeDecode(string str, string key)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i += key.Length)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (i + j > str.Length - 1)
                    {
                        break;
                    }
                    char temp = (char)(str[i + j] ^ key[j]);
                    sb.Append(temp);
                }
            }
            return sb.ToString();
        }
    }
