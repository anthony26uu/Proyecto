namespace Login.UI.Registros
{
    partial class RegistroEmpleados
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
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label nombreEmpleadoLabel;
            System.Windows.Forms.Label telefonoEmpleadoLabel;
            System.Windows.Forms.Label fechaContratacionLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label cargoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEmpleados));
            this.idEmpleadoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoEmpleadoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.salarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.fechaContratacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSalario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCargo = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            nombreEmpleadoLabel = new System.Windows.Forms.Label();
            telefonoEmpleadoLabel = new System.Windows.Forms.Label();
            fechaContratacionLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idEmpleadoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Location = new System.Drawing.Point(63, 89);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(69, 13);
            idEmpleadoLabel.TabIndex = 1;
            idEmpleadoLabel.Text = "Id Empleado:";
            // 
            // nombreEmpleadoLabel
            // 
            nombreEmpleadoLabel.AutoSize = true;
            nombreEmpleadoLabel.Location = new System.Drawing.Point(63, 118);
            nombreEmpleadoLabel.Name = "nombreEmpleadoLabel";
            nombreEmpleadoLabel.Size = new System.Drawing.Size(97, 13);
            nombreEmpleadoLabel.TabIndex = 3;
            nombreEmpleadoLabel.Text = "Nombre Empleado:";
            // 
            // telefonoEmpleadoLabel
            // 
            telefonoEmpleadoLabel.AutoSize = true;
            telefonoEmpleadoLabel.Location = new System.Drawing.Point(63, 144);
            telefonoEmpleadoLabel.Name = "telefonoEmpleadoLabel";
            telefonoEmpleadoLabel.Size = new System.Drawing.Size(102, 13);
            telefonoEmpleadoLabel.TabIndex = 5;
            telefonoEmpleadoLabel.Text = "Telefono Empleado:";
            // 
            // fechaContratacionLabel
            // 
            fechaContratacionLabel.AutoSize = true;
            fechaContratacionLabel.Location = new System.Drawing.Point(63, 171);
            fechaContratacionLabel.Name = "fechaContratacionLabel";
            fechaContratacionLabel.Size = new System.Drawing.Size(103, 13);
            fechaContratacionLabel.TabIndex = 7;
            fechaContratacionLabel.Text = "Fecha Contratacion:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(63, 202);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 9;
            direccionLabel.Text = "Direccion:";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(63, 249);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(42, 13);
            salarioLabel.TabIndex = 11;
            salarioLabel.Text = "Salario:";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Location = new System.Drawing.Point(63, 275);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(38, 13);
            cargoLabel.TabIndex = 13;
            cargoLabel.Text = "Cargo:";
            // 
            // idEmpleadoNumericUpDown
            // 
            this.idEmpleadoNumericUpDown.Location = new System.Drawing.Point(172, 89);
            this.idEmpleadoNumericUpDown.Name = "idEmpleadoNumericUpDown";
            this.idEmpleadoNumericUpDown.Size = new System.Drawing.Size(99, 20);
            this.idEmpleadoNumericUpDown.TabIndex = 2;
            // 
            // nombreEmpleadoTextBox
            // 
            this.nombreEmpleadoTextBox.Location = new System.Drawing.Point(172, 115);
            this.nombreEmpleadoTextBox.Name = "nombreEmpleadoTextBox";
            this.nombreEmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreEmpleadoTextBox.TabIndex = 4;
            // 
            // telefonoEmpleadoMaskedTextBox
            // 
            this.telefonoEmpleadoMaskedTextBox.Location = new System.Drawing.Point(172, 141);
            this.telefonoEmpleadoMaskedTextBox.Mask = "(999)000-0000";
            this.telefonoEmpleadoMaskedTextBox.Name = "telefonoEmpleadoMaskedTextBox";
            this.telefonoEmpleadoMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoEmpleadoMaskedTextBox.TabIndex = 6;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(172, 199);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 41);
            this.direccionTextBox.TabIndex = 10;
            // 
            // salarioMaskedTextBox
            // 
            this.salarioMaskedTextBox.Location = new System.Drawing.Point(172, 246);
            this.salarioMaskedTextBox.Mask = "99999";
            this.salarioMaskedTextBox.Name = "salarioMaskedTextBox";
            this.salarioMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.salarioMaskedTextBox.TabIndex = 12;
            this.salarioMaskedTextBox.ValidatingType = typeof(int);
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.Location = new System.Drawing.Point(172, 272);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(200, 20);
            this.cargoTextBox.TabIndex = 14;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(297, 89);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 26;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(194, 313);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 25;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(300, 313);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 24;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(85, 313);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 23;
            this.buttonNuevo.Text = "NUEVO";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // fechaContratacionDateTimePicker
            // 
            this.fechaContratacionDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaContratacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaContratacionDateTimePicker.Location = new System.Drawing.Point(172, 167);
            this.fechaContratacionDateTimePicker.Name = "fechaContratacionDateTimePicker";
            this.fechaContratacionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaContratacionDateTimePicker.TabIndex = 22;
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderTelefono
            // 
            this.errorProviderTelefono.ContainerControl = this;
            // 
            // errorProviderDireccion
            // 
            this.errorProviderDireccion.ContainerControl = this;
            // 
            // errorProviderSalario
            // 
            this.errorProviderSalario.ContainerControl = this;
            // 
            // errorProviderCargo
            // 
            this.errorProviderCargo.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "REGISTRO EMPLEADOS";
            // 
            // RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.fechaContratacionDateTimePicker);
            this.Controls.Add(idEmpleadoLabel);
            this.Controls.Add(this.idEmpleadoNumericUpDown);
            this.Controls.Add(nombreEmpleadoLabel);
            this.Controls.Add(this.nombreEmpleadoTextBox);
            this.Controls.Add(telefonoEmpleadoLabel);
            this.Controls.Add(this.telefonoEmpleadoMaskedTextBox);
            this.Controls.Add(fechaContratacionLabel);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioMaskedTextBox);
            this.Controls.Add(cargoLabel);
            this.Controls.Add(this.cargoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroEmpleados";
            this.Text = "REGISTRO EMPLEADOS";
            this.Load += new System.EventHandler(this.RegistroEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idEmpleadoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown idEmpleadoNumericUpDown;
        private System.Windows.Forms.TextBox nombreEmpleadoTextBox;
        private System.Windows.Forms.MaskedTextBox telefonoEmpleadoMaskedTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.MaskedTextBox salarioMaskedTextBox;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.DateTimePicker fechaContratacionDateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderTelefono;
        private System.Windows.Forms.ErrorProvider errorProviderDireccion;
        private System.Windows.Forms.ErrorProvider errorProviderSalario;
        private System.Windows.Forms.ErrorProvider errorProviderCargo;
        private System.Windows.Forms.Label label1;
    }
}