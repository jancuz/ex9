using System;
using MyLibrary;

namespace ex9
{
    class Program
    {
        const int MININT_VALUE = -100;
        const int MAXINT_VALUE = 100;
        const int MIN_SIZE = 1;
        const int MAX_SIZE = 100;

        static void PrintMenu()
        {
            Console.WriteLine("1. Создать однонаправленный список.");
            Console.WriteLine("2. Сформировать pos и neg списки.");
            Console.WriteLine("3. Выход.");
        }

        static void Run()//работа с однонаправленными списками
        {
            int checkRun1 = 0, left = 1, right = 3;
            int size = 0;
            UnidirectionalList beg = null;
            do
            {
                PrintMenu();
                checkRun1 = AskData.ReadIntNumber("Введите номер пункта, который хотите выполнить", left, right);
                switch (checkRun1)
                {
                    case 1: //создать список
                        {
                            size = AskData.ReadIntNumber("Введите количество элементов списка:", MIN_SIZE, MAX_SIZE);
                            beg = UnidirectionalList.MakeList(ref size);
                            UnidirectionalList.ShowList(beg);
                            break;
                        }

                    case 2: //pos и neg списки
                        {
                            UnidirectionalList begPos = null;
                            UnidirectionalList begNeg = null;
                            beg = UnidirectionalList.FormPosAndNegList(beg, ref begPos, ref begNeg);
                            Console.WriteLine("Главный список:");
                            UnidirectionalList.ShowList(beg);
                            Console.WriteLine("Список, состоящий из положительных элементов:");
                            UnidirectionalList.ShowList(begPos);
                            Console.WriteLine("Список, состоящий из отрицательных элементов:");
                            UnidirectionalList.ShowList(begNeg);
                            break;
                        }
                }
            } while (checkRun1 != right);

        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}
