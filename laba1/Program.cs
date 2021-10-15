using System;

namespace laba1
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            float d, x1, x2;
            Console.WriteLine("Введите число а");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            c = Convert.ToInt32(Console.ReadLine());


            d = (float) (Math.Pow(b, 2) - 4 * a * c);
            if (d > 0)
            {
                x1 = (float) ((-b + Math.Sqrt(d)) / (2 * a));
                x2 = (float) ((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine($"x1={x1} x2={x2}");
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
    }
}