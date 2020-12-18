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
    public partial class Colas : Form
    {
        CColas.Nodo n;
        CColas.Cola MiCola = new CColas.Cola();    
        
        public Colas()
        {
            InitializeComponent();
        }

        private void Colas_Load(object sender, EventArgs e)
        {
            gbAbajo.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbArriba.Visible = false;
            gbAbajo.Visible = true;
        }
        
        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                n = new CColas.Nodo();
                n.Dato = int.Parse(txtDato.Text);
                MiCola.Encolar(n);
                lblCola.Text = MiCola.ToString();
                txtDato.Clear();
            }
            catch
            {
                MessageBox.Show("Bruh");
                txtDato.Clear();
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            MiCola.Desencolar();
            lblCola.Text = MiCola.ToString();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El dato frontal es : " + MiCola.Front());
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                gbAbajo.Visible = true;
                gbArriba.Visible = false;
                OpenFileDialog Seleccionar = new OpenFileDialog();
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    MiCola.Head = null;
                    int contador = 0;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Lista = linea.Split(',');
                    foreach (string i in Lista)
                    {
                        n = new CColas.Nodo();
                        n.Dato = int.Parse(Lista[contador]);
                        MiCola.Encolar(n);
                        contador++;
                    }
                    lblCola.Text = MiCola.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
            }
        }
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            try
            {
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = lblCola.Text;
                    string nombreDelArchivo;
                    if (txtArchivo.Text == "")
                    {
                        nombreDelArchivo = "Cola";
                    }
                    else
                    {
                        nombreDelArchivo = txtArchivo.Text;
                    }
                    string ruta = Dialogo.SelectedPath + "\\" + nombreDelArchivo + ".txt";
                    using (var writer = new StreamWriter(ruta))
                    {
                        writer.Close();
                    }
                    File.WriteAllText(ruta, dato);
                    MessageBox.Show("Datos guardados en el archivo : " + nombreDelArchivo + ".txt");
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void algoritmosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAlgoritmos hoesaek = new MenuAlgoritmos();
            hoesaek.Show();
            this.Close();
        }

        private void estructurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEstructuras geomeunsaek = new MenuEstructuras();
            geomeunsaek.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
