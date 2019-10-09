using System;
using System.Collections.Generic;

namespace ListManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var MathExpresion = new List<String> { "(", "(", "3", "+", "4", ")", "*", "6", ")" };
            var index = MathExpresion.IndexOf("(");
            int count = 0;

            foreach (var exp in MathExpresion)
            {
                if (exp.IndexOf("(") == 0)
                {
                    Console.WriteLine($"( se encuentra  en la posición {count}");
                }
                if (exp.IndexOf(")") == 0)
                {
                    Console.WriteLine($") se encuentra  en la posición {count}");
                }
                count++;
            }

            //Console.WriteLine("------" +MathExpresion.IndexOf("(")); si no se recorre con un foreach no muestra todoas las ocurrencias.
            //IndexOf si lo encuentra devuelve cero y sino -1.
        }
    }
}
