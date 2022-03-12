using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUno
{
    public partial class frmPrincipal : Form
    {
        public string nombre = "Usuario ";
        public frmPrincipal()
        {
           
            InitializeComponent();
            usuario(nombre);
        }
        public void usuario(string nombre) {
            label1.Text = nombre;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void puntuacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            nombre = label1.Text;
            this.Close();
            Cantidad frmCantidad = new Cantidad();
            frmCantidad.usuario(nombre);
            frmCantidad.Visible = true;

        }
    }
}
