using System;

namespace Pessoas 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Pessoa mais velha: {(p1.Idade > p2.Idade ? $"{p1.Nome}" : $"{p2.Nome}")}");
        }
    }
}
