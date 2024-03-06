using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 50, 10, 3, 80, 2 };

            int posicionMayor = ObtenerPosicionMayor(numeros);

            Console.WriteLine($"El número mayor se encuentra en la posición: {posicionMayor}");

            Console.ReadKey();
        }
        static int ObtenerPosicionMayor(int[] array)
        {
            int posicionMayor = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[posicionMayor])
                {
                    posicionMayor = i;
                }
            }

            return posicionMayor;
        }
    }
}
