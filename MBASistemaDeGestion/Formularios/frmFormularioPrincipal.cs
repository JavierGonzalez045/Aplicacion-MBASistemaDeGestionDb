using MBASistemaDeGestion.Formularios.FormulariosDeUsuario;
using MBASistemaDeGestion.Formularios.FormulariosDeExistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBASistemaDeGestion.Formularios.FormulariosDeCuentas;
using MBASistemaDeGestion.Formularios.FormulariosDeProveedores;
using MBASistemaDeGestion.Formularios.FormulariosDeClientes;
using MBASistemaDeGestion.Formularios.FormulariosDeCompra;

namespace MBASistemaDeGestion
{
    public partial class frmFormularioPrincipal : Form
    {
        frmTiposDeUsuario FormularioTiposDeUsuario;
        frmProductos FormularioDeProductos;
        

        public frmFormularioPrincipal()
        {
            InitializeComponent();
        }

        private void AñadirtiposDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioTiposDeUsuario == null)
            {
                FormularioTiposDeUsuario = new frmTiposDeUsuario();     
            }
            FormularioTiposDeUsuario.ShowDialog();
        }

        private void añadirUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAñadirUsuarios frm = new frmAñadirUsuarios();
            frm.ShowDialog();
        }

        private void tsbIniciarSesion_Click(object sender, EventArgs e)
        {
            frmFormularioIniciarSesion frm = new frmFormularioIniciarSesion(this);
            frm.ShowDialog();
        }

        private void frmFormularioPrincipal_Load(object sender, EventArgs e)
        {
            tsbIniciarSesion.Visible = true;
            tsbCerrarSesion.Visible = false;
            menudenavegacion.Enabled = false;
        }

        private void tsbCerrarSesion_ButtonClick(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizarUsuario frm = new frmActualizarUsuario();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioDeProductos == null)
            {
                FormularioDeProductos = new frmProductos();
            }
            FormularioDeProductos.TopLevel = false;
            panelprincipal.Controls.Add(FormularioDeProductos);
            FormularioDeProductos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormularioDeProductos.Dock = DockStyle.Fill;
            FormularioDeProductos.Show();
        }

        private void cuentaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentaPrincipal frm = new frmCuentaPrincipal();
            frm.ShowDialog();
        }

        private void controlesDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControlDeCuenta frm = new frmControlDeCuenta();
            frm.ShowDialog();
        }

        private void subcontrolDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubControlDeCuentas frm = new frmSubControlDeCuentas();
            frm.ShowDialog();
        }

        private void añoFinancieroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAñoFiscal frm = new frmAñoFiscal();
            frm.ShowDialog();
        }

        private void añadirProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.ShowDialog();
        }

        private void añadirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

        private void facturaDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormularioDeCompras frm = new frmFormularioDeCompras();
            frm.ShowDialog();
        }
    }
} 

