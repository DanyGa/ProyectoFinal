﻿using System;
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
    public partial class ListaSimple : Form
    {
        Nodo n;
        CListaSimple.LS MiLista = new CListaSimple.LS();
        public ListaSimple()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MiLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new Nodo();
                    n.Dato = int.Parse(txtNodo.Text);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtDatoBorrar.Text);
            if (!MiLista.BuscarDato(dato))
            {
                MessageBox.Show("No se encontro el dato");
                lblLista.Text = MiLista.ToString();
                return;
            }
            MiLista.Borrar(dato);
            lblLista.Text = MiLista.ToString();
            txtDatoBorrar.Clear();
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            MiLista.Head = null;
            lblLista.Text = MiLista.ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = MiLista.ToString();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de nodos en la lista: " + MiLista.ContarNodos());
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            if (Seleccionar.ShowDialog() == DialogResult.OK)
            {
                MiLista.Head = null;
                int contador = 0;
                string ruta = Seleccionar.FileName;
                string linea = File.ReadAllText(ruta);
                string[] Lista = linea.Split(',');
                foreach (string i in Lista)
                {
                    n = new Nodo();
                    n.Dato = int.Parse(Lista[contador]);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    contador++;
                }

            }
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
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

        private void algoritmosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAlgoritmos noransaek = new MenuAlgoritmos();
            noransaek.Show();
            this.Close();
        }

        private void estructurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEstructuras joohwangsaek = new MenuEstructuras();
            joohwangsaek.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
