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
    public partial class frmJuego : Form
    {
        string Usuario = "JUGADOR";
        int cantidad = 0, puntosmaquina=0, puntosjugador=0;
        public frmJuego()
        {
            InitializeComponent();
            usuario(Usuario);
        }

        public void usuario(string nombre)
        {
            lblUsuario.Text = nombre;
        }
        public void Cantidad(int cant)
        {
            cantidad = cant;
        }
        private void frmJuego_Load(object sender, EventArgs e)
        {

        }
        class carta
        {
            public string nombre;
            public int valor;
            public string palo;
            public override string ToString() { return string.Format("{0} of {1}", nombre, palo); }

        }
        class MazodeCarta
        {

            public List<carta> MazodeCartas { get; set; } = new List<carta>
                {

                    new carta{nombre="dos",valor=2,palo ="corazones"},
                    new carta{nombre="tres",valor=3,palo="corazones"},
                    new carta{nombre="cuatro",valor=4,palo="corazones"},
                    new carta{nombre="cinco", valor=5, palo="corazones"},
                    new carta{nombre="seis",valor=6,palo="corazones"},
                    new carta{nombre="siete",valor=7,palo="corazones"},
                    new carta{nombre="ocho",valor=8,palo="corazones"},
                    new carta {nombre="nueve", valor=9, palo="corazones"},
                    new carta{nombre="diez",valor=10,palo="corazones"},
                    new carta{nombre="jack",valor=11,palo="corazones"},
                    new carta{nombre="reina",valor=12,palo="corazones"},
                    new carta { nombre="rey", valor=13, palo="corazones"},
                    new carta { nombre="As", valor=14, palo="corazones"},


                  new carta{nombre="dos",valor=2,palo ="diamantes"},
                    new carta{nombre="tres",valor=3,palo="diamantes"},
                    new carta{nombre="cuatro",valor=4,palo="diamantes"},
                    new carta{nombre="cinco", valor=5, palo="diamantes"},
                    new carta{nombre="seis",valor=6,palo="diamantes"},
                    new carta{nombre="siete",valor=7,palo="diamantes"},
                    new carta{nombre="ocho",valor=8,palo="diamantes"},
                    new carta {nombre="nueve", valor=9, palo="diamantes"},
                    new carta{nombre="diez",valor=10,palo="diamantes"},
                    new carta{nombre="jack",valor=11,palo="diamantes"},
                    new carta{nombre="reina",valor=12,palo="diamantes"},
                    new carta { nombre="rey", valor=13, palo="diamantes"},
                    new carta { nombre="As", valor=14, palo="diamantes"},


                    new carta{nombre="dos",valor=2,palo ="espadas"},
                    new carta{nombre="tres",valor=3,palo="espadas"},
                    new carta{nombre="cuatro",valor=4,palo="espadas"},
                    new carta{nombre="cinco", valor=5, palo="espadas"},
                    new carta{nombre="seis",valor=6,palo="espadas"},
                    new carta{nombre="siete",valor=7,palo="espadas"},
                    new carta{nombre="ocho",valor=8,palo="espadas"},
                    new carta {nombre="nueve", valor=9, palo="espadas"},
                    new carta{nombre="diez",valor=10,palo="espadas"},
                    new carta{nombre="jack",valor=11,palo="espadas"},
                    new carta{nombre="reina",valor=12,palo="espadas"},
                    new carta { nombre="rey", valor=13, palo="espadas"},
                    new carta { nombre="As", valor=14, palo="espadas"},

                    new carta{nombre="dos",valor=2,palo ="treboles"},
                    new carta{nombre="tres",valor=3,palo="treboles"},
                    new carta{nombre="cuatro",valor=4,palo="treboles"},
                    new carta{nombre="cinco", valor=5, palo="treboles"},
                    new carta{nombre="seis",valor=6,palo="treboles"},
                    new carta{nombre="siete",valor=7,palo="treboles"},
                    new carta{nombre="ocho",valor=8,palo="treboles"},
                    new carta {nombre="nueve", valor=9, palo="treboles"},
                    new carta{nombre="diez",valor=10,palo="treboles"},
                    new carta{nombre="jack",valor=11,palo="treboles"},
                    new carta{nombre="reina",valor=12,palo="treboles"},
                    new carta { nombre="rey", valor=13, palo="treboles"},
                    new carta { nombre="As", valor=14, palo="treboles"},

             };
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            int contador;
            puntosmaquina = 0;
            puntosjugador=0;
            lstBoxCartasJugadorUno.Items.Clear();
            listBox1.Items.Clear();
            MazodeCarta MAZO = new MazodeCarta();
            List<carta> MazoAleatorio = new List<carta>();
            List<carta> MazoJugadorUno = new List<carta>();
            List<carta> MazoJugadorDos = new List<carta>();
           

            Random random = new Random();
            for (int c = 0; c < 52; c++)
            {
                int pos = random.Next(0, 50);
                MazoAleatorio.Add(MAZO.MazodeCartas[pos]);
                       
            }
            
            contador = 0;

            for (int i = 0; i <= cantidad*2; i++)
            {
                if (i < cantidad) {  MazoJugadorUno.Add(MazoAleatorio[i]);
                    lstBoxCartasJugadorUno.Items.Add(MazoJugadorUno[contador]);
                    contador++;
                }
                if (contador == cantidad)
                {
                    contador = 0;
                }
                if (i > cantidad) { MazoJugadorDos.Add(MazoAleatorio[i]);
                    listBox1.Items.Add(MazoJugadorDos[contador]);
                    contador++;
                }
                
            }

            for (int x=0; x < cantidad; x++)
            {
                Puntaje(MazoJugadorDos[x].palo,MazoJugadorDos[x].palo, MazoJugadorDos[x].valor, MazoJugadorDos[x].valor);
            }

            if (puntosjugador > puntosmaquina)
            { label1.Text = $"Jugador ha ganado con {puntosjugador} puntos"; }
            if (puntosjugador < puntosmaquina) { label1.Text = $"Maquina ha ganado con {puntosmaquina} puntos"; }
            if (puntosjugador == puntosmaquina) { label1.Text = $"Juego empatado con {puntosjugador} puntos"; }

        }
   
    
        public void Puntaje(string paloJugador, string palomaquina, int valorjugador, int valormaquina)
        {
            if (paloJugador == "diamante")
            {
                if (palomaquina == "diamante")
                {
                    if (valorjugador >= valormaquina)
                    {
                        puntosjugador += 1;
                    }
                    else { puntosmaquina += 1; }
                }
                if ((palomaquina == "espadas") || (palomaquina == "treboles")) { puntosjugador += 1; }
                if (palomaquina == "corazones") { puntosmaquina += 1; }
            }
            
            if (paloJugador == "corazones")
            {
                if (palomaquina == "diamante") { puntosjugador += 1; }
                if ((palomaquina == "espadas") || (palomaquina == "treboles")) { puntosjugador += 1; }
                if (palomaquina == "corazones")
                {
                    if (valorjugador >= valormaquina)
                    {
                        puntosjugador += 1;
                    }
                    else { puntosmaquina += 1; }
                }
            }
           
            if ((paloJugador == "espadas") || (paloJugador == "treboles"))
            {
                if (palomaquina == "diamante") { puntosmaquina += 1; }
                if ((palomaquina == "espadas") || (palomaquina == "treboles"))
                {
                    if (valorjugador >= valormaquina)
                    {
                        puntosjugador += 1;
                    }
                    else { puntosmaquina += 1; }
                }
                if (palomaquina == "corazones") { puntosmaquina += 1; }
            }

        }
    }
    }
