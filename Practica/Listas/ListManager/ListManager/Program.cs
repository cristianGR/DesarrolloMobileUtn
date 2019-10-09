using System;
using System.Collections.Generic;

namespace ListManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var MathExpresion = new List<string>{ "(", "(", "3", "+", "4", ")", "*", "6", ")" };
            var QueueParentesisCierre = new Queue<string>();
            var StackParentesisApertura = new Stack<string>();
            string count = "0";
            int i = 0;

            foreach (var exp in MathExpresion)
            {
                if (exp.IndexOf("(") == 0)
                {
                    //Console.WriteLine($"( se encuentra  en la posición {count}");
                    StackParentesisApertura.Push(count);
                }
                if (exp.IndexOf(")") == 0)
                {
                    // Console.WriteLine($") se encuentra  en la posición {count}");
                    QueueParentesisCierre.Enqueue(count);
                }
                count = "" + i++;
            }


            Console.WriteLine($"1° intervalo de solución : [{StackParentesisApertura.Pop()}],[{QueueParentesisCierre.Dequeue()}]");
            Console.WriteLine($"2° intervalo de solución: [{StackParentesisApertura.Pop()}],[{QueueParentesisCierre.Dequeue()}]");

        }
    }
}