/*Crie um programa C# que exiba para os clientes de um mercado que está aberto
 sob a condição do seu horário de funcionamento das 7h as 17h e após esse horario
 exibir uma mensagem de que se encontra fechado e indicando o horário de 
 funcionamento deste estabelecimento.*/
using System;

namespace exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
           int hora = 7;

           while( hora >= 7 && hora <= 17){
               Console.WriteLine($" Agora são exatamente {hora} horas e o Supermercado se encontra Aberto!");
               hora++;
           }
               Console.WriteLine("===========================================================");
               Console.WriteLine("Acabamos de fechar.(Horário de funcionamento das 7h ás 17h)");
        }
    }
}
