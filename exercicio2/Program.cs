using System;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A");
            string strValorA = Console.ReadLine();
            int valorA = Convert.ToInt32(strValorA);

            Console.WriteLine("Digite o valor B");
            string strValorB = Console.ReadLine();
            int valorB = Convert.ToInt32(strValorB);

            Console.WriteLine("Digite o valor C");
            string strValorC = Console.ReadLine();
            int valorC = Convert.ToInt32(strValorC);

            if (valorA > valorB && valorB > valorC)
                Console.WriteLine("{0} {1} {2}" , valorA, valorB, valorC);

            else if (valorA > valorB && valorA > valorC && valorC > valorB) 
                Console.WriteLine("{0} {1} {2}", valorA, valorB, valorC);

            else if (valorB > valorA && valorA > valorC)
            Console.WriteLine("{0} {1} {2}", valorB, valorA, valorC);

            else if (valorB > valorA && valorB > valorC && valorC > valorA)
            Console.WriteLine("{0} {1} {2}", valorB, valorC, valorA);

            else if (valorC > valorB && valorB > valorA)
                Console.WriteLine("{0} {1} {2}", valorC, valorB, valorA);

            else if (valorC > valorB && valorA > valorB)
                Console.WriteLine("{0} {1} {2}", valorC, valorA, valorB);
            Console.ReadLine();

        }
    }
}
