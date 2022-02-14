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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
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
                query = "SELECT ProveedorID [ID], NombreDelProveedor [Proveedor], NoDeTelefono [Teléfono], Email [Correo],Direccion [Dirección],Descripcion [Descripción] FROM TablaDeProveedores";
            }
            else
            {
                query = "SELECT ProveedorID [ID], NombreDelProveedor [Proveedor], NoDeTelefono [Teléfono], Email [Correo],Direccion [Dirección],Descripcion [Descripción] FROM TablaDeProveedores WHERE (NombreDelProveedor +' '+NoDeTelefono+' '+Direccion+' '+Email+' '+Descripcion) LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvProveedor.DataSource = tabladedatos;
                    dgvProveedor.Columns[0].Width = 100;    // ID Del Proveedor.
                    dgvProveedor.Columns[1].Width = 150;    // Nombre Del Proveedor.
                    dgvProveedor.Columns[2].Width = 120;    // Número Telefónico Del Proveedor.
                    dgvProveedor.Columns[3].Width = 120;    // Correo Electrónico.
                    dgvProveedor.Columns[4].Width = 200;    // Dirección.
                    dgvProveedor.Columns[5].Width = 300;    // Descripción.
                }
                else
                {
                    dgvProveedor.DataSource = null;
                }
            }
            else
            {
                dgvProveedor.DataSource = null;
            }
        }

        private void HabilitarControl()
        {
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            dgvProveedor.Enabled = false;
            textBusqueda.Enabled = false;
        }

        private void DeshabilitarControl()
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;
            dgvProveedor.Enabled = true;
            textBusqueda.Enabled = true;
            LlenarCuadro("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarControl();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            textNombreDelProveedor.Clear();
            textNumeroTelefonico.Clear();
            textDireccion.Clear();
            textCorreoElectronico.Clear();
            textDescripcion.Clear();
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarCuadro(textBusqueda.Text.Trim()); 
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProveedor != null)
            {
                if (dgvProveedor.Rows.Count > 0)
                {
                    if (dgvProveedor.SelectedRows.Count == 1)
                    {
                        textNombreDelProveedor.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[1].Value);    // Nombre Del Proveedor.
                        textNumeroTelefonico.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[2].Value);    // Número Telefónico Del Proveedor.
                        textCorreoElectronico.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[3].Value);    // Correo Electrónico.
                        textDireccion.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[4].Value);    // Dirección.
                        textDescripcion.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[5].Value);    // Descripción.
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textNombreDelProveedor.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNombreDelProveedor, "Debe ingresar el nombre del proveedor.");
                textNombreDelProveedor.Focus();
                return;
            }

            if (textNumeroTelefonico.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNumeroTelefonico, "Debe ingresar el número telefónico.");
                textNumeroTelefonico.Focus();
                return;
            }

            if (textDireccion.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textDireccion, "Debe ingresar la dirección.");
                textDireccion.Focus();
                return;
            }

            DataTable tabladedatos = new DataTable();
            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaDeProveedores WHERE NoDeTelefono = '" + textNumeroTelefonico.Text.Trim() + "'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textNombreDelProveedor, "Ya está registrado.");
                    textNombreDelProveedor.Focus();
                    return;
                }
            }


            string query = string.Format("INSERT INTO TablaDeProveedores(NombreDelProveedor,NoDeTelefono,Email,Direccion,Descripcion) VALUES('{0}','{1}','{2}','{3}','{4}')", textNombreDelProveedor.Text.Trim(),textNumeroTelefonico.Text.Trim(),textCorreoElectronico.Text.Trim(),textDireccion.Text.Trim(),textDescripcion.Text.Trim());
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textNombreDelProveedor.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNombreDelProveedor, "Debe ingresar el nombre del proveedor.");
                textNombreDelProveedor.Focus();
                return;
            }

            if (textNumeroTelefonico.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNumeroTelefonico, "Debe ingresar el número telefónico.");
                textNumeroTelefonico.Focus();
                return;
            }

            if (textDireccion.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textDireccion, "Debe ingresar la dirección.");
                textDireccion.Focus();
                return;
            }

            DataTable tabladedatos = new DataTable();
            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaDeProveedores WHERE NoDeTelefono = '" + textNumeroTelefonico.Text.Trim() + "' AND ProveedorID != '"+dgvProveedor.CurrentRow.Cells[0].Value+"'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textNombreDelProveedor, "Ya está registrado.");
                    textNombreDelProveedor.Focus();
                    return;
                }
            }


            string query = string.Format("UPDATE TablaDeProveedores SET NombreDelProveedor = '{0}',NoDeTelefono = '{1}',Email = '{2}',Direccion = '{3}',Descripcion = '{4}' WHERE ProveedorID = '{5}'", 
                                          textNombreDelProveedor.Text.Trim(), textNumeroTelefonico.Text.Trim(), textCorreoElectronico.Text.Trim(), textDireccion.Text.Trim(), textDescripcion.Text.Trim(), dgvProveedor.CurrentRow.Cells[0].Value);
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

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            LlenarCuadro("");
        }

        private void btnImprimirListaDeProveedores_Click(object sender, EventArgs e)
        {
            frmImprimirListaDeProveedores frm = new frmImprimirListaDeProveedores();
            frm.ShowDialog();
        }
    }
}
