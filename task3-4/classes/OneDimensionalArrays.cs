﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    sealed class OneDimensionalArray<T> : ArrayBase
    {
        private int n;

        T[] array;

        static ValueProvider<T> valueProvider = new ValueProvider<T>();

        public int Length
        {
            get { return n; }
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public OneDimensionalArray(bool userInput = false) : base(userInput) { }

        protected override void RandomInput()
        {
            n = rnd.Next(1, 10);

            array = new T[n];

            for (int i = 0; i < array.Length; i++)
            {
                //int value = rnd.Next(0, 1000);
                array[i] = valueProvider.GetRandomValue();
            }
        }

        protected override void UserInput()
        {
            Console.WriteLine("Input length of the array");

            n = int.Parse(Console.ReadLine());

            array = new T[n]; 

            for (int i = 0; i < n; i++)
            {
                array[i] = valueProvider.GetUserValue(); 
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

        //public override double FindAverage()
        //{
        //    double sum = 0;

        //    foreach (T num in array)
        //    {
        //        sum += num;
        //    }

        //    double average = sum / n;

        //    return average;
        //}

        //public void GetArrayAbs100()
        //{
        //    int newLength = n;

        //    foreach (T num in array)
        //    {
        //        if (Math.Abs(num) > 100)
        //        {
        //            newLength--;
        //        }
        //    }

        //    int[] newArray = new int[newLength];

        //    int newIndex = 0;

        //    for (int i = 0; i < n; i++)
        //    {
        //        if (Math.Abs(array[i]) <= 100)
        //        {
        //            newArray[newIndex] = array[i];
        //            newIndex++;
        //        }
        //    }
            
        //    Console.WriteLine(string.Join(" ", newArray));
        //}

        //public void GetArrayWithoutDuplicates()
        //{
        //    int newLength = n;

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = i; j < n; j++)
        //        {
        //            if (i != j && array[i] == array[j])
        //            {
        //                newLength--;
        //                break;
        //            }
        //        }
        //    }

        //    int[] newArray = new int[newLength];

        //    int newIndex = 0;

        //    for (int i = 0; i < n; i++)
        //    {
        //        if (!newArray.Contains(array[i]))
        //        {
        //            newArray[newIndex] = array[i];
        //            newIndex++;
        //        }
        //    }

        //    Console.WriteLine(string.Join(" ", newArray));
        //}
    }
}
