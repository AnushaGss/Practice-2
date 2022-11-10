class Program
{
    // Iterate list element using foreach loop  
    private static void SortValues<T>(List<T> val)
    {
        val.Sort();



        foreach (var name in val)
        {
            Console.WriteLine(name);
        }
    }
    public static void Main(string[] args)
    {

        // Create a list of strings  
        var names = new List<string>();
        names.Add("Sonoo Jaiswal");
        names.Add("Ankit");
        names.Add("Peter");
        names.Add("Irfan");
        SortValues(names);

        // Create a list of int  
        var num = new List<int>();
        num.Add(1);
        num.Add(2);
        num.Add(3);
        num.Add(4);
        num.Add(5);
        SortValues(num);



        // Create a list of char  
        var chars = new List<char>();
        chars.Add('s');
        chars.Add('g');
        chars.Add('l');
        chars.Add('j');
        chars.Add('b');
        SortValues(chars);





        // Create a list of int  
        var d = new List<double>();
        d.Add(1.8);
        d.Add(87.8);
        d.Add(5.8);
        d.Add(7.8);
        d.Add(5.8);
        d.Add(9.8);
        SortValues(d);
    }
}





