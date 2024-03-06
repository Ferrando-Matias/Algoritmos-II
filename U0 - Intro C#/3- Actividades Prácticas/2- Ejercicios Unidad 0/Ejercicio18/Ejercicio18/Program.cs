using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado: 
             * 18)	Recorre los números del 1 al 100. Muestra los números pares
             */

            for (int i = 1; i <= 100; i++) { 
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
