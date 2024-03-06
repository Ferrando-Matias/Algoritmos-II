using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado:
            /* 23)	Solicitar al usuario que ingrese un número entero positivo y mostrar la suma de los números del 1 al número ingresado
            */

            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            int suma=0;
            for (int i = 1;  i <= num; i++)
            {
                suma += i;
            }
            Console.WriteLine($"La suma del 1 al numero {num} es de: {suma}");
            Console.ReadKey();
        }
    }
}
