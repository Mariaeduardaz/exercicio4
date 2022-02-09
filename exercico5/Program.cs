using System;

namespace exercico5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero 1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero 2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero 3");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                int resultado2 = num1 + num2;
                Console.WriteLine($"Os numeros deram como iguais, entao fica como: {num1} + {num2} = {resultado2}");
            }
                

            else
            {
                int resultado3 = num1 * num2;
                Console.WriteLine($"Os numeros são diferentes, entao: {num1} * {num2} = {resultado3}");

            }
            Console.ReadLine();
           

        }
    }
}
