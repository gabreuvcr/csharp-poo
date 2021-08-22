using System;
using System.Globalization;

namespace Estoque 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine($"\nDados do produto: {p}\n");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);
        }
    }
}
