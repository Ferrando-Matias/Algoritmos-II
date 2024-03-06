using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 12)	Realizar un programa que indique que tipo de triangulo es al ingresar los tres lados 
             */

            Console.WriteLine("Ingrese el primer lado");
            int lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado");
            int lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer lado");
            int lado3 = Convert.ToInt32(Console.ReadLine());

            if (lado1 == lado2 || lado1 == lado3)
            {
                if (lado2 == lado3)
                {
                    Console.WriteLine("El triangulo es equilatero");
                }
                else
                {
                    Console.WriteLine("El triangulo es isoceles");
                }
            }
            else
            {
                Console.WriteLine("El triangulo es escaleno");
            }
            Console.ReadKey();
        }
    }
}
