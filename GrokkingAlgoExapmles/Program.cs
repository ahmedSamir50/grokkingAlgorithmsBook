using GrokkingAlgoExapmles.Chapter_2;
using System;

namespace GrokkingAlgoExapmles
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello World!");
           
        }
        private static void Printarray (int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
