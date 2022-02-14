using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBASistemaDeGestion.Formularios.FormulariosDeClientes
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void LlenarCuadro(string busqueda_a_realizar)
        {
            string query = string.Empty;
            btnImprimirListaDeProveedores.Enabled = true;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT ClienteID [ID], NombreDelCliente [Cliente], NoDeTelefono [Teléfono], Area [Area Del Cliente] ,Direccion [Dirección],Descripcion [Descripción] FROM TablaClientes";
            }
            else
            {
                query = "SELECT ClienteID [ID], NombreDelCliente [Cliente], NoDeTelefono [Teléfono], Area [Area Del Cliente] ,Direccion [Dirección],Descripcion [Descripción] FROM TablaClientes WHERE (NombreDelCliente +' '+NoDeTelefono+' '+Direccion+' '+Area+' '+Descripcion) LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvCliente.DataSource = tabladedatos;
                    dgvCliente.Columns[0].Width = 100;    // ID Del cliente.
                    dgvCliente.Columns[1].Width = 150;    // Nombre Del cliente.
                    dgvCliente.Columns[2].Width = 120;    // Número Telefónico Del cliente.
                    dgvCliente.Columns[3].Width = 120;    // Area Del Cliente.
                    dgvCliente.Columns[4].Width = 200;    // Dirección.
                    dgvCliente.Columns[5].Width = 300;    // Descripción.
                }
                else
                {
                    dgvCliente.DataSource = null;
                }
            }
            else
            {
                dgvCliente.DataSource = null;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            LlenarCuadro("");
        }

        private void HabilitarControl()
        {
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            dgvCliente.Enabled = false;
            textBusqueda.Enabled = false;
        }

        private void DeshabilitarControl()
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;
            dgvCliente.Enabled = true;
            textBusqueda.Enabled = true;
            LlenarCuadro("");
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            textNombreDelCliente.Clear();
            textNumeroTelefonico.Clear();
            textDireccion.Clear();
            textAreaDelCliente.Clear();
            textDescripcion.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarControl();
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarCuadro(textBusqueda.Text.Trim());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textNombreDelCliente.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNombreDelCliente, "Debe ingresar el nombre del cliente.");
                textNombreDelCliente.Focus();
                return;
            }

            if (textNumeroTelefonico.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNumeroTelefonico, "Debe ingresar el número telefónico.");
                textNumeroTelefonico.Focus();
                return;
            }

            if (textAreaDelCliente.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textAreaDelCliente, "Debe ingresar el area del cliente.");
                textAreaDelCliente.Focus();
                return;
            }

            if (textDireccion.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textDireccion, "Debe ingresar la dirección.");
                textDireccion.Focus();
                return;
            }

            DataTable tabladedatos = new DataTable();
            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaClientes WHERE NoDeTelefono = '" + textNumeroTelefonico.Text.Trim() + "'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textNombreDelCliente, "Ya está registrado.");
                    textNombreDelCliente.Focus();
                    return;
                }
            }


            string query = string.Format("INSERT INTO TablaClientes(NombreDelCliente,NoDeTelefono,Area,Direccion,Descripcion) VALUES('{0}','{1}','{2}','{3}','{4}')", textNombreDelCliente.Text.Trim(), textNumeroTelefonico.Text.Trim(), textAreaDelCliente.Text.Trim(), textDireccion.Text.Trim(), textDescripcion.Text.Trim());
            bool resultado = AccesoABaseDeDatos.Insertar(query);
            if (resultado)
            {
                MessageBox.Show("Guardado exitosamente.");
                LlenarCuadro("");
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCliente != null)
            {
                if (dgvCliente.Rows.Count > 0)
                {
                    if (dgvCliente.SelectedRows.Count == 1)
                    {
                        textNombreDelCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[1].Value);    // Nombre Del Cliente.
                        textNumeroTelefonico.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[2].Value);    // Número Telefónico Del Cliente.
                        textAreaDelCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[3].Value);    // Area Del Cliente.
                        textDireccion.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[4].Value);    // Dirección.
                        textDescripcion.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[5].Value);    // Descripción.
                        HabilitarControl();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un registro.");
                    }
                }
                else
                {
                    MessageBox.Show("La lista está vacía.");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textNombreDelCliente.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNombreDelCliente, "Debe ingresar el nombre del cliente.");
                textNombreDelCliente.Focus();
                return;
            }

            if (textNumeroTelefonico.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNumeroTelefonico, "Debe ingresar el número telefónico.");
                textNumeroTelefonico.Focus();
                return;
            }

            if (textAreaDelCliente.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textAreaDelCliente, "Debe ingresar el area del cliente.");
                textAreaDelCliente.Focus();
                return;
            }

            if (textDireccion.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textDireccion, "Debe ingresar la dirección.");
                textDireccion.Focus();
                return;
            }

            DataTable tabladedatos = new DataTable();
            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaClientes WHERE NoDeTelefono = '" + textNumeroTelefonico.Text.Trim() + "' AND ClienteID != '"+dgvCliente.CurrentRow.Cells[0].Value+"'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textNombreDelCliente, "Ya está registrado.");
                    textNombreDelCliente.Focus();
                    return;
                }
            }


            string query = string.Format("UPDATE TablaClientes SET NombreDelCliente = '{0}',NoDeTelefono = '{1}',Area = '{2}',Direccion = '{3}',Descripcion = '{4}' WHERE ClienteID = '{5}'",
                                          textNombreDelCliente.Text.Trim(), textNumeroTelefonico.Text.Trim(), textAreaDelCliente.Text.Trim(), textDireccion.Text.Trim(), textDescripcion.Text.Trim(), dgvCliente.CurrentRow.Cells[0].Value);
            bool resultado = AccesoABaseDeDatos.Insertar(query);
            if (resultado)
            {
                MessageBox.Show("Actualizado exitosamente.");
                DeshabilitarControl();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }

        private void btnImprimirListaDeProveedores_Click(object sender, EventArgs e)
        {
            frmImprimirListaDeDeClientes frm = new frmImprimirListaDeDeClientes();
            frm.ShowDialog();
        }
    }
}
