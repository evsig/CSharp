using System;
using System.Collections.Generic;
using System.Text;

namespace MyArrayList2
{
    public class ArrayList1<T> /*используем обобобщение. теперь при иниц класса можем дополнительно указывать какого типа класс
    мы создаём. */
        {
        T[] array;

        //int[] array;
        int realLength;

        //public ArrayList1()
        //{
        //    array = new int[10];
        //}


        public ArrayList1()
        {
            array = new T[10];
        }

        //public void Add(int val)
        //{
        //    array[realLength] = val;

        //}
    }
}
