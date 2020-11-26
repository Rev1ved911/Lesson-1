using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, r;
            Console.Write("Введите координаты первой точки:\nx1: ");
            x1 = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты второй точки:\nx2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между координатой {x1}.{y1} и {x2}.{y2} равно - {r.ToString("f2")}");
            Console.ReadKey();
        }
    }
}
