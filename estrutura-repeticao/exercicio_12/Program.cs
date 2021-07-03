/*Utilizando as estruturas de repetição, crie um programa C# que realize
uma contagem regressiva decrescente iniciando em 10 e exiba a mensagem
"Foguete lançado ao espaço!".*/
using System;

namespace exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem regressiva iniciada em ...");

            for (int contador = 10; contador > -1; contador--)
            {
                Console.WriteLine(contador);
            }
            Console.WriteLine("Foguete lançado ao espaço!");
        }
    }
}
