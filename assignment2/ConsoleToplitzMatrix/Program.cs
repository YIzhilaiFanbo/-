using System;

namespace ToplitzMatrix
{
    public class ToplitzMatrix
    {
        int row;
        int column;
        int[,] matrix;

        public ToplitzMatrix(int row, int column, int[,] matrix)
        {
            this.row = row;
            this.column = column;
            this.matrix = matrix;
        }

        public ToplitzMatrix() { }

        public bool isToplitzMatriz()
        {
            int roworigin = 0;
            int colorigin = 0;
            for (int i = 0; i < column; i++)
            {
                colorigin = i;
                if (i < row - 1 && colorigin < column - 1 && matrix[i, colorigin] != matrix[i + 1, colorigin + 1])
                {
                    return false;
                }
            }
            for (int i = 1; i < row; i++)
            {
                roworigin = i;
                if (i < column - 1 && roworigin < row - 1 && matrix[roworigin, i] != matrix[roworigin + 1, i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("请输入二维数组行数和列数：");
            string[] dimensions = Console.ReadLine().Split();
            int row = int.Parse(dimensions[0]);
            int column = int.Parse(dimensions[1]);

            int[,] matrix = new int[row, column];

            Console.WriteLine("请输入矩阵：");
            for (int i = 0; i < row; i++)
            {
                string[] rowValues = Console.ReadLine().Split();
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = int.Parse(rowValues[j]);
                }
            }
            ToplitzMatrix toplitzmatriz = new ToplitzMatrix(row, column, matrix);
            Console.WriteLine(toplitzmatriz.isToplitzMatriz());
        }
    }
}