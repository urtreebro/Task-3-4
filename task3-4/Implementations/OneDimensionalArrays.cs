using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    sealed class OneDimensionalArray<T> : ArrayBase<T>, IOneDimensional
    {
        private int n;

        T[] array;

        public int Length
        {
            get { return n; }
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public OneDimensionalArray(IValueProvider<T> _valueProvider, bool userInput = false) : base(_valueProvider, userInput) { }

        protected override void RandomInput()
        {
            n = rnd.Next(1, 10);

            array = new T[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = _valueProvider.GetRandomValue();
            }
        }

        protected override void UserInput()
        {
            Console.WriteLine("Input length of the array");

            n = int.Parse(Console.ReadLine());

            array = new T[n];

            Console.WriteLine($"Input {n} values");

            for (int i = 0; i < n; i++)
            {
                array[i] = _valueProvider.GetUserValue(); 
            }
        }
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

        public override void Print()
        {
            Console.WriteLine("Printed array:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
