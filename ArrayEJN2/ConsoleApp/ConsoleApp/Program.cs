using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroPrueba = 0;
            Random nroAleatorio = new Random();
            nroPrueba = nroAleatorio.Next(10);
            Console.Write($"El numero a Factorizar fue: {nroPrueba} y el resultado fue: ");
            Console.WriteLine(Factorial(nroPrueba));
        }

        static int Factorial(int nro)
        {
            return (nro == 1)? 1:(nro * Factorial(nro - 1));
        }
    }
}
