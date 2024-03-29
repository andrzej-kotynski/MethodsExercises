﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2484612#content
namespace MethodsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");

            int number;
            var result = int.TryParse("abc", out number); // result is bool
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }
        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                //point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at {point.X}, {point.Y}");

                point.Move(100, 200);
                Console.WriteLine($"Point is at {point.X}, {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}