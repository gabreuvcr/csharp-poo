using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, quantia, conversao;

            Console.Write("Qual é a cotação do dólar: ");
            cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            quantia = double.Parse(Console.ReadLine());

            conversao = ConversorDeMoeda.DolarParaReal(cotacao, quantia);

            Console.WriteLine($"Valor a ser pago em reais = {conversao:F2}");
        }
    }
}
