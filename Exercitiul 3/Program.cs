using System;

namespace Exercitiul_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul!");
            int numar = Convert.ToInt32(Console.ReadLine());
            int ultimaCifra = numar % 10;
            Console.WriteLine("Ultima cifra a numarului introdus = " + ultimaCifra);
        }
    }
}
