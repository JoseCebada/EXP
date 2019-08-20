using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Imprime los números del X hasta Y de -1");
            Console.WriteLine("De donde arrancamos el ciclo (Mayor): ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde terminamos el ciclo (Menor): ");
            y = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i >= y; i--)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}
