﻿using Login.UI.Consulta;
using Login.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login.UI.Menus
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroArticulo db = new RegistroArticulo();
            db.Show();
        }

        private void articuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroUser db = new RegistroUser(); //Problemas Con referencia En realidad se refiere a consulta Articulo
            db.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaUsuario db = new ConsultaUsuario();
            db.Show();

        }

        private void usuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario db = new RegistroUsuario();
            db.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleados db = new RegistroEmpleados();
            db.Show();
        }
    }
}