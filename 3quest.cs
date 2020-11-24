using System;

class Program
{
    static void Main(string[] args)
    {
        char c = Console.ReadLine()[0];
        Console.WriteLine("Следующий символ: {0}", (char)(c + 1));
        Console.ReadKey(false);
    }
}