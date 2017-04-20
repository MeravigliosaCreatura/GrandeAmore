using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Person : IComparable<Person>
    {
        private String _firstName;
        private String _lastName;

        public Person(String FirstName, String LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public override string ToString()
        {
            return string.Format("Фамилия: {0}, Имя: {1} ", _lastName, _firstName);
            
        }

        public int CompareTo(Person other)
        {
            string FIO = this._lastName + this._firstName;
            string otherFio = other._lastName + other._firstName;   
            if (FIO.CompareTo(otherFio)>0) 
            {
                return 1;
            }

            if (FIO.CompareTo(otherFio)==0) 
            {
                return 0;
            }

            return -1;

         }


    }
}


