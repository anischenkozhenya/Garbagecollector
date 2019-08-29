using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyClass : IDisposable
    {
        //Имя объекта
        public string name;
        //Булевая переменная
        bool disposed = false;
        //Большой массив
        public object[] obj = new object[1000000];
        /// <summary>
        /// Конструктор
        /// </summary>
        public MyClass()
        {
            Counter.id++;
            name = "Объект" + Counter.id.ToString();
            Console.WriteLine("Объект создан: "+name);            
        }
        /// <summary>
        /// Метод для подготовки перед очисткой памяти от мусора
        /// </summary>
        public void Dispose()
        {            
            Clean(false);
            Console.WriteLine("Объект " + name + " уничтожен");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clean">Булевой значение.false если первичная очистка</param>
        private void Clean(bool clean)
        {
            if (!disposed)
            {
                if (!clean)
                {
                    disposed = true;

                    Console.WriteLine("Первая очистка");
                }
            }
            Console.WriteLine("Вторичная очистка.При непосредственной очистке ресурсов");
        }
        /// <summary>
        /// Деконструктор
        /// </summary>
        ~MyClass()
        {
            Dispose();
        }
    }
}
