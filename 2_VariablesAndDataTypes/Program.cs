internal class Program
{
    static void Main(string[] args)
    {
        int idade = 25;
        float altura = 1.75f;
        string nome = "João";
        bool aprovado = true;

        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}, Aprovado: {aprovado}");

        //Integer
        int smallNumber = 90;
        long bigNumber = 900000000L; //L defines the number as 64 bit
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(long.MaxValue);


        //Decimals
        float smallDecimal = 3.14F; //F defines the number to be as float(small decimal)
        double bigDecimal = 0.9999999999999;
        decimal money = 115.99M; //M of mandatory, used in finances. Has 16Bytes
        Console.WriteLine(float.MaxValue);
        Console.WriteLine(double.MaxValue);
    }
}
