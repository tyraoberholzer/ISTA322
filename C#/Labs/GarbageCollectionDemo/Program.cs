﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Tyra Oberholzer's GarbageCollection Demo Lab.");
            //Calculator calc = new Calculator();
            //double result = calc.Divide(120, 15);
            //Console.WriteLine($"120 / 15 = {result}");
            Console.WriteLine("=================================================================================");
            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine($"120 / 0 = {calculator.Divide(120, 0)}");
            }
            Console.WriteLine("Program finishing");
        }
    }
}
