﻿/*
Эберлинг Виктор Викторович

3.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distance
{
    class Program
    {
        static double result(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void Main(string[] args)
        {
            #region Настройки консоли
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetWindowSize(59, 9);
            Console.SetBufferSize(59, 9);
            #endregion
            double x1, x2, y1, y2, r;
            Console.Write("Введите координаты первой точки:\nx1: ");
            x1 = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты второй точки:\nx2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            r = result(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между координатой {x1}.{y1} и {x2}.{y2} равно - {r.ToString("f2")}");
            Console.ReadKey();
        }
    }
}
