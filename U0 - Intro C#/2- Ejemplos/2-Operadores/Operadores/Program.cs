using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores Aritmeticos

            // esto es una suma da como resultado 13
            int suma = 5 + 8; // se realiza la suma y se almacena en la variable
            double division = 8 / 9;
            long multiplicacion = 45 * 45; // long es tipo entero(int) pero soporta cantidades más grandes
            int resta = 5 - 1;

            int resultado;

            int numero1 = 7;
            int numero2 = 5;

            resultado = numero1 % numero2; // el resultado será 2, 
                                           //porque 7 entre 5 es igual a 1, y sobran 2

            numero1 = 17;
            numero2 = 3;

            resultado = numero1 % numero2; // el resultado será 2, 
                                           //porque 17 entre 3 es igual a 5, y sobran 2

            //Operadores de Asignacion
            int numero;
            string nombre;

            numero = 45;
            // se le asigna el valor 45(derecha) a la variable numero(izquierda)
            nombre = "Jorge";
            // se le asigna jorge a la variable nombre
            numero = numero + 13;
            // se le suma 13 al valor contenido en numero (45)
            //y luego se le asigna el resultado a numero

            //Sobrecargas del operador de asignacion
            numero1 = 4;
            numero2 = 5;
            numero1++; // esto incrementa el valor de numero1 en una unidad
            numero2--; // esto decrementa el valor de numero2 en una unidad
            numero1 += 5; // esto equivale a numero1 = numero1 + 5
            numero1 -= numero2; // esto equivale a numero1 = numero1 - numero2
            numero1 *= 2; //esto equivale a numero1 = numero1 - numero2
            numero2 /= numero1; //esto equivale a numero1 = numero1  / numero2
            numero1 %= 2; //esto equivale a numero1 = numero1 % numero2

            // Operadores Relacionales
            bool resultadoB;

            resultadoB = 5 > 1; // esto da como resultado verdadero (true)
            resultadoB = 5 <= 5; // esto da como resultado verdadero(true)
                                //debido a que aunque 5 no es menor que 5, si es igual a 5

            string valor1 = "juan";
            string valor2 = "pepe";

            resultadoB = valor1 != valor2; // esto es verdadero, porque juan es diferente a pepe
            resultadoB = "pepe" == valor2; // esto es como resultado verdadero, ambos valores son iguales

            resultadoB = valor1 == "Juan"; // esto es falso (false), debido a que juan y Juan
                                           //son valores diferentes, C# distingue entre minusculas y mayusculas


            // Operadores Logicos
            int n1 = 78;
            int n2 = 90;
            int n3 = 9;

            resultadoB = n1 < n2 && n2 > n3;
            //en este caso el resultado es verdadero
            //debido a que n1 < n2 es verdadero
            //y n2> n3 tambien es verdadero
            //aplicamos el operador &&  ( leer operador &&)

            resultadoB = n1 != 70 || n3 > 10;
            //en este caso el resultado es verdadero
            //debido a que n1 != 70 es verdadero
            //n3 > 10 es falso, pero el operador OR solo necesita uno verdadero
            //aplicamos el operador || 

            resultadoB = true;
            resultadoB = !resultadoB;
            //en este caso el resultado es falso
            //debido a que la variable “resultado” contiene el valor true(verdadero)
            //pero aplicando el operador de negación NOT(!), hemos invertido el valor

            //en este caso usamos el if para aprovechar los operadores
            if (n1 > 10)
            {
                Console.WriteLine("Es Mayor"); //por consola
            }

        }
    }
}
