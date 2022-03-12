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
    public partial class Cantidad : Form
    {

        string Usuario = "JUGADOR";
        int Iteraciones = 0;
        public Cantidad()
        {
            InitializeComponent();
            usuario(Usuario);
        }


      
        public void usuario(string nombre)
        {
            lblJugador.Text = nombre;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox1.Text) <= 10) && (int.Parse(textBox1.Text) >1))
            {
                Usuario = lblJugador.Text;
                Iteraciones = int.Parse(textBox1.Text);
                this.Close();
                frmJuego juego = new frmJuego();
                juego.usuario(Usuario);
                juego.Cantidad(Iteraciones);
                juego.Visible = true;
            }
            else
            {
                MessageBox.Show("Recuerde digitar un valor entre 1 y 10");
            }
        }
    }
}
