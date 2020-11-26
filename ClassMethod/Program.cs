/*
Эберлинг Виктор Викторович

6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Relief
    {
        static void Print(string Message)
        {
            Console.Write(Message);
        }
        static void Pause()
        {
            Print("Press eny key...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            #region Настройки консоли
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetWindowSize(17, 2);
            Console.SetBufferSize(17, 2);
            #endregion
            Print("Hello!\n");
            Pause();
        }
    }
}
