using System;

namespace Input 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            byte quartos = byte.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            string sobrenome = dados[0];
            byte idade = byte.Parse(dados[1]);
            float altura = float.Parse(dados[2]);

            Console.WriteLine($"\n{nome}");
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
