using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Vector<T> : IList<T>
    {
        private T[] _data = new T[1];
        private int _count = 0;

        /// <summary>
        /// Количество элементов в векторе
        /// </summary>

        public int Count
        {
            get
            {
                return _count;
            }

        }

        /// <summary>
        /// Добавление элемента в вектор
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            _data[_count] = value;
            _count++;
            Array.Resize(ref _data, _count + 1);

        }

        /// <summary>
        /// Проверка наличия элемента в векторе
        /// </summary>
        /// <param name="person"></param>

        public bool Contains(T person)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_data[i].Equals(person))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Поиск индекса элемента
        /// </summary>

        public int IndexOf(T person)
        {
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if (_data[i].Equals(person))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        /// <summary>
        ///  Вставка элемента по индексу
        /// </summary>

        public void Insert(int index, T person)
        {
            if (_count + 1 >= _data.Length || index <= 0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }
            _count++;

            for (int i = Count; i > index; i--)
            {
                _data[i] = _data[i - 1];
            }
            _data[index] = person;


        }

        /// <summary>
        /// Удаление по индексу
        /// </summary>

        public void RemoveAt(int index)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = index; i < Count; i++)
            {
                _data[i] = _data[i + 1];
            }
            _count--;


        }


        /// <summary>
        /// Удаление элемента
        /// </summary>

        public bool Remove(T person)
        {
            if (IndexOf(person) < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            RemoveAt(IndexOf(person));
            return true;

        }


        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Cкопировать из одного массива в другой, начиная с указанного индекса
        /// </summary>

        public void CopyTo(T[] arr, int index)
        {
            int I = index;
            for (int i = 0; i < Count; i++)
            {
                arr.SetValue(_data[i], I);
                I++;
            }

        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > _count)
                {

                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return _data[index];
                }
            }
            set
            {
                if (index < 0 || index > _count)
                {
                    throw new IndexOutOfRangeException();
                }
                _data[index] = value;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_data).GetEnumerator();
        }

        /// <summary>
        /// Очистка вектора
        /// </summary>

        public void Clear()
        {
            _count = 0;
        }

    }

}
