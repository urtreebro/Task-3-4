using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    sealed class JaggedArray : ArrayBase, IJagged
    {
        private OneDimensionalArray[] array;

        private int n;

        public JaggedArray(bool userInput = false) : base(userInput) { }

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

            array = new OneDimensionalArray[n];

            for (int i = 0; i < n; i++)
            {
                OneDimensionalArray nestedArray = new(true);

                array[i] = nestedArray;
            }
        }

        protected override void RandomInput()
        {
            n = rnd.Next(1, 10);

            array = new OneDimensionalArray[n];
             
            for (int i = 0; i < n; i++)
            {
                OneDimensionalArray nestedArray = new();

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

        public override double FindAverage()
        {
            double sum = 0;

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    count++;
                }
            }
            double average = sum / count;
            return average;
        }

        public void GetAverageNumInNestedArrays()
        {
            double[] averageArray = new double[n];

            for (int i = 0; i < n; i++)
            {
                double sum = 0;

                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                double average = sum / array[i].Length;
                averageArray[i] = average;
            }

            Console.WriteLine(string.Join(" ", averageArray));
        }

        public void ChangeArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
        }
    }    
}
