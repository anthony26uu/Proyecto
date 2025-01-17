﻿using Login.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login.UI.Registros
{
    public partial class RegistroUsuario : Form
    {
        Usuario usuario = new Usuario();
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreUsuarioTextBox.Text))
            {
                errorProviderNombre.SetError(nombreUsuarioTextBox, "Campo Vacio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(passUsuarioTextBox.Text))
            {
                errorProviderNombre.SetError(passUsuarioTextBox, "Campo Vacio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(ConfirmaContextBox.Text))
            {
                errorProviderNombre.SetError(ConfirmaContextBox, "Campo Vacio");
                retorno = false;
            }
            return retorno;

        }

        private void Limpiar()
        {
            nombreUsuarioTextBox.Clear();
            IdnumericUpDown.ResetText();
            passUsuarioTextBox.Clear();
            ConfirmaContextBox.Clear();
            nombreUsuarioTextBox.Focus();
            errorProviderConfirmaContr.Clear();
            errorProviderContra.Clear();
            errorProviderNombre.Clear();
        }

        private Usuario LlenarCampos()
        {
          
            usuario.Id = (Utils.TOINT(IdnumericUpDown.Text));
            usuario.NombreUsuario = nombreUsuarioTextBox.Text;
            usuario.PassUsuario = passUsuarioTextBox.Text;

            return usuario;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               
               
                if(passUsuarioTextBox.Text==ConfirmaContextBox.Text)
                {

                    usuario = LlenarCampos();
                    if (!Validar())
                    {
                        MessageBox.Show("Por favor llenar los campos");
                    }
                    else if (BLL.UserBLL.Guardar(usuario))
                    {
                        MessageBox.Show("El Usuario se agrego con exito.");
                    }

                    Limpiar();
                }
                else
                {
                 errorProviderConfirmaContr.SetError(ConfirmaContextBox, "Contraseña no son iguales");
                }
                

            }
            catch (Exception )
            {
                
                throw;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdnumericUpDown.Text);
            Usuario user;
            using (var db = new BLL.Repositorio<Usuario>())
            {
                user = db.Buscar(p => p.Id == id);
               
                if (user != null)
                {
                    IdnumericUpDown.Text = Convert.ToString(user.Id);
                    nombreUsuarioTextBox.Text = user.NombreUsuario;
                    passUsuarioTextBox.Text = "*****";
                    ConfirmaContextBox.Text = "*****";
                    MessageBox.Show("Este es el Usuario Contraseña Protegida por seguridad");
                }
                else
                {
                    MessageBox.Show("No existe ningun Usuario con ese Id.");
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdnumericUpDown.Text);
            using (var db = new BLL.Repositorio<Usuario>())
            {
                if (db.Eliminar(db.Buscar(p => p.Id == id)))
                {

                    MessageBox.Show("Usuario eliminado con exito.");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar  Usuario.");
                }
            }
        }
     
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
