using System;

namespace Combustiveis 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int opcao = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while (opcao != 4) 
            {
                if (opcao == 1) 
                {
                    alcool++;
                }
                else if (opcao == 2) 
                {
                    gasolina++;
                }
                else if (opcao == 3) 
                {
                    diesel++;
                }
                
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
    }
}
