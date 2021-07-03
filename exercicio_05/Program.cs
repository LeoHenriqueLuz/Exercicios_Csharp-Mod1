       /* Crie um programa em C# que utilize uma Função chamada "PreçoFinal que
          ajuste em 25% a mais do valor inicial dos produtos:
          * chocolate: 30
          * Refrigerante: 50
          * Bolo: 45
          * Sorvete: 60
          * Pão: 15 
            Exiba o resultado na tela
          */
using System;

namespace exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
         precoFinal("chocolate", 30);
         precoFinal("Refrigerante", 50);
         precoFinal("Bolo", 20);
         precoFinal("Sorvete", 60);
         precoFinal("Pão", 15);

         Console.ReadLine();

        }
          static void precoFinal( string nomeProduto, int preco)
          {
              int valorFinal = preco + (preco/4);
             
              Console.WriteLine( $" O produto: {nomeProduto} custa R$ {valorFinal}");
          }
    }
}
