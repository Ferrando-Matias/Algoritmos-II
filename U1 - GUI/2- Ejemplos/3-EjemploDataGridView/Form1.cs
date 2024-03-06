using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDataGridView
{
    public partial class Form1 : Form
    {
        /* Declaro la lista justo debajo de la
         * declaracion de la clase, para que su ambito sea a nivel formulario
         */
        List<Personas> lPersonas;


        public Form1()
        {
            InitializeComponent();
            /* Instancio la lista en el constructor para que se cree
             * al momento de inicializar componentes del formulario
             */
            lPersonas = new List<Personas>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargo dos datos en la lista, a modo prueba, para tener en la grilla
            lPersonas.Add (new Personas()
            {
                Identificador=1,
                Apellido="Perez",
                Nombres="Juan",
                DNI=12345678,
                Baja=false
            });
            lPersonas.Add(new Personas()
            {
                Identificador = 2,
                Apellido = "Gonzales",
                Nombres = "Maria",
                DNI = 87654321,
                Baja = true
            });
            
            // Doy formato a la grilla con las siguientes instrucciones

            // Comportamiento
            dgvPrueba.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer click en alguna celda
            dgvPrueba.MultiSelect = false; // Que no pueda seleccionar multiples filas
            dgvPrueba.ReadOnly = true; // Hace que la grilla no se pueda editar
            dgvPrueba.AllowUserToAddRows = false; // Desactiva  la ultima fila 
            dgvPrueba.RowHeadersVisible=false; // Oculto los encabezados de filas

            // Grafica
            dgvPrueba.EnableHeadersVisualStyles= false; // Para poder modificar estilos en la cabecera
            dgvPrueba.ColumnHeadersBorderStyle= DataGridViewHeaderBorderStyle.None; // Quito los bordes de la cabecera
            dgvPrueba.ColumnHeadersDefaultCellStyle.BackColor= Color.DarkBlue; // Color de fondo de la cabecera
            dgvPrueba.ColumnHeadersDefaultCellStyle.ForeColor= Color.White; // Color de texto de la cabecera
            dgvPrueba.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkBlue; // Color de fondo de la celda del encabezado seleccionada
            dgvPrueba.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;// Centro el texto de las cabeceras


            // Enlazo la lista a la grilla
            dgvPrueba.DataSource = null; // Primero debo romper un enlace anterior
            dgvPrueba.DataSource=lPersonas; // Enlazo la lista a la grilla
            // Oculto la columna correspondiente al Identificador o ID
            dgvPrueba.Columns["Identificador"].Visible = false;
            
            /* Cambio un encabezado de columna
             * NOTA: DEBE HACERSE LUEGO DE ENLAZAR LOS DATOS, CASO CONTRARIO DARA ERROR
             */
            dgvPrueba.Columns[4].HeaderText = "ESTADO DE LA PERSONA"; // Busco la columna por indice y le doy el nuevo texto

            // Alineo la columna 3 a la derecha
            dgvPrueba.Columns[3].DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleRight;


            // Agregar un boton a la grilla
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn(); // Creo el objeto 
            btn.HeaderText = "Editar"; // Texto que tendra la cabecera
            btn.Name = "boton"; // Nombre de la columna
            btn.Text = "Editar"; // Texto del boton
            btn.UseColumnTextForButtonValue = true;
            dgvPrueba.Columns.Add(btn); // Agrego el objeto a la grilla

        }

        private void dbvPrueba_RowEnter(object sender, DataGridViewCellEventArgs e)
        // Este evento pertenece al DataGridView, y ocurre cualdo toma el foco o cambia de fila
        {
            if (dgvPrueba.SelectedRows.Count > 0) // Esta pregunta debo hacerla para verificar que el haya seleccionado algo en el DataGrid
            {
                // Asigno los datos de la fila seleccionada a los controles del formulario
                lblId.Text = "Identificacion Persona Nº " + dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["Identificador"].Value.ToString();
                txtApellido.Text = dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["Apellido"].Value.ToString();
                txtNombres.Text = dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["Nombres"].Value.ToString();
                txtDNI.Text = dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["DNI"].Value.ToString();
                chkBaja.Checked = (bool)dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["baja"].Value;
            }
        }

        private void dgvPrueba_CellContentClick(object sender, DataGridViewCellEventArgs e)
            // Este evento ocurre cuando se hace click en una celda determinada de la grilla
        {
            /* El Objeto "e" que trae el evento, contiene en su propiedad ColumnIndex, que es el
             * indice de columna en la cual se clickeo.
             */
            if(dgvPrueba.Columns[e.ColumnIndex].Name == "boton") // Si se clickeo la columna llamada boton obtengo los datos de dicha columna
            {
                // Tomo, de la primer fila [0] de las seleccionadas, el valor de la celda "Apellido"/"Nombres" y lo convierto a String
                string Apellido = dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["Apellido"].Value.ToString(); 
                string Nombre = dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["Nombres"].Value.ToString();
                MessageBox.Show($"Diste click en la persona: {Nombre} {Apellido} " );
            }
        }

        private void btnCargar2Grilla_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = null; // Rompo un enlace previo
            dgv1.DataSource = lPersonas; // Establezco el enlace con la lista
        }


        private void chkPermitirEdicion_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPermitirEdicion.Checked)
            {
                dgvPrueba.SelectionMode = DataGridViewSelectionMode.CellSelect; //Selecciona solo la celda clickeada
                dgvPrueba.ReadOnly = false; // Hace que la grilla se pueda editar
                dgvPrueba.Select(); // Llevo el foco al DataGridView
            }
            else
            {
                dgvPrueba.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila
                dgvPrueba.ReadOnly = true; // Hace que la grilla no se pueda editar
                dgvPrueba.AllowUserToAddRows = false; // Desactiva  la ultima fila 
                dgvPrueba.RowHeadersVisible = false; // Oculto los encabezados de filas
                dgvPrueba.Select(); // Llevo el foco al DataGridView
            }
        }
    }

    public class Personas
    {
        public int Identificador { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public int DNI { get; set; }
        public bool Baja { get; set; }

    }

}
