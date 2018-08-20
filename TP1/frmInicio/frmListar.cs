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
    public partial class frmListar : Form
    {

        public frmListar()
        {
            InitializeComponent();
            lblIngreso.BackColor = Color.Transparent;
        }

        private void btnSalir_Click(object sender, EventArgs e) //si cierro el form lanzo el form inicial otra vez
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txbIngreso.Text != null && txbIngreso.Text.Trim() != "") //verifico que no este vacio ni hayan unicamente espacios
            {
                lbxIzq.Items.Add(txbIngreso.Text); //copio el valor del txbox a la lista
                txbIngreso.Clear(); //pongo en blanco el textbox
            }

            else
            {
                MessageBox.Show("Ingrese un dato");
            }
        }

        private void btnPasarUno_Click(object sender, EventArgs e)
        {
            if (lbxIzq.SelectedItems.Count == 0) //verifico que haya seleccionado un item
            {
                MessageBox.Show("Seleccione un Item");
            }
            else
            {
                if (lbxDer.Items.Count > 0) //verifico si ya existen items en la lista derecha
                {
                    if (lbxDer.Items.Contains(lbxIzq.SelectedItem.ToString())) //revisa si ya existe el valor en la otra lista
                    {
                        MessageBox.Show("Valor ya existe en la lista, elija otro o borre el ingreso");
                    }
                    else
                    {
                        lbxDer.Items.Add(lbxIzq.SelectedItem.ToString()); //si no existe lo envio a la lista derecha
                        lbxIzq.Items.Remove(lbxIzq.SelectedItem); //y lo borro de la izquierda
                    }
                }
                else //si no existen items en la lista derecha directamente paso el valor
                {
                    lbxDer.Items.Add(lbxIzq.SelectedItem.ToString());
                    lbxIzq.Items.Remove(lbxIzq.SelectedItem);
                }
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (lbxDer.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un Item");
            }
            else
            {
                lbxIzq.Items.Add(lbxDer.SelectedItem.ToString()); //copio el valor seleccionado de derecha a izquierda
                lbxDer.Items.Remove(lbxDer.SelectedItem); //lo borro de la lista de la derecha
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string nom;
            if (lbxDer.SelectedItems.Count == 0) MessageBox.Show("Seleccione un Item");
            
            nom = lbxDer.SelectedItem.ToString(); //paso el valor del item a una variable auxiliar
            lbxDer.Items.Remove(lbxDer.SelectedItem); //borro el item seleccionado
            MessageBox.Show("Item " + nom + " eliminado"); //informo el item eliminado
        }
            

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            if (lbxIzq.Items.Count == 0) MessageBox.Show("No hay datos a pasar");

            int cont = lbxIzq.Items.Count; //uso un contador para llevar de referencia de cada item
            
            while (cont > 0)
            {
                for(int x=0; x<=lbxIzq.Items.Count -1; x++)
                {
                    if (lbxDer.Items.Contains(lbxIzq.Items[x].ToString())) //verifico si el item de la vuelta ya existe en la lista de la derecha
                    {
                        cont--; //si existe no lo paso y quito un valor del contador ya que el item ya ha sido procesado
                    }
                    else
                    {
                        lbxDer.Items.Add(lbxIzq.Items[x].ToString()); //si no existe a la derecha lo paso y descuento un valor del contador
                        lbxIzq.Items.Remove(lbxIzq.Items[x]);
                        cont--;
                    }
                }
                
            }


        }








    }
}








