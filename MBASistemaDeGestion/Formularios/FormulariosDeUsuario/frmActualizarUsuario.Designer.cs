
namespace MBASistemaDeGestion.Formularios.FormulariosDeUsuario
{
    partial class frmActualizarUsuario
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
            this.proveedor_de_errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBorrar = new System.Windows.Forms.Button();
            this.comboSeleccionarTipoDeUsuario = new System.Windows.Forms.ComboBox();
            this.textConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.textContraseñaActual = new System.Windows.Forms.TextBox();
            this.textNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.textNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.textCorreoElectronico = new System.Windows.Forms.TextBox();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCabecera = new System.Windows.Forms.Label();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadirTiposDeUsuario = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_de_errores)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedor_de_errores
            // 
            this.proveedor_de_errores.ContainerControl = this;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(220, 503);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(89, 40);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // comboSeleccionarTipoDeUsuario
            // 
            this.comboSeleccionarTipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeleccionarTipoDeUsuario.Enabled = false;
            this.comboSeleccionarTipoDeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSeleccionarTipoDeUsuario.FormattingEnabled = true;
            this.comboSeleccionarTipoDeUsuario.Location = new System.Drawing.Point(157, 117);
            this.comboSeleccionarTipoDeUsuario.Name = "comboSeleccionarTipoDeUsuario";
            this.comboSeleccionarTipoDeUsuario.Size = new System.Drawing.Size(185, 21);
            this.comboSeleccionarTipoDeUsuario.TabIndex = 14;
            // 
            // textConfirmarContraseña
            // 
            this.textConfirmarContraseña.Location = new System.Drawing.Point(157, 474);
            this.textConfirmarContraseña.Name = "textConfirmarContraseña";
            this.textConfirmarContraseña.PasswordChar = '*';
            this.textConfirmarContraseña.Size = new System.Drawing.Size(243, 20);
            this.textConfirmarContraseña.TabIndex = 6;
            // 
            // textContraseñaActual
            // 
            this.textContraseñaActual.Location = new System.Drawing.Point(157, 385);
            this.textContraseñaActual.Name = "textContraseñaActual";
            this.textContraseñaActual.PasswordChar = '*';
            this.textContraseñaActual.Size = new System.Drawing.Size(243, 20);
            this.textContraseñaActual.TabIndex = 4;
            // 
            // textNombreDeUsuario
            // 
            this.textNombreDeUsuario.Location = new System.Drawing.Point(157, 340);
            this.textNombreDeUsuario.Name = "textNombreDeUsuario";
            this.textNombreDeUsuario.Size = new System.Drawing.Size(243, 20);
            this.textNombreDeUsuario.TabIndex = 3;
            // 
            // textNumeroTelefonico
            // 
            this.textNumeroTelefonico.Location = new System.Drawing.Point(157, 198);
            this.textNumeroTelefonico.Name = "textNumeroTelefonico";
            this.textNumeroTelefonico.Size = new System.Drawing.Size(243, 20);
            this.textNumeroTelefonico.TabIndex = 1;
            // 
            // textCorreoElectronico
            // 
            this.textCorreoElectronico.Location = new System.Drawing.Point(157, 242);
            this.textCorreoElectronico.Name = "textCorreoElectronico";
            this.textCorreoElectronico.Size = new System.Drawing.Size(243, 20);
            this.textCorreoElectronico.TabIndex = 2;
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(157, 157);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(243, 20);
            this.textNombreCompleto.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Confirmar contraseña nueva:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Contraseña actual:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nombre de usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Número telefónico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Correo electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Seleccionar tipo de usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Actualizar nombre de usuario y contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Actualizar detalles personales";
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecera.Location = new System.Drawing.Point(49, 9);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(323, 29);
            this.lblCabecera.TabIndex = 15;
            this.lblCabecera.Text = "Actualizar perfil de usuario";
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(315, 503);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(89, 40);
            this.botonActualizar.TabIndex = 7;
            this.botonActualizar.Text = "Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(157, 429);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.PasswordChar = '*';
            this.textContraseña.Size = new System.Drawing.Size(243, 20);
            this.textContraseña.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Contraseña nueva:";
            // 
            // btnAñadirTiposDeUsuario
            // 
            this.btnAñadirTiposDeUsuario.BackgroundImage = global::MBASistemaDeGestion.Properties.Resources.personbutton;
            this.btnAñadirTiposDeUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAñadirTiposDeUsuario.Enabled = false;
            this.btnAñadirTiposDeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirTiposDeUsuario.Location = new System.Drawing.Point(374, 116);
            this.btnAñadirTiposDeUsuario.Name = "btnAñadirTiposDeUsuario";
            this.btnAñadirTiposDeUsuario.Size = new System.Drawing.Size(26, 25);
            this.btnAñadirTiposDeUsuario.TabIndex = 18;
            this.btnAñadirTiposDeUsuario.UseVisualStyleBackColor = true;
            this.btnAñadirTiposDeUsuario.Click += new System.EventHandler(this.btnAñadirTiposDeUsuario_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::MBASistemaDeGestion.Properties.Resources.actualizar_mas_pequeño;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Location = new System.Drawing.Point(346, 116);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(26, 25);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-7, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 10);
            this.panel1.TabIndex = 24;
            // 
            // frmActualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 554);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAñadirTiposDeUsuario);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.comboSeleccionarTipoDeUsuario);
            this.Controls.Add(this.textConfirmarContraseña);
            this.Controls.Add(this.textContraseñaActual);
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
            this.Name = "frmActualizarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar usuario";
            this.Load += new System.EventHandler(this.frmActualizarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_de_errores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider proveedor_de_errores;
        private System.Windows.Forms.Button btnAñadirTiposDeUsuario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox comboSeleccionarTipoDeUsuario;
        private System.Windows.Forms.TextBox textConfirmarContraseña;
        private System.Windows.Forms.TextBox textContraseñaActual;
        private System.Windows.Forms.TextBox textNombreDeUsuario;
        private System.Windows.Forms.TextBox textNumeroTelefonico;
        private System.Windows.Forms.TextBox textCorreoElectronico;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCabecera;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}