﻿using System;

namespace Open_Lab_01._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the base of the triangle and then enter its height");
            string siteA = Console.ReadLine();
            string height = Console.ReadLine();
            int a = Convert.ToInt32(siteA);
            int b = Convert.ToInt32(height);
            int c = a * b / 2;
            Console.WriteLine($"The area of ​​the triangle is {c}.");
        }
    }
}
