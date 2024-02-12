using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    class Week : IPrinter
    {
        public void Print()
        {
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.Write(day + " ");
            }

            Console.WriteLine();    
        }

        enum DayOfWeek
        {
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday, 
            Sunday
        }
    }
}
