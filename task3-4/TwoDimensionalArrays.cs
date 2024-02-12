using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    sealed class TwoDimensionalArray : ArrayBase, ITwoDimensional
    {
        private int n;

        private int m;

        private int[,] array;

        public TwoDimensionalArray(bool userInput = false) : base(userInput) { }

        public override void Refill(bool userInput = false)
        {
            if (userInput)
            {
                UserInput();
            }
            else
            {
                RandomInput();
            }
        }

        protected override void UserInput()
        {
            Console.WriteLine("Input length of the array");

            n = int.Parse(Console.ReadLine());

            m = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input {n * m} numbers"); 

            array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        array[i, j] = num;
                    }
                    else
                    {
                        Console.WriteLine("Couldn't convert into int");
                    }
                }
            }
        }

        protected override void RandomInput()
        {
            n = rnd.Next(1, 10);

            m = rnd.Next(1, 10);

            array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int value = rnd.Next(0, 1000);
                    array[i, j] = value;
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine("Normally printed array:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Snake-like printed array:");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(array[i, j]);
                        Console.Write("\t");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = m - 1; j >= 0; j--)
                    {
                        Console.Write(array[i, j]);
                        Console.Write("\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        public override double FindAverage()
        {
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += array[i, j];
                }
            }
            double average = sum / (n * m);
            return average;
        }

        public double GetMatrixDeterminant()
        {
            return GetMatrixDeterminant(array);
        }

        public double GetMatrixDeterminant(int[,] array)
        {
            int size = array.GetLength(0);

            if (size != array.GetLength(1))
            {
                throw new ArgumentException("Matrix determinant can only be get in square matrix");
            }

            if (size == 1)
            {
                return array[0, 0];
            }

            double determinant = 0;

            for (int i = 0; i < size; i++)
            {
                int[,] subArray = CreateSubArray(array, 0, i);
                determinant += Math.Pow(-1, i) * array[0, i] * GetMatrixDeterminant(subArray);
            }
            return determinant;
        }

        private int[,] CreateSubArray(int[,] array, int excludedRow, int excludedColumn)
        {
            int size = array.GetLength(0);

            int[,] subArray = new int[size - 1, size - 1];

            int row = 0;

            for (int i = 0; i < size; i++)
            {
                if (i == excludedRow)
                {
                    continue;
                }
                int column = 0;
                for (int j = 0; j < size; j++)
                {
                    if (j == excludedColumn)
                    {
                        continue;
                    }
                    subArray[row, column] = array[i, j];
                    column++;
                }
                row++;
            }
            return subArray;
        }
    }
}
