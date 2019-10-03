using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            String mensajeAlOperador = "";
            do
            {
                try
                {
                    mensajeAlOperador = "Escriba un numero";
                    Console.Clear();
                    Console.WriteLine(mensajeAlOperador);
                    numeroIngresado = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    mensajeAlOperador = "Ingrese un número entero por favor. Se tomará por defecto el 0";
                    numeroIngresado = 0;
                    Console.WriteLine(mensajeAlOperador);
                }
                finally
                {
                    mensajeAlOperador = Evaluar(45, 500, 84, numeroIngresado) ? $"El valor {numeroIngresado} es válido" :
                        $"El valor {numeroIngresado} no es válido";
                    Console.WriteLine(mensajeAlOperador);
                }

                Console.ReadLine();

            } while (numeroIngresado > 0 || numeroIngresado < 0);
        }

        private static bool Evaluar(int valorCotaMenor, int valorCotaMayor, int valorNoPosible, int valorIngresado)
        {
            return (valorIngresado > valorCotaMenor && valorIngresado < valorCotaMayor && valorIngresado!=valorNoPosible) ? true : false;
        }
    }
}
