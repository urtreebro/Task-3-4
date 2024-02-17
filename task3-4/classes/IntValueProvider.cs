﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    class IntValueProvider : IValueProvider<int>
    {
        public int GetRandomValue()
        {
            return new Random().Next(0, 100);
        }

        public int GetUserValue()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
