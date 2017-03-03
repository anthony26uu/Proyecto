using Login.DAL;
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
    public partial class ConsultaArticulo : Form
    {
        Articulos articulo = new Articulos();

        public ConsultaArticulo()
        {
            InitializeComponent();
        }
        
        private Articulos llenarCampos()
        {

            articulo.IdArticulo = (Utils.TOINT(ArticulonumericUpDown.Text));
            articulo.NombreArticulo = nombreArticuloTextBox.Text;
            articulo.Existencia = (Utils.TOINT(existenciaMaskedTextBox.Text));
            articulo.FechaIngreso = fechaIngresoDateTimePicker.Value.Date;
            articulo.PrecioVenta = precioVentaMaskedTextBox.Text;
            articulo.PrecioCompra = precioCompraMaskedTextBox.Text;
            articulo.CodigoArticulo = codigoArticuloMaskedTextBox.Text;
            string categoria = categoriaComboBox.SelectedValue.ToString();
            articulo.Categoria = categoria;
            articulo.ITBS = iTBSMaskedTextBox.Text;

            return articulo;
        }

        private void Limpiar()
        {
            articulo = new Articulos();
            ArticulonumericUpDown.ResetText();
            nombreArticuloTextBox.Clear();
            existenciaMaskedTextBox.Clear();
            precioCompraMaskedTextBox.Clear();
            precioVentaMaskedTextBox.Clear();
            codigoArticuloMaskedTextBox.Clear();
            fechaIngresoDateTimePicker.Value = DateTime.Today;
            nombreArticuloTextBox.Focus();

            errorProviderCategoria.Clear();
            errorProviderITBS.Clear();
            errorProviderCodigoArticulo.Clear();
            errorProviderExistencia.Clear();
            errorProviderNombre.Clear();
            errorProviderPrecioCompra.Clear();
            errorProviderPrecioVenta.Clear();
        }

        private bool Validar()
        {
            bool retorno = true;
            if(string.IsNullOrWhiteSpace(nombreArticuloTextBox.Text))
            {
                errorProviderNombre.SetError(nombreArticuloTextBox, "Campo Obligatorio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(existenciaMaskedTextBox.Text))
            {
                errorProviderNombre.SetError(existenciaMaskedTextBox, "Campo Obligatorio");
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
            categoriaComboBox.DisplayMember = "ENLATADOS";

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
                    categoriaComboBox.Text = "OTROS";
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
            try
            {
                using (var db = new BLL.Repositorio<Articulos>())
                {   int id = 0;
                    
                    if (!Validar())
                    {
                        MessageBox.Show("Por favor llenar los campos");
                    }
                    else 
                    {

                        articulo = llenarCampos();

                        if (id != articulo.IdArticulo )
                    {
                        db.Modificar(articulo);
                    
                        MessageBox.Show("El articulo ha sido modificado");

                    }
                    else
                    {
                        BLL.RepositorioBLL.Guardar(articulo);
                        MessageBox.Show("El articulo ha sido Guardado");

                    }

                  }

                    Limpiar();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ArticulonumericUpDown.Text);
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
            int id = int.Parse(ArticulonumericUpDown.Text);
            Articulos articulo;
            using (var db = new BLL.Repositorio<Articulos>())
            {
                articulo = db.Buscar(p => p.IdArticulo == id);

                if (articulo != null)
                {
                     nombreArticuloTextBox.Text = articulo.NombreArticulo;
                     existenciaMaskedTextBox.Text = Convert.ToString( articulo.Existencia);
                     precioVentaMaskedTextBox.Text = Convert.ToString(articulo.PrecioVenta);
                     precioCompraMaskedTextBox.Text = Convert.ToString( articulo.PrecioCompra);
                     categoriaComboBox.Text = articulo.Categoria;
                     codigoArticuloMaskedTextBox.Text = Convert.ToString(articulo.CodigoArticulo);
                     fechaIngresoDateTimePicker.Text = Convert.ToString(articulo.FechaIngreso);
                      iTBSMaskedTextBox.Text = articulo.ITBS;
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
