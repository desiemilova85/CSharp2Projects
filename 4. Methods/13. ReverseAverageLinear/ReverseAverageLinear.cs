using System;

    class ReverseAverageLinear
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

        static double Average(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }

        static void LinearEq(int a, int b)
        {
            if (a != 0)
            {
                Console.WriteLine("{0}*x+{1}=0 x={2}", a, b,(double)-b / a);
            }
            else Console.WriteLine("a should not be equal to 0");
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter number that should be reversed: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter the length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];
            for (int j = 0; j < n; j++)
            {
                Console.Write("Array1[{0}] = ", j);
                newArray[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The reveresed number of {0} is {1}",m, RevNum(m));
            LinearEq(a, b);
            Console.WriteLine("Average number in the array is {0}", Average(newArray));
           
        }
    }
