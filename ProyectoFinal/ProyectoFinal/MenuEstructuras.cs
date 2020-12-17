using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MenuEstructuras : Form
    {
        public MenuEstructuras()
        {
            InitializeComponent();
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Listas open = new EstructurasdeDatos.Listas();
            open.Show();
            this.Close();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Pilas ouvrir = new EstructurasdeDatos.Pilas();
            ouvrir.Show();
            this.Close();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Colas yeolgi = new EstructurasdeDatos.Colas();
            yeolgi.Show();
            this.Close();
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Grafos aperto = new EstructurasdeDatos.Grafos();
            aperto.Show();
            this.Close();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Arboles hiraku = new EstructurasdeDatos.Arboles();
            hiraku.Show();
            this.Close();
        }
    }
}
