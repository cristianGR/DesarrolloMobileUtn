using System;


using System;

namespace ConsoleAppAndIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            String mensajeAlOperador = "Escriba un numero: ";

            try
            {
                Console.WriteLine(mensajeAlOperador);
                numeroIngresado = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                mensajeAlOperador = "Ingrese un número entero por favor. Se tomará por defecto el 0";
                Console.WriteLine(mensajeAlOperador);
            }
            finally
            {
                mensajeAlOperador = EvaluarEntreNrosAnd(0,100, numeroIngresado)?$"El valor {numeroIngresado} es válido":
                    $"El valor {numeroIngresado} no es válido";
                Console.WriteLine(mensajeAlOperador);
           
            }

        }

        private static bool EvaluarEntreNrosAnd(int valorCotaMenor, int valorCotaMayor, int valorIngresado)
        {
            return (valorIngresado > valorCotaMenor && valorIngresado < valorCotaMayor) ? true : false;
        }

        private static bool EvaluarEntreNrosIf(int valorCotaMenor, int valorCotaMayor, int valorIngresado)
        {
            if (valorIngresado > valorCotaMenor)
                return (valorIngresado < valorCotaMayor) ? true : false;
            return false;
        }
    }
}
