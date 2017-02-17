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
    public partial class RegistroArticulo : Form
    {
        public RegistroArticulo()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            idArticuloMaskedTextBox.Clear();
            nombreArticuloTextBox.Clear();
            existenciaTextBox.Clear();
            precioCompraMaskedTextBox.Clear();
            precioVentaMaskedTextBox.Clear();
            codigoArticuloMaskedTextBox.Clear();
            fechaIngresoDateTimePicker.Value = DateTime.Today;
        }

        private bool Validar()
        {
            bool retorno = true;
            if(string.IsNullOrWhiteSpace(nombreArticuloTextBox.Text))
            {
                errorProviderNombre.SetError(nombreArticuloTextBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(existenciaTextBox.Text))
            {
                errorProviderNombre.SetError(existenciaTextBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(precioCompraMaskedTextBox.Text))
            {
                errorProviderNombre.SetError(precioCompraMaskedTextBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(precioVentaMaskedTextBox.Text))
            {
                errorProviderNombre.SetError(precioVentaMaskedTextBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(categoriaComboBox.Text))
            {
                errorProviderNombre.SetError(categoriaComboBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(codigoArticuloMaskedTextBox.Text))
            {
                errorProviderNombre.SetError(codigoArticuloMaskedTextBox, "Campo Obligatorio");
                retorno = false;
            }
            return retorno;
        }

        public void LlenarCombo()
        {
            categoriaComboBox.Items.Insert(0, "ENLATADOS");
            categoriaComboBox.Items.Insert(1, "DEPORTIVO");
            categoriaComboBox.Items.Insert(2, "OTROS");
            categoriaComboBox.Items.Insert(3, "CALZADO");
            categoriaComboBox.DataSource = categoriaComboBox.Items;
            categoriaComboBox.DisplayMember = "*SELCIONE*";

        }

        public void Seleccione()
        {
            var guardar = new Articulos();
            using (var conn = new BLL.Repositorio<Articulos>())
            {
                if (categoriaComboBox.SelectedIndex == 0)
                {
                    categoriaComboBox.Text = "ENLATADOS";
                }

                if (categoriaComboBox.SelectedIndex == 1)
                {
                    categoriaComboBox.Text = "DEPORTIVO";
                }
                if (categoriaComboBox.SelectedIndex == 2)
                {
                    categoriaComboBox.Text = guardar.Categoria;
                }
                if (categoriaComboBox.SelectedIndex == 3)
                {
                    categoriaComboBox.Text = "CALZADO";
                }
            }

        }


        private void RegistroArticulo_Load(object sender, EventArgs e)
        {
            LlenarCombo();

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var guardar = new Articulos();
            Seleccione();
            guardar.NombreArticulo = nombreArticuloTextBox.Text;
            guardar.Existencia = Convert.ToInt32( existenciaTextBox.Text);
            guardar.FechaIngreso = fechaIngresoDateTimePicker.Value.Date;
            guardar.PrecioVenta = double.Parse(precioVentaMaskedTextBox.Text);
            guardar.PrecioCompra = double.Parse(precioCompraMaskedTextBox.Text);
            guardar.Categoria = categoriaComboBox.Text;
             guardar.CodigoArticulo = Convert.ToInt32(codigoArticuloMaskedTextBox.Text);

          //  guardar.IdArticulo = (Utils.TOINT(idArticuloMaskedTextBox.Text));
        //    guardar.Existencia = (Utils.TOINT(nombreArticuloTextBox.Text));
          //  guardar.PrecioVenta = (Utils.TOINT(precioVentaMaskedTextBox.Text));
          //  guardar.PrecioCompra = (Utils.TOINT(precioCompraMaskedTextBox.Text));
         //   guardar.CodigoArticulo = (Utils.TOINT(codigoArticuloMaskedTextBox.Text));
           


            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos");
            }
            else if (BLL.RepositorioBLL.Guardar(guardar))
            {
                MessageBox.Show("El articulo se agrego con exito.");
            }

            Limpiar();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idArticuloMaskedTextBox.Text);
            using (var db = new BLL.Repositorio<Articulos>())
            {
                if (db.Eliminar(db.Buscar(p => p.IdArticulo == id)))
                {

                    MessageBox.Show("Articulo eliminado con exito.");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Articulo.");
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idArticuloMaskedTextBox.Text);
            Articulos articulo;
            using (var db = new BLL.Repositorio<Articulos>())
            {
                articulo = db.Buscar(p => p.IdArticulo == id);

                if (articulo != null)
                {
                    nombreArticuloTextBox.Text = articulo.NombreArticulo;
                    existenciaTextBox.Text = Convert.ToString( articulo.Existencia);
                    precioVentaMaskedTextBox.Text = Convert.ToString(articulo.PrecioVenta);
                    precioCompraMaskedTextBox.Text = Convert.ToString(articulo.PrecioCompra);
                    categoriaComboBox.Text = articulo.Categoria;
                    codigoArticuloMaskedTextBox.Text = Convert.ToString(articulo.CodigoArticulo);
                    fechaIngresoDateTimePicker.Text = Convert.ToString(articulo.FechaIngreso);


                    
                    MessageBox.Show("Resultados");
                }
                else
                {
                    MessageBox.Show("No existe ningun Articulo con ese Id.");
                }
            }
        }
    }
}
