
namespace MBASistemaDeGestion.Formularios.FormulariosDeUsuario
{
    partial class frmAñadirUsuarios
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
            this.lblCabecera = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.textCorreoElectronico = new System.Windows.Forms.TextBox();
            this.textNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.textNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.comboSeleccionarTipoDeUsuario = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAñadirTiposDeUsuario = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.proveedor_de_errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_de_errores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecera.Location = new System.Drawing.Point(109, 9);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(213, 29);
            this.lblCabecera.TabIndex = 0;
            this.lblCabecera.Text = "Registrar usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar detalles personales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar nombre de usuario y contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccionar tipo de usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre completo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Correo electrónico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Número telefónico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre de usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Contraseña:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Confirmar contraseña:";
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(149, 157);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(243, 20);
            this.textNombreCompleto.TabIndex = 3;
            // 
            // textCorreoElectronico
            // 
            this.textCorreoElectronico.Location = new System.Drawing.Point(149, 250);
            this.textCorreoElectronico.Name = "textCorreoElectronico";
            this.textCorreoElectronico.Size = new System.Drawing.Size(243, 20);
            this.textCorreoElectronico.TabIndex = 5;
            // 
            // textNumeroTelefonico
            // 
            this.textNumeroTelefonico.Location = new System.Drawing.Point(149, 205);
            this.textNumeroTelefonico.Name = "textNumeroTelefonico";
            this.textNumeroTelefonico.Size = new System.Drawing.Size(243, 20);
            this.textNumeroTelefonico.TabIndex = 4;
            // 
            // textNombreDeUsuario
            // 
            this.textNombreDeUsuario.Location = new System.Drawing.Point(149, 340);
            this.textNombreDeUsuario.Name = "textNombreDeUsuario";
            this.textNombreDeUsuario.Size = new System.Drawing.Size(243, 20);
            this.textNombreDeUsuario.TabIndex = 6;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(149, 385);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.PasswordChar = '*';
            this.textContraseña.Size = new System.Drawing.Size(243, 20);
            this.textContraseña.TabIndex = 7;
            // 
            // textConfirmarContraseña
            // 
            this.textConfirmarContraseña.Location = new System.Drawing.Point(149, 430);
            this.textConfirmarContraseña.Name = "textConfirmarContraseña";
            this.textConfirmarContraseña.PasswordChar = '*';
            this.textConfirmarContraseña.Size = new System.Drawing.Size(243, 20);
            this.textConfirmarContraseña.TabIndex = 8;
            // 
            // comboSeleccionarTipoDeUsuario
            // 
            this.comboSeleccionarTipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeleccionarTipoDeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSeleccionarTipoDeUsuario.FormattingEnabled = true;
            this.comboSeleccionarTipoDeUsuario.Location = new System.Drawing.Point(149, 117);
            this.comboSeleccionarTipoDeUsuario.Name = "comboSeleccionarTipoDeUsuario";
            this.comboSeleccionarTipoDeUsuario.Size = new System.Drawing.Size(185, 21);
            this.comboSeleccionarTipoDeUsuario.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(303, 456);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 40);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(208, 456);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(89, 40);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAñadirTiposDeUsuario
            // 
            this.btnAñadirTiposDeUsuario.BackgroundImage = global::MBASistemaDeGestion.Properties.Resources.personbutton;
            this.btnAñadirTiposDeUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAñadirTiposDeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirTiposDeUsuario.Location = new System.Drawing.Point(366, 116);
            this.btnAñadirTiposDeUsuario.Name = "btnAñadirTiposDeUsuario";
            this.btnAñadirTiposDeUsuario.Size = new System.Drawing.Size(26, 25);
            this.btnAñadirTiposDeUsuario.TabIndex = 2;
            this.btnAñadirTiposDeUsuario.UseVisualStyleBackColor = true;
            this.btnAñadirTiposDeUsuario.Click += new System.EventHandler(this.btnAñadirTiposDeUsuario_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::MBASistemaDeGestion.Properties.Resources.actualizar_mas_pequeño;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Location = new System.Drawing.Point(338, 116);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(26, 25);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // proveedor_de_errores
            // 
            this.proveedor_de_errores.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-13, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 10);
            this.panel1.TabIndex = 6;
            // 
            // frmAñadirUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 509);
            this.Controls.Add(this.btnAñadirTiposDeUsuario);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.comboSeleccionarTipoDeUsuario);
            this.Controls.Add(this.textConfirmarContraseña);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textNombreDeUsuario);
            this.Controls.Add(this.textNumeroTelefonico);
            this.Controls.Add(this.textCorreoElectronico);
            this.Controls.Add(this.textNombreCompleto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAñadirUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar usuario";
            this.Load += new System.EventHandler(this.frmAñadirUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_de_errores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCabecera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.TextBox textCorreoElectronico;
        private System.Windows.Forms.TextBox textNumeroTelefonico;
        private System.Windows.Forms.TextBox textNombreDeUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textConfirmarContraseña;
        private System.Windows.Forms.ComboBox comboSeleccionarTipoDeUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAñadirTiposDeUsuario;
        private System.Windows.Forms.ErrorProvider proveedor_de_errores;
        private System.Windows.Forms.Panel panel1;
    }
}