using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
         StringBuilder sb = new StringBuilder("abc");
         sb.Append(", def");
         sb.Append(" ,ghi");
         sb.AppendLine();
         sb.Append("Welcome to GSS");
         Console.WriteLine(sb);

        StringBuilder sb1 = new StringBuilder("Welcome GSS");
        sb1.Insert(8, "to  world ");
        Console.WriteLine(sb1);


        StringBuilder sb2 = new StringBuilder("Welcome to GSS ");
        sb2.Remove(8, 4);
        Console.WriteLine(sb2);

        StringBuilder sb3 = new StringBuilder("Welcome to GSS");
        sb3.Replace("GSS" ,"C#");
        Console.WriteLine(sb3);
    }
}



