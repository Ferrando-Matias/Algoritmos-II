using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicional Simple (IF)
            double nota;
            Console.WriteLine("Ingrese Nota:");
            nota = Convert.ToDouble(Console.ReadLine());
            if (nota >= 7)
            {
                Console.WriteLine("APROBADO");
            }

            Console.WriteLine("Ingrese Nota:");
            nota = Convert.ToDouble(Console.ReadLine());
            if (nota >= 7)
            {
                Console.WriteLine("APROBADO");
            }
            else
            {
                Console.WriteLine("DESAPROBADO");
            }

            Console.WriteLine("Ingrese Nota:");
            nota = Convert.ToDouble(Console.ReadLine());
            if (nota >= 7)
            {
                Console.WriteLine("APROBADO");
            }
            else if (nota >= 4)
            {
                Console.WriteLine("DICIEMBRE");
            }
            else
            {
                Console.WriteLine("FEBRERO");
            }


            // Condicional Multiple (SWITCH)
            // aca pueden cambiar el valor de la/las variables
            // para ver los diferentes resultados posibles.
            bool Booleana = true;
            char Caracter = 'a';
            string cadena = "Mañana"; // Tarde // noche
            int Nro = 7;

            // Con variables booleanas (bool)
            switch (Booleana)
            {
                case true:
                    Console.WriteLine("La variable entro como Verdadero");
                    Console.ReadKey();
                    break;
                case false:
                    Console.WriteLine("La variable entro como Falso");
                    Console.ReadKey();
                    break;
            }

            //Con variable caracter (char)
            switch (Caracter)
            {
                // Agrupacion de casos
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("El caracter es vocal");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("El caracter es consonante");
                    Console.ReadKey();
                    break;
            }

            // Con variable de cadenas (string)
            switch (cadena)
            {
                case "Mañana":
                    Console.WriteLine("que tengas un buen dia");
                    Console.ReadKey();
                    break;
                case "Tarde":
                    Console.WriteLine("que tengas una buena tarde");
                    Console.ReadKey();
                    break;
                case "Noche":
                    Console.WriteLine("que tengas buenas noches");
                    Console.ReadKey();
                    break;
            }

            //Con variables numericas (int)
            switch (Nro)
            {
                case 3:
                    //..........
                    break;
                case 4:
                    //........
                    break;
                default:
                    //..........
                    break;
            }


            Console.ReadKey();

        }
    }
}
