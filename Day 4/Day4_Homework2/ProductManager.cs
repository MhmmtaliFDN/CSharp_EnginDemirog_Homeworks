using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Homework2
{
    class ProductManager<T>
    {
        T[] Items;
        T[] tempArray;
        public ProductManager()
        {
            Items = new T[0];
        }
        public void Add(T item)
        {
            tempArray = Items;
            Items = new T[Items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Items[i] = tempArray[i];
            }
            Items[Items.Length - 1] = item;
        }

        public T[] Product
        {
            get { return Items; }
        }
    }
}
