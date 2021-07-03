using System;

namespace exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que receba o chamado de usuários
            classificando e exibindo na tela o nivel de urgência do chamado,
            sendo que de 0 até 3 = nivel baixo, maior que 3 até 6 = nivel médio,
            maior que 6 até 9 = nivel alto e grave para maior numero da escala*/

            int urgencia = 0;
            Console.WriteLine("                                                         ");
            Console.WriteLine("Por favor descreva qual a solicitação de urgência:"       );
            Console.WriteLine("=========================================================");
            Console.ReadLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine("                                                         ");
          
            Console.WriteLine("Informe em uma escala de 0 até 10 o seu nivel de urgência");
            Console.WriteLine("=========================================================");
            urgencia = int.Parse(Console.ReadLine());
            Console.WriteLine("=========================================================");

            if(urgencia >= 0 && urgencia <= 3)
            {
                Console.WriteLine($"Sua solicitação de escala {urgencia} foi enviado com sucesso e é de Nivel Baixo!");
            }
            else if (urgencia > 3 && urgencia <= 6)
            {
                Console.WriteLine($"Sua solicitação de escala {urgencia} foi enviado com sucesso e é de Nivel Médio!");
            }else if(urgencia > 6 && urgencia < 9)
            {
                Console.WriteLine($"Sua solicitação de escala {urgencia} foi enviado com sucesso e é de Nivel Alto!");
            }
            else
            {
                Console.WriteLine($"Sua solicitação de escala {urgencia} foi enviado com sucesso e é de Nivel Grave!");
            }




        }
    }
}
