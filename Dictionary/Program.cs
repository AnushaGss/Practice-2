using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> names = new Dictionary<int, string>();
        names.Add(1, "abc");
        names.Add(2, "def");
        names.Add(3, "ghi");

        foreach (KeyValuePair<int, string> pair in names)
        {
            Console.WriteLine(pair.Key + " " + pair.Value);
        }
    }
}