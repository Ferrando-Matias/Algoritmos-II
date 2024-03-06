using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Si observamos el código a continuación, veremos que el
             * for tiene 3 secciones encerradas entre paréntesis y separadas
             * por un (;), la 1ra sección indica en que valor comenzara 
             * el ciclo, la 2da indica hasta que valor se repetirá, y la 3ra
             * es el incremento.
             */

            int i = 0;

            Console.WriteLine("Ciclo For clasico");
            Console.WriteLine("1er ciclo for");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            /*
             *en esta línea, vemos en que valor quedara la variable
             * incremental, y podremos observar que siempre quedara 
             * en el valor final más 1.
             */
            Console.WriteLine("Valor en que queda la variable fuera del ciclo: {0}", i);
            Console.WriteLine("");

            /*
             * Tambien existe la posiblilidad en estos ciclos de obviar
             * la primera seccion, en el ej siguiente vemos que es lo que sucede
             * y al ejecutar el programa veremos que la variable incremental
             * comienza donde termino el ciclo anterior (para obvial la 1er seccion 
             * debemos mantener el (;) separador).
             */
            Console.WriteLine("2do ciclo for iniciando la variable en su valor previo (obviando el parámetro de inicio).");
            for (; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            /*
             * En el siguiente ciclo veremos que tambien existe la posiblilidad de obviar
             * la 3ra seccion, pero en esete caso, deberemos tener mucho cuidado
             * dado que SI DENTRO DEL CICLO NO INCREMENTAMOS LA VARIABLE, ESTE ENTRARIA
             * EN UN BUCLE INFINITO.
             */
            Console.WriteLine("3er ciclo For, colocando su incremento dentro de la estructura de instrucciones.");
            for (i = 0; i < 5;)
            {
                Console.WriteLine(i);
                i++; // Aqui incremento la variable.
            }
            Console.WriteLine("");

            /*
             * En el proximo ciclo veremos que podemos utilizar mas de una variable 
             * incremental o decremental
             */
            Console.WriteLine("Ciclo for con 2 variables incrementales y/o decrementales.");
            int m = 5;
            for (i = 0, m = 5; i < 5; i++, m--)
            {
                Console.WriteLine("Valor de i es: {0}, el valor de m es: {1}", i, m);
            }
            Console.WriteLine("");

            /*
             * Tambien podemos incrementar la variable de control
             * en 2, 3, o lo que necesitemos
             */
            Console.WriteLine("Ciclo for con incrementando la variable de control en 2.");
            for (i = 0; i < 5; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            // De la misma manera que en el ciclo anterior, podemos incrementarla exponencialmente.
            Console.WriteLine("Ciclo for incrementando la variable de control exponencialmente.");
            for (i = 2; i <= 10000; i *= i)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("");

            Console.WriteLine("Ciclo for utilizando la variable de control de tipo Char.");
            char letra;
            for (letra = 'a'; letra <= 'z'; letra++)
            {
                Console.WriteLine(letra);
            }


            Console.WriteLine("For Anidados");
            int x;
            int y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= 5; y++)
                {
                    Console.WriteLine("El valor de (x;y) es : {0};{1}", x, y);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Foreach");
            string apellido = "Ferrando";
            foreach (char letraA in apellido)
            {
                Console.WriteLine(letraA);
            }


            Console.ReadKey();

        }
    }
}
