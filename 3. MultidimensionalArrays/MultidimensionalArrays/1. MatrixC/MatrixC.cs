﻿using System;

    class MatrixC
    {
        static void Main()
        {
        Console.Write("Please enter the matrix size:");
        int dimension = int.Parse(Console.ReadLine());
        int[,] matrix = new int[dimension, dimension];
        int count = 1;
        for (int i = 0; i < dimension; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                matrix[dimension - i + j - 1, j] = count++;
            }
        }

        for (int i = dimension - 2; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {
                matrix[i - j, dimension - j - 1] = count++;
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
