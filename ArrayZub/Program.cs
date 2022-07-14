using System;

namespace SumPosOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            } */

            var arr = new int[]{1, 5, -8, 9, -11 };
            int check = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] >= check) {
                    count++;
                }
            }

            Console.WriteLine(count);   





        }
    }
}
