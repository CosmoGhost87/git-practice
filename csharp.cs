using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Программа приветствия ===");
            
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            
            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nПривет, {name}!");
            Console.WriteLine($"Через 10 лет вам будет {age + 10} лет.");
            
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}