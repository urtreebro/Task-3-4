using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    interface IValueProvider<T>  
    {
        T GetRandomValue();

        T GetUserValue();

        //T Sum(T a, T b);
    }

    class ValueProvider<T> : IValueProvider<T>
    {
        public static StringValueProvider stringValueProvider = new StringValueProvider();

        public static IntValueProvider intValueProvider = new IntValueProvider();

        public T GetRandomValue()
        {
            if (typeof(T) == typeof(int))
            {
                return (T)(object) intValueProvider.GetRandomValue();
            }
            else
            {
                return (T)(object) stringValueProvider.GetRandomValue();
            }
        }

        public T GetUserValue()
        {
            if (typeof(T) == typeof(int))
            {
                return (T)(object) intValueProvider.GetUserValue();
            }
            else
            {
                return (T)(object) stringValueProvider.GetUserValue();
            }
        }
    }

    class IntValueProvider 
    {
        public int GetRandomValue()
        {
            return new Random().Next(0, 100);
        }

        public int GetUserValue()
        {
            return int.Parse(Console.ReadLine());
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }

    class StringValueProvider
    {
        public string GetRandomValue()
        {
            return "0";
        }

        public string GetUserValue()
        {
            return Console.ReadLine();
        }

        public string Sum(string a, string b)
        {
            return a + b;
        }
    }
}
