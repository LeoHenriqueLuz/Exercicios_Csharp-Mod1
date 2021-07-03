using System;

namespace Exercicios_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

              //continue a solucao
             if ( a >= (b + c) )
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if ( a*a == (b*b) + (c*c) )
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a*a > (b*b)+(c*c))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a*a < (b*b)+(c*c) )
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if ( a == b && a == c )
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
    }
}
