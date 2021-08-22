using System;
using System.Globalization;

namespace Estoque 
{
    class Produto 
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() 
        {
            Quantidade = 0;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set 
            { 
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEstoque() 
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) 
        {
            Quantidade += quantidade;
            Console.WriteLine($"\nDados atualizado: {this}\n");
        }

        public void RemoverProdutos(int quantidade) 
        {
            if (Quantidade - quantidade >= 0)
            {
                Quantidade -= quantidade;
                Console.WriteLine($"\nDados atualizado: {this}\n");
            }
            else
            {
                Console.WriteLine("\nNão há estoque suficiente\n");
            }
        }

        public override string ToString() 
        {
            return $"{Nome}, " +
            $"$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
            $"{Quantidade} unidades, " + 
            $"total de $ {ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
