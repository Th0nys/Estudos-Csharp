﻿using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Joao", "Alex" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}