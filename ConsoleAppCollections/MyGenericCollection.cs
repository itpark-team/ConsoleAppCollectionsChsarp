using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppCollections
{
    public class MyGenericCollection<T>
    {
        private T[] array;

        public MyGenericCollection()
        {
            array = new T[0];
        }

        public void Add(T elem)
        {
            T[] tempArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[tempArray.Length - 1] = elem;

            array = tempArray;
        }

        public T GetElemByIndex(int index)
        {
            return array[index];
        }

        public int GetLength()
        {
            return array.Length;
        }
    }
}