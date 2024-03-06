using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosControles
{
    public partial class FrmControles : Form
    {

        public FrmControles()
        {
            InitializeComponent();
        }

        private void mensaje(string TipoControl, string Valor)
        {
            string mensaje = "Valor del " + TipoControl + ": " + Valor;
            string titulo = "Valor " + TipoControl;
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void FrmControles_Load(object sender, EventArgs e)
        {
            // Cargo items en el ListBox
            for (int i = 1; i < 6; i++)
            {
                lstEjemplo.Items.Add("Item " + i);
            }

            // Cargo items en el Combobox
            for (int i = 1; i < 6; i++)
            {
                cmbEjemplo.Items.Add("Item " + i);
            }

            // Cargo Checkbox en el ChechListBox
            for (int i = 1; i < 6; i++)
            {
                chlbEjemplo.Items.Add("Item " + i);
            }
        }

        private void btnVerTxt_Click(object sender, EventArgs e)
        {
            string valorTxt = txtEjemplo.Text;
            mensaje("TextBox", valorTxt);
        }

        private void btnVerNmr_Click(object sender, EventArgs e)
        {
            decimal valorNmr = nmrEjemplo.Value;
            mensaje("NumericUpDown", valorNmr.ToString());
        }

        private void btnVerMsk_Click(object sender, EventArgs e)
        {
            string valorMsk = mskEjemplo.Text;
            mensaje("MaskedTextBox", valorMsk);
        }

        private void btnVerChk_Click(object sender, EventArgs e)
        {
            string estadoChk = "Checkbox sin tildar";
            if (chkEjemplo.Checked)
            {
                estadoChk = "Checkbox Tildado";
            }
            mensaje("CheckBox", estadoChk);
        }

        private void btnVerRdb_Click(object sender, EventArgs e)
        {
            string estadoRdb = "";
            /*
             * Manera sencilla y larga de corroborar:
             
            if (rdbEjemplo1.Checked)
            {
                estadoRdb = "RadioButton Ejemplo 1 marcado";
            }
            else if (rdbEjemplo2.Checked)
            {
                estadoRdb = "RadioButton Ejemplo 2 marcado";
            }
            else if (rdbEjemplo3.Checked)
            {
                estadoRdb = "RadioButton Ejemplo 3 marcado";
            }
            else
            {
                estadoRdb = "Ningun RadioButton marcado";
            }
            */

            // Manera optima de corroborar
            foreach (var rdb in grpEjemplo.Controls)
            {
                if (((RadioButton)rdb).Checked)
                {
                    estadoRdb = ((RadioButton)rdb).Text + " marcado";
                }
            }
            mensaje("RadioButton", estadoRdb);
        }

        private void btnVerLst_Click(object sender, EventArgs e)
        {
            string itemSeleccionado;
            if (lstEjemplo.SelectedIndex != -1)
            {
                itemSeleccionado = lstEjemplo.SelectedItem.ToString();
                mensaje("ListBox", itemSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                lstEjemplo.Focus(); 
            }
        }

        private void btnVerCmb_Click(object sender, EventArgs e)
        {
            string itemSeleccionado;
            if (cmbEjemplo.SelectedIndex != -1)
            {
                itemSeleccionado = cmbEjemplo.SelectedItem.ToString();
                mensaje("ComboBox", itemSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                cmbEjemplo.Focus();
            }
        }

        private void btnVerChlb_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (var chlb in chlbEjemplo.CheckedItems)
            {
                list.Add(chlb.ToString());
            }
            string mensaje = "Cantidad de elementos seleccionados: " + list.Count.ToString();
            this.mensaje("CheckListBox", mensaje);
        }

        private void btnVerDtp_Click(object sender, EventArgs e)
        {
            string valorFechaCorta = dtpFechaEjemplo.Value.ToShortDateString(); // Solo fecha en formato DD/MM/AAAA
            string valorFechaLarga = dtpFechaEjemplo.Value.ToLongDateString(); // Fecha en formato largo
            string valorFechaHoraEntera = dtpFechaEjemplo.Value.ToString(); // Fecha en formato DD/MM/AAAA y Hora
            string valorHora = dtpFechaEjemplo.Value.ToShortTimeString(); // Solo Hora
            mensaje("DateTimePicker", valorFechaLarga);
        }
    }
}
