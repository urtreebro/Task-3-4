using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    sealed class JaggedArray<T> : ArrayBase<T>, IJagged
    {
        private OneDimensionalArray<T>[] array;

        private int n;

        public JaggedArray(IValueProvider<T> _valueProvider, bool userInput = false) : base(_valueProvider ,userInput) { }

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

            array = new OneDimensionalArray<T>[n];

            for (int i = 0; i < n; i++)
            {
                OneDimensionalArray<T> nestedArray = new(_valueProvider, true);

                array[i] = nestedArray;
            }
        }

        protected override void RandomInput()
        {
            n = rnd.Next(1, 10);

            array = new OneDimensionalArray<T>[n];

            for (int i = 0; i < n; i++)
            {
                OneDimensionalArray<T> nestedArray = new(_valueProvider);

                array[i] = nestedArray;
            }
        }

        public override void Print()
        {
            Console.WriteLine("Printed array:");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
