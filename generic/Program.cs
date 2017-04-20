using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector<Person> persons = new Vector<Person>();
            persons.Add(new Person("Стив", "Джобс"));
            persons.Add(new Person("Билл", "Гейтс"));
            persons.Add(new Person("Тим", "Бертон"));
            persons.Add(new Person("Синди", "Гризман"));
            persons.Add(new Person("Андрей", "Михайлов"));
            
            Console.WriteLine("Количество элементов:{0}", persons.Count());
            Utility.Print(persons);
            Console.WriteLine("Добавим элемент по индексу 45:");
            try
            { 
                persons[45] = new Person("Роман", "Лазарев"); 
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                try
                {
                    persons.Remove(persons[9]);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch(IndexOutOfRangeException e) 
            {
                Console.WriteLine(e.Message);
            }
                                
          
            try
            {
                persons.RemoveAt(1);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
                                      
            Console.WriteLine("Количество элементов:{0}",persons.Count());
            Utility.Print(persons);
            Console.WriteLine("Элемент с индексом 1: {0}",persons[1]);
            Console.WriteLine("Исходный вектор");
            Utility.Print(persons);
            
            Utility.Sort(persons);
            Console.WriteLine("Отсортированный вектор");
            Utility.Print(persons);
            Vector<double> edgar = new Vector<double>();
            Random random = new Random();
            
            //проверка           
            const int COUNT = 1000;
            Utility.Sort(edgar);
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            for (int i = 0; i < COUNT; i++)
            {
                edgar.Add(random.NextDouble());
                sw.Start();
                Utility.Sort(edgar);
                sw.Stop();

            }
            Console.WriteLine("{0} ms", sw.ElapsedMilliseconds/COUNT);
            sw.Reset();
            List<double> edgar2 = new List<double>();
            for (int i = 0; i < COUNT; i++)
            {
                edgar2.Add(random.NextDouble());
                sw.Start();
                edgar2.Sort();
                sw.Stop();

            }
            Console.WriteLine("{0} ms", sw.ElapsedMilliseconds/COUNT);
        
        }
    }

}

