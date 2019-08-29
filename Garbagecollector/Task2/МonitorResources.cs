using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Мониторинг ресурсов
    /// </summary>
    class МonitorResources
    {

        /// <summary>
        /// Хранит заданую максимальный объем отведенной памяти 
        /// </summary>
        public long MaxMem = long.MaxValue; 


        /// <summary>
        ///Проверяет количество памяти если превышает максимальное заданное - Извещение о превышении памяти
        /// </summary>
        /// <param name="obj"></param>
        public void Checking(object obj)
        {
            if (CheckNow() >= MaxMem)
            {
                Console.WriteLine("Превышение памяти");
            }
        }

        /// <summary>
        /// Проверяет занятую память
        /// </summary>
        /// <returns>long занятой памяти</returns>
        public long CheckNow()
        {
            return GC.GetTotalMemory(false);
        }

        /// <summary>
        /// Устанавливает максимальный объем в мб
        /// </summary>
        /// <param name="mb">Память в мб</param>
        public void MaxMemory(int mb)
        {
            long maxbytes = mb * 1024;
            if (maxbytes <= long.MaxValue && maxbytes >= long.MinValue)
            {
                MaxMem = maxbytes;
            }
        }
    }
}
