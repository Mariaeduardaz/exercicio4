using System;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[2];
            Console.WriteLine("Nos indique seu peso?");
            numeros[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Nos indique qual a sua altura?");
            numeros[1] = double.Parse(Console.ReadLine());
            double num1 = numeros[1] * numeros[1];

            double resultado = numeros[0] / num1;
            
            if (resultado < 18.5
                )
             Console.WriteLine("Voce esta muito abaixo do seu peso ideal, vamos se cuidar!");
            
            else if (25 >= resultado && resultado >= 18.5
                )
               Console.WriteLine("Voce esta entre seu peso normal, continue assim :)");
            
            else if (resultado > 25 && resultado <= 30
                )
                Console.WriteLine("Voce esta acima do peso");
            
            else if (resultado > 30
                )
                Console.WriteLine("OBESIDADEE");
            
             Console.ReadLine();




        }  
    }
}
