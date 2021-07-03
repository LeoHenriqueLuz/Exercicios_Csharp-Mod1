using System;

namespace exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
          /*Crie um programa que receba tres numeros do usuário,
          informe na tela qual o menor deles ou exiba se eles são iguais.*/

          Console.WriteLine("Digite um valor:");
          int n1 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite o segundo valor:");
          int n2 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite o terceiro valor:");
          int n3 = int.Parse(Console.ReadLine());

          if(n1 < n2 && n1 < n3 )
          {
             Console.WriteLine($"{n1} é o menor entre os três valores");
          }
          else if (n2 < n1 && n2 < n3)
          {
              Console.WriteLine($" {n2} é o menor entre os três valores");
          }
          else if (n3 < n1 && n3 < n2)
          {
              Console.WriteLine($" {n3} é o menor entre os três valores");
          }
          else if (n1 == n2 && n1 == n3)
          {
              Console.WriteLine($" os valores informados são iguais.");
          }
          else {
              Console.WriteLine(" ERROR: Informe um valor valido");
          }

        }
    }
}
