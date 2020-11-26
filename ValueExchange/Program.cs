/*
Эберлинг Виктор Викторович

4. Написать программу обмена значениями двух переменных.

а) с использованием третьей переменной;
б) *без использования третьей переменной.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueExchange
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Настройки консоли
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetWindowSize(50, 10);
            Console.SetBufferSize(50, 10);
            #endregion
            double x, y, z;
            Console.WriteLine("Обмен значениями трех переменнных");
            Console.Write("Введите значение переменной X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной Z: ");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nВведено: X = {x}, Y = {y}, Z = {z}\nМеняем местами...");
            double[] mass = {x, y, z };
            Console.Write($"         X = {x = mass[1]}, Y = {y = mass[2]}, Z = {z = mass[0]}");
            Console.ReadKey();
            Console.Clear();
            double a, b;
            Console.WriteLine("Обмен значениями двух переменнных");
            Console.Write("Введите значение переменной X: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной Y: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nВведено: X = {a}, Y = {b}\nМеняем местами...");
            double[] mass2 = {a, b };
            Console.Write($"         X = {a = mass2[1]}, Y = {b = mass2[0]}");
            Console.ReadKey();
        }
    }
}
