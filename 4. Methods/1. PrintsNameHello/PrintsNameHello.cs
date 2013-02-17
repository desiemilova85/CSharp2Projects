using System;

    class PrintsNameHello
    {
            static void Hello(string name)
            {
                Console.WriteLine("Hello, {0}!", name);
            }

            static void Main()
            {
                Console.WriteLine("Please enter your name and then press enter:");
                Hello(Console.ReadLine());
            }
    }
