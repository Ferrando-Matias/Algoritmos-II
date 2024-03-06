using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enunciado: 14)	Dados 3 números, mostrarlos por pantalla en orden decreciente
            int num1 = 50;
            int num2 = 10;
            int num3 = 70;
            int mayor = 0, menor = 0, medio = 0;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    mayor = num1;
                    if(num2 > num3)
                    {
                        medio = num2;
                        menor = num3;
                    }
                    else
                    {
                        medio = num3;
                        menor = num2;
                    }
                }
                else
                {
                    mayor = num3;
                    medio = num1;
                    menor = num2;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    mayor = num2;
                    if(num1 > num3)
                    {
                        medio = num1;
                        menor = num3;
                    }
                    else
                    {
                        medio = num3;
                        menor = num1;
                    }
                }
                else
                {
                    mayor = num3;
                    medio = num2;
                    menor = num1;
                }
            }
            Console.WriteLine("Mayor: {0} \nMedio: {1}\nMenor:{2}",mayor,medio,menor);
            Console.ReadKey();
        }
    }
}
