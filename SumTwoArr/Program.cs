using System;

namespace SumTwoArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int sum = 0;

            foreach (int item in arr) {
                if (item > 0)
                    sum++;
            } 
            Console.WriteLine(sum); 
        }
    }
}
