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
            Hide();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Pilas dul = new EstructurasdeDatos.Pilas();
            dul.Show();
            Hide();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Colas set = new EstructurasdeDatos.Colas();
            set.Show();
            Hide();
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Grafos.Grafos net = new EstructurasdeDatos.Grafos.Grafos();          
            net.Show();
            Hide();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            EstructurasdeDatos.Arboles daseot = new EstructurasdeDatos.Arboles();
            daseot.Show();
            Hide();
        }

        private void MenuEstructuras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
