using System;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int numQuartos = Int32.Parse(Console.ReadLine());

            Aluno[] quartos = new Aluno[10];

            for (int i = 0; i < numQuartos; i++) 
            {
                Console.WriteLine($"\nAluguel #{i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int escolhido = Int32.Parse(Console.ReadLine());
                if (quartos[escolhido] == null)
                {
                    quartos[escolhido] = new Aluno(nome, email);
                } 
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}: {quartos[i]}");
                }
            }
        }
    }
}
