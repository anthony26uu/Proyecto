﻿namespace Login.UI.Registros
{
    partial class ConsultaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label precioVentaLabel;
            System.Windows.Forms.Label precioCompraLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label codigoArticuloLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label iTBSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaArticulo));
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.precioVentaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.precioCompraMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.codigoArticuloMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderExistencia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrecioVenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrecioCompra = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCodigoArticulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.existenciaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ArticulonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iTBSMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorProviderITBS = new System.Windows.Forms.ErrorProvider(this.components);
            idArticuloLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            precioVentaLabel = new System.Windows.Forms.Label();
            precioCompraLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            codigoArticuloLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            iTBSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigoArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticulonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderITBS)).BeginInit();
            this.SuspendLayout();
            // 
            // idArticuloLabel
            // 
            idArticuloLabel.AutoSize = true;
            idArticuloLabel.Location = new System.Drawing.Point(58, 96);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(57, 13);
            idArticuloLabel.TabIndex = 1;
            idArticuloLabel.Text = "Id Articulo:";
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.Location = new System.Drawing.Point(58, 122);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(85, 13);
            nombreArticuloLabel.TabIndex = 3;
            nombreArticuloLabel.Text = "Nombre Articulo:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(58, 148);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(58, 13);
            existenciaLabel.TabIndex = 5;
            existenciaLabel.Text = "Existencia:";
            // 
            // precioVentaLabel
            // 
            precioVentaLabel.AutoSize = true;
            precioVentaLabel.Location = new System.Drawing.Point(58, 174);
            precioVentaLabel.Name = "precioVentaLabel";
            precioVentaLabel.Size = new System.Drawing.Size(71, 13);
            precioVentaLabel.TabIndex = 7;
            precioVentaLabel.Text = "Precio Venta:";
            // 
            // precioCompraLabel
            // 
            precioCompraLabel.AutoSize = true;
            precioCompraLabel.Location = new System.Drawing.Point(58, 200);
            precioCompraLabel.Name = "precioCompraLabel";
            precioCompraLabel.Size = new System.Drawing.Size(79, 13);
            precioCompraLabel.TabIndex = 9;
            precioCompraLabel.Text = "Precio Compra:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(58, 226);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 11;
            categoriaLabel.Text = "Categoria:";
            // 
            // codigoArticuloLabel
            // 
            codigoArticuloLabel.AutoSize = true;
            codigoArticuloLabel.Location = new System.Drawing.Point(58, 253);
            codigoArticuloLabel.Name = "codigoArticuloLabel";
            codigoArticuloLabel.Size = new System.Drawing.Size(81, 13);
            codigoArticuloLabel.TabIndex = 13;
            codigoArticuloLabel.Text = "Codigo Articulo:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Location = new System.Drawing.Point(58, 280);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(78, 13);
            fechaIngresoLabel.TabIndex = 15;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(56, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 13);
            label1.TabIndex = 22;
            label1.Text = "REGISTRO ARTICULO";
            // 
            // iTBSLabel
            // 
            iTBSLabel.AutoSize = true;
            iTBSLabel.Location = new System.Drawing.Point(67, 314);
            iTBSLabel.Name = "iTBSLabel";
            iTBSLabel.Size = new System.Drawing.Size(34, 13);
            iTBSLabel.TabIndex = 26;
            iTBSLabel.Text = "ITBS:";
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(149, 119);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreArticuloTextBox.TabIndex = 4;
            // 
            // precioVentaMaskedTextBox
            // 
            this.precioVentaMaskedTextBox.Location = new System.Drawing.Point(149, 171);
            this.precioVentaMaskedTextBox.Mask = "99999";
            this.precioVentaMaskedTextBox.Name = "precioVentaMaskedTextBox";
            this.precioVentaMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioVentaMaskedTextBox.TabIndex = 8;
            this.precioVentaMaskedTextBox.ValidatingType = typeof(int);
            // 
            // precioCompraMaskedTextBox
            // 
            this.precioCompraMaskedTextBox.Location = new System.Drawing.Point(149, 197);
            this.precioCompraMaskedTextBox.Mask = "99999";
            this.precioCompraMaskedTextBox.Name = "precioCompraMaskedTextBox";
            this.precioCompraMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioCompraMaskedTextBox.TabIndex = 10;
            this.precioCompraMaskedTextBox.ValidatingType = typeof(int);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(149, 223);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoriaComboBox.TabIndex = 12;
            // 
            // codigoArticuloMaskedTextBox
            // 
            this.codigoArticuloMaskedTextBox.Location = new System.Drawing.Point(149, 250);
            this.codigoArticuloMaskedTextBox.Mask = "9-999999-999999";
            this.codigoArticuloMaskedTextBox.Name = "codigoArticuloMaskedTextBox";
            this.codigoArticuloMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoArticuloMaskedTextBox.TabIndex = 14;
            // 
            // fechaIngresoDateTimePicker
            // 
            this.fechaIngresoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIngresoDateTimePicker.Location = new System.Drawing.Point(149, 276);
            this.fechaIngresoDateTimePicker.Name = "fechaIngresoDateTimePicker";
            this.fechaIngresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaIngresoDateTimePicker.TabIndex = 16;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(272, 90);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 21;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(170, 359);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 20;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(276, 359);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 19;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(61, 359);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 18;
            this.buttonNuevo.Text = "NUEVO";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderExistencia
            // 
            this.errorProviderExistencia.ContainerControl = this;
            // 
            // errorProviderPrecioVenta
            // 
            this.errorProviderPrecioVenta.ContainerControl = this;
            // 
            // errorProviderPrecioCompra
            // 
            this.errorProviderPrecioCompra.ContainerControl = this;
            // 
            // errorProviderCategoria
            // 
            this.errorProviderCategoria.ContainerControl = this;
            // 
            // errorProviderCodigoArticulo
            // 
            this.errorProviderCodigoArticulo.ContainerControl = this;
            // 
            // existenciaMaskedTextBox
            // 
            this.existenciaMaskedTextBox.Location = new System.Drawing.Point(149, 145);
            this.existenciaMaskedTextBox.Mask = "99999";
            this.existenciaMaskedTextBox.Name = "existenciaMaskedTextBox";
            this.existenciaMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.existenciaMaskedTextBox.TabIndex = 24;
            this.existenciaMaskedTextBox.ValidatingType = typeof(int);
            // 
            // ArticulonumericUpDown
            // 
            this.ArticulonumericUpDown.Location = new System.Drawing.Point(149, 90);
            this.ArticulonumericUpDown.Name = "ArticulonumericUpDown";
            this.ArticulonumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ArticulonumericUpDown.TabIndex = 25;
            // 
            // iTBSMaskedTextBox
            // 
            this.iTBSMaskedTextBox.Location = new System.Drawing.Point(149, 311);
            this.iTBSMaskedTextBox.Mask = "99999";
            this.iTBSMaskedTextBox.Name = "iTBSMaskedTextBox";
            this.iTBSMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.iTBSMaskedTextBox.TabIndex = 27;
            this.iTBSMaskedTextBox.ValidatingType = typeof(int);
            // 
            // errorProviderITBS
            // 
            this.errorProviderITBS.ContainerControl = this;
            // 
            // ConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 466);
            this.Controls.Add(iTBSLabel);
            this.Controls.Add(this.iTBSMaskedTextBox);
            this.Controls.Add(this.ArticulonumericUpDown);
            this.Controls.Add(this.existenciaMaskedTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(idArticuloLabel);
            this.Controls.Add(nombreArticuloLabel);
            this.Controls.Add(this.nombreArticuloTextBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(precioVentaLabel);
            this.Controls.Add(this.precioVentaMaskedTextBox);
            this.Controls.Add(precioCompraLabel);
            this.Controls.Add(this.precioCompraMaskedTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(codigoArticuloLabel);
            this.Controls.Add(this.codigoArticuloMaskedTextBox);
            this.Controls.Add(fechaIngresoLabel);
            this.Controls.Add(this.fechaIngresoDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaArticulo";
            this.Text = "RegistroArticulo";
            this.Load += new System.EventHandler(this.RegistroArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigoArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticulonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderITBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.MaskedTextBox precioVentaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox precioCompraMaskedTextBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.MaskedTextBox codigoArticuloMaskedTextBox;
        private System.Windows.Forms.DateTimePicker fechaIngresoDateTimePicker;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderExistencia;
        private System.Windows.Forms.ErrorProvider errorProviderPrecioVenta;
        private System.Windows.Forms.ErrorProvider errorProviderPrecioCompra;
        private System.Windows.Forms.ErrorProvider errorProviderCategoria;
        private System.Windows.Forms.ErrorProvider errorProviderCodigoArticulo;
        private System.Windows.Forms.MaskedTextBox existenciaMaskedTextBox;
        private System.Windows.Forms.NumericUpDown ArticulonumericUpDown;
        private System.Windows.Forms.MaskedTextBox iTBSMaskedTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderITBS;
    }
}