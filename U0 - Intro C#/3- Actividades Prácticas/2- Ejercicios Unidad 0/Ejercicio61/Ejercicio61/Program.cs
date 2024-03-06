using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 61)	Crear un método que devuelva la suma de un array. 
             */
            int[] numeros = { 5, 10, 3, 8, 2 };

            double suma = CalcularSuma(numeros);

            Console.WriteLine($"La media del array es: {suma}");

            Console.ReadKey();

        }
        static double CalcularSuma(int[] array)
        {
            int suma = 0;

            foreach (int numero in array)
            {
                suma += numero;
            }
                        
            return suma;
        }
    }
}
