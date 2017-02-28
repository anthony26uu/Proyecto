using AutoExplicacion;
using Login.UI.Menus;
using Login.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{


    public partial class Form1 : Form
    {
        public object Me { get; private set; }

        public Form1()
        {
            InitializeComponent();
            timer1Hora.Enabled = true;
          
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(texCuenta.Text))
            {
                errorProviderNombre.SetError(texCuenta, "Campo vacio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(texPass.Text))
            {
                errorProviderPass.SetError(texPass, "Campo Vacio");
                retorno = false;
            }
            return retorno;

        }

        private void limpiar()
        {
            texCuenta.Clear();
            texPass.Clear();
            texCuenta.Focus();
            errorProviderNombre.Clear();
            errorProviderPass.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio db = new Inicio();
            db.Show();
            /*
            try
            {

                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                //    limpiar();
                }
                else
                {

                    if (texCuenta.Text == "Admin" && texPass.Text == "0000")
                    {
                        Inicio db = new Inicio();
                        db.Show();
                    }

                    else
                    {
                        MessageBox.Show("Nombre Usuario & Contraseña \n  Son Incorrectos");
                    }
                }
               



        }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message);
            }
         */
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                if (texCuenta.Text == "Admin" && texPass.Text == "0000")
                {
                    RegistroUsuario db = new RegistroUsuario();
                    db.Show();
                }
                else
                {
                 //   MessageBox.Show("Nombre Usuario & Contraseña \n  Son Incorrectos");
                    errorProviderNombre.SetError(texCuenta, "Verifique e intente de nuevo");
                    errorProviderPass.SetError(texPass, "Verifique e intente de nuevo");
                }
                


            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message);
            }

                  

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1Hora_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            labelHORA.Text = DateTime.Now.ToLongTimeString();
            //Fecha
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
         
            
        }

        private void labelHORA_Click(object sender, EventArgs e)
        {

        }

        private void autoExplicacion1_TextChanged(object sender, EventArgs e)
        {

        }


      

    }
}
