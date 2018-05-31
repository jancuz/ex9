using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    //определение однонаправленного списка
    class UnidirectionalList
    {
        public int data;//информационное поле
        public UnidirectionalList next;//адресное поле
        public UnidirectionalList()//конструктор без параметров
        {
            data = 0;
            next = null;
        }
        public UnidirectionalList(int d)//конструктор с параметрами
        {
            data = d;
            next = null;
        }
        public override string ToString()
        {
            return data + " ";
        }
    }
}
