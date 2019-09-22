using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте свой класс, объекты которого будут занимать много места в памяти
//(например, в коде класса будет присутствовать большой массив) и реализуйте
//для этого класса формализованный шаблон очистки.

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем первый объект и заполняем массив на 1000000 массивами из 100 Int переменных
            Console.WriteLine("Первый объект заполняем массив на 1000000 массивами из 100 Int переменных");
            var inst = new MyClass();
            for (int i = 0; i < inst.obj.Length; i++)
            {
                inst.obj[i] = new int[100];
            }
            Console.WriteLine("Очистка методом Dispose");
            inst.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine(new string('_', 20));


            //Создаем второй объект и заполняем массив на 1000000 массивами из 500 string переменных
            Console.WriteLine("Второй объект заполняем массив на 1000000 массивами из 500 String переменных\nОсвобождение ресурсов используя Using(Dispose Вызывается приотработке метода внутри конструкции)");
            using (var inst2 = new MyClass())
            {
                for (int i = 0; i < inst2.obj.Length; i++)
                {
                    inst2.obj[i] = new string[500];
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine(new string('_', 20));

            //Создаем третий объект
            Console.WriteLine("Третий объект\nОсвобождение ресурсов произойдет после прохода сборщика мусора");
            var inst3 = new MyClass();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Для выхода нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
