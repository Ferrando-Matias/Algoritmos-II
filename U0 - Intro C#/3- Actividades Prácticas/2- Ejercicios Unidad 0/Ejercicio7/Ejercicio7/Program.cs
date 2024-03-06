using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 7)	Pedir dos números al usuario por teclado y decir que número es el mayor
             * */

            Console.WriteLine("Ingrese un numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 < numero2)
            {
                Console.WriteLine("El segundo es mayor");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("El primero es mayor");
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }
            Console.ReadKey();
        }
    }
}
