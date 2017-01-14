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
            this.Cuenta = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.texPass = new System.Windows.Forms.TextBox();
            this.texCuenta = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cuenta
            // 
            this.Cuenta.AutoSize = true;
            this.Cuenta.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuenta.Location = new System.Drawing.Point(53, 166);
            this.Cuenta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Size = new System.Drawing.Size(60, 18);
            this.Cuenta.TabIndex = 0;
            this.Cuenta.Text = "Account";
            this.Cuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(159, 296);
            this.Login.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(156, 33);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(566, 376);
            this.Exit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(39, 42);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // texPass
            // 
            this.texPass.Location = new System.Drawing.Point(159, 208);
            this.texPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.texPass.Name = "texPass";
            this.texPass.Size = new System.Drawing.Size(156, 30);
            this.texPass.TabIndex = 3;
            this.texPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // texCuenta
            // 
            this.texCuenta.Location = new System.Drawing.Point(159, 166);
            this.texCuenta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.texCuenta.Name = "texCuenta";
            this.texCuenta.Size = new System.Drawing.Size(156, 30);
            this.texCuenta.TabIndex = 4;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(53, 220);
            this.Pass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(68, 18);
            this.Pass.TabIndex = 5;
            this.Pass.Text = "Password";
            this.Pass.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 132);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 247);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 28);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 433);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.texCuenta);
            this.Controls.Add(this.texPass);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Cuenta);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cuenta;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox texPass;
        private System.Windows.Forms.TextBox texCuenta;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

