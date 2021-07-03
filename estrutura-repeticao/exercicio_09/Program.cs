/*Crie um programa em C# usando as estruturas de repetição que contabilize
a velocidade de um carro de fórmula 1, sem ultrapassar o limite de 200km/h
permitido na pista e ao final exiba uma mensagem informando que chegou ao limite.*/
using System;

namespace exercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidade = 0;

            while(velocidade < 201){
                Console.WriteLine($"O veiculo está há {velocidade} km/h.");
                velocidade++;

               
            }
             Console.WriteLine("Você chegou no limite máximo permitido!");
             Console.ReadKey();
          
        }
          
    }
}
