using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoFinal.AlgoritmosdeOdenamiento
{
    public partial class Burbuja : Form
    {
        public Burbuja()
        {
            InitializeComponent();
        }

        int n;
        int may;
        int men;
        int i;       
        int[] lista;
        Stopwatch contador = new Stopwatch();

        public void Agregar(int n, int men, int may)
        {
            lista = new int[n];
            Random aleatorio = new Random();
            for (i = 0; i < lista.Length; i++)
            {
                lista[i] = aleatorio.Next(men, may);

            }
        }

        public void Mostrar(ListBox l)
        {
            for (i = 0; i < lista.Length; i++)
            {
                l.Items.Add(lista[i]);
            }
        }

        public void Ordenar(int n)
        {
            int aux;
            int comparaciones = 0;
            int intercambios = 0;
            for (int i = 1; i < lista.Length; i++)
            {
                for (int j = 0; j < lista.Length - 1; j++)
                {
                    comparaciones++;
                    if (lista[j] > lista[j + 1])
                    {
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                        intercambios++;
                    }
                }
            }
            lblComparaciones.Text = comparaciones.ToString() + " Comparaciones";
            lblIntercambios.Text = intercambios.ToString() + " Intercambios";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                lbNum.Items.Clear();
                lbOrd.Items.Clear();
                n = int.Parse(txtNum.Text);
                men = int.Parse(txtMen.Text);
                may = int.Parse(txtMay.Text);
                Agregar(n, men, may);
                Mostrar(lbNum);
                btnCrear.Enabled = false;
                btnOrdenar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Introduzca un numero valido");
            }
        }      

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            contador.Restart();
            Ordenar(n);
            contador.Stop();
            lblOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() + " Milisegundos";
            Mostrar(lbOrd);
            btnCrear.Enabled = true;
            btnOrdenar.Enabled = false;

        }

        private void algoritmosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAlgoritmos boonhongsaek = new MenuAlgoritmos();
            boonhongsaek.Show();
            this.Close();
        }

        private void estructuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEstructuras galsaek = new MenuEstructuras();
            galsaek.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
