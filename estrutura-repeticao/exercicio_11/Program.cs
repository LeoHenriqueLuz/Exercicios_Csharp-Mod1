/*Crie um programa C# que exiba um cardápio de uma pizzaria contando
10 sabores de pizza e exiba na tela a frase "Temos o sabor:" e "Aproveite a refeição"
em todos os sabores.*/
using System;

namespace exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sabor = 
            {
               "mussarela",
               "portuguesa",
               "calabresa",
               "frango com catupiry",
               "baiana",
               "4 queijos",
               "peperoni",
               "Caipira",
               "atum",
               "frango com milho"
            };

            foreach (string sabores  in sabor)
            {
                 Console.WriteLine("=================================================================");
                 Console.WriteLine($"Temos o sabor: {sabores} || Aproveite a refeição!");
                
            }
                 Console.WriteLine("=================================================================");

              Console.ReadKey(); 
        }
        
    }
}
