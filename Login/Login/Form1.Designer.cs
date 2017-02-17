namespace Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.texPass = new System.Windows.Forms.TextBox();
            this.texCuenta = new System.Windows.Forms.TextBox();
            this.labelHORA = new System.Windows.Forms.Label();
            this.timer1Hora = new System.Windows.Forms.Timer(this.components);
            this.labelFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(120, 228);
            this.Login.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(69, 34);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(277, 369);
            this.Exit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(54, 34);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "E";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Info;
            this.checkBox1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(100, 197);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(98, 293);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CREATE ACCOUNT";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // texPass
            // 
            this.texPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texPass.Location = new System.Drawing.Point(85, 158);
            this.texPass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.texPass.Name = "texPass";
            this.texPass.Size = new System.Drawing.Size(140, 25);
            this.texPass.TabIndex = 3;
            this.texPass.Text = "Contraseña";
            this.texPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // texCuenta
            // 
            this.texCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texCuenta.Location = new System.Drawing.Point(85, 111);
            this.texCuenta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.texCuenta.Name = "texCuenta";
            this.texCuenta.Size = new System.Drawing.Size(140, 25);
            this.texCuenta.TabIndex = 4;
            this.texCuenta.Text = "Usuario";
            // 
            // labelHORA
            // 
            this.labelHORA.AutoSize = true;
            this.labelHORA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHORA.Location = new System.Drawing.Point(11, 383);
            this.labelHORA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHORA.Name = "labelHORA";
            this.labelHORA.Size = new System.Drawing.Size(46, 20);
            this.labelHORA.TabIndex = 9;
            this.labelHORA.Text = "HORA";
            this.labelHORA.Click += new System.EventHandler(this.labelHORA_Click);
            // 
            // timer1Hora
            // 
            this.timer1Hora.Tick += new System.EventHandler(this.timer1Hora_Tick);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(11, 9);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(45, 20);
            this.labelFecha.TabIndex = 10;
            this.labelFecha.Text = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 412);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelHORA);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.texCuenta);
            this.Controls.Add(this.texPass);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox texPass;
        private System.Windows.Forms.TextBox texCuenta;
        private System.Windows.Forms.Label labelHORA;
        private System.Windows.Forms.Timer timer1Hora;
        private System.Windows.Forms.Label labelFecha;
    }
}

