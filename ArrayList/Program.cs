using System;
using System.Collections;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrList=new ArrayList();
        arrList.Add("abc");
        arrList.Add(100);
        arrList.Add(20.31);
        Console.WriteLine("count of Array: " +arrList.Count);
        Console.WriteLine("capacity of Array: " + arrList.Capacity);
        Console.WriteLine("List of Array");
        foreach(var item in arrList)
        {
            Console.WriteLine(item);
        }
    }
}