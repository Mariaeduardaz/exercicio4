using System;

namespace exercicio4.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero qualquer e vamos te dizer se é par ou impar");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Seu numero é par");

            }
            else
            {
                Console.WriteLine("Seu numero é impar");
            }
            Console.ReadLine();   
            
            
           


        }
    }
}
