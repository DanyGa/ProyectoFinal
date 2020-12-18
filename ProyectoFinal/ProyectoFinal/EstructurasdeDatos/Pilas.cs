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

namespace ProyectoFinal.EstructurasdeDatos
{
    public partial class Pilas : Form
    {
        CPilas.Pila miPila = new CPilas.Pila();
        CPilas.Nodo n = new CPilas.Nodo();
        public Pilas()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            CPilas.Nodo n = new CPilas.Nodo(int.Parse(txtNodo.Text));
            miPila.Push(n);
            lblPila.Text = miPila.ToString();
            txtNodo.Clear();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            miPila.Pop();
            lblPila.Text = miPila.ToString();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            miPila.Top = null;
            lblPila.Text = miPila.ToString();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miPila.Count + "");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog Dialogo = new FolderBrowserDialog();
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = lblPila.Text;
                    string ruta = Dialogo.SelectedPath + "\\Pila.txt";
                    using (var writer = new StreamWriter(ruta))
                    {
                        writer.Close();
                    }
                    File.WriteAllText(ruta, dato);
                    MessageBox.Show("Datos guardados en el archivo : " + "Pila.txt");
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Seleccionar = new OpenFileDialog();
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    miPila.Top = null;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Pila = linea.Split(',');
                    int contador = Pila.Length - 1;
                    foreach (string i in Pila)
                    {
                        n = new CPilas.Nodo();
                        n.Dato = int.Parse(Pila[contador]);
                        miPila.Push(n);
                        contador--;
                    }
                    lblPila.Text = miPila.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
                miPila.Top = null;
                lblPila.Text = miPila.ToString();
            }
        }
    }
}
