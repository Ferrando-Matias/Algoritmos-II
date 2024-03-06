using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Las listas en C# son objeto tipados. Es decir, cuando creamos una lista
             * le debemos indicar qué tipo de objetos va contener
             * (al igual que las variables:strings, int, double, etc o tipo T)
             * Cuando hablamos de tipo «T», nos referimos a cualquier tipo de objetos 
             * que hayamos definido en nuestro código, como por ejemplo puedo crear una lista de 
             * objetos de una clase
             */

            List<string> Nombres; //creo una lista de tipo string
            Nombres = new List<string>(); // instancio la lista creada anteriormente

            List<int> Edades = new List<int>(); //creo e instancio la lista en un solo paso
            

            //DIVERSAS MANERAS DE AGREGAR DATOS A LA LISTA
            Nombres.Add("Juan");
            Nombres.Add("Pedro");
            Nombres.Add("Mariela");
            Nombres.Add("Jose");
            Nombres.Add("Juana");

            Edades.Add(5);
            Edades.Add(6);
            Edades.Add(20);

            /* Inserto un nombre en una posición determina
             * para ello debo indicar el indice de la lista
             * donde necesito intercalarlo
             */
            Nombres.Insert(0, "Veronica");

            //ELIMINAR ELEMENTOS DE LA LISTA
            Nombres.Remove("Pedro"); //puedo remover por el dato que contiene la lista
            Nombres.RemoveAt(0);    //o puedo remover por el indice
            // Si indico eliminar un valor que no existe C# no indicara ningun error
            Nombres.Remove("PEPE");
            // Si indico eliminar un indice que no existe C# SI indicara un error
            //Nombres.RemoveAt(30);

            /*  RemoveAll() es el más complejo de los métodos remove,
             *  pero definitivamente también el más poderoso.
             *  Toma un delegado a un método como parámetro y este método decide
             *  si un elemento debe eliminarse o no devolviendo verdadero o falso.
             *  Esto le permite aplicar su propia lógica al eliminar elementos 
             *  y también le permite eliminar más de un elemento a la vez. 
             *  Los delegados no serán tratados en este momento, 
             *  debido a que es un tema complejo en esta instancia de la cursada, 
             *  pero es importante que entiendan lo conveniente que es el método
             *  RemoveAll, así que aquí hay un ejemplo:
             */

            List<string> ListadDeNombres = new List<string>()
            {
                "Jorge",
                "Juan",
                "Javier",
                "Marcelo"
            };

            ListadDeNombres.RemoveAll(name =>
            {
                if (name.StartsWith("J"))
                    return true;
                else
                    return false;
            });
            //El ejemplo anterior borra todos los nombres que comienzan con la letra  J


            //ORDENAR LOS ELEMENTOS DE UNA LISTA
            Nombres.Sort(); //ordeno de menor a mayor, o de A a Z
            Nombres.Reverse();//invierte el orden de la lista
            
            //CONTAR LOS ELEMENTOS DE UNA LISTA
            int cantElementos = Nombres.Count();

            //SUMAR LOS ELEMENTOS DE UNA LISTA
            int sumaElementos = Edades.Sum();

            //PROMEDIAR LOS ELEMENTOS DE UNA LISTA
            double promedioElementos = Edades.Average();

            //MINIMO LOS ELEMENTOS DE UNA LISTA
            double minElementos = Edades.Min();

            //MAXIMO LOS ELEMENTOS DE UNA LISTA
            double maxElementos = Edades.Max();

            //OBTENER EL PRIMER Y EL ULTIMO ELEMENTO DE UNA LISTA
            string primero = Nombres.First();
            string ultimo = Nombres.Last();

            //VACIAR TODA LA LISTA (ELIMINA TODOS LOS ELEMENTOS)
            Edades.Clear();

            //RECORRER UNA LISTA

            //Con ciclo for
            Console.WriteLine("Lista recorrida con ciclo for");
            Console.WriteLine("_____________________________");
            int i;
            for (i=0; i < Nombres.Count; i++)
            {
                Console.WriteLine("Elemento {0} = {1}", i, Nombres[i]);
            }

            Console.WriteLine("");
            i = 0;
            //Con ciclo Foreach
            Console.WriteLine("Lista recorrida con ciclo Foreach");
            Console.WriteLine("_________________________________");

            foreach (var v in Nombres)
            {
                Console.WriteLine("Elemento {0} = {1}", i, v);
                i++;
            }

            i = 0;
            Console.WriteLine("");

            //Con expresion Lambda
            Console.WriteLine("Lista recorrida con expresion Lambda");
            Console.WriteLine("____________________________________");

            Nombres.ForEach((v) => Console.WriteLine("Elemento = {0}", v));

            Console.WriteLine("");

            //LISTAS TIPO <<t>> (OBJETOS Y\O CLASES)
            Console.WriteLine("Lista TIPO t (OBJETOS)");
            Console.WriteLine("____________________________________");

            List<Usuarios> ListaDeUsuarios = new List<Usuarios>()
            {
                new Usuarios() { Nombre = "Juan Perez", Edad = 6 },
                new Usuarios() { Nombre = "Marcela Santos", Edad = 34 },
                new Usuarios() { Nombre = "Jose Bermudez", Edad = 8 },
            };

            List<Usuarios> ListaDeUsuariosOrdenada = ListaDeUsuarios.OrderBy(x => x.Edad).ToList();
            IEnumerable<Usuarios> ListaDeUsuariosOrdenada2 = ListaDeUsuarios.Where(x => x.Nombre == "Juan Perez");
            for (i = 0; i < ListaDeUsuariosOrdenada.Count; i++)
            {
                Console.WriteLine(ListaDeUsuariosOrdenada[i].Nombre + " tiene " + ListaDeUsuariosOrdenada[i].Edad + " años");
            }
            Console.ReadKey();
        }
    }

    class Usuarios
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }
    }
}
    
