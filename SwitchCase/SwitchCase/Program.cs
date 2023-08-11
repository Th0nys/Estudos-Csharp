using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            // Switch Case

            switch (x)
            {
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2: Console.WriteLine("Monday");
                    break;
                case 3: Console.WriteLine("Tuesday");
                    break;
                default: Console.WriteLine("Invalid Value");
                    break;
            }

            // Operacao ternaria

            double y = double.Parse(Console.ReadLine());

            double desconto = (y < 10) ? y * 0.1 : y * 0.05;

            Console.WriteLine(desconto.ToString("F2"));

        }
    }
}