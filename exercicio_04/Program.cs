using System;


namespace exercicios_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // captura de dados do usuário
            // uso de Condicionais
            // uso de operadores lógicos ( && ou And)
           
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
             
            Console.WriteLine("Digite o sua idade:");
             int idade = int.Parse(Console.ReadLine());
             
             if(idade > 0 && idade <= 11)
             {
                 Console.WriteLine($"Ola {nome}, você tem a idade de uma criança.");
             } 
             else if(idade >=12 && idade < 18)
             {
                 Console.WriteLine($"Ola {nome}, você tem a idade de um(a) adolecente."); 
             } 
             else if(idade >= 18 && idade <= 59)
             {
                 Console.WriteLine($"Ola {nome}, você tem a idade de uma pessoa adulta.");
             } 
             else 
             {
                 Console.WriteLine($"Ola {nome}, você tem a idade de uma pessoa idosa.");
             }
                 Console.ReadLine(); 
        }
    }
}
