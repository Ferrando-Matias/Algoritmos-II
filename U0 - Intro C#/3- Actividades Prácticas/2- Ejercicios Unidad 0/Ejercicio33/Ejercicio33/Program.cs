using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 33)	Crea un array de 10 posiciones, pide los valores por consola y muestra el array. 
             */

            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
