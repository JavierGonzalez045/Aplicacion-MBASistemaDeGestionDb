using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBASistemaDeGestion.Formularios.FormulariosDeCuentas
{
    public partial class frmCuentaPrincipal : Form
    {
        public frmCuentaPrincipal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textCuenta.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textCuenta, "Debe ingresar la cuenta principal.");
                textCuenta.Focus();
                return;
            }

            DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaCuentaPrincipal WHERE NombreDeLaCuentaPrincipal = '" + textCuenta.Text.Trim()+"'");
            if (tabla_de_datos != null)
            {
                if (tabla_de_datos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textCuenta, "Ya existe.");
                    textCuenta.Focus();
                    return;
                }
            }

            string insertarquery = string.Format("INSERT INTO TablaCuentaPrincipal(Usuario_ID,NombreDeLaCuentaPrincipal) VALUES('{0}','{1}')", UsuarioActual.UsuarioID, textCuenta.Text.Trim());
            bool resultado = AccesoABaseDeDatos.Insertar(insertarquery);
            if (resultado)
            {
                MessageBox.Show("Guardado exitosamente.");
                textCuenta.Clear();
                LlenarCuadro("");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }

        }

        private void LlenarCuadro(string busqueda_a_realizar)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT * FROM v_ListaCuentaPrincipal";
            }
            else
            {
                query = "SELECT * FROM v_ListaCuentaPrincipal WHERE ([Cuenta Principal] +' '+ [Usuario]) LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvCuentas.DataSource = tabladedatos;
                    dgvCuentas.Columns[0].Width = 100;
                    dgvCuentas.Columns[1].Visible = false;
                    dgvCuentas.Columns[2].Width = 170;
                    dgvCuentas.Columns[3].Width = 120;
                }
                else
                {
                    dgvCuentas.DataSource = null;
                }
            }
            else
            {
                dgvCuentas.DataSource = null;
            }
        }

        private void frmCuentaPrincipal_Load(object sender, EventArgs e)
        {
            LlenarCuadro("");
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCuentas != null)
            {
                if (dgvCuentas.Rows.Count > 0)
                {
                    if (dgvCuentas.SelectedRows.Count == 1)
                    {
                        textCuenta.Text = Convert.ToString(dgvCuentas.CurrentRow.Cells[2].Value);
                        HabilitarComponentes();
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

        private void HabilitarComponentes()
        {
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            dgvCuentas.Enabled = false;
            textBusqueda.Enabled = false;
        }

        private void DeshabilitarControl()
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;
            dgvCuentas.Enabled = true;
            textBusqueda.Enabled = true;
            LlenarCuadro("");
            textCuenta.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarControl();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textCuenta.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textCuenta.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textCuenta, "Debe ingresar la cuenta principal.");
                textCuenta.Focus();
                return;
            }

            DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaCuentaPrincipal WHERE NombreDeLaCuentaPrincipal = '" + textCuenta.Text.Trim() + "' AND WHERE CuentaPrincipalID = '" + dgvCuentas.CurrentRow.Cells[0].Value+"'");
            if (tabla_de_datos != null)
            {
                if (tabla_de_datos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textCuenta, "Ya existe.");
                    textCuenta.Focus();
                    return;
                }
            }

            string actualizarquery = string.Format("UPDATE TablaCuentaPrincipal SET Usuario_ID = '{0}', NombreDeLaCuentaPrincipal = '{1}' WHERE CuentaPrincipalID = '{2}'", UsuarioActual.UsuarioID, textCuenta.Text.Trim(), dgvCuentas.CurrentRow.Cells[0].Value);
            bool resultado = AccesoABaseDeDatos.Actualizar(actualizarquery);
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

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarCuadro(textBusqueda.Text.Trim());
        }
    }
}
