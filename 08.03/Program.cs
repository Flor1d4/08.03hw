using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03
{
    internal class Program
    {
        static void Main()
        {
            string[] countries1 = { "Украина", "США", "Китай", "Украина", "Германия", "Польша" };
            string[] countries2 = { "Китай", "Япония", "США", "Австрия", "Канада" };
            // разность множеств
            var result = countries1.Except(countries2);
            Console.WriteLine("Разница двух массивов:");
            foreach (var country in result)
            {
                Console.WriteLine(country);
            }
            // пересечение множеств
            result = countries1.Intersect(countries2);
            Console.WriteLine("\nПересечение массивов:");
            foreach (var country in result)
            {
                Console.WriteLine(country);
            }
            // Для объединения двух множеств используется метод Union. 
            // Его результатом является новый набор, в котором имеются элементы, как из одного, так и из второго множества. 
            // Повторяющиеся элементы добавляются в результат только один раз
            // объединение множеств
            result = countries1.Union(countries2);
            Console.WriteLine("\nОбъединение массивов:");
            foreach (var country in result)
            {
                Console.WriteLine(country);
            }
            // Для удаления дубликатов в наборе используется метод Distinct
            Console.WriteLine("\nСодержимое первого массива без повторений:");
            result = result.Distinct();           
            foreach (var country in result)
            {
                Console.WriteLine(country);
            }           
        }
    }
}
