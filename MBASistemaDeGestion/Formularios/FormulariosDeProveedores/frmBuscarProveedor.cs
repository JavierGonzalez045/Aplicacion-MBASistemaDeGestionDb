using MBASistemaDeGestion.CodigoFuente;
using MBASistemaDeGestion.Formularios.FormulariosDeCompra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBASistemaDeGestion.Formularios.FormulariosDeProveedores
{
    public partial class frmBuscarProveedor : Form
    {
        frmFormularioDeCompras FormularioDeCompras;

        public frmBuscarProveedor()
        {
            InitializeComponent();
        }

        public frmBuscarProveedor(string busqueda_a_realizar, frmFormularioDeCompras frmCompras)
        {
            InitializeComponent();
            this.FormularioDeCompras = frmCompras;
            ClaseProveedor.ObtenerProveedor(busqueda_a_realizar, dgvProveedor);
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            ClaseProveedor.ObtenerProveedor(textBusqueda.Text.Trim(), dgvProveedor);
        }

        private void btnObtenerTodo_Click(object sender, EventArgs e)
        {
            ClaseProveedor.ObtenerProveedor("", dgvProveedor);
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProveedor != null)
            {
                if (dgvProveedor.Rows.Count > 0)
                {
                    if (dgvProveedor.SelectedRows.Count == 1)
                    {
                        FormularioDeCompras.seleccionarproveedorid = Convert.ToString(dgvProveedor.CurrentRow.Cells[0].Value);
                        FormularioDeCompras.labelProveedor.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[1].Value) +"   Teléfono : "+ Convert.ToString(dgvProveedor.CurrentRow.Cells[2].Value);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un registro.");
                    }
                }
                else
                {
                    MessageBox.Show("La lista está vacía.");
                }
            }
        }

        private void frmBuscarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
