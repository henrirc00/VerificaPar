using System;

namespace VerificarPar
{
    class Program
    {
        static void Main(string[] args)
        {
          //Declaração da variavel numero do tipo Inteiro(int) 
          int numero;

          Console.WriteLine("Digite um número");
          numero = int.Parse(Console.ReadLine());

          if(numero % 2 == 0)
            Console.WriteLine("O número digitado é PAR");
            

          
        }
    }
}
