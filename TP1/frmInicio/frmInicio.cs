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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            Form cargar = new frmCarga();
            cargar.Show();
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Form listar = new frmListar();
            listar.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el sistema, hasta luego.");
            this.Close();
        }
    }
}
