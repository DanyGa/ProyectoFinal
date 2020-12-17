using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal.EstructurasdeDatos.TiposdeListas
{
    public partial class ListaDoble : Form
    {
        public ListaDoble()
        {
            InitializeComponent();
        }

        Nodo n;
        CListaDoble.LD miLista = new CListaDoble.LD();

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!miLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new Nodo();
                    n.Dato = int.Parse(txtNodo.Text);
                    miLista.Insertar(n);
                    lblLista.Text = miLista.ToString();
                    txtNodo.Clear();
                    return;
                }
                MessageBox.Show("El dato ya existe en la lista");
                txtNodo.Clear();
            }
            catch
            {
                MessageBox.Show("Introduzca un numero valido");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtNodo.Text);
            if (!miLista.BuscarDato(dato))
            {
                MessageBox.Show("No se encontro el dato");
                lblLista.Text = miLista.ToString();
                return;
            }
            miLista.Eliminar(dato);
            lblLista.Text = miLista.ToString();
            txtNodo.Clear();
        }

        private void bntBorrarL_Click(object sender, EventArgs e)
        {
            miLista.Head = null;
            lblLista.Text = miLista.ToString();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de nodos en la lista: " + miLista.ContarNodos());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                string dato = lblLista.Text;
                string ruta = Dialogo.SelectedPath + "\\Lista.txt";
                using (var writer = new StreamWriter(ruta))
                {
                    writer.Close();
                }
                File.WriteAllText(ruta, dato);
                MessageBox.Show("Datos guardados");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            if (Seleccionar.ShowDialog() == DialogResult.OK)
            {
                miLista.Head = null;
                int contador = 0;
                string ruta = Seleccionar.FileName;
                string linea = File.ReadAllText(ruta);
                string[] Lista = linea.Split(',');
                foreach (string i in Lista)
                {
                    n = new Nodo();
                    n.Dato = int.Parse(Lista[contador]);
                    miLista.Insertar(n);
                    lblLista.Text = miLista.ToString();
                    contador++;
                }
            }
        }

        private void algoritmosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAlgoritmos borasaek = new MenuAlgoritmos();
            borasaek.Show();
            this.Close();
        }

        private void estructurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEstructuras noksaek = new MenuEstructuras();
            noksaek.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
