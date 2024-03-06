using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDataGridView
{
    // Clase que utilizaremos para crear una lista de productos
    internal class Productos
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public double Stock { get; set; }
    }
}
