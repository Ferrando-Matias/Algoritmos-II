﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 11)	Pedir al usuario un numero e informar si es positivo, negativo o cero 
             */
            Console.WriteLine("Ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es cero");
            }
            Console.ReadKey();
        }
    }
}
