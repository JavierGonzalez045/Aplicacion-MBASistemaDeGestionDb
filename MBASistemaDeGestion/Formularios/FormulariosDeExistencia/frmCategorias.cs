using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBASistemaDeGestion.Formularios.FormulariosDeExistencia
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void LlenarCuadro(string busqueda_a_realizar)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT CategoriaID [ID], NombreDeLaCategoria [Categoria], EstaBorrado FROM TablaDeCategorias WHERE EstaBorrado = 0";
            }
            else
            {
                query = "SELECT CategoriaID [ID], NombreDeLaCategoria [Categoria], EstaBorrado FROM TablaDeCategorias WHERE NombreDeLaCategoria LIKE '%" + busqueda_a_realizar + "%' AND EstaBorrado = 0";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvListaDeCategorias.DataSource = tabladedatos;
                    dgvListaDeCategorias.Columns[0].Width = 100;
                    dgvListaDeCategorias.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvListaDeCategorias.Columns[2].Visible = false;
                }
                else
                {
                    dgvListaDeCategorias.DataSource = null;
                } 
            }
            else
            {
                dgvListaDeCategorias.DataSource = null;
            }
            checkBorrado.Checked = false;
        }


        private void LlenarCuadroBorrado(string busqueda_a_realizar)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT CategoriaID [ID], NombreDeLaCategoria [Categoria],EstaBorrado FROM TablaDeCategorias WHERE EstaBorrado = 1";
            }
            else
            {
                query = "SELECT CategoriaID [ID], NombreDeLaCategoria [Categoria],EstaBorrado FROM TablaDeCategorias WHERE NombreDeLaCategoria LIKE '%" + busqueda_a_realizar + "%' AND EstaBorrado = 1";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvListaDeCategorias.DataSource = tabladedatos;
                    dgvListaDeCategorias.Columns[0].Width = 100;
                    dgvListaDeCategorias.Columns[1].Width = 100;
                    dgvListaDeCategorias.Columns[2].Width = 100;
                }
                else
                {
                    dgvListaDeCategorias.DataSource = null;
                }
            }
            else
            {
                dgvListaDeCategorias.DataSource = null;
            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            LlenarCuadro("");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textCategoria.Clear();
        }

        private void HabilitarControl()
        {
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            dgvListaDeCategorias.Enabled = false;
            textBusqueda.Enabled = false;
            checkBorrado.Enabled = false;
        }

        private void DeshabilitarControl()
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;
            dgvListaDeCategorias.Enabled = true;
            textBusqueda.Enabled = true;
            LlenarCuadro("");
            textCategoria.Clear();
            checkBorrado.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarControl();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textCategoria.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textCategoria, "Debe ingresar el nombre de la categoria.");
                textCategoria.Focus();
                return;
            }


            DataTable tabladedatos = new DataTable();
            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaDeCategorias WHERE NombreDeLaCategoria = '" + textCategoria.Text.Trim() + "'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textCategoria, "Ya está registrado.");
                    textCategoria.Focus();
                    return;
                }
            }


            string query = string.Format("INSERT INTO TablaDeCategorias(NombreDeLaCategoria) VALUES('{0}')", textCategoria.Text.Trim());
            bool resultado = AccesoABaseDeDatos.Insertar(query);
            if (resultado)
            {
                MessageBox.Show("Guardado exitosamente.");
                checkBorrado.Checked = false;
                LlenarCuadro("");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }


        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvListaDeCategorias != null)
            {
                if (dgvListaDeCategorias.Rows.Count > 0)
                {
                    if (dgvListaDeCategorias.SelectedRows.Count == 1)
                    {
                        textCategoria.Text = Convert.ToString(dgvListaDeCategorias.CurrentRow.Cells[1].Value);
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
            if (textCategoria.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textCategoria, "Debe ingresar el nombre de la categoria.");
                textCategoria.Focus();
                return;
            }


            DataTable tabladedatos = new DataTable();
            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaDeCategorias WHERE NombreDeLaCategoria = '" + textCategoria.Text.Trim() + "' AND CategoriaID != '" + dgvListaDeCategorias.CurrentRow.Cells[0].Value+"'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textCategoria, "Ya está registrado.");
                    textCategoria.Focus();
                    return;
                }
            }


            string query = string.Format("UPDATE TablaDeCategorias SET NombreDeLaCategoria = '{0}' WHERE CategoriaID = '{1}'", textCategoria.Text.Trim(),dgvListaDeCategorias.CurrentRow.Cells[0].Value);
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListaDeCategorias != null)
            {
                if (dgvListaDeCategorias.Rows.Count > 0)
                {
                    if (dgvListaDeCategorias.SelectedRows.Count == 1)
                    {

                        if (eliminarToolStripMenuItem.Text == "Eliminar")
                        {

                            if (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string eliminarquery = "UPDATE TablaDeCategorias SET EstaBorrado = 1 WHERE CategoriaID = '" + dgvListaDeCategorias.CurrentRow.Cells[0].Value + "'";
                                bool resultado = AccesoABaseDeDatos.Eliminar(eliminarquery);
                                if (resultado)
                                {
                                    MessageBox.Show("Eliminado exitosamente.");
                                    LlenarCuadro("");
                                }
                            }
                        }
                        else if (eliminarToolStripMenuItem.Text == "Recuperar")
                        {
                            if (MessageBox.Show("¿Está seguro de que desea recuperar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string eliminarquery = "UPDATE TablaDeCategorias SET EstaBorrado = 0 WHERE CategoriaID = '" + dgvListaDeCategorias.CurrentRow.Cells[0].Value + "'";
                                bool resultado = AccesoABaseDeDatos.Eliminar(eliminarquery);
                                if (resultado)
                                {
                                    MessageBox.Show("Recuperado exitosamente.");
                                    LlenarCuadro("");
                                }
                            }
                        }


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

        private void checkBorrado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBorrado.Checked == true)
            {
                LlenarCuadroBorrado("");
            }
            else
            {
                LlenarCuadro("");
            }
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (checkBorrado.Checked == true)
            {
                LlenarCuadroBorrado(textBusqueda.Text.Trim());
            }
            else
            {
                LlenarCuadro(textBusqueda.Text.Trim());
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvListaDeCategorias != null)
            {
                if (dgvListaDeCategorias.Rows.Count > 0)
                {
                    if (dgvListaDeCategorias.SelectedRows.Count == 1)
                    {
                        if (Convert.ToBoolean(dgvListaDeCategorias.CurrentRow.Cells[2].Value) == true)
                        {
                            eliminarToolStripMenuItem.Text = "Recuperar";
                        }
                        else
                        {
                            eliminarToolStripMenuItem.Text = "Eliminar";
                        }
                    }
                }
                else
                {
                    eliminarToolStripMenuItem.Text = "Eliminar";
                }
            }
            else
            {
                eliminarToolStripMenuItem.Text = "Eliminar";
            }
        }
    }
}