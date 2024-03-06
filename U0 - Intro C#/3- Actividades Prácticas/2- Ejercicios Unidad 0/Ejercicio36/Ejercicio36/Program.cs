using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 36)	Pedir un numero por teclado, multiplicar todos 
             * los valores de un array y los resultados de cada multiplicacion. 
             */

            int[] numeros = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            foreach (var num in numeros)
            {
                int multiplicacion = num * numero;
                Console.WriteLine($"La multiplicacion de {numero} * {num} es: {multiplicacion}");
            }
            Console.ReadKey();
        }
    }
}
