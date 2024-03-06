using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool encendido = true;
            int i;
            int x = 0;
            // While
            // Mientras se cumpla la condición que encendido valga true
            while (encendido)
            {
                for (i = 1; i <= 5; i++)
                {
                    Console.WriteLine("el valor de la variable es {0}", encendido);
                }
                Console.WriteLine();
                i++;
                if (x == 2) //condición de salida si se cumple determinada acción
                {
                    encendido = false;
                    Console.WriteLine("el valor de la variable es {0}", encendido);
                }
                Console.WriteLine("el valor de la variable x es {0}", x);
                x++;
            }

            //Do While
            do
            {
                for (i = 1; i <= 5; i++)
                {
                    Console.WriteLine("el valor de la variable  es {0}", encendido);
                }
                Console.WriteLine();
                i++;
                if (x == 2) //condicion de salida si se cumple determinada accion
                {
                    encendido = false;
                    Console.WriteLine("el valor de la variable es {0}", encendido);
                }
                Console.WriteLine("el valor de la variable x es {0}", x);
                x++;
            } while (encendido == true);

            Console.ReadKey();

        }
    }
}
