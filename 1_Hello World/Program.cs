internal class Program
{
    static void Main(string[] args)
    {
        double x = 2.13213123;
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Format1 x: {0}", x.ToString("f2"));
        Console.WriteLine($"Format2 x: {x}");
    }
}
