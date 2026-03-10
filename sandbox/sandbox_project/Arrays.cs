using System;

public static class Arrays
{
    public static void Run()
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.
        // Console.WriteLine("Hello Sandbox World!");

        // * * * Fixed Array declaration * * * 
        // var numbers = new int[5];

        // for (int i = 0; i < numbers.Count(); i++ )
        // {
        //     numbers[i] = (i + 1) * 10;
        //     Console.Write(numbers[i] + " ");
        // }
        // * * * Fixed Array declaration -new way- * * * 
        // var nums = new [] {11, 12, 13, 14, 15};
        // for (int i = 0; i < nums.Count(); i++ )
        // {
        //     Console.Write(nums[i] + " ");
        // }

        // * * * Dynamic Array * * * 
        // var data = new List<int> { 21, 22, 23, 24, 25 };
        // data.Add(26);
        // data.Add(27);
        // data.Add(28);
        // Console.WriteLine("ForEach Loop");
        // foreach (var item in data)
        // {
        //     Console.Write(item + " ");
        // }        
        // Console.WriteLine("\nFor Loop");
        // for (int i = 0; i < data.Count; i++)
        // {
        //     Console.Write(data[i] + " ");
        // }

        Console.WriteLine("\n======================\nReverse\n======================");
        var lista = new List<int> {23, 45, 98, 34, 53, 67, 71, 18, 3, 8, 5, 2, 9, 1};
        foreach(var e in lista)
        {
            Console.Write( e + " ");
        }
        int qtty = 7;
        Console.WriteLine();
        var start = new List<int> {};
        start.AddRange(lista.GetRange(lista.Count - qtty, qtty));
        foreach(var e in start)
        {
            Console.Write( e + " ");
        }
        Console.WriteLine();
        var end = new List<int> {};        
        end.AddRange(lista.GetRange(0, lista.Count - qtty));
        foreach(var e in end)
        {
            Console.Write( e + " ");
        }
        Console.WriteLine();
        lista.Clear();
        lista.AddRange(start);
        lista.AddRange(end);
        
        foreach(var e in lista)
        {
            Console.Write( e + " ");
        }
    }

}