using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    sealed class TwoDimensionalArray<T> : ArrayBase<T>, ITwoDimensional
    {
        private int n;

        private int m;

        private T[,] array;

        public TwoDimensionalArray(IValueProvider<T> _valueProvider, bool userInput = false) : base(_valueProvider, userInput) { }

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

            Console.WriteLine($"Input {n*m} values");

            array = new T[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = _valueProvider.GetUserValue();
                }
            }
        }

        protected override void RandomInput()
        {
            n = rnd.Next(1, 10);

            m = rnd.Next(1, 10);

            array = new T[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = _valueProvider.GetRandomValue();
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
    }
}
