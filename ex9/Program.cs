using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

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

        //создание элемента списка
        static UnidirectionalList MakePoint(int d)
        {
            UnidirectionalList p = new UnidirectionalList(d);
            return p;
        }

        static Random rnd = new Random();
        //формирование списка из n элементов путем добавления элементов в конец списка с помощью ДСЧ
        static UnidirectionalList MakeListToEndRandom(int size) //добавление в конец
        {
            int info = rnd.Next(MININT_VALUE, MAXINT_VALUE);
            UnidirectionalList beg = MakePoint(info);
            UnidirectionalList r = beg;
            for (int i = 1; i < size; i++)
            {
                info = rnd.Next(MININT_VALUE, MAXINT_VALUE);
                UnidirectionalList p = MakePoint(info);
                r.next = p;
                r = p;
            }
            return beg;
        }

        //формирование списка из n элементов путем добавления элементов в конец списка с клавиатуры
        static UnidirectionalList MakeListToEndHand(int size) //добавление в конец
        {
            int info = AskData.ReadIntNumber("Введите 1 элемент: ", MININT_VALUE, MAXINT_VALUE);
            UnidirectionalList beg = MakePoint(info);
            UnidirectionalList r = beg;
            for (int i = 2; i <= size; i++)
            {
                Console.Write("Введите {0} элемент:", i);
                info = AskData.ReadIntNumber("", MININT_VALUE, MAXINT_VALUE);
                UnidirectionalList p = MakePoint(info);
                r.next = p;
                r = p;
            }
            return beg;
        }

        static UnidirectionalList MakeList(ref int size) //для формирования списка двумя способами
        {
            int checkMakeUnidirectionalList = 0;
            UnidirectionalList beg = null;
            PrintForm();
            checkMakeUnidirectionalList = AskData.ReadIntNumber("", 1, 3);
            switch (checkMakeUnidirectionalList)
            {
                case 1: beg = MakeListToEndHand(size); Console.WriteLine("Однонаправленный список сформирован"); break;
                case 2: beg = MakeListToEndRandom(size); Console.WriteLine("Однонаправленный список сформирован"); break;
                case 3: size = 0; Console.WriteLine("Однонаправленный список не сформирован!"); break;
            }
            return beg;
        }

        static void Main(string[] args)
        {
        }
    }
}
