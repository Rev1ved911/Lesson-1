/*
Эберлинг Виктор Викторович

1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.

а) используя склеивание;
б) используя форматированный вывод;
в) *используя вывод со знаком $.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Surname;
            double Age, Growth_M, Weight, Growth_CM;
            Console.Write("Введите ваше имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            Surname = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            Age = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш рост в см.: ");
            Growth_CM = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш вес в кг.: ");
            Weight = Convert.ToDouble(Console.ReadLine());
            Growth_M = Growth_CM / 100;
            Console.WriteLine($"\n   Имя: {Name}\n   Фамилия: {Surname}\n   Возраст: {Age} лет\n   Рост: {Growth_M} м.\n   Вес: {Weight} кг.");
            Console.Write("\nPess any key to exit...");
            Console.ReadKey();
        }
    }
}
