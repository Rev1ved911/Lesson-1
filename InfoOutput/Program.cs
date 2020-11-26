/*
Эберлинг Виктор Викторович

5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoOutput
{
    class Program
    {
        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ms);
        }
        static void Main(string[] args)
        {
            #region Настройки консоли
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetWindowSize(50, 25);
            Console.SetBufferSize(50, 25);
            #endregion
            Print("Эберлинг", 22, 9);
            Print("Виктор", 23, 10);
            Print("г. Норильск", 20, 11);
            Console.ReadKey();

        }
    }
}
