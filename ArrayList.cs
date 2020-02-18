using System;
using System.Collections.Generic;
using System.Text;

namespace MyArrayList2
{
    public class ArrayList
    {
        private int[] array;  //поле для того, чтобы хранить данные внутри экз класса
        private int realLength; //счетчик добавленных, не нулевых элементов

        public ArrayList()
        {
            array = new int[10]; //создаёт пустой массив. сработает в момент создания экземпляра класса
            realLength = 0;
        }

        public ArrayList(int[] array)
        {
            this.array = array; //создаёт пустой массив. сработает в момент создания экземпляра класса
            realLength = array.Length;
        }


        public int[] ToArray() //возвращает массив
        {
            int[] temp = new int[realLength];
            for (int i = 0; i < realLength; i++)
            {
                temp[i] = array[i];
            }
            return temp; 
        }


        public void ShowArray()
        {
            for (int i = 0; i < array.Length; i++)
            Console.Write(array[i]+" ");
        }
        public void AddCapacity()
        {
            int[] temp = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
                Console.Write(temp[i]);
            }
            array = temp;
        }
        public void Add(int val) //добавляет элемент со значением val на место с индексом realLength,
                                //т.к. место последнего добавленного элемента realLenght - 1 
        {
            if (realLength == array.Length)
            {
                AddCapacity();
            }

            array[realLength] = val;
            realLength++;
        }
       /* public void AddAll(int[] array)
        {
            if (array)
            for (int i = 0; i < array.Length; i++)
            {
                Add(array[i]);
            }
        }*/
        public void Remove(int val)
        {
            int index = Array.IndexOf(array, val, 0, realLength);
            if (index < 0)
                return;
            for (int i = index; i < realLength - 1; i++)
            {
                array[i] = array[i+1];
                realLength--;
            }
        }
        public bool Contain(int val)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                { return true; }
            }
            return false;
        }
        public void RemoveAt(int idx)
        {
            if (idx > realLength)
            { return; }
            else
            {
                for (int i = idx; i < realLength - 1; i++)
                {
                    array[i] = array[i - 1];
                }
            }
            array[realLength - 1] = 0;
            if (realLength< array.Length)//обратная формула
            {
                //создать новый массив и перенести в него всё, что было
            }
            realLength--;
        }
        public int Search(int val)
        {
            int idx = 0;
            if (idx > realLength)
            { return -1; }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                {
                    return idx;
                }
            }
            return -1;
        }
        public void RemoveAll(int val)
        {
            //int[] idxs = Search(val); //получаем значения индексов переменных
            int[] temp = new int[realLength];
            int counter = 0;
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] != val)
                {
                    temp[i - counter] = array[i];
                }
                else { counter++; }
            }
            array = temp;
            realLength -= counter;
        }
        public int Get(int val)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (array[i] == val)
                    return i;
            }
            return -1;
        }
        public void Set(int val)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (array[i] == val)
                    array[i] = val;
            }
        }

    }
}
