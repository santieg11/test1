using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmInicio
{
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
            lblApellido.BackColor = Color.Transparent;
            lblNombre.BackColor = Color.Transparent;
            lblEdad.BackColor = Color.Transparent;
            gbxSexo.BackColor = Color.Transparent;
            rbnFem.BackColor = Color.Transparent;
            rbnMasc.BackColor = Color.Transparent;
            lblFNac.BackColor = Color.Transparent;
            lblMusica.BackColor = Color.Transparent;
            lblColor.BackColor = Color.Transparent;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e) //calculo la edad segun la fecha ingresada
        {
            if (dtpFechaNac.Value > DateTime.Today) //verifico que no se ingresen fechas en el futuro
            {
                MessageBox.Show("No se puede agregar fechas mayores al dia de la fecha");
                dtpFechaNac.Value = DateTime.Today;
            }
            else
            {
                DateTime fechanac = dtpFechaNac.Value;
                int años = System.DateTime.Now.Year - fechanac.Year;
                if (System.DateTime.Now.Subtract(fechanac.AddYears(años)).TotalDays < 0) { txbEdad.Text = Convert.ToString(años - 1); }
                else { txbEdad.Text = Convert.ToString(años); }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e) //vuelve todos los campos a default
        {
            txbNombre.Text = "";
            txbApellido.Text = "";
            dtpFechaNac.Value = DateTime.Today;
            txbEdad.Text = "";
            rbnMasc.Checked = false;
            rbnFem.Checked = false;
            lbxMusica.ClearSelected();
            cbxColor.SelectedItem = null;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool aux = false; //auxiliar para verificar que se completen todos los datos
            string sexo; //auxiliar para pasar el sexo seleccionado
            string maux;
            string musica = "";
            
            if (txbNombre.Text == "") { aux = true; }
            if (txbApellido.Text == "") { aux = true; }
            if (dtpFechaNac.Value == DateTime.Today) { aux = true; }
            if (rbnMasc.Checked == false && rbnFem.Checked == false) { aux = true; }
            if (lbxMusica.SelectedIndex < 0) { aux = true; }
            if (cbxColor.SelectedIndex < 0) { aux = true; }

            if (rbnMasc.Checked == true) { sexo = "Masculino"; }
            else { sexo = "Femenino"; }

            for (int x = 0; x <= lbxMusica.SelectedItems.Count - 1; x++) //reviso cuantos generos selecciono
            {
                maux = lbxMusica.Items[x].ToString();
                if (x==0) { musica = maux; }
                else { musica = musica + "| " + maux; } //junto lo seleccionado en un solo string
            }
         

            if (aux == true) //si hay algun campo sin completar avisa
            {
                MessageBox.Show("Aun faltan completar datos");
            }
            else //si todos los campos estan completos muestra un resumen
            {
                 MessageBox.Show("Nombre: " + txbNombre.Text + "\r\n" +
                                 "Apellido: " + txbApellido.Text + "\r\n" +
                                 "Edad: " + txbEdad.Text + "\r\n" +
                                 "Sexo: " + sexo + "\r\n" +
                                 "Gustos musicales: " + musica + "\r\n" +
                                 "Color favorito: " + cbxColor.SelectedItem);
            }
        }


        private void txbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) //valido que solo ingresen letras
                e.Handled = true;
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) //valido que solo ingresen letras
                e.Handled = true;
        }
    }
}
