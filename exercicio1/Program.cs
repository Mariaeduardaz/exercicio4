using System;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça as somas!");
            Console.WriteLine("Digite seu primeiro numero correspondente a 'A'");
            double numeroA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu segundo numero correspondente a 'b'");
            double numerob = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu terceiro numero correspondente a 'c'");
            double numeroc = double.Parse(Console.ReadLine());
            Console.WriteLine("resultado da operação");
            if (numeroA + numerob > numeroc
                )
                Console.WriteLine("A soma do numero 'A' e 'B' sao maiores que 'C'");
                    else Console.WriteLine("A soma do numero 'A' e 'B' não sao maiores que 'C'");
            Console.ReadLine(); 
        }
    }
}
