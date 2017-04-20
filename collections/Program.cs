using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1 задание
            List<string> car_list= new List<string>();
            car_list.Add("Toyota");
            car_list.Add("Nissan");
            car_list.Add("BMW");
            Console.Write("Исходный список:");
            Utility.Print(car_list);
            Console.Write("\n");
            Console.WriteLine("Поиск элемента со значением Skoda: {0}", car_list.Contains("Skoda"));
            Console.WriteLine("Вставим новый элемент");
            car_list.Insert(3, "Volswagen");
            Console.Write("Измененный список:");
            Utility.Print(car_list);
            Console.Write("\n");
            Console.WriteLine("Получим тип списка: {0}", car_list.GetType());
            car_list.Clear();


            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(1);
            stack.Push(7);
            Console.Write("Исходный стек:");
            Utility.Print(stack);
            Console.WriteLine("\nУдалим и вернем первый элемент: {0} ",  stack.Pop());
            Console.WriteLine("Вернем первый элемент, не удаляя: {0} ", stack.Peek());
            Console.WriteLine(stack.ToString());
            Console.Write("Измененный стек:");
            Utility.Print(stack);
            stack.Clear();

            Queue<string> pochta_rossii = new Queue<string>();
            pochta_rossii.Enqueue("Марья Ивановновна");
            pochta_rossii.Enqueue("Алевтина Вольдемаровна");
            pochta_rossii.Enqueue("Петр Захарович");
            Console.Write("\nИсходная очередь:");
            Utility.Print(pochta_rossii);           
            Console.WriteLine("\nУдалим элемент очереди");
            pochta_rossii.Dequeue();
            Console.Write("Измененная очередь:");
            Utility.Print(pochta_rossii);
            Console.WriteLine("\nНаходится ли в очереди Барак Обама? {0} ", pochta_rossii.Contains("Барак Обама"));
            pochta_rossii.Clear();


            

            Dictionary<int,string> dictionary= new Dictionary<int,string>();
            dictionary.Add(1, "Китай");
            dictionary.Add(4, "Япония");
            Console.Write("Исходный словарь:");
            Utility.Print(dictionary);
            Console.Write("\n");
            Console.WriteLine("Поиск элемента по ключу 4:{0}", dictionary.ContainsKey(3));
            Console.WriteLine("Получим хешкод словаря:{0}", dictionary.GetHashCode());
            Console.WriteLine("Проверим есть ли элемент со значением Япония:{0}", dictionary.ContainsValue("Япония"));
            dictionary.Clear();

            HashSet<int> hashset = new HashSet<int>();
            hashset.Add(12);
            hashset.Add(14);
            Console.Write("Исходный hashset:");
            Utility.Print(hashset);
            hashset.CopyTo(new int[2]);
            Console.WriteLine("\nСодержится ли элемент со значением 55? {0}", hashset.Contains(55));
            Console.WriteLine("Удалим элемент со значением 1:{0}", hashset.Remove(1));
            HashSet<int> hashset2 = new HashSet<int>();
            hashset2.Add(122);
            hashset2.Add(55);
            Console.Write("HashSet2:");
            foreach(int value in hashset2)
            {
                Console.Write("{0} ", value);
            }
            Console.Write("\n");
            Console.WriteLine("Объединим hashset и hashset2");
            hashset.UnionWith(hashset2);
            Console.Write("Полученный hashset:");
            Utility.Print(hashset);
            Console.Write("\n");

            //2 Задание
            List<double> list2 = new List<double>();
            List<double> list = new List<double>();
            list.Add(3.5);
            list.Add(2.5);
            list.Add(11.44);
            list.Add(6.43);
            list.Add(99.99);
            list.Add(1.3);
            Console.Write("Print:");
            try
            {
                Utility.Print(list);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Write("\n");
            Console.Write("Геометрическая прогрессия: ");
            try
            {
                foreach (double elem in Utility.GeometricProgression(3, 0.5, 6))
                {
                    Console.Write("{0} ", elem);
                }
                Console.Write("\n");
               
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Сумма элементов последовательности (33) ");
            try
            {
                foreach (double elem in Utility.LessWhenSum(list, 24))
                {
                    Console.Write("{0} ", elem);
                }
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("\n");
            Console.Write("Каждый 2 элемент: ");
            try
            {
                foreach (double elem in Utility.Which(list, 2))
                {
                    Console.Write("{0} ", elem);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("\n");
            Console.Write("Латинский алфавит: ");
            foreach (char elem in Utility.LatinAlphabet())
            {
                Console.Write("{0} ", elem);
            }

            Console.Write("\n");
            List<double> listik = new List<double>();
            listik.Add(4.2);
            listik.Add(1.11);
            Console.Write("1 List: ");
            Utility.Print(list);
            Console.Write("\n");
            Console.Write("2 List: ");
            Utility.Print(listik);
            Console.Write("\n");
            Console.Write("Merge:");
            try
            {
                foreach (double elem in Utility.Merge(list, listik))
                {
                    Console.Write("{0} ", elem);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

 }
   
