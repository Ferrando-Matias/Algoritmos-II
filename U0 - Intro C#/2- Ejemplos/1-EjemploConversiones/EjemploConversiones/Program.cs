using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConversiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 56; // variable tipo entero
            double flotanteLargo = 56.77878m; // variable tipo flotante largo
            decimal flotanteLargoDecimal = 56.7787865874d; // variable tipo flotante largo
            float flota = 2.9f; // variable tipo flotante corto           
            char caracter = '9'; // Variable tipo carácter
            string cadena = "56"; // Variable tipo cadena
            object objeto = 45.25;

            // Conversiones Implicitas
            double n_numero; //se declara una variable de tipo double
            n_numero = numero;
            //se le asigna el valor de numero a n_numero, realizamos la conversion de int a double 
            //numero tiene como valor 90
            //n_numero tiene como valor 90.0

            float flotante = (float)objeto;
            int n_entero = (int)objeto;
            char n_char = (char)objeto;
            string n_object = (string)objeto;
            double n_doble = (double)objeto;

            // Conversiones Explicitas
            // Clase Convert
            int n_cadena;
            n_cadena = Convert.ToInt32(cadena);
            double n_caracter;
            n_caracter = Convert.ToDouble(caracter);
            double n_objeto;
            n_objeto = Convert.ToDouble(objeto);


            // Metodo Parse
            cadena = "5";
            float flotanteP = float.Parse(cadena);
            int n_enteroP = int.Parse(cadena);
            char n_charP = char.Parse(cadena);
            double n_dobleP = double.Parse(cadena);

            // Convertir a String
            flotante = 45.9f;
            string n_string = flota.ToString();

            // Metodo TryParse
            string numeroTexto = "123";
            int num;

            if (int.TryParse(numeroTexto, out num))
            {
                Console.WriteLine("La conversión fue exitosa. El número es: " + num);
            }
            else
            {
                Console.WriteLine("La conversión falló. La cadena de texto no es un número válido.");
            }
            Console.ReadKey();


        }
    }
}
