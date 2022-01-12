using GrokkingAlgoExapmles.Chapter_2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrokkingAlgoExapmles
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello World!");
            DijkstraAlgo dijkstraAlgo = new DijkstraAlgo();

            TreeNode fin = new TreeNode("fin");
            TreeNode _APoint = new TreeNode("A");
            TreeNode _BPoint = new TreeNode("B");
            _APoint.Neigbores = new Dictionary<TreeNode, double>(new List<KeyValuePair<TreeNode, double>> {
                new KeyValuePair<TreeNode, double>( fin,1) ,
            });
            _APoint.Neigbores = new Dictionary<TreeNode, double>(new List<KeyValuePair<TreeNode, double>> {
                new KeyValuePair<TreeNode, double>( _APoint,3) ,
                new KeyValuePair<TreeNode, double>( fin,3) ,
            });
            TreeNode start = new TreeNode("start");
            start.Neigbores = new Dictionary<TreeNode, double>(new List<KeyValuePair<TreeNode, double>> {
                new KeyValuePair<TreeNode, double>( _APoint,6) ,
                new KeyValuePair<TreeNode, double>( _BPoint,2) ,
            });
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
