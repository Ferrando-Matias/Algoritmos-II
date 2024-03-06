using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 57)	Crear un método que nos salude, pasándole un nombre por parámetro
             */
            Saludo("Matias");
            Console.ReadKey();
        }

        static void Saludo(string nombre)
        {
            Console.WriteLine($"Buenos dias {nombre}");
        }
    }
}
