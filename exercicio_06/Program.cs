/*Paulo é pizzaiolo e precisa descobrir a área de uma circuferência
para conseguir fazer a pizza perfeita e ganhar o campeonato de melhor pizzaiolo de sua região.
Ajude ele criando um programa usando uma função que faça o calculo
da área deste circulo, recebendo o raio com valor de 30 definido por Paulo.*/
using System;

namespace exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
         float Resultado = calculoArea(30);
           Console.WriteLine($"A circuferência da pizza deve ter aproximadamente, {Resultado} cm. "); 
        }
        static float calculoArea( int raio)
        {
         float Pi = 3.14f;
         float area = Pi * (raio * raio);
          return area;
        }


    }
}
