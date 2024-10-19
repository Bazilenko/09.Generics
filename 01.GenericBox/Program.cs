using System;
class Program
{
    static void Main()
    {
        Menu7();
    }
    static void Menu1()
    {
        Box<int> box = new Box<int>();
        Box<string> box1 = new Box<string>();
        box.Value = int.Parse(Console.ReadLine());
        box1.Value = Console.ReadLine();
        Console.WriteLine(box.ToString());
        Console.WriteLine(box1.ToString());
    }
    static void Menu2()
    {
        Console.WriteLine("Enter N:");
        int N;
        List<Box<string>> boxes = new List<Box<string>>();
        N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            Box<string> box = new Box<string>(Console.ReadLine());
            boxes.Add(box);
        }
        PrintList(boxes);
    }
    static void Menu3()
    {
        Console.WriteLine("Enter N:");
        int N;
        List<Box<int>> boxes = new List<Box<int>>();
        N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
            boxes.Add(box);
        }
        PrintList(boxes);
    }
    static void Menu4()
    { 
        List<Box<int>> boxes = new List<Box<int>>();
        Box<int> box = new Box<int>();
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        for(int i = 0;i < N; i++)
        {
            box = new Box<int>(int.Parse(Console.ReadLine()));
            boxes.Add(box);
        }
        int ind1, ind2;
        ind1 = int.Parse(Console.ReadLine());
        ind2 = int.Parse(Console.ReadLine());
        Box<int> swapBox = new Box<int>();
        swapBox.Swap(boxes, ind1, ind2);
        PrintList(boxes);    
    }
    static void Menu5()
    {
        List<Box<string>> boxes = new List<Box<string>>();
        Box<string> box = new Box<string>();
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            box = new Box<string>(Console.ReadLine());
            boxes.Add(box);
        }
        int ind1, ind2;
        ind1 = int.Parse(Console.ReadLine());
        ind2 = int.Parse(Console.ReadLine());
        box.Swap(boxes, ind1, ind2);
        PrintList(boxes);
    }
    static void Menu6()
    {
        
        List<Box<string>> boxes = new List<Box<string>>();
        Box<string> box = new Box<string>();
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            box = new Box<string>(Console.ReadLine());
            boxes.Add(box);
        }
        Console.WriteLine("Enter value for comparing:");
        box = new Box<string>( Console.ReadLine());
        Console.WriteLine(box.Compare(boxes, box));
        
    }
    static void Menu7()
    {
        List<Box<double>> boxes = new List<Box<double>>();
        Box<double> box = new Box<double>();
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            box = new Box<double>(double.Parse(Console.ReadLine()));
            boxes.Add(box);
        }
        Console.WriteLine("Enter value for comparing:");
        box = new Box<double>(double.Parse(Console.ReadLine()));
        Console.WriteLine(box.Compare(boxes, box));

    }
    static void PrintList<T>(List<T> list) {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}