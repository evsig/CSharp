using System;

namespace MyArrayList2
{
    class Program
    {
        static ArrayList aList = new ArrayList();
        
        static void Main(string[] args)
        {
            //ArrayList1 aList1 = new ArrayList1;
            //aList1.Add(5);


            aList.ShowArray();
            aList.Add(33);
            aList.Add(32);
            aList.ToArray();
            Console.WriteLine(aList.Get(32));
            /*aList.Add(31);
            aList.Add(30);
            aList.Add(29);
            aList.Add(28);
            aList.Add(27);
            aList.Add(26);
            aList.Add(25);
            aList.Add(24);
            aList.Add(23);
            aList.Add(22);
            aList.Add(21);
            aList.Add(20);
            aList.Add(19);
            aList.Add(18);
            aList.Add(17);
            aList.Add(16);*/
            Console.Read();
        }
    }
}
