using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Создайте класс, который позволит выполнять мониторинг ресурсов, используемых программой.
//Используйте его в целях наблюдения за работой программы, а именно: пользователь может
//указать приемлемые уровни потребления ресурсов(памяти), а методы класса позволят выдать
//предупреждение, когда количество реально используемых ресурсов приблизиться к максимально допустимому уровню

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            МonitorResources monitor = new МonitorResources();
            monitor.MaxMem = 400000;
            var timer = new Timer(monitor.Checking, null, 0, 100);            
            for (int i = 0; i < 100; i++)
            {
                new MyClass().method(i);
            }
            timer.Dispose();
            Console.WriteLine("Количество проведенных сборок мусора: "+GC.CollectionCount(0));
            Console.WriteLine("Для выходы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
