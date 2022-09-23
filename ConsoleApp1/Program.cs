using System;

namespace ЛР1_асд
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (Math.Pow(x, 5) * (Math.Cos(a + x)) - Math.Pow((Math.Abs(2 * x - a)), 1 / 3) + Math.Log10(Math.Pow((x - 2), 2) + 2));

            double f = ((Math.Sqrt(Math.Pow(a * x, 2) + b * x)) * Math.Exp(-a * x) + Math.Log10(Math.Abs(a - x) + 3));

            Console.WriteLine("Вывод по Y=" + y);
            Console.WriteLine("Вывод по F=" + f);
            Console.ReadKey();
        }
    }
}