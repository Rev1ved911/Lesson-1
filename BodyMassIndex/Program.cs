/*
Эберлинг Виктор Викторович

2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double Growth_M, Weight, BMIndex, Growth_CM;
            Console.Write("Введите ваш рост в см.: ");
            Growth_CM = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш вес в кг.: ");
            Weight = Convert.ToDouble(Console.ReadLine());
            Growth_M = Growth_CM / 100;
            BMIndex = Weight / (Growth_M * Growth_M);
            Console.WriteLine($"\n   Индекс вашей массы тела (ИМТ) составляет: {BMIndex.ToString("f2")}");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
