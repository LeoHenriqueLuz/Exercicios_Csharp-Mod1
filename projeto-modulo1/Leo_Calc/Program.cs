using System;

namespace Leo_Calc
{
    class Program
    {
         enum Menu {Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair };
        static void Main(string[] args)
        {
          // lógica para programa continuar rodando e apenas sair caso a opção Sair for selecionado.
           bool opcaoSair = false;

           while( !opcaoSair){  // enquanto usuario não(!)= "true",  selecionar "opção sair" que no momento é true, exiba o menu.
               // exiba o menu
                Console.WriteLine(    "Seja bem vindo ao LeoCalc!"    );
          Console.WriteLine("==================================");
          Console.WriteLine("Digite a opção que deseja efetuar:");
          Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

          Menu Opcao = (Menu)int.Parse(Console.ReadLine());

           switch(Opcao){
              case Menu.Soma:
              Soma();
              break;
              case Menu.Subtracao:
              Sub();
              break;
              case Menu.Divisao:
              Div();
              break;
              case Menu.Multiplicacao:
              Mult();
              break;
              case Menu.Potencia:
              Pow();
              break;
              case Menu.Raiz:
              Raiz();
              break;
              case Menu.Sair:
              opcaoSair = true; // ira se tornar "false", pois irá bater no while, e a condição será invertida parando o programa.
              break;
             
           }
           
           Console.Clear();
           
           }
        }
           
         static void Soma(){
             Console.WriteLine("soma entre 2 valores:");
             Console.WriteLine("digite o 1º valor:");
             int n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("digite o 2º valor:");
             int n2 = int.Parse(Console.ReadLine());
             int resultado = n1 + n2;
             Console.WriteLine($"Resultado: {resultado}");
             Console.WriteLine(" Aperte Enter para retornar ao Menu");
             Console.ReadLine();
         }

         static void Sub(){
             Console.WriteLine("Subtração entre 2 valores:");
             Console.WriteLine("digite o 1º valor:");
             int n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("digite o 2º valor:");
             int n2 = int.Parse(Console.ReadLine());
             int resultado = n1 - n2;
             Console.WriteLine($"Resultado: {resultado}");
             Console.WriteLine(" Aperte Enter para retornar ao Menu");
             Console.ReadLine();
         }

         static void Div(){
             Console.WriteLine("Divisão entre 2 valores:");
             Console.WriteLine("digite o 1º valor:");
             int n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("digite o 2º valor:");
             int n2 = int.Parse(Console.ReadLine());
             float resultado = (float)n1 / (float)n2; // como na divisão, o retorno pode ter ponto flutuante, devemos fazer o cast
             Console.WriteLine($"Resultado: {resultado}"); // de conversão para float, assim o C# não descarta o ponto flutuante.
             Console.WriteLine(" Aperte Enter para retornar ao Menu");
             Console.ReadLine();
         }

         static void Mult(){
             Console.WriteLine("Multiplicação entre 2 valores:");
             Console.WriteLine("digite o 1º valor:");
             int n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("digite o 2º valor:");
             int n2 = int.Parse(Console.ReadLine());
             int resultado = n1 * n2;
             Console.WriteLine($"Resultado: {resultado}");
             Console.WriteLine(" Aperte Enter para retornar ao Menu");
             Console.ReadLine();
         }

          static void Pow(){
             Console.WriteLine("Potência de um valor:");
             Console.WriteLine("digite o valor base:");
             int baseNum = int.Parse(Console.ReadLine());
             Console.WriteLine("digite o valor expoente:");
             int expo = int.Parse(Console.ReadLine());
             int resultado = (int)Math.Pow(baseNum, expo);
             Console.WriteLine($"Resultado: {resultado}");
             Console.WriteLine(" Aperte Enter para retornar ao Menu");
             Console.ReadLine();
         }

          static void Raiz(){
             Console.WriteLine("Raiz de um valor:");
             Console.WriteLine("digite o valor:");
             int num  = int.Parse(Console.ReadLine());
             double resultado = Math.Sqrt(num);
             Console.WriteLine($"Resultado: {resultado}");
             Console.WriteLine(" Aperte Enter para retornar ao Menu");
             Console.ReadLine();
         }

    }
}
