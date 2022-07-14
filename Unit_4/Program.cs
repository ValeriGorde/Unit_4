using System;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите ваш любимый цвет!");

            int t = 0;

             while (true) { 
                Console.WriteLine("Иттерация {0}", t);
                
                var text = Console.ReadLine();
switch (text)
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
                if (text == "stop") {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }
                
                

                t++;
            }

            Console.ReadKey();  
        }
    }
}
