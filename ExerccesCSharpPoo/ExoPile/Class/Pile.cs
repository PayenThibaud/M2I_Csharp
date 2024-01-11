using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPile.Class
{
    internal class Pile<T>
    {
        private T[] _elements;
        private int _count;

        public Pile(int taille)
        {
            _elements = new T[taille];
            _count = 0;
        }

        public void AfficheElements()
        {
            foreach (T element in _elements)
            {
                if (element != null && !element.Equals(default(T)))
                {  
                        Console.WriteLine(element);
                }
            }
        }


        public bool Empiler(T input)
        {
            if (_count < _elements.Length)
            {
                _elements[_count++] = input;
                return true;
            }

            return false;
        }
        
        public T Depiler()
        {
            if (_count > 0)
            {
                _count--;
                T elementDepiler = _elements[_count];
                _elements[_count] = default(T);
                return elementDepiler;
            }
            else
            {
                return default(T);
            }
        }

        public T Recuperer(int index)
        {
            if (index >= 0 && index < _count)
            {
                T elementRecupere = _elements[index];

                for (int i = index; i < _count - 1; i++)
                {
                    _elements[i] = _elements[i + 1];
                }

                _elements[_count - 1] = default(T);
                _count--;
                return elementRecupere;
            }
            return default(T);
        }
    }
}
