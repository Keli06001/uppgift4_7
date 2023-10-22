using System;

namespace uppgift4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande");
            string meddelande = Console.ReadLine();
            Console.WriteLine("hur många steg åt höger vill du skriva ditt meddelande?");
            int steg = int.Parse(Console.ReadLine());
            for (int i = 0; i < meddelande.Length; i++) 
            {
                string bokstav = meddelande[i].ToString();
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(bokstav);
            }
            Console.ReadKey();
        }
    }
}