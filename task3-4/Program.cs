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
            Console.WriteLine("Which interface do you want to test?");
            Console.WriteLine("Enter p for IPrinter, b for IBase, o for IOneDimensional, t for ITwoDimensional, j for IJagged, e for exit");

            string message = Console.ReadLine();

            while (message != "e")
            {
                OneDimensionalArray onedimarray = new();

                TwoDimensionalArray twodimarray = new();

                JaggedArray jaggedarray = new();

                if (message == "p")
                {
                    IPrinter[] printers = new IPrinter[4];

                    printers[0] = onedimarray;

                    printers[1] = twodimarray;

                    printers[2] = jaggedarray;

                    Week week = new();
                    printers[3] = week;

                    foreach (IPrinter printer in printers)
                    {
                        printer.Print();
                    }
                }
                else if (message == "b")
                {
                    IBase[] allArrays = new ArrayBase[3];

                    allArrays[0] = onedimarray;

                    allArrays[1] = twodimarray;

                    allArrays[2] = jaggedarray;

                    foreach (IBase array in allArrays)
                    {
                        Console.WriteLine($"Average: {array.FindAverage()} \n");

                        array.Print();

                        Console.WriteLine();

                        array.Refill();

                        Console.WriteLine("Refilled array\n");

                        array.Print();

                        Console.WriteLine();
                    }
                }
                else if (message == "o")
                {
                    IOneDimensional[] onedims = new IOneDimensional[2];

                    OneDimensionalArray onedimarray1 = new();

                    onedims[0] = onedimarray;

                    onedims[1] = onedimarray1;

                    foreach (IOneDimensional one in onedims)
                    {
                        Console.WriteLine("Array with numbers less than 100 abs:");
                        one.GetArrayAbs100();

                        Console.WriteLine("Array without duplicates:");
                        one.GetArrayWithoutDuplicates();
                    }
                }
                else if (message == "t")
                {
                    ITwoDimensional[] twodims = new ITwoDimensional[2];

                    Console.WriteLine("Warning! Matrix has to be square!");

                    TwoDimensionalArray twodimarray1 = new(true);

                    TwoDimensionalArray twodimarray2 = new(true);

                    twodims[0] = twodimarray1;

                    twodims[1] = twodimarray2;

                    foreach (ITwoDimensional two in twodims)
                    {
                        Console.WriteLine($"Matrix determinant: {two.GetMatrixDeterminant()}\n");
                    }
                }
                else if (message == "j")
                {
                    IJagged[] jaggeds = new IJagged[2];

                    JaggedArray jaggedarray1 = new();

                    jaggeds[0] = jaggedarray;

                    jaggeds[1] = jaggedarray1;

                    foreach (IJagged jagged in jaggeds)
                    {
                        Console.WriteLine("Averages in nested arrays:");
                        jagged.GetAverageNumInNestedArrays();

                        jagged.ChangeArray();
                        jagged.Print();
                    }
                }
                else
                {
                    Console.WriteLine("Unknown command.");
                }

                Console.WriteLine("Which interface do you want to test?");
                Console.WriteLine("Enter p for IPrinter, b for IBase, o for IOneDimensional, t for ITwoDimensional, j for IJagged, e for exit");

                message = Console.ReadLine();
            }
        }
    }
}
