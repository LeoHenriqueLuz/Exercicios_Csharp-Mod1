/* Alguns engenheiros precisam construir uma praça em um terreno que tem
formato Triangular, porém precisam saber qual a área total exata deste terreno.
Ajude eles crie uma função que calcule a área de um  triãngulo, recebendo
uma base com valor de 250 e altura de 350*/

using System;

namespace exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
          float areaTotal = baseTriangulo(250, 350);
          Console.WriteLine($"A área do terreno é de {areaTotal} m2. ");
        }

        static int baseTriangulo( int Base, int Altura)
        {
          int area = (Base * Altura) / 2;
          return area;
        }
    }
}
