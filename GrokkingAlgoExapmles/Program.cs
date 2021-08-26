using GrokkingAlgoExapmles.Chapter_2;
using System;

namespace GrokkingAlgoExapmles
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 5, 6, 9, 10, 3, 7, 2, 1, 8, 0, 4, 100, -100 };
            array = QuickSort<int>.QSort(array, true);
            Printarray(array);

        }
        private static void Printarray <T>(T[] arr , char separator = ',')
        {
            for (int i = 0; i < arr.Length; i++)
            {
                string value = i == 0 ? "[" + arr[i]+""+separator : arr[i] + $"{(i == arr.Length - 1 ? "]" : separator.ToString())}";
                Console.Write(value);
            }
        }
    }
}
