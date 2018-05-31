using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        const int MININT_VALUE = -100;
        const int MAXINT_VALUE = 100;
        const int MIN_SIZE = 1;
        const int MAX_SIZE = 100;

        static void PrintForm()
        {
            Console.WriteLine("Введите номер пункта, который хотите выполнить:");
            Console.WriteLine("1. Ввести с клавиатуры");
            Console.WriteLine("2. С помощью ДСЧ");
            Console.WriteLine("3. Назад");
        }

        static void PrintMenu()
        {
            Console.WriteLine("1. Создать однонаправленный список.");
            Console.WriteLine("2. Сформировать pos и neg списки.");
            Console.WriteLine("3. Выход.");
        }

        static void Main(string[] args)
        {
        }
    }
}
