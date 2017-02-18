using Login.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login.UI.Consulta
{
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        public void Llenar()
        {
            //  comboBox1.Items.Insert(3, "Nombre1");
            comboBox1.Items.Insert(0, "NOMBRE");
            comboBox1.Items.Insert(1, "TODO");

            //Si Colocas DiplayMember arriba no funcoina
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombre";


        }

        public void Selecionar()
        {
            using (var db = new BLL.Repositorio<Usuario>())
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = db.GetListNombre(p => p.NombreUsuario == buscaText.Text);
                }

               
                if (comboBox1.SelectedIndex == 1)
                {
                    dataGridView1.DataSource = db.GetList();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            Llenar();
        }
    }
}
