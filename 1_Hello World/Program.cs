internal class Program
{
    static void Main(string[] args)
    {

        string name = "Pichara"; // " " is used for strings
        char letter = 'F'; // " " is used for chars
        Console.Write(name);
        Console.WriteLine(letter); //WriteLine comes with a null terminator, like \n

        //But you can also use just the \n
        Console.Write("...\n");

        //string to numbers
        string textAge = "20";
        int age = Convert.ToInt32(textAge); //You can convert to all data types 


        double x = 2.13213123;
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Format1 x: {0}", x.ToString("f2"));
        Console.WriteLine($"Format2 x: {x}");
    }
}
