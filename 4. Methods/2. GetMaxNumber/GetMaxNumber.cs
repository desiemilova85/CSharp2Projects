using System;

    class GetMaxNumber
    {
        static int GetMaxNum(int first, int second)
        {
            if (second > first)
            
                first= second;
                return first;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third number:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("The biggest number ot the 3 entered numbers from the console is :{0} ",GetMaxNum(GetMaxNum(n, m),k));
        }
    }
