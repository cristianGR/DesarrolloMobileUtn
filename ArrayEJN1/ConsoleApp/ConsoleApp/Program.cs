using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nroAleatorio = new Random();
            int cuenta = 0;
            int nroGenerado = 0;
            int cantNrosGenerados = 10;
            int promedio = 0;

            Console.WriteLine("Se generarán 10 numeros aleatorios:\n");
            Console.Write("[");
            for (int i = 0; i < cantNrosGenerados; i++)
            {
                nroGenerado = nroAleatorio.Next(50);
                cuenta += nroGenerado;
                Console.Write($"{nroGenerado},");
            }
            Console.Write("\b]\n");

            promedio = cuenta / cantNrosGenerados;

            Console.WriteLine($"El promedio de los 10 numeros generados aleatoriamente es: {promedio}");
        }
    }
}
