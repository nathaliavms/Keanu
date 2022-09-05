using System;

namespace Keanu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine((numero * numero) - ((numero * numero) / 2) + " casas brancas e " + ((numero * numero) / 2) + " casas pretas");
        }
    }
}
