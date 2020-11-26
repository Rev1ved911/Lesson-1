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
            double Growth_M, Weight, BMIndex, Growth_CM;
            Console.Write("Введите ваш рост в см.: ");
            Growth_CM = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш вес в кг.: ");
            Weight = Convert.ToDouble(Console.ReadLine());
            Growth_M = Growth_CM / 100;
            BMIndex = Weight / (Growth_M * Growth_M);
            Console.WriteLine($"\n   Индекс вашей массы тела (ИМТ) составляет: {BMIndex.ToString("f2")}");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
