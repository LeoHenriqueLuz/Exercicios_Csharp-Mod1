/*A diretora de uma escola precisa de um programa em C# que exiba uma mensagem de 
boas vindas para os 10 alunos novos. Utilizando a estrura Foreach, exiba a mesma msg
para todos os alunos novos.*/
using System;

namespace exercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos_Novos = 
            { 
            "Rafael", 
            "Gustavo",
            "Marcelo",
            "Ana Claudia",
            "Maria Luiza",
            "Eric",
            "Marcia",
            "Delange",
            "Angelina",
            "Ysabela"
            };

            foreach(string nomes in alunos_Novos){
                Console.WriteLine( $"Ola aluno(a) {nomes}, seja bem vindo(a)!");
            }
            Console.ReadKey();
        }
    }
}
