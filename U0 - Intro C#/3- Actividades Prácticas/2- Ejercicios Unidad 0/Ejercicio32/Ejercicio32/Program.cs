﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 32)	Crea un array de 10 posiciones, con valores puestos por ti y muestra el array. 
             */

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
