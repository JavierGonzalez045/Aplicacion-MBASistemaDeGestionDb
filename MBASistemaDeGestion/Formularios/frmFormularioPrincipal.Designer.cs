
namespace MBASistemaDeGestion
{
    partial class frmFormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioPrincipal));
            this.menudenavegacion = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AñadirtiposDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajustesDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlesDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subcontrolDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.AñoFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuprincipal = new System.Windows.Forms.ToolStrip();
            this.tsbIniciarSesion = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrarSesion = new System.Windows.Forms.ToolStripDropDownButton();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.menudenavegacion.SuspendLayout();
            this.tsmenuprincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menudenavegacion
            // 
            this.menudenavegacion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menudenavegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.existenciasToolStripMenuItem,
            this.ajustesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menudenavegacion.Location = new System.Drawing.Point(0, 0);
            this.menudenavegacion.Name = "menudenavegacion";
            this.menudenavegacion.Size = new System.Drawing.Size(1280, 28);
            this.menudenavegacion.TabIndex = 0;
            this.menudenavegacion.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem1
            // 
            this.cerrarSesiónToolStripMenuItem1.Name = "cerrarSesiónToolStripMenuItem1";
            this.cerrarSesiónToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.cerrarSesiónToolStripMenuItem1.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.facturaDeCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // añadirProveedorToolStripMenuItem
            // 
            this.añadirProveedorToolStripMenuItem.Name = "añadirProveedorToolStripMenuItem";
            this.añadirProveedorToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.añadirProveedorToolStripMenuItem.Text = "Añadir Proveedor";
            this.añadirProveedorToolStripMenuItem.Click += new System.EventHandler(this.añadirProveedorToolStripMenuItem_Click);
            // 
            // facturaDeCompraToolStripMenuItem
            // 
            this.facturaDeCompraToolStripMenuItem.Name = "facturaDeCompraToolStripMenuItem";
            this.facturaDeCompraToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.facturaDeCompraToolStripMenuItem.Text = "Factura De Compra";
            this.facturaDeCompraToolStripMenuItem.Click += new System.EventHandler(this.facturaDeCompraToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // añadirClienteToolStripMenuItem
            // 
            this.añadirClienteToolStripMenuItem.Name = "añadirClienteToolStripMenuItem";
            this.añadirClienteToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.añadirClienteToolStripMenuItem.Text = "Añadir Cliente";
            this.añadirClienteToolStripMenuItem.Click += new System.EventHandler(this.añadirClienteToolStripMenuItem_Click);
            // 
            // existenciasToolStripMenuItem
            // 
            this.existenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.existenciasToolStripMenuItem.Name = "existenciasToolStripMenuItem";
            this.existenciasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.existenciasToolStripMenuItem.Text = "Existencias";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesDeUsuarioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ajustesDeCuentasToolStripMenuItem});
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // ajustesDeUsuarioToolStripMenuItem
            // 
            this.ajustesDeUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AñadirtiposDeUsuarioToolStripMenuItem,
            this.añadirUsuariosToolStripMenuItem});
            this.ajustesDeUsuarioToolStripMenuItem.Name = "ajustesDeUsuarioToolStripMenuItem";
            this.ajustesDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajustesDeUsuarioToolStripMenuItem.Text = "Ajustes de Usuario";
            // 
            // AñadirtiposDeUsuarioToolStripMenuItem
            // 
            this.AñadirtiposDeUsuarioToolStripMenuItem.Name = "AñadirtiposDeUsuarioToolStripMenuItem";
            this.AñadirtiposDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.AñadirtiposDeUsuarioToolStripMenuItem.Text = "Tipos de Usuario";
            this.AñadirtiposDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.AñadirtiposDeUsuarioToolStripMenuItem_Click);
            // 
            // añadirUsuariosToolStripMenuItem
            // 
            this.añadirUsuariosToolStripMenuItem.Name = "añadirUsuariosToolStripMenuItem";
            this.añadirUsuariosToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.añadirUsuariosToolStripMenuItem.Text = "Añadir Usuario";
            this.añadirUsuariosToolStripMenuItem.Click += new System.EventHandler(this.añadirUsuariosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // ajustesDeCuentasToolStripMenuItem
            // 
            this.ajustesDeCuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaPrincipalToolStripMenuItem,
            this.controlesDeCuentaToolStripMenuItem,
            this.subcontrolDeCuentaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.AñoFiscalToolStripMenuItem});
            this.ajustesDeCuentasToolStripMenuItem.Name = "ajustesDeCuentasToolStripMenuItem";
            this.ajustesDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajustesDeCuentasToolStripMenuItem.Text = "Ajustes de Cuentas";
            // 
            // cuentaPrincipalToolStripMenuItem
            // 
            this.cuentaPrincipalToolStripMenuItem.Name = "cuentaPrincipalToolStripMenuItem";
            this.cuentaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.cuentaPrincipalToolStripMenuItem.Text = "Cuenta Principal";
            this.cuentaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.cuentaPrincipalToolStripMenuItem_Click);
            // 
            // controlesDeCuentaToolStripMenuItem
            // 
            this.controlesDeCuentaToolStripMenuItem.Name = "controlesDeCuentaToolStripMenuItem";
            this.controlesDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.controlesDeCuentaToolStripMenuItem.Text = "Control de Cuentas";
            this.controlesDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.controlesDeCuentaToolStripMenuItem_Click);
            // 
            // subcontrolDeCuentaToolStripMenuItem
            // 
            this.subcontrolDeCuentaToolStripMenuItem.Name = "subcontrolDeCuentaToolStripMenuItem";
            this.subcontrolDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.subcontrolDeCuentaToolStripMenuItem.Text = "Subcontrol de Cuentas";
            this.subcontrolDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.subcontrolDeCuentaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(238, 6);
            // 
            // AñoFiscalToolStripMenuItem
            // 
            this.AñoFiscalToolStripMenuItem.Name = "AñoFiscalToolStripMenuItem";
            this.AñoFiscalToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.AñoFiscalToolStripMenuItem.Text = "Año Fiscal";
            this.AñoFiscalToolStripMenuItem.Click += new System.EventHandler(this.AñoFiscalToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tsmenuprincipal
            // 
            this.tsmenuprincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsmenuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIniciarSesion,
            this.tsbCerrarSesion});
            this.tsmenuprincipal.Location = new System.Drawing.Point(0, 28);
            this.tsmenuprincipal.Name = "tsmenuprincipal";
            this.tsmenuprincipal.Size = new System.Drawing.Size(1280, 51);
            this.tsmenuprincipal.TabIndex = 1;
            this.tsmenuprincipal.Text = "toolStrip1";
            // 
            // tsbIniciarSesion
            // 
            this.tsbIniciarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsbIniciarSesion.Image")));
            this.tsbIniciarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIniciarSesion.Name = "tsbIniciarSesion";
            this.tsbIniciarSesion.Size = new System.Drawing.Size(100, 48);
            this.tsbIniciarSesion.Text = "Iniciar Sesión";
            this.tsbIniciarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbIniciarSesion.Click += new System.EventHandler(this.tsbIniciarSesion_Click);
            // 
            // tsbCerrarSesion
            // 
            this.tsbCerrarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.tsbCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrarSesion.Image")));
            this.tsbCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarSesion.Name = "tsbCerrarSesion";
            this.tsbCerrarSesion.Size = new System.Drawing.Size(110, 48);
            this.tsbCerrarSesion.Text = "Cerrar Sesión";
            this.tsbCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrarSesion.Visible = false;
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Actualizar perfil";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1280, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 20);
            this.toolStripStatusLabel1.Text = "Listo";
            // 
            // panelprincipal
            // 
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(0, 79);
            this.panelprincipal.Margin = new System.Windows.Forms.Padding(4);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(1280, 469);
            this.panelprincipal.TabIndex = 3;
            // 
            // frmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 574);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsmenuprincipal);
            this.Controls.Add(this.menudenavegacion);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menudenavegacion;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema De Contabilidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFormularioPrincipal_Load);
            this.menudenavegacion.ResumeLayout(false);
            this.menudenavegacion.PerformLayout();
            this.tsmenuprincipal.ResumeLayout(false);
            this.tsmenuprincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsmenuprincipal;
        private System.Windows.Forms.ToolStripMenuItem ajustesDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AñadirtiposDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirUsuariosToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton tsbIniciarSesion;
        public System.Windows.Forms.MenuStrip menudenavegacion;
        public System.Windows.Forms.ToolStripDropDownButton tsbCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajustesDeCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlesDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subcontrolDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem AñoFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaDeCompraToolStripMenuItem;
    }
}