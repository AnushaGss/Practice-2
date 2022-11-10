using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 3, 4 };
        list.Insert(0, 0);
        list.Insert(2, 2);
        list.Insert(5,5);

        List<int> list2 = new List<int>() { 500,1000 };
        list.InsertRange(2, list2);
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
}
