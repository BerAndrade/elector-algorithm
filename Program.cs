using System;

namespace algoritmoeleitor
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            Console.WriteLine("***ALGORÍTMO DO ELEITOR***");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nPor favor, informe a sua idade: ");
                N = double.Parse(Console.ReadLine());
                if (N < 16)
                    Console.WriteLine("\nMenor de idade, não eleitor.");
                else
                    if ((N >= 18) && (N <= 65))
                    Console.WriteLine("\nMaior de 18 anos, eleitor obrigatório.");
                else
                    Console.WriteLine("Eleitor facultativo.");
            }           
        }
    }
}
