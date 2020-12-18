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
            EstructurasdeDatos.Listas hana = new EstructurasdeDatos.Listas();
            hana.Show();
            this.Close();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Pilas dul = new EstructurasdeDatos.Pilas();
            dul.Show();
            this.Close();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Colas set = new EstructurasdeDatos.Colas();
            set.Show();
            this.Close();
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Grafos net = new EstructurasdeDatos.Grafos();
            net.Show();
            this.Close();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Arboles daseot = new EstructurasdeDatos.Arboles();
            daseot.Show();
            this.Close();
        }
    }
}
