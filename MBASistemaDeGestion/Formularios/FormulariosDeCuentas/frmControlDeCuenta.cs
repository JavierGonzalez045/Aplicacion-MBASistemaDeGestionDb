using MBASistemaDeGestion.CodigoFuente;
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
    public partial class frmControlDeCuenta : Form
    {
        public frmControlDeCuenta()
        {
            InitializeComponent();
        }

        private void LlenarCuadro(string busqueda_a_realizar)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT ControlDeCuentaID  as [ID], CuentaPrincipal_ID, NombreDeLaCuentaPrincipal as [Cuenta Principal], NombreDelControlDeCuenta as [Control De Cuenta], NombreDeUsuario as [Usuario] FROM v_ListaControlDeCuentas";
            }
            else
            {
                query = "SELECT ControlDeCuentaID  as [ID], CuentaPrincipal_ID, NombreDeLaCuentaPrincipal as [Cuenta Principal], NombreDelControlDeCuenta as [Control De Cuenta], NombreDeUsuario as [Usuario] FROM v_ListaControlDeCuentas WHERE (NombreDeLaCuentaPrincipal +' '+ NombreDeUsuario + ' ' + NombreDelControlDeCuenta) LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvCuentas.DataSource = tabladedatos;
                    dgvCuentas.Columns[0].Width = 100;
                    dgvCuentas.Columns[1].Visible = false;
                    dgvCuentas.Columns[2].Width = 120;
                    dgvCuentas.Columns[3].Width = 120;
                    dgvCuentas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void btnAñadirCuentaPrincipal_Click(object sender, EventArgs e)
        {
            frmCuentaPrincipal frm = new frmCuentaPrincipal();
            frm.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarCuentaPrincipal(comboSeleccionarCuentaPrincipal);
        }

        private void frmControlDeCuenta_Load(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarCuentaPrincipal(comboSeleccionarCuentaPrincipal);
            btnActualizar_Click(sender, e);
            LlenarCuadro("");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (comboSeleccionarCuentaPrincipal.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarCuentaPrincipal, "Debe seleccionar una cuenta principal.");
                comboSeleccionarCuentaPrincipal.Focus();
                return;
            }
            if (textControlDeCuenta.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textControlDeCuenta, "Debe ingresar el nombre del control de cuenta.");
                textControlDeCuenta.Focus();
                return;
            }

            DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaControlDeCuentas WHERE NombreDelControlDeCuenta = '" + textControlDeCuenta.Text.Trim() + "' AND CuentaPrincipal_ID = '"+comboSeleccionarCuentaPrincipal.SelectedValue+"'");
            if (tabla_de_datos != null)
            {
                if (tabla_de_datos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textControlDeCuenta, "Ya existe.");
                    textControlDeCuenta.Focus();
                    return;
                }
            }

            string insertarquery = string.Format("INSERT INTO TablaControlDeCuentas(Usuario_ID,CuentaPrincipal_ID,NombreDelControlDeCuenta) VALUES('{0}','{1}','{2}')", UsuarioActual.UsuarioID, comboSeleccionarCuentaPrincipal.SelectedValue, textControlDeCuenta.Text.Trim());
            bool resultado = AccesoABaseDeDatos.Insertar(insertarquery);
            if (resultado)
            {
                MessageBox.Show("Guardado exitosamente.");
                textControlDeCuenta.Clear();
                comboSeleccionarCuentaPrincipal.SelectedIndex = 0;
                LlenarCuadro("");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textControlDeCuenta.Clear();
            comboSeleccionarCuentaPrincipal.SelectedIndex = 0;
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
            textControlDeCuenta.Clear();
            comboSeleccionarCuentaPrincipal.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarControl();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (comboSeleccionarCuentaPrincipal.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarCuentaPrincipal, "Debe seleccionar una cuenta principal");
                comboSeleccionarCuentaPrincipal.Focus();
                return;
            }
            if (textControlDeCuenta.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textControlDeCuenta, "Debe ingresar el nombre de la cuenta de control.");
                textControlDeCuenta.Focus();
                return;
            }

            DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaControlDeCuentas WHERE NombreDelControlDeCuenta = '" + textControlDeCuenta.Text.Trim() + "' AND CuentaPrincipal_ID = '" + comboSeleccionarCuentaPrincipal.SelectedValue + "' AND ControlDeCuentaID != '" + dgvCuentas.CurrentRow.Cells[0].Value+"'");
            if (tabla_de_datos != null)
            {
                if (tabla_de_datos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textControlDeCuenta, "Ya existe.");
                    textControlDeCuenta.Focus();
                    return;
                }
            }

            string actualizarquery = string.Format("UPDATE TablaControlDeCuentas SET Usuario_ID = '{0}',CuentaPrincipal_ID = '{1}',NombreDelControlDeCuenta = '{2}' WHERE ControlDeCuentaID = '{3}'", UsuarioActual.UsuarioID, comboSeleccionarCuentaPrincipal.SelectedValue, textControlDeCuenta.Text.Trim(), dgvCuentas.CurrentRow.Cells[0].Value);
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCuentas != null)
            {
                if (dgvCuentas.Rows.Count > 0)
                {
                    if (dgvCuentas.SelectedRows.Count == 1)
                    {
                        comboSeleccionarCuentaPrincipal.SelectedValue = Convert.ToInt32(dgvCuentas.CurrentRow.Cells[1].Value);
                        textControlDeCuenta.Text = Convert.ToString(dgvCuentas.CurrentRow.Cells[3].Value);
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

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarCuadro(textBusqueda.Text.Trim());
        }
    }
}
