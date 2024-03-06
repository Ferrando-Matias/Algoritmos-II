using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 28)	Solicitar al usuario que ingrese una palabra y mostrar
             * cada letra de la palabra en una línea separada
             */

            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            foreach (char letra in palabra)
            {
                Console.WriteLine(letra);
            }

            Console.ReadKey();
        }
    }
}
