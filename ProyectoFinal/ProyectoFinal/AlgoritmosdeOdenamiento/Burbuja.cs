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

        int aux;
        int comparaciones = 0;
        int intercambios = 0;
        int[] lista;

        public void Agregar(int rango, int may, int men)
        {
            lista = new int[rango];
            Random random = new Random();
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = random.Next(men, may);
            }
        }

        public string Mostrar()
        {
            string numeros = "";
            if (lista.Length != 0)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    numeros += lista[i] + ", ";
                }
                return numeros;
            }
            else
            {
                return "LA LISTA ESTÁ VACÍA.";
            }

        }

        public string Ordenar()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
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
            stopwatch.Stop();
            string time = $"    Tiempo = {stopwatch.Elapsed.TotalMilliseconds } ms.";
            return "Comparaciones = " + comparaciones + "  Intercambios = " + intercambios + time;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int tam = Convert.ToInt32(txtNum.Text);
            int may = Convert.ToInt32(txtMay.Text);
            int men = Convert.ToInt32(txtMen.Text);
            Agregar(tam, may, men);
            lblNum.Text = Mostrar();
            txtNum.Clear();
            txtMay.Clear();
            txtMen.Clear();
        }      

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Ordenar();
            lblOrdenado.Text = Mostrar();
            MessageBox.Show(Ordenar());

        }

        private void btnEliminarL_Click(object sender, EventArgs e)
        {
            lblNum.Text = "----";
            lblOrdenado.Text = "----";
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
