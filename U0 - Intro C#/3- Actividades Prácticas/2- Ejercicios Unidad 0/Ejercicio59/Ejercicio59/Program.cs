using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 59)	Crear un método que sume dos números pasados por parámetros, devolverá el resultado
             */
            double num1 = 5;
            double num2 = 5;
            Console.WriteLine($"El total de la suma es de {Suma(num1,num2)}");
            Console.ReadKey();
        }

        static double Suma (double x, double y)
        {
            return x + y;
        }
    }
}
