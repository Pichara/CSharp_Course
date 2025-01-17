internal class Program
{
    static void Main(string[] args)
    {
        int resultado = Somar(5, 3);
        Console.WriteLine($"A soma é: {resultado}");
    }

    static int Somar(int a, int b)
    {
        return a + b;
    }
}
