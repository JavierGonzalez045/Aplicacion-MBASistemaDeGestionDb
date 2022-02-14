
namespace MBASistemaDeGestion.Formularios.FormulariosDeCompra
{
    partial class frmFormularioDeCompras
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBProveedor = new System.Windows.Forms.GroupBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAñadirProveedor = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCarritoDeCompras = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaDeExpiracion = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtpFechaDeFabricacion = new System.Windows.Forms.DateTimePicker();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textCantidadUmbral = new System.Windows.Forms.TextBox();
            this.textPrecioDeVentaPorUnidad = new System.Windows.Forms.TextBox();
            this.textPrecioDeCompraPorUnidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textCantidadDeCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTodasLasCuentas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboSeleccionarCategoria = new System.Windows.Forms.ComboBox();
            this.comboSeleccionarProducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelMontoTotal = new System.Windows.Forms.Label();
            this.checkBoxFacturaDePago = new System.Windows.Forms.CheckBox();
            this.btnIniciarNuevaCompra = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.proveedor_de_errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.colCategoriaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioDeCompraPorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioDeVentaPorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadUmbral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostoDelArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDeFabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDeExpiracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelMontoPagado = new System.Windows.Forms.Label();
            this.labelMontoRestante = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBProveedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoDeCompras)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_de_errores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(319, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Factura De Compra";
            // 
            // groupBProveedor
            // 
            this.groupBProveedor.Controls.Add(this.labelProveedor);
            this.groupBProveedor.Controls.Add(this.label3);
            this.groupBProveedor.Controls.Add(this.btnAñadirProveedor);
            this.groupBProveedor.Controls.Add(this.btnBuscarProveedor);
            this.groupBProveedor.Controls.Add(this.textBusqueda);
            this.groupBProveedor.Controls.Add(this.label2);
            this.groupBProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBProveedor.Location = new System.Drawing.Point(24, 138);
            this.groupBProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBProveedor.Name = "groupBProveedor";
            this.groupBProveedor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBProveedor.Size = new System.Drawing.Size(501, 165);
            this.groupBProveedor.TabIndex = 1;
            this.groupBProveedor.TabStop = false;
            this.groupBProveedor.Text = "Seleccionar Proveedor";
            // 
            // labelProveedor
            // 
            this.labelProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.Location = new System.Drawing.Point(175, 115);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(295, 23);
            this.labelProveedor.TabIndex = 6;
            this.labelProveedor.Text = " ";
            this.labelProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccionar Proveedor : ";
            // 
            // btnAñadirProveedor
            // 
            this.btnAñadirProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirProveedor.Location = new System.Drawing.Point(440, 54);
            this.btnAñadirProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirProveedor.Name = "btnAñadirProveedor";
            this.btnAñadirProveedor.Size = new System.Drawing.Size(32, 26);
            this.btnAñadirProveedor.TabIndex = 4;
            this.btnAñadirProveedor.Text = "+";
            this.btnAñadirProveedor.UseVisualStyleBackColor = true;
            this.btnAñadirProveedor.Click += new System.EventHandler(this.btnAñadirProveedor_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackgroundImage = global::MBASistemaDeGestion.Properties.Resources.busqueda_de_lupa;
            this.btnBuscarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(406, 54);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(32, 26);
            this.btnBuscarProveedor.TabIndex = 3;
            this.btnBuscarProveedor.Text = " ";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.Location = new System.Drawing.Point(152, 54);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(252, 24);
            this.textBusqueda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Proveedor : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCarritoDeCompras);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(537, 139);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(617, 431);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrito De Compras";
            // 
            // dgvCarritoDeCompras
            // 
            this.dgvCarritoDeCompras.AllowUserToAddRows = false;
            this.dgvCarritoDeCompras.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCarritoDeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarritoDeCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategoriaD,
            this.colCategoria,
            this.colProductoID,
            this.colProducto,
            this.colCuenta,
            this.colCantidadDeCompra,
            this.colPrecioDeCompraPorUnidad,
            this.colPrecioDeVentaPorUnidad,
            this.colCantidadUmbral,
            this.colCostoDelArticulo,
            this.colFechaDeFabricacion,
            this.colFechaDeExpiracion});
            this.dgvCarritoDeCompras.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCarritoDeCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarritoDeCompras.Location = new System.Drawing.Point(3, 18);
            this.dgvCarritoDeCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCarritoDeCompras.MultiSelect = false;
            this.dgvCarritoDeCompras.Name = "dgvCarritoDeCompras";
            this.dgvCarritoDeCompras.ReadOnly = true;
            this.dgvCarritoDeCompras.RowHeadersVisible = false;
            this.dgvCarritoDeCompras.RowHeadersWidth = 51;
            this.dgvCarritoDeCompras.RowTemplate.Height = 24;
            this.dgvCarritoDeCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarritoDeCompras.Size = new System.Drawing.Size(611, 411);
            this.dgvCarritoDeCompras.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.dtpFechaDeExpiracion);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Controls.Add(this.dtpFechaDeFabricacion);
            this.groupBox3.Controls.Add(this.btnBorrar);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textCantidadUmbral);
            this.groupBox3.Controls.Add(this.textPrecioDeVentaPorUnidad);
            this.groupBox3.Controls.Add(this.textPrecioDeCompraPorUnidad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textCantidadDeCompra);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboTodasLasCuentas);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboSeleccionarCategoria);
            this.groupBox3.Controls.Add(this.comboSeleccionarProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 306);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(501, 523);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles Del Producto";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::MBASistemaDeGestion.Properties.Resources.actualizar_mas_pequeño;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Location = new System.Drawing.Point(194, 70);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(30, 24);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(364, 462);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaDeExpiracion
            // 
            this.dtpFechaDeExpiracion.CustomFormat = "dd MMMM, yyyy";
            this.dtpFechaDeExpiracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDeExpiracion.Location = new System.Drawing.Point(271, 406);
            this.dtpFechaDeExpiracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDeExpiracion.Name = "dtpFechaDeExpiracion";
            this.dtpFechaDeExpiracion.Size = new System.Drawing.Size(193, 22);
            this.dtpFechaDeExpiracion.TabIndex = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(256, 462);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtpFechaDeFabricacion
            // 
            this.dtpFechaDeFabricacion.CustomFormat = "dd MMMM, yyyy";
            this.dtpFechaDeFabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDeFabricacion.Location = new System.Drawing.Point(22, 406);
            this.dtpFechaDeFabricacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDeFabricacion.Name = "dtpFechaDeFabricacion";
            this.dtpFechaDeFabricacion.Size = new System.Drawing.Size(207, 22);
            this.dtpFechaDeFabricacion.TabIndex = 29;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(149, 462);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 28;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(268, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Fecha De Expiración";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(41, 462);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(19, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha De Fabricación";
            // 
            // textCantidadUmbral
            // 
            this.textCantidadUmbral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidadUmbral.Location = new System.Drawing.Point(347, 311);
            this.textCantidadUmbral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCantidadUmbral.Name = "textCantidadUmbral";
            this.textCantidadUmbral.Size = new System.Drawing.Size(117, 28);
            this.textCantidadUmbral.TabIndex = 20;
            this.textCantidadUmbral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidadDeCompra_KeyPress);
            // 
            // textPrecioDeVentaPorUnidad
            // 
            this.textPrecioDeVentaPorUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioDeVentaPorUnidad.Location = new System.Drawing.Point(183, 311);
            this.textPrecioDeVentaPorUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPrecioDeVentaPorUnidad.Name = "textPrecioDeVentaPorUnidad";
            this.textPrecioDeVentaPorUnidad.Size = new System.Drawing.Size(120, 28);
            this.textPrecioDeVentaPorUnidad.TabIndex = 19;
            this.textPrecioDeVentaPorUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecioDeCompraPorUnidad_KeyPress);
            // 
            // textPrecioDeCompraPorUnidad
            // 
            this.textPrecioDeCompraPorUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioDeCompraPorUnidad.Location = new System.Drawing.Point(21, 311);
            this.textPrecioDeCompraPorUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPrecioDeCompraPorUnidad.Name = "textPrecioDeCompraPorUnidad";
            this.textPrecioDeCompraPorUnidad.Size = new System.Drawing.Size(132, 28);
            this.textPrecioDeCompraPorUnidad.TabIndex = 18;
            this.textPrecioDeCompraPorUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecioDeCompraPorUnidad_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(341, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cantidad Umbral";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(188, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Precio De Venta ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(19, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Precio  De Compra";
            // 
            // textCantidadDeCompra
            // 
            this.textCantidadDeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidadDeCompra.Location = new System.Drawing.Point(183, 201);
            this.textCantidadDeCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCantidadDeCompra.Name = "textCantidadDeCompra";
            this.textCantidadDeCompra.Size = new System.Drawing.Size(279, 28);
            this.textCantidadDeCompra.TabIndex = 7;
            this.textCantidadDeCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidadDeCompra_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(19, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad De Compra : ";
            // 
            // comboTodasLasCuentas
            // 
            this.comboTodasLasCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTodasLasCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboTodasLasCuentas.FormattingEnabled = true;
            this.comboTodasLasCuentas.Location = new System.Drawing.Point(21, 156);
            this.comboTodasLasCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.comboTodasLasCuentas.Name = "comboTodasLasCuentas";
            this.comboTodasLasCuentas.Size = new System.Drawing.Size(441, 24);
            this.comboTodasLasCuentas.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(19, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccionar Cuenta : ";
            // 
            // comboSeleccionarCategoria
            // 
            this.comboSeleccionarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeleccionarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSeleccionarCategoria.FormattingEnabled = true;
            this.comboSeleccionarCategoria.Location = new System.Drawing.Point(21, 70);
            this.comboSeleccionarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.comboSeleccionarCategoria.Name = "comboSeleccionarCategoria";
            this.comboSeleccionarCategoria.Size = new System.Drawing.Size(170, 24);
            this.comboSeleccionarCategoria.TabIndex = 11;
            this.comboSeleccionarCategoria.SelectedIndexChanged += new System.EventHandler(this.comboSeleccionarCategoria_SelectedIndexChanged);
            // 
            // comboSeleccionarProducto
            // 
            this.comboSeleccionarProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeleccionarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSeleccionarProducto.FormattingEnabled = true;
            this.comboSeleccionarProducto.Location = new System.Drawing.Point(241, 70);
            this.comboSeleccionarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.comboSeleccionarProducto.Name = "comboSeleccionarProducto";
            this.comboSeleccionarProducto.Size = new System.Drawing.Size(223, 24);
            this.comboSeleccionarProducto.TabIndex = 10;
            this.comboSeleccionarProducto.SelectedIndexChanged += new System.EventHandler(this.comboSeleccionarProducto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label5.Location = new System.Drawing.Point(238, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seleccionar Producto : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(19, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccionar Categoria : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(537, 609);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Monto Total : ";
            // 
            // labelMontoTotal
            // 
            this.labelMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoTotal.Location = new System.Drawing.Point(633, 601);
            this.labelMontoTotal.Name = "labelMontoTotal";
            this.labelMontoTotal.Size = new System.Drawing.Size(189, 37);
            this.labelMontoTotal.TabIndex = 7;
            this.labelMontoTotal.Text = " ";
            this.labelMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMontoTotal.Click += new System.EventHandler(this.label14_Click);
            // 
            // checkBoxFacturaDePago
            // 
            this.checkBoxFacturaDePago.AutoSize = true;
            this.checkBoxFacturaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFacturaDePago.Location = new System.Drawing.Point(698, 757);
            this.checkBoxFacturaDePago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxFacturaDePago.Name = "checkBoxFacturaDePago";
            this.checkBoxFacturaDePago.Size = new System.Drawing.Size(137, 21);
            this.checkBoxFacturaDePago.TabIndex = 30;
            this.checkBoxFacturaDePago.Text = "Factura De Pago";
            this.checkBoxFacturaDePago.UseVisualStyleBackColor = true;
            // 
            // btnIniciarNuevaCompra
            // 
            this.btnIniciarNuevaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnIniciarNuevaCompra.Location = new System.Drawing.Point(903, 757);
            this.btnIniciarNuevaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarNuevaCompra.Name = "btnIniciarNuevaCompra";
            this.btnIniciarNuevaCompra.Size = new System.Drawing.Size(109, 51);
            this.btnIniciarNuevaCompra.TabIndex = 31;
            this.btnIniciarNuevaCompra.Text = "Iniciar Nueva \r\nCompra";
            this.btnIniciarNuevaCompra.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnFinalizar.Location = new System.Drawing.Point(1042, 757);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(109, 51);
            this.btnFinalizar.TabIndex = 32;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // proveedor_de_errores
            // 
            this.proveedor_de_errores.ContainerControl = this;
            // 
            // colCategoriaD
            // 
            this.colCategoriaD.HeaderText = "CategoriaID";
            this.colCategoriaD.MinimumWidth = 6;
            this.colCategoriaD.Name = "colCategoriaD";
            this.colCategoriaD.ReadOnly = true;
            this.colCategoriaD.Visible = false;
            this.colCategoriaD.Width = 125;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 125;
            // 
            // colProductoID
            // 
            this.colProductoID.HeaderText = "ProductoID";
            this.colProductoID.MinimumWidth = 6;
            this.colProductoID.Name = "colProductoID";
            this.colProductoID.ReadOnly = true;
            this.colProductoID.Visible = false;
            this.colProductoID.Width = 125;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 125;
            // 
            // colCuenta
            // 
            this.colCuenta.HeaderText = "Cuenta";
            this.colCuenta.MinimumWidth = 6;
            this.colCuenta.Name = "colCuenta";
            this.colCuenta.ReadOnly = true;
            this.colCuenta.Width = 125;
            // 
            // colCantidadDeCompra
            // 
            this.colCantidadDeCompra.HeaderText = "Cantidad De Compra";
            this.colCantidadDeCompra.MinimumWidth = 6;
            this.colCantidadDeCompra.Name = "colCantidadDeCompra";
            this.colCantidadDeCompra.ReadOnly = true;
            this.colCantidadDeCompra.Width = 125;
            // 
            // colPrecioDeCompraPorUnidad
            // 
            this.colPrecioDeCompraPorUnidad.HeaderText = "Precio De Compra";
            this.colPrecioDeCompraPorUnidad.MinimumWidth = 6;
            this.colPrecioDeCompraPorUnidad.Name = "colPrecioDeCompraPorUnidad";
            this.colPrecioDeCompraPorUnidad.ReadOnly = true;
            this.colPrecioDeCompraPorUnidad.Width = 125;
            // 
            // colPrecioDeVentaPorUnidad
            // 
            this.colPrecioDeVentaPorUnidad.HeaderText = "Precio De Venta";
            this.colPrecioDeVentaPorUnidad.MinimumWidth = 6;
            this.colPrecioDeVentaPorUnidad.Name = "colPrecioDeVentaPorUnidad";
            this.colPrecioDeVentaPorUnidad.ReadOnly = true;
            this.colPrecioDeVentaPorUnidad.Width = 125;
            // 
            // colCantidadUmbral
            // 
            this.colCantidadUmbral.HeaderText = "Cantidad Umbral";
            this.colCantidadUmbral.MinimumWidth = 6;
            this.colCantidadUmbral.Name = "colCantidadUmbral";
            this.colCantidadUmbral.ReadOnly = true;
            this.colCantidadUmbral.Width = 125;
            // 
            // colCostoDelArticulo
            // 
            this.colCostoDelArticulo.HeaderText = "Costo Del Artículo";
            this.colCostoDelArticulo.MinimumWidth = 6;
            this.colCostoDelArticulo.Name = "colCostoDelArticulo";
            this.colCostoDelArticulo.ReadOnly = true;
            this.colCostoDelArticulo.Width = 125;
            // 
            // colFechaDeFabricacion
            // 
            this.colFechaDeFabricacion.HeaderText = "FechaDeFabricacion";
            this.colFechaDeFabricacion.MinimumWidth = 6;
            this.colFechaDeFabricacion.Name = "colFechaDeFabricacion";
            this.colFechaDeFabricacion.ReadOnly = true;
            this.colFechaDeFabricacion.Visible = false;
            this.colFechaDeFabricacion.Width = 125;
            // 
            // colFechaDeExpiracion
            // 
            this.colFechaDeExpiracion.HeaderText = "FechaDeExpiracion";
            this.colFechaDeExpiracion.MinimumWidth = 6;
            this.colFechaDeExpiracion.Name = "colFechaDeExpiracion";
            this.colFechaDeExpiracion.ReadOnly = true;
            this.colFechaDeExpiracion.Visible = false;
            this.colFechaDeExpiracion.Width = 125;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(834, 611);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Monto Pagado : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.Location = new System.Drawing.Point(826, 669);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Monto Restante : ";
            // 
            // labelMontoPagado
            // 
            this.labelMontoPagado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoPagado.Location = new System.Drawing.Point(949, 601);
            this.labelMontoPagado.Name = "labelMontoPagado";
            this.labelMontoPagado.Size = new System.Drawing.Size(202, 37);
            this.labelMontoPagado.TabIndex = 36;
            this.labelMontoPagado.Text = " ";
            this.labelMontoPagado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMontoRestante
            // 
            this.labelMontoRestante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMontoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoRestante.Location = new System.Drawing.Point(949, 659);
            this.labelMontoRestante.Name = "labelMontoRestante";
            this.labelMontoRestante.Size = new System.Drawing.Size(202, 37);
            this.labelMontoRestante.TabIndex = 37;
            this.labelMontoRestante.Text = " ";
            this.labelMontoRestante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFormularioDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 853);
            this.Controls.Add(this.labelMontoRestante);
            this.Controls.Add(this.labelMontoPagado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnIniciarNuevaCompra);
            this.Controls.Add(this.checkBoxFacturaDePago);
            this.Controls.Add(this.labelMontoTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBProveedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormularioDeCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura De Compras";
            this.Load += new System.EventHandler(this.frmFormularioDeCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBProveedor.ResumeLayout(false);
            this.groupBProveedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoDeCompras)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_de_errores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBProveedor;
        private System.Windows.Forms.Button btnAñadirProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCarritoDeCompras;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboSeleccionarProducto;
        private System.Windows.Forms.ComboBox comboSeleccionarCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTodasLasCuentas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCantidadDeCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPrecioDeCompraPorUnidad;
        private System.Windows.Forms.TextBox textPrecioDeVentaPorUnidad;
        private System.Windows.Forms.TextBox textCantidadUmbral;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaDeExpiracion;
        private System.Windows.Forms.DateTimePicker dtpFechaDeFabricacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelMontoTotal;
        private System.Windows.Forms.CheckBox checkBoxFacturaDePago;
        private System.Windows.Forms.Button btnIniciarNuevaCompra;
        private System.Windows.Forms.Button btnFinalizar;
        public System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider proveedor_de_errores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoriaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioDeCompraPorUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioDeVentaPorUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadUmbral;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoDelArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDeFabricacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDeExpiracion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelMontoRestante;
        private System.Windows.Forms.Label labelMontoPagado;
    }
}