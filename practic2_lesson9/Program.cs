using System;

namespace practic2_lesson9
{
    
    struct Point
    {
        public double x;
        public double y;
    }

    class MatrixPoint
    {
        private Point[,] AP;

        public MatrixPoint(int rows, int columns)
        {
            AP = new Point[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    AP[i, j] = new Point { x = random.NextDouble() * 10 - 5, y = random.NextDouble() * 10 - 5 };
                }
            }
        }

        public Point[] this[int row]
        {
            get
            {
                int columns = AP.GetLength(1);
                Point[] result = new Point[columns];

                for (int j = 0; j < columns; j++)
                {
                    result[j] = AP[row, j];
                }

                return result;
            }
        }

        public double this[int row, int column]
        {
            get
            {
                Point point = AP[row, column];
                return Math.Sqrt(point.x * point.x + point.y * point.y);
            }
        }

        public override string ToString()
        {
            int rows = AP.GetLength(0);
            int columns = AP.GetLength(1);
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result += string.Format("({0}, {1}) ", AP[i, j].x, AP[i, j].y);
                }

                result += "\n";
            }

            return result;
        }
    }
    
    internal class Program
    {
        public static void Main()
        {
            MatrixPoint matrix = new MatrixPoint(3, 4);
            Console.WriteLine(matrix.ToString());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Row {0}:", i);
                Point[] row = matrix[i];

                foreach (Point point in row)
                {
                    Console.WriteLine("({0}, {1})", point.x, point.y);
                }
            }

            Console.WriteLine("Distance from point at row 1 column 2 to origin: {0}", matrix[1, 2]);
        }
    }
}