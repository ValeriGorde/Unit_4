using System;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите ваш любимый цвет");

            string color = Console.ReadLine();

            switch (color)
            {
                case "красный":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш любимый цвет красный!");
                    break;

                case "зелёный":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш любимый цвет зелёный!");
                    break;

                case "бирюзовый":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш цвет бирюзовый!");
                    break;

                    default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;   

                    Console.WriteLine("Ваш цвет жёлтый!");
                    break;
            }
            

            Console.ReadKey();  
        }
    }
}
