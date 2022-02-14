using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBASistemaDeGestion
{
    public partial class frmTiposDeUsuario : Form
    {
        public frmTiposDeUsuario()
        {
            InitializeComponent();
        }

        private void LlenarCuadro(string busqueda_a_realizar)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT TipoDeUsuarioID [ID], TipoDeUsuario [Tipo de usuario] FROM TablaTiposDeUsuarios";
            }
            else
            {
                query = "SELECT TipoDeUsuarioID [ID], TipoDeUsuario [Tipo de usuario] FROM TablaTiposDeUsuarios WHERE TipoDeUsuario LIKE '%" + busqueda_a_realizar+"%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvTipoDeUsuario.DataSource = tabladedatos;
                    dgvTipoDeUsuario.Columns[0].Width = 100;
                    dgvTipoDeUsuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvTipoDeUsuario.DataSource = null;
                }
            }
            else
            {
                dgvTipoDeUsuario.DataSource = null;
            }
        }


        private void frmTiposDeUsuarios_Load(object sender, EventArgs e)
        {
            LlenarCuadro("");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textIngresarTipoDeUsuario.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textIngresarTipoDeUsuario, "Debe ingresar el tipos de usuario.");
                textIngresarTipoDeUsuario.Focus();
                return;
            }


            DataTable tabladedatos = new DataTable();
            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaTiposDeUsuarios WHERE TipoDeUsuario = '" + textIngresarTipoDeUsuario.Text.Trim() + "'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textIngresarTipoDeUsuario, "Ya está registrado.");
                    textIngresarTipoDeUsuario.Focus();
                    return;
                }
            }


            string query = string.Format("INSERT INTO TablaTiposDeUsuarios(TipoDeUsuario) VALUES('{0}')", textIngresarTipoDeUsuario.Text.Trim());
            bool resultado = AccesoABaseDeDatos.Insertar(query);
            if (resultado)
            {
                MessageBox.Show("Guardado exitosamente.");
                LlenarCuadro("");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarCuadro(textBusqueda.Text.Trim());
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textIngresarTipoDeUsuario.Clear();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTipoDeUsuario != null)
            {
                if (dgvTipoDeUsuario.Rows.Count > 0)
                {
                    if (dgvTipoDeUsuario.SelectedRows.Count == 1)
                    {
                        textIngresarTipoDeUsuario.Text = Convert.ToString(dgvTipoDeUsuario.CurrentRow.Cells[1].Value);
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


        private void HabilitarControl()
        {
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            dgvTipoDeUsuario.Enabled = false;
            textBusqueda.Enabled = false;
        }

        private void DeshabilitarControl()
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;
            dgvTipoDeUsuario.Enabled = true;
            textBusqueda.Enabled = true;
            LlenarCuadro("");
            textIngresarTipoDeUsuario.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textIngresarTipoDeUsuario.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textIngresarTipoDeUsuario, "Ingresar el tipos de usuario.");
                textIngresarTipoDeUsuario.Focus();
                return;
            }


            DataTable tabladedatos = new DataTable();
            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaTiposDeUsuarios WHERE TipoDeUsuario = '" + textIngresarTipoDeUsuario.Text.Trim() + "' AND TipoDeUsuarioID != '" + Convert.ToString(dgvTipoDeUsuario.CurrentRow.Cells[0].Value) + "'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textIngresarTipoDeUsuario, "Ya está registrado.");
                    textIngresarTipoDeUsuario.Focus();
                    return;
                }
            }


            string query = string.Format("UPDATE TablaTiposDeUsuarios SET TipoDeUsuario = '{0}' WHERE TipoDeUsuarioID = '{1}'", textIngresarTipoDeUsuario.Text.Trim(), Convert.ToString(dgvTipoDeUsuario.CurrentRow.Cells[0].Value));
            bool resultado = AccesoABaseDeDatos.Actualizar(query);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarControl();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTipoDeUsuario != null)
            {
                if (dgvTipoDeUsuario.Rows.Count > 0)
                {
                    if (dgvTipoDeUsuario.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool resultado = AccesoABaseDeDatos.Eliminar("DELETE FROM TablaTiposDeUsuarios WHERE TipoDeUsuarioID = '" + dgvTipoDeUsuario.CurrentRow.Cells[0].Value + "'");
                            if (resultado)
                            {
                                LlenarCuadro("");
                                MessageBox.Show("Eliminado exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("Algunos registros son dependientes. Por favor contactese con el programador.");
                            }
                        }
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
    }
}
