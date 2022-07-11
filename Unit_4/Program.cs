using System;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите ваш любимый цвет");

            string color = Console.ReadLine();

            if (color == "красный") {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Ваш любимый цвет красный!");
            }

            else if (color == "зелёный") {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Ваш любимый цвет зелёный!");
            }

            else {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;   

                Console.WriteLine("Ваш цвет бирюзовый!");
            
            }
            Console.ReadKey();  
        }
    }
}
