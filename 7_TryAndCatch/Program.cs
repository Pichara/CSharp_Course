internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            int numero = int.Parse("abc");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
