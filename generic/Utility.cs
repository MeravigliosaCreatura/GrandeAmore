using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public static class Utility
    {
        /// <summary>
        /// Вывод элементов последовательности на экран
        /// </summary>
       
         public static void Print<T>(IEnumerable<T> smth)
         {
             
             foreach (T value in smth)
             {
                 
                 Console.WriteLine(value);

             }
         }
        
        /// <summary>
         /// Сортировка
        /// </summary>
       
        public static void Sort<T> (IList <T> smth) where T: IComparable <T>
        {
           for(int i=0; i<smth.Count-1;i++)
           {
               for (int k = 0; k < smth.Count-i-1; k++)
               {
                   if (smth[k].CompareTo(smth[k + 1]) > 0)
                   {
                       T swap = smth[k];
                       smth[k] = smth[k + 1];
                       smth[k + 1] = swap;
                   }
               }
           }
        }
    }   
}

