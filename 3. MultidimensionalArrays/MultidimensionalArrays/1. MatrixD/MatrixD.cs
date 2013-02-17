using System;

class MatrixD
{
    static void Main()
    {

        int dimension = int.Parse(Console.ReadLine());
        int[,] matrix = new int[dimension, dimension];
        int end = dimension;
        int start = 0;
        int count = 1;
        do
        {
            for (int i = start; i < end; i++)
            {
                matrix[i, start] = count;
                count++;
            }
            for (int j = start + 1; j < end; j++)
            {
                matrix[end - 1, j] = count;
                count++;
            }
            for (int k = end - 2; k >= start; k--)
            {
                matrix[k, end - 1] = count;
                count++;
            }
            for (int p = end - 2; p >= start + 1; p--)
            {
                matrix[start, p] = count;
                count++;
            }
            start++;
            end--;
        }
        while (end - start > 0);
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
