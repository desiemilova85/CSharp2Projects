using System;

    class ReverseDigitsOfNumber
    {
        public static int RevNum(int number)
        {
            int revNum = 0;
            int remainder = 0;
            while (number > 0)
            {
                remainder = number % 10;
                revNum = revNum * 10 + remainder;
                number = number / 10;
            }
            return revNum;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter number = ");
            int number = int.Parse(Console.ReadLine());
            int reversed = RevNum(number);
            Console.WriteLine("The reversed number of {0} is {1}", number, reversed);
        }
    }
