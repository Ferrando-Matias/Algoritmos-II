﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ENUNCIADO:
             * 4)	Pedir al usuario dos números e informar la suma de los mismos 
             */

            Console.WriteLine("ingrese un numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = numero1 + numero2;
            Console.WriteLine("La suma de ambos numeros es de: " + resultado);
            Console.ReadKey();
        }
    }
}
