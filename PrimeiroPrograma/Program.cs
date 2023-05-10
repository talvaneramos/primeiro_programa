using System;

namespace PrimeiroPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Bem vindo(a): " + nome);

            Console.ReadKey();
        }
    }
}
