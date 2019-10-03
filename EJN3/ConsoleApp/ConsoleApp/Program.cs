using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            char[] operadores = new char[100];
            int seleccion = 0; 
            String mensajeAlOperador = "";

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();
                mensajeAlOperador = "Este es un programa que sirve como:\n" +
                    "CALCULADORA(0) -soportando : SUMA (+), RESTA (-) , MULTIPLICACIÓN (*) , DIVISIÓN (/)\n" +
                    "SUPERFICIE (1)\n" +
                    "PERIMETRO (2)\n"+
                    "ESC(salir)\n";
                Console.WriteLine(mensajeAlOperador);
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 0:
                        CalcularExpresion();
                        break;
                    case 1:
                        CalcularSuperficie();
                        break;
                    case 2:
                        CalcularPerimetro();
                        break;
                    default:
                        mensajeAlOperador = "Escriba opción válida";
                        Console.WriteLine(mensajeAlOperador);
                        break;
                }

                mensajeAlOperador = "Desea salir? [ESC]";
                Console.WriteLine(mensajeAlOperador);
                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);
        }

        private static void CalcularPerimetro()
        {
            Console.WriteLine("Perimetro");
        }

        private static void CalcularSuperficie()
        {
            Console.WriteLine("Superficie");
        }

        private static void CalcularExpresion()
        {
            Console.WriteLine("Calculadora");
        }
    }
}
