using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 1, 3, 8, 2 };

            int posicionMenor = ObtenerPosicionMenor(numeros);

            Console.WriteLine($"El número mayor se encuentra en la posición: {posicionMenor}");

            Console.ReadKey();
        }
        static int ObtenerPosicionMenor(int[] array)
        {
            int posicionMenor = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[posicionMenor])
                {
                    posicionMenor = i;
                }
            }

            return posicionMenor;
        }
    }
}
