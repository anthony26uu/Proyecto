﻿using Login.UI.Menus;
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
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Inicio db = new Inicio();
                db.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message);
            }

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
    }
}
