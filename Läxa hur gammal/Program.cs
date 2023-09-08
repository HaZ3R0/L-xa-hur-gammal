using System;
namespace Läxa_hur_gammal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket år föddes du?"); 
            string årtal = Console.ReadLine();
            int x = int.Parse(årtal);
            int ålder = 2023 - x;
            Console.WriteLine("Du är " + ålder + " år gammal");
            Console.ReadKey();
        }
    }
}
