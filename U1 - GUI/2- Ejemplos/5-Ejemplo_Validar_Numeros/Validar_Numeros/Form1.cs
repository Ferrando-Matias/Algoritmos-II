using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validar_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsNumeric(txtNroUno.Text))
            {
                MessageBox.Show("El dato ingresado es un número");
            }
            else
            {
                MessageBox.Show("El dato ingresado NO es un número");
            }
        }

        private void txtNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //La variable "e" es donde VS guarda la tecla presionada
            //al ser de TIPO KeyPressEventArgs el parametro que la reciba
            //en un metodo debera ser del mismo tipo para que tenga todas 
            //sus prioridades.
            ValidarNro(e);
        }


        #region Metodos

        //Metodo que devuelve verdadero / Falso si da error al convertir
        //funcion TryParse verifica que un dato sea ingresado correctamente
        public Boolean IsNumeric(string valor)
        {
            return int.TryParse(valor, out int result);
        }


        // El siguiente metodo es llamado desde el evento KeyPress de un TextBox
        // y en el caso que la tecla presionada sobre el mismo no sea un numero
        // ni una tecla de control (enter, delete, backspace, etc) simplemente
        // no la escribe

        public static bool ValidarNro(KeyPressEventArgs e)
        {
            //Verifico que tecla presiono el usuario, observar las diversas propiedades
            //tanto de la clase "Char" como de la variable "e"
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar) | char.ToString(e.KeyChar) == ",")
            {
                //la propiedad HandLed de la variable e es la que deja o no pasar
                //el caracter presionado, si su valor se encuentra en false lo deja
                //pasar, en cambio si se encuentra en true el caracter NO se imprimira
                //en el objeto
                e.Handled = false; 
            }
            else
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        #endregion
    }
}

