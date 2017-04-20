using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        public static bool ByFclub(Footballer f1, Footballer f2)
        {
            if (f1._fclub.CompareTo(f2._fclub) < 0)
            {
                return true;
            }
            return false;
        }

        static void Sort<T>(T[] array, Func<T, T, bool> compare)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (!compare(array[j], array[j + 1]))
                    {
                        var t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
                }

            }
        }


        static void Main(string[] args)
        {
            var calculator = new Calculator();
            calculator.Add(x => x * 2.0);
            calculator.Add(x => x + 6);
            Console.WriteLine("Результат выполнения операций:   {0}", calculator.Execute(5.0));
            Logger log = new Logger();
            log.Add(msg => Console.WriteLine("{0:dd.MM.yyyy HH:mm:ss} {1}", DateTime.Now, msg));
            log.Add(msg => File.WriteAllText(@"C:\Users\ItGigant\Desktop\log.txt", msg));
            log.Log("Я уеду жить в Лондон!");
            var players = new[]
            {
                new Footballer("Cristiano", "Ronaldo","Real Madrid",7),
                new Footballer("Manuel", "Neuer","Bayern",1),
                new Footballer("Antoine", "Griezmann","Atletico",7),
                new Footballer("Edinson", "Cavani","Paris Saint-Germain",9),
                new Footballer("Mesut", "Ozil","Arsenal",11)
                            
            };

            Console.WriteLine("До сортировки:");
            foreach (var value in players)
            {
                Console.WriteLine(value._fclub);
            }

            Program.Sort(players, ByFclub);
            Console.WriteLine("После сортировки:");
            foreach (var value in players)
            {
                Console.WriteLine(value._fclub);
            }

            Console.WriteLine("До сортировки:");

            foreach (var value in players)
            {
                Console.WriteLine(value._lastname);
            }

            Program.Sort(players, delegate(Footballer f1, Footballer f2)
            {
                if (f1._lastname.CompareTo(f2._lastname) < 0) return true;
                return false;
            });
            Console.WriteLine("После сортировки:");
            foreach (var value in players)
            {
                Console.WriteLine(value._lastname);
            }

            Console.WriteLine("До сортировки:");
            foreach (var value in players)
            {
                Console.WriteLine(value._number);
            }

            Program.Sort(players, (f1, f2) => f1._number < f2._number);
            Console.WriteLine("После сортировки:");
            foreach (var value in players)
            {
                Console.WriteLine(value._number);
            }

        }

    }
}