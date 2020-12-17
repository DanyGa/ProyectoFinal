using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.EstructurasdeDatos
{
    public partial class Listas : Form
    {
        public Listas()
        {
            InitializeComponent();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            TiposdeListas.ListaSimple wolyoil = new TiposdeListas.ListaSimple();
            wolyoil.Show();
            this.Close();
        }

        private void btnSimpleCircular_Click(object sender, EventArgs e)
        {
            TiposdeListas.ListaSimpleCircular hwayoil = new TiposdeListas.ListaSimpleCircular();
            hwayoil.Show();
            this.Close();
        }

        private void btnDoble_Click(object sender, EventArgs e)
        {
            TiposdeListas.ListaDoble suyoil = new TiposdeListas.ListaDoble();
            suyoil.Show();
            this.Close();
        }

        private void btnDobleCircular_Click(object sender, EventArgs e)
        {
            TiposdeListas.ListaDobleCircular mokyoil = new TiposdeListas.ListaDobleCircular();
            mokyoil.Show();
            this.Close();
        }
    }
}
