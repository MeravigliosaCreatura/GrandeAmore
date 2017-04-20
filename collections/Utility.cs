using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    static class Utility
    {
        /// <summary>
        /// Генерирует последовательность букв латинского алфавита
        /// </summary>

        public static IEnumerable<char> LatinAlphabet()
        {
            for (var i = 'a'; i <= 'z'; i++)
            {
                yield return i;
            }

            for (var i = 'A'; i <= 'Z'; i++)
            {
                yield return i;
            }
        }

        /// <summary>
        /// Генерирует элементы геометрической прогрессии
        /// </summary>
        public static IEnumerable<double> GeometricProgression(double first, double factor, int count)
        {
            if (count < 0)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i <= count; i++)
            {
                yield return first * Math.Pow(factor, i - 1);
            }


        }

        /// <summary>
        /// Возвращает максимальное количество  n первых элементов коллекции, сумма которых не превышает заданого значения
        /// </summary>

        public static IEnumerable<double> LessWhenSum(IEnumerable<double> enumerable, double sum)
        {
            int n = 0;
            if (n > 10000)
            {
                throw new OutOfMemoryException();
            }

            double sum2 = 0.0;

            foreach (double elem in enumerable)
            {
                sum2 = sum2 + elem;
                if (sum2 < sum)
                {
                    n++;
                    yield return elem;
                }
            }

        }

        /// <summary>
        /// Возвращает каждый nth член последовательности
        /// </summary>
        public static IEnumerable<T> Which<T>(IEnumerable<T> enumerable, int nth)
        {
            if (nth <= 0)
            {
                throw new ArgumentException();
            }

            int count = 0;
            foreach (T value in enumerable)
            {
                count++;
                if (count % nth == 0)
                {
                    yield return value;
                }

            }
        }

        /// <summary>
        /// Соединяет элементы 2 последовательностей
        /// </summary>
        public static IEnumerable<T> Merge<T>(IEnumerable<T> first, IEnumerable<T> second)
        {
            if (first == null || second == null)
            {
                throw new NullReferenceException();
            }

            foreach (T value in first)
            {
                yield return value;
            }

            foreach (T value in second)
            {
                yield return value;
            }

        }

        /// <summary>
        ///Вывод на экран элементов последовательности 
        /// </summary>

        public static void Print<T>(IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new NullReferenceException();
            }

            foreach (T elem in enumerable)
            {
                Console.Write("{0} ", elem);
            }


        }
    }

}
