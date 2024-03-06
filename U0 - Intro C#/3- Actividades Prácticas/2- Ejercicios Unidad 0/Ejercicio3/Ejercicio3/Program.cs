using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ENUNCIADO
             * 3)	Pedir por consola tu nombre y tu edad y mostrar el 
             * siguiente mensaje: “Te llamas <nombre> y tienes <años> años”
             */

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Te llamas {0} y tienes {1} años", nombre, edad);
            Console.ReadKey();
        }
    }
}
