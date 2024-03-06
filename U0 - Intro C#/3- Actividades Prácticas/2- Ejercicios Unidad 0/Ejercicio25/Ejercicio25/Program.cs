using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enunciado: Realizar un temporizador
            Console.WriteLine("Ingrese las horas");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos");
            int minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los segundos");
            int segundos = Convert.ToInt32(Console.ReadLine());

            for (int i = horas; i >= 0; i--)
            {
                for (int j = minutos; j >= 0; j--)
                {
                    for(int k = segundos; k >= 0; k--)
                    {
                        Console.WriteLine("{0}:{1}:{2}",i,j,k);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    segundos = 59;
                }
                minutos = 59;
            }
            Console.ReadKey();
        }
    }
}
