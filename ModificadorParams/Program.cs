﻿using ModificadorParams;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(3, 4);
            int s2 = Calculator.Sum(4, 5);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}