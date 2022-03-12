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
    public partial class FrmPuntuaciones : Form
    {
        public FrmPuntuaciones()
        {
            InitializeComponent();
           
        }

        public void usuario(string nombre)
        {
            label1.Text = nombre;
        }
        private void FrmPuntuaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
