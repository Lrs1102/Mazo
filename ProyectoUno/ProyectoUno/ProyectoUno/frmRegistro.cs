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
    public partial class frmRegistro : Form
    {
        public string nombre;
        public frmRegistro()
        {
            
            InitializeComponent();
        }
     
        private void btnOK_Click(object sender, EventArgs e)
        {
            nombre = txtUser.Text.ToUpper();
           
            frmPrincipal principal = new frmPrincipal();
            principal.usuario(nombre);
            principal.Visible = true;

        }
    }
}
