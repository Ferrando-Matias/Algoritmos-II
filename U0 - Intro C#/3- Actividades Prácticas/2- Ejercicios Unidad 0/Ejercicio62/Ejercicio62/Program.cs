﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
             * 62)	Crear un método que devuelva la media de un array. 
             */
            int[] numeros = { 5, 10, 3, 8, 2 };

            double media = CalcularMedia(numeros);

            Console.WriteLine($"La media del array es: {media}");

            Console.ReadKey();

        }
        static double CalcularMedia(int[] array)
        {
            int suma = 0;

            foreach (int numero in array)
            {
                suma += numero;
            }

            double media = (double)suma / array.Length;

            return media;
        }
    }
}
