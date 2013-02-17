using System;

class MatrixBestSum
{
    static void Main()
         {

                 Console.WriteLine("Enter the number of rows: ");
                 int rows = int.Parse(Console.ReadLine());
 
                 Console.WriteLine("Enter the number of columns: ");
                 int cols = int.Parse(Console.ReadLine());
 
                 int[,] matrix = new int[rows, cols];
 
                 Console.WriteLine("Enter the cells of the matrix:");
 
                 for (int row = 0; row < rows; row++)
                 {
                       for (int col = 0; col < cols; col++)
                       {
                           Console.Write("matrix[{0},{1}] = ", row, col);
                           matrix[row, col] = int.Parse(Console.ReadLine());
                       }
                 }

                int bestSum = int.MinValue;
                int bestRow = 0;
                int bestCol = 0;
                int k=3;
                
                for (int row = 0; row <= matrix.GetLength(0)-k; row++)
                {
                    for (int col = 0; col <= matrix.GetLength(1)-k; col ++)
                    {
                        int sum = (matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col + matrix[row + 2, col + 1] + matrix[row + 2, col + 2]);
                        if (sum > bestSum)
                         {
                            bestSum = sum;
                            bestRow = row;
                            bestCol = col;
                         }
                    }
                }
                        Console.WriteLine("The best platform is:");
                        Console.WriteLine("  {0} {1}",
                                                     matrix[bestRow, bestCol],
                                                     matrix[bestRow, bestCol + 1],
                                                     matrix[bestRow, bestCol + 2]);
                        Console.WriteLine("  {0} {1}",
                                                     matrix[bestRow + 1, bestCol],
                                                     matrix[bestRow + 1, bestCol + 1],
                                                     matrix[bestRow + 1, bestCol + 2 ]);
                        Console.WriteLine("  {0} {1}",
                                                     matrix[bestRow + 2, bestCol],
                                                     matrix[bestRow + 2, bestCol + 1],
                                                     matrix[bestRow + 2, bestCol + 2 ]);
                        Console.WriteLine("The maximal sum is: {0}", bestSum);
        }
}


