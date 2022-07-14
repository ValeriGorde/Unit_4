using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам:");

            foreach (var letter in name)
            {
                Console.Write(letter + " ");
            }

            Console.WriteLine("\n");

            for (var i = name.Length - 1; i >= 0; i--) { 
                Console.Write(name[i] + " "); 
            }

            //Console.WriteLine("\nВаша последняя буква имени: {0}", name[name.Length - 1]);
        }
    }
}
