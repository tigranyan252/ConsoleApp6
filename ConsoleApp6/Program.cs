using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите N");
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите A");
                double A = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите B");
                double B = double.Parse(Console.ReadLine());
                double H = (B - A) / N;
                for (double i =A ; i <=B; i+=H)
                {
                    Console.WriteLine(1-Math.Sin(i));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
