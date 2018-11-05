using System;

namespace MatrixWithAlternatingRectanglesOfZeroAndX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix with alternating rectangles of Zero and X!");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Enter the number of rows in the matrix");
            try
            {
                int noOfRows = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of columns in the matrix");
                int noOfColumns = int.Parse(Console.ReadLine());
                PrintAlternatingRectangleMatrix(noOfRows, noOfColumns);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }

            Console.ReadLine();
        }

        private static void PrintAlternatingRectangleMatrix(int rows, int columns) {

            int m = 0;
            int n = 0;

            char charToWrite = 'X';
            char[,] matrix = new char[rows, columns];

            while (m < rows && n < columns)
            {
                for (int i = n; i < columns; i++) {
                    matrix[m, i] = charToWrite;
                }
                m++;

                for (int i = m; i < rows; i++) {
                    matrix[i, columns-1] = charToWrite;
                }
                columns--;

                if (n < columns) {
                    for (int i = columns-1; i >=n; i--) {
                        matrix[rows - 1, i] = charToWrite;
                    }
                    rows--;
                }
                if (m < rows) {
                    for (int i = rows - 1; i >=m; i--) {
                        matrix[i, n] = charToWrite;
                    }
                    n++;
                }
                if (charToWrite == 'X') charToWrite = '0';
                else charToWrite = 'X';
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix) {
            Console.WriteLine("---------Printing Matrix---------------------");
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------");
        }
    }
}
