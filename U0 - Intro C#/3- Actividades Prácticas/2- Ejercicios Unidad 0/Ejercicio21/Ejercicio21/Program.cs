using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 21)	Mostrar los números del 10 al 1 en orden descendente.
             */
            for (int i = 10; i > 0; i--) {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
