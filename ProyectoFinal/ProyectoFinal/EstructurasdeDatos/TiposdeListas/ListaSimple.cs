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
    }
}
