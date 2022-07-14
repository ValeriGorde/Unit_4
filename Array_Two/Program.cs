using System;

namespace Array_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int num = 0;

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++) {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++) 
                    Console.Write(arr[i, j] + " ");
                
                Console.WriteLine();    
                
            } */

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var item in arr) {
                Console.WriteLine(item);
            }
             
        }
    }
}
