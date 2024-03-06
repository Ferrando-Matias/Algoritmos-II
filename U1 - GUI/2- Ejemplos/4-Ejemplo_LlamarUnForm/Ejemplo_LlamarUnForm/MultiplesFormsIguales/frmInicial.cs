using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplesFormsIguales
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void btnLocalidades_Click(object sender, EventArgs e)
        {
            frmGenerico fAux = new frmGenerico("Localidades", "Localidad"); // Envio parametros que van a ser tomados al momento de iniciar el formulario
            fAux.ShowDialog(); // Abre como un form dentro de este, no se puede acceder a otro form hasta no cerrar el mismo
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            frmGenerico fAux = new frmGenerico("Partidos", "Partido"); //Envio parametros que van a ser tomados al momento de iniciar el formulario
            fAux.ShowDialog(); // Abre como un form dentro de este, no se puede acceder a otro form hasta no cerrar el mismo
        }

        private void btnProvincias_Click(object sender, EventArgs e)
        {
            frmGenerico fAux = new frmGenerico("Provincias", "Provincia"); //Envio parametros que van a ser tomados al momento de iniciar el formulario
            fAux.ShowDialog(); // Abre como un form dentro de este, no se puede acceder a otro form hasta no cerrar el mismo
        }

        private void btnVacio_Click(object sender, EventArgs e)
        {
            frmGenerico fAux = new frmGenerico(); // No envio ningun parametro, por lo que se ejecuta el formulario sin datos previos
            fAux.Show(); // Abre como un formulario independiente
        }
    }
}
