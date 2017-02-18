using Login.Entidades;
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
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            idEmpleadoNumericUpDown.ResetText();
            nombreEmpleadoTextBox.Clear();
            telefonoEmpleadoMaskedTextBox.Clear();
            fechaContratacionDateTimePicker.Value = DateTime.Today;
            direccionTextBox.Clear();
            salarioMaskedTextBox.Clear();
            cargoTextBox.Clear();
            nombreEmpleadoTextBox.Focus();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreEmpleadoTextBox.Text))
            {
                errorProviderNombre.SetError(nombreEmpleadoTextBox, "El Campo Esta en blanco");
                retorno = false;
            }

            if (string.IsNullOrWhiteSpace(telefonoEmpleadoMaskedTextBox.Text))
            {
                errorProviderNombre.SetError(telefonoEmpleadoMaskedTextBox, "El Campo Esta en blanco");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(direccionTextBox.Text))
            {
                errorProviderNombre.SetError(direccionTextBox, "El Campo Esta en blanco");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(salarioMaskedTextBox.Text))
            {
                errorProviderNombre.SetError(salarioMaskedTextBox, "El Campo Esta en blanco");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(cargoTextBox.Text))
            {
                errorProviderNombre.SetError(cargoTextBox, "El Campo Esta en blanco");
                retorno = false;
            }
            return retorno;
        }



        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                var guardar = new Empleado();
                guardar.IdEmpleado = (Utils.TOINT(idEmpleadoNumericUpDown.Text));
                guardar.NombreEmpleado = nombreEmpleadoTextBox.Text;
                guardar.TelefonoEmpleado = Convert.ToInt32(telefonoEmpleadoMaskedTextBox.Text);
                guardar.FechaContratacion = fechaContratacionDateTimePicker.Value.Date;
                guardar.Direccion = direccionTextBox.Text;
                guardar.Salario = salarioMaskedTextBox.Text;
                guardar.Cargo = cargoTextBox.Text;



                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else if (BLL.EmpleadoBLL.Guardar(guardar))
                {
                    MessageBox.Show("El Empleado se agrego con exito.");
                }

                Limpiar();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idEmpleadoNumericUpDown.Text);
            using (var db = new BLL.Repositorio<Empleado>())
            {
                if (db.Eliminar(db.Buscar(p => p.IdEmpleado == id)))
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idEmpleadoNumericUpDown.Text);
            Empleado Empleado;
            using (var db = new BLL.Repositorio<Empleado>())
            {
                Empleado = db.Buscar(p => p.IdEmpleado == id);

                if (Empleado != null)
                {
                  //  idEmpleadoNumericUpDown.ResetText = Empleado.IdEmpleado;
                    nombreEmpleadoTextBox.Text = Empleado.NombreEmpleado;
                    telefonoEmpleadoMaskedTextBox.Text = Convert.ToString( Empleado.TelefonoEmpleado);
                    fechaContratacionDateTimePicker.Text = Convert.ToString( Empleado.FechaContratacion);
                    direccionTextBox.Text = Empleado.Direccion;
                    salarioMaskedTextBox.Text = Empleado.Salario;
                    cargoTextBox.Text = Empleado.Cargo;

                    MessageBox.Show("Este es el Empleado");
                }
                else
                {
                    MessageBox.Show("No existe ningun Usuario con ese Id.");
                }
            }
        }
    }
}