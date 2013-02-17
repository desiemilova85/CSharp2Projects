using System;

    class ReturnsLastDigitAsWord
    {
        static void LastDigit(int number)
        {
            int digit = Math.Abs(number % 10);

            switch (digit)
            {
                case 0: Console.WriteLine("Last digit of the number is: Zero");
                    break;
                case 1: Console.WriteLine("Last digit of the number is: One");
                    break;
                case 2: Console.WriteLine("Last digit of the number is: Two");
                    break;
                case 3: Console.WriteLine("Last digit of the number is: Three");
                    break;
                case 4: Console.WriteLine("Last digit of the number is: Four");
                    break;
                case 5: Console.WriteLine("Last digit of the number is: Five");
                    break;
                case 6: Console.WriteLine("Last digit of the number is: Six");
                    break;
                case 7: Console.WriteLine("Last digit of the number is: Seven");
                    break;
                case 8: Console.WriteLine("Last digit of the number is :Eight");
                    break;
                case 9: Console.WriteLine("Last digit of the number is: Nine");
                    break;
            }
        }
        static void Main()
        {
            Console.WriteLine("Please enter integer number:");
            int n = int.Parse(Console.ReadLine());
            LastDigit(n);
        }
    }
