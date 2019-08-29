using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{/// <summary>
/// Пользовательский класс
/// </summary>
    class MyClass
    {
        //4*1000~4mb 
        //Создаем массив Int На 10000 элементов~40mb
        public int[] obj = new int[10000];
        //Выводит число(порядковое число)
        public void method(int i)
        {
            Console.WriteLine(i);
        }       
    }
}
