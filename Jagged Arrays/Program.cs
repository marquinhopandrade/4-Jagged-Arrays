using System;

namespace Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };
            // alternative way:
            int[][] jaggedArray2 = new int[][]
            {
                new int [] {2,3,5,7,11} ,   new int [] {1, 2, 3 }
            };
            Console.WriteLine("The value in the middle of the first entry is: {0}", jaggedArray2[0][2]);
            /*for(int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("jaggedArray: {0}", jaggedArray.Length);
                Console.WriteLine("jaggedArray[i]:{0}", jaggedArray[i].Length);
            }*/

            //Console.ReadLine();
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Array {0}", i);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("Element {0}: {1}", j ,jaggedArray[i][j]);
                }
            }
            ;
        }
    }
}
