﻿using System;

    class MatrixA
    {
        static void Main()
        {
            Console.Write("Please enter the matrix sixe:");
            int dimension = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimension, dimension];
            int count = 1;
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matrix[j, i] = count++;
                }
            }
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write("{0,4}", matrix[row, col]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
    }
}
