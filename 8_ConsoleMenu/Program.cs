using System.Runtime.InteropServices;

namespace _8_ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu demo
            bool run = true;
            while (run)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                switch (cki.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Hi");
                        break;

                    default:
                        Console.WriteLine("Key not find");
                        break;

                }
            }

            Console.WriteLine("Program Ended");
        }



    }
}