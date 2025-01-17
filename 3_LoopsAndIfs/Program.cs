internal class Program
{
    static void Main(string[] args)
    {
        int nota = 85;

        if (nota >= 70)
        {
            Console.WriteLine("Aprovado!");
        }
        else
        {
            Console.WriteLine("Reprovado!");
        }

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Contagem: {i}");
        }
    }
}
