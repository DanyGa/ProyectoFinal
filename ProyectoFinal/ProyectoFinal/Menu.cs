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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
       
        private void btnAlgoritmo_Click(object sender, EventArgs e)
        {
            MenuAlgoritmos abrir = new MenuAlgoritmos();
            abrir.Show();
            Hide();
        }

        private void btnEstructura_Click(object sender, EventArgs e)
        {
            MenuEstructuras aperto = new MenuEstructuras();
            aperto.Show();
            Hide();
        }
    }
}
