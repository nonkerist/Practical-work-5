//****************************************
//* Практическая_работа_1 работа № 5     *
//* Выполнил: Истомин Е. А., группа 2ИСПд*
//****************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, m;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Практическая_работа_5.");
            Console.WriteLine("Здравствуй пользователь!");
            Console.Write("Введите температуру: ");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());
            if (a >= 70 && a <= 80 && m >= 50 && m <= 60)
            {
                Console.WriteLine("Процесс вулканизации прошел нормально.");
            }
            else
                Console.WriteLine("Процесс вулканизации прошел ненормально.");
            Console.ReadKey();
        }
    }
}
