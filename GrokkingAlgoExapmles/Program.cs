using GrokkingAlgoExapmles.Chapter_2;
using System;
using System.Linq;

namespace GrokkingAlgoExapmles
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 5, 6, 9, 10, 3, 7, 2, 1, 8, 0, 4, 100, -100 };
            array = BubbleSort<int>.SortArray(array, false);
            //array = Enumerable.Range(1, 4150).ToArray();
            Printarray(array);
            //--------------------------
            array = new int[] { 5, 6, 9, 10, 3, 7, 2, 1, 8, 0, 4, 100, -100 };
            array = QuickSort<int>.QSort(array, true);
             array = Enumerable.Range(1, 4150).ToArray();
             int[] arrayRev = QuickSort<int>.QSort(array, true);
            Printarray(arrayRev);

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
