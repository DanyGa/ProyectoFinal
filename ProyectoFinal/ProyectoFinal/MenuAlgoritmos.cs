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
    public partial class MenuAlgoritmos : Form
    {
        public MenuAlgoritmos()
        {
            InitializeComponent();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOdenamiento.Burbuja il = new AlgoritmosdeOdenamiento.Burbuja();
            il.Show();
            this.Close();
        }

        private void btnBurbujaB_Click(object sender, EventArgs e)
        {
            AlgoritmosdeOdenamiento.BurbujaBidireccional i = new AlgoritmosdeOdenamiento.BurbujaBidireccional();
            i.Show();
            this.Close();
        }
    }
}
