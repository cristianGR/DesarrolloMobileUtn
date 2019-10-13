using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string rta;
            do
            {
                Calculadora calculadora = new Calculadora();
                Ingreso numero = new Ingreso();
                calculadora.IngresarNumero(numero.NuevoIngreso());
                Console.Write("Ingrese Operación (+,-,*,/) : ");
                string operacionIngresada = Console.ReadLine();
                switch (operacionIngresada)
                {
                    case "+":
                        calculadora.Mas();
                        break;
                    case "-":
                        calculadora.Menos();
                        break;
                    case "*":
                        calculadora.Multiplicacion();
                        break;
                    case "/":
                        calculadora.Division();
                        break;
                }
                calculadora.IngresarNumero(numero.NuevoIngreso());
                Console.WriteLine("resultado: " + calculadora.GetResultado());
                Console.WriteLine("Desea realizar otra operación? Ingresar (S/N)");
                rta = Console.ReadLine();
            } while (rta == "S");
        }
    }

    public class Ingreso
    {
        public float NuevoIngreso()
        {
            float x;
            string ingreso;
            do
            {
                Console.Write("Ingrese un número: ");
                ingreso = Console.ReadLine();
            } while (!float.TryParse(ingreso, out x));
            return x;
        }
    }
    public class Calculadora
    {
        float mantisa = 0;
        string operacion = "";

        public int factorial(int numero)
        {
            if (numero == 0)
                return 1;
            return numero * factorial(numero - 1);
        }
        public void IngresarNumero(float numero)
        {
            if (operacion == "")
                mantisa = numero;

            if (operacion == "+")
                mantisa += numero;

            if (operacion == "-")
                mantisa -= numero;

            if (operacion == "*")
                mantisa *= numero;

            if (operacion == "/" && numero!= 0)
            {
                mantisa /= numero;
            }
            else if (operacion == "/" && numero == 0)
            {
                Console.WriteLine("ingrese un nro distinto de cero como divisor");
            }
        }
        public void Mas()
        {
            operacion = "+";
        }
        public void Menos()
        {
            operacion = "-";
        }
        public void Multiplicacion()
        {
            operacion = "*";
        }
        public void Division()
        {
            operacion = "/";
        }

        public float GetResultado()
        {
            return mantisa;
        }
    }
}
