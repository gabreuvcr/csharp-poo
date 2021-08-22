using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre o número da conta: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine().ToLower());

            if (resp == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(id, nome, depositoInicial); 
            }
            else 
            {
                conta = new Conta(id, nome);
            }

            Console.WriteLine($"\nDados da conta:\n{conta}");

            Console.Write("\nEntre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);

            Console.WriteLine($"Dados da conta atualizados:\n{conta}");

            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);

            Console.WriteLine($"Dados da conta atualizados:\n{conta}");
        }
    }
}
