using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2023, 08, 09);
            DateTime d2 = new DateTime(2023, 08, 09, 20, 45, 3);
            DateTime d3 = new DateTime(2023, 08, 09, 20, 45, 3);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;


            Console.WriteLine(d1);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2023-08-09");
            DateTime d8 = DateTime.Parse("2023-08-09 08:34:57 PM");
            DateTime d9 = DateTime.Parse("09/08/2023");

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);

            DateTime d10 = DateTime.ParseExact("2023-08-09", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);
        }
    }
}
