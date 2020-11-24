using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int D = b ^ 2 - 4 * a * c;
        Console.WriteLine($"Дискриминант равен: {D} ");

        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / 2 * a;
            double x2 = (-b - Math.Sqrt(D)) / 2 * a;
            Console.WriteLine($"Первый корень: {x1} ");
            Console.WriteLine($"Второй корень: {x2} ");
        }

        if (D == 0)
        {
            double x = (-b / 2 * a);
            Console.Write($"Один корень: {x} ");

        }
        
        if (D < 0)
        {
            Console.WriteLine("Корней нет");
        }
    }
}