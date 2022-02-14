
namespace MBASistemaDeGestion.Formularios.FormulariosDeExistencia
{
    partial class frmProductos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAñadirCategoria = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.comboSeleccionarCategoria = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeFabricacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDeCaducacion = new System.Windows.Forms.DateTimePicker();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textUmbralDeCantidadDeExistencia = new System.Windows.Forms.TextBox();
            this.textPrecioUnitarioDeCompraActual = new System.Windows.Forms.TextBox();
            this.textPrecioUnitarioDeVenta = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textNombreDelProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaDeProductos = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.historialDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.proveedor_de_errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeProductos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_de_errores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAñadirCategoria);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.comboSeleccionarCategoria);
            this.groupBox1.Controls.Add(this.dtpFechaDeFabricacion);
            this.groupBox1.Controls.Add(this.dtpFechaDeCaducacion);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.textUmbralDeCantidadDeExistencia);
            this.groupBox1.Controls.Add(this.textPrecioUnitarioDeCompraActual);
            this.groupBox1.Controls.Add(this.textPrecioUnitarioDeVenta);
            this.groupBox1.Controls.Add(this.textCantidad);
            this.groupBox1.Controls.Add(this.textNombreDelProducto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1064, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar detalles del producto";
            // 
            // btnAñadirCategoria
            // 
            this.btnAñadirCategoria.BackgroundImage = global::MBASistemaDeGestion.Properties.Resources.personbutton;
            this.btnAñadirCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAñadirCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirCategoria.Location = new System.Drawing.Point(473, 48);
            this.btnAñadirCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadirCategoria.Name = "btnAñadirCategoria";
            this.btnAñadirCategoria.Size = new System.Drawing.Size(35, 31);
            this.btnAñadirCategoria.TabIndex = 19;
            this.btnAñadirCategoria.UseVisualStyleBackColor = true;
            this.btnAñadirCategoria.Click += new System.EventHandler(this.btnAñadirCategoria_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::MBASistemaDeGestion.Properties.Resources.actualizar_mas_pequeño;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Location = new System.Drawing.Point(436, 48);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(35, 31);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // comboSeleccionarCategoria
            // 
            this.comboSeleccionarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeleccionarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSeleccionarCategoria.FormattingEnabled = true;
            this.comboSeleccionarCategoria.Location = new System.Drawing.Point(184, 49);
            this.comboSeleccionarCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSeleccionarCategoria.Name = "comboSeleccionarCategoria";
            this.comboSeleccionarCategoria.Size = new System.Drawing.Size(245, 24);
            this.comboSeleccionarCategoria.TabIndex = 17;
            // 
            // dtpFechaDeFabricacion
            // 
            this.dtpFechaDeFabricacion.CustomFormat = "dd MMMM yyyy";
            this.dtpFechaDeFabricacion.Enabled = false;
            this.dtpFechaDeFabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDeFabricacion.Location = new System.Drawing.Point(721, 100);
            this.dtpFechaDeFabricacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDeFabricacion.Name = "dtpFechaDeFabricacion";
            this.dtpFechaDeFabricacion.Size = new System.Drawing.Size(307, 22);
            this.dtpFechaDeFabricacion.TabIndex = 16;
            // 
            // dtpFechaDeCaducacion
            // 
            this.dtpFechaDeCaducacion.CustomFormat = "dd MMMM yyyy";
            this.dtpFechaDeCaducacion.Enabled = false;
            this.dtpFechaDeCaducacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDeCaducacion.Location = new System.Drawing.Point(721, 46);
            this.dtpFechaDeCaducacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDeCaducacion.Name = "dtpFechaDeCaducacion";
            this.dtpFechaDeCaducacion.Size = new System.Drawing.Size(307, 22);
            this.dtpFechaDeCaducacion.TabIndex = 15;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(557, 180);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(471, 184);
            this.textDescripcion.TabIndex = 11;
            // 
            // textUmbralDeCantidadDeExistencia
            // 
            this.textUmbralDeCantidadDeExistencia.Enabled = false;
            this.textUmbralDeCantidadDeExistencia.Location = new System.Drawing.Point(244, 338);
            this.textUmbralDeCantidadDeExistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUmbralDeCantidadDeExistencia.Name = "textUmbralDeCantidadDeExistencia";
            this.textUmbralDeCantidadDeExistencia.Size = new System.Drawing.Size(261, 22);
            this.textUmbralDeCantidadDeExistencia.TabIndex = 14;
            this.textUmbralDeCantidadDeExistencia.Text = "10";
            // 
            // textPrecioUnitarioDeCompraActual
            // 
            this.textPrecioUnitarioDeCompraActual.Enabled = false;
            this.textPrecioUnitarioDeCompraActual.Location = new System.Drawing.Point(244, 281);
            this.textPrecioUnitarioDeCompraActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPrecioUnitarioDeCompraActual.Name = "textPrecioUnitarioDeCompraActual";
            this.textPrecioUnitarioDeCompraActual.Size = new System.Drawing.Size(261, 22);
            this.textPrecioUnitarioDeCompraActual.TabIndex = 13;
            this.textPrecioUnitarioDeCompraActual.Text = "0";
            // 
            // textPrecioUnitarioDeVenta
            // 
            this.textPrecioUnitarioDeVenta.Enabled = false;
            this.textPrecioUnitarioDeVenta.Location = new System.Drawing.Point(184, 223);
            this.textPrecioUnitarioDeVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPrecioUnitarioDeVenta.Name = "textPrecioUnitarioDeVenta";
            this.textPrecioUnitarioDeVenta.Size = new System.Drawing.Size(321, 22);
            this.textPrecioUnitarioDeVenta.TabIndex = 12;
            this.textPrecioUnitarioDeVenta.Text = "0";
            // 
            // textCantidad
            // 
            this.textCantidad.Enabled = false;
            this.textCantidad.Location = new System.Drawing.Point(184, 165);
            this.textCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(323, 22);
            this.textCantidad.TabIndex = 11;
            this.textCantidad.Text = "0";
            // 
            // textNombreDelProducto
            // 
            this.textNombreDelProducto.Location = new System.Drawing.Point(184, 107);
            this.textNombreDelProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNombreDelProducto.Name = "textNombreDelProducto";
            this.textNombreDelProducto.Size = new System.Drawing.Size(323, 22);
            this.textNombreDelProducto.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Descripción :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 342);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Umbral de cantidad de existencia :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de fabricación :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de caducación :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio unitario de compra actual :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio unitario de venta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del producto :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar categoria :";
            // 
            // dgvListaDeProductos
            // 
            this.dgvListaDeProductos.AllowUserToAddRows = false;
            this.dgvListaDeProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaDeProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListaDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeProductos.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListaDeProductos.Location = new System.Drawing.Point(16, 474);
            this.dgvListaDeProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaDeProductos.MultiSelect = false;
            this.dgvListaDeProductos.Name = "dgvListaDeProductos";
            this.dgvListaDeProductos.ReadOnly = true;
            this.dgvListaDeProductos.RowHeadersVisible = false;
            this.dgvListaDeProductos.RowHeadersWidth = 51;
            this.dgvListaDeProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaDeProductos.Size = new System.Drawing.Size(1611, 260);
            this.dgvListaDeProductos.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.historialDeProductoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 110);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // historialDeProductoToolStripMenuItem
            // 
            this.historialDeProductoToolStripMenuItem.Name = "historialDeProductoToolStripMenuItem";
            this.historialDeProductoToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.historialDeProductoToolStripMenuItem.Text = "Historial de Productos";
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(97, 428);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(981, 22);
            this.textBusqueda.TabIndex = 12;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 432);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Búsqueda:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(1224, 356);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 49);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(1104, 356);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 49);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1104, 266);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 49);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1104, 177);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 49);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(1459, 401);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(168, 47);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir catalogo";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // proveedor_de_errores
            // 
            this.proveedor_de_errores.ContainerControl = this;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 753);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvListaDeProductos);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProductos";
            this.Text = "Detalles de existencias";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeProductos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_de_errores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUmbralDeCantidadDeExistencia;
        private System.Windows.Forms.TextBox textPrecioUnitarioDeCompraActual;
        private System.Windows.Forms.TextBox textPrecioUnitarioDeVenta;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textNombreDelProducto;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaDeCaducacion;
        private System.Windows.Forms.DateTimePicker dtpFechaDeFabricacion;
        private System.Windows.Forms.DataGridView dgvListaDeProductos;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialDeProductoToolStripMenuItem;
        private System.Windows.Forms.Button btnAñadirCategoria;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox comboSeleccionarCategoria;
        private System.Windows.Forms.ErrorProvider proveedor_de_errores;
    }
}