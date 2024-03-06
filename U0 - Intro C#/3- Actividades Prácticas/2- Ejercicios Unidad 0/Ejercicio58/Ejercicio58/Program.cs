using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 58)	Crear una sobrecarga de métodos que nos salude 
             * utilizando solo nuestro nombre, o nombre y apellido 
             */
            Saludo("Matias");
            Saludo("Matias", "Ferrando");
            Console.ReadKey();
        }

        static void Saludo (string nombre)
        {
            Console.WriteLine($"Buenos dias {nombre}");
        }

        static void Saludo (string nombre, string apellido)
        {
            Console.WriteLine($"Buenos dias {nombre} {apellido}");
        }
    }
}
