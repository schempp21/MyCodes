using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {

                Console.Write("Введите первое число: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (y == 0)
                {
                    Console.WriteLine("О нет, ты хочешь поделить на ноль? НЕЛЬЗЯ!");
                }
                else
                {
                    Console.Write("Ответ: ");
                    Console.WriteLine(x / y);
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Введите число!");
            }
        }
    }
}