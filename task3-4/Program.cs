using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    class Program
    {
        static void Main(string[] args)
        {    
            IntValueProvider intProvider = new IntValueProvider();
            DoubleValueProvider doubleProvider = new DoubleValueProvider();
            BoolValueProvider boolProvider = new BoolValueProvider();
            StringValueProvider stringProvider = new StringValueProvider();

            IPrinter[] printers = new IPrinter[12];

            OneDimensionalArray<int> intOnedim = new OneDimensionalArray<int>(intProvider);
            printers[0] = intOnedim;
            OneDimensionalArray<double> doubleOnedim = new OneDimensionalArray<double>(doubleProvider);
            printers[1] = doubleOnedim;
            OneDimensionalArray<bool> boolOnedim = new OneDimensionalArray<bool>(boolProvider);
            printers[2] = boolOnedim;
            OneDimensionalArray<string> stringOnedim = new OneDimensionalArray<string>(stringProvider);
            printers[3] = stringOnedim;

            TwoDimensionalArray<int> intTwodim = new TwoDimensionalArray<int>(intProvider);
            printers[4] = intTwodim;
            TwoDimensionalArray<double> doubleTwodim = new TwoDimensionalArray<double>(doubleProvider);
            printers[5] = doubleTwodim;
            TwoDimensionalArray<bool> boolTwodim = new TwoDimensionalArray<bool>(boolProvider);
            printers[6] = boolTwodim;
            TwoDimensionalArray<string> stringTwodim = new TwoDimensionalArray<string>(stringProvider);
            printers[7] = stringTwodim;

            JaggedArray<int> intJagged = new JaggedArray<int>(intProvider);
            printers[8] = intJagged;
            JaggedArray<double> doubleJagged = new JaggedArray<double>(doubleProvider);
            printers[9] = doubleJagged;
            JaggedArray<bool> boolJagged = new JaggedArray<bool>(boolProvider);
            printers[10] = boolJagged;
            JaggedArray<string> stringJagged = new JaggedArray<string>(stringProvider);
            printers[11] = stringJagged;

            foreach (IPrinter array in printers)
            {
                array.Print();

                Console.WriteLine();
            }

        }
    }
}
