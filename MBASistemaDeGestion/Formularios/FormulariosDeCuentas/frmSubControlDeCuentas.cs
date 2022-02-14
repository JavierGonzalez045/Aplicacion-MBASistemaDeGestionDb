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
    public partial class frmSubControlDeCuentas : Form
    {

        private string id = string.Empty;
        public frmSubControlDeCuentas()
        {
            InitializeComponent();
        }

        private void LlenarCuadro(string busqueda_a_realizar)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT SubControlDeCuentaID as [ID], CuentaPrincipal_ID, NombreDeLaCuentaPrincipal as [Cuenta Principal],ControlDeCuenta_ID,NombreDelControlDeCuenta as [Control De Cuenta],NombreDeSubControlDeCuenta [Sub Control], NombreDeUsuario as [Usuario] from v_ListaSubControlDeCuentas";
            }
            else
            {
                query = "SELECT SubControlDeCuentaID as [ID], CuentaPrincipal_ID, NombreDeLaCuentaPrincipal as [Cuenta Principal],ControlDeCuenta_ID,NombreDelControlDeCuenta as [Control De Cuenta],NombreDeSubControlDeCuenta [Sub Control], NombreDeUsuario as [Usuario] from v_ListaSubControlDeCuentas WHERE (NombreDeLaCuentaPrincipal +' '+ NombreDeUsuario + ' ' + NombreDelControlDeCuenta + ' ' +NombreDeSubControlDeCuenta) LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvSubControlDeCuentas.DataSource = tabladedatos;
                    dgvSubControlDeCuentas.Columns[0].Width = 100;
                    dgvSubControlDeCuentas.Columns[1].Visible = false;
                    dgvSubControlDeCuentas.Columns[2].Width = 120;
                    dgvSubControlDeCuentas.Columns[3].Visible = false;
                    dgvSubControlDeCuentas.Columns[4].Width = 140;
                    dgvSubControlDeCuentas.Columns[5].Width = 140;
                    dgvSubControlDeCuentas.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvSubControlDeCuentas.DataSource = null;
                }
            }
            else
            {
                dgvSubControlDeCuentas.DataSource = null;
            }
        }

        private void btnAñadirCuentaPrincipal_Click(object sender, EventArgs e)
        {
            frmCuentaPrincipal frm = new frmCuentaPrincipal();
            frm.ShowDialog();
        }

        private void btnActualizarPrincipal_Click(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarCuentaPrincipal(comboSeleccionarCuentaPrincipal);
        }

        private void HabilitarComponentes()
        {
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            dgvSubControlDeCuentas.Enabled = false;
            textBusqueda.Enabled = false;
        }

        private void DeshabilitarControl()
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;
            dgvSubControlDeCuentas.Enabled = true;
            textBusqueda.Enabled = true;
            LlenarCuadro("");
            RestablecerFormulario();
        }

        private void RestablecerFormulario()
        {
            textSubControlDeCuenta.Clear();
            comboSeleccionarCuentaPrincipal.SelectedIndex = 0;
        }


        private void btnAñadirControlesPrincipales_Click(object sender, EventArgs e)
        {
            frmControlDeCuenta frm = new frmControlDeCuenta();
            frm.ShowDialog();
            comboSeleccionarCuentaPrincipal_SelectedIndexChanged(sender, e);
        }

        private void comboSeleccionarCuentaPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarControlesDeCuentaPrincipal(comboSeleccionarControles, comboSeleccionarCuentaPrincipal.SelectedValue);
        }

        private void frmSubControlDeCuentas_Load(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarCuentaPrincipal(comboSeleccionarCuentaPrincipal);
            LlenarCuadro("");
        }

        private void btnActualizarControles_Click(object sender, EventArgs e)
        {
            comboSeleccionarCuentaPrincipal_SelectedIndexChanged(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarControl();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            RestablecerFormulario();
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarCuadro(textBusqueda.Text.Trim());
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

            if (comboSeleccionarControles.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarControles, "Debe seleccionar una cuenta de control.");
                comboSeleccionarControles.Focus();
                return;
            }

            if (textSubControlDeCuenta.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textSubControlDeCuenta, "Debe ingresar el nombre de la cuenta de sub control.");
                textSubControlDeCuenta.Focus();
                return;
            }

            DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaDeSubControlDeCuentas WHERE NombreDeSubControlDeCuenta = '" + textSubControlDeCuenta.Text.Trim() + "' AND CuentaPrincipal_ID = '" + comboSeleccionarCuentaPrincipal.SelectedValue + "' AND ControlDeCuenta_ID = '" + comboSeleccionarControles.SelectedValue+"' ");
            if (tabla_de_datos != null)
            {
                if (tabla_de_datos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textSubControlDeCuenta, "Ya existe.");
                    textSubControlDeCuenta.Focus();
                    return;
                }
            }

            string insertarquery = string.Format("INSERT INTO TablaDeSubControlDeCuentas(CuentaPrincipal_ID,ControlDeCuenta_ID,Usuario_ID,NombreDeSubControlDeCuenta) VALUES('{0}','{1}','{2}','{3}')", comboSeleccionarCuentaPrincipal.SelectedValue,comboSeleccionarControles.SelectedValue, UsuarioActual.UsuarioID, textSubControlDeCuenta.Text.Trim());
            bool resultado = AccesoABaseDeDatos.Insertar(insertarquery);
            if (resultado)
            {
                MessageBox.Show("Guardado exitosamente.");
                RestablecerFormulario();
                LlenarCuadro("");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }

        }

        private void textSubControlDeCuenta_TextChanged(object sender, EventArgs e)
        {
            LlenarCuadro(textBusqueda.Text.Trim());
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSubControlDeCuentas != null)
            {
                if (dgvSubControlDeCuentas.Rows.Count > 0)
                {
                    if (dgvSubControlDeCuentas.SelectedRows.Count == 1)
                    {

                        id = Convert.ToString(dgvSubControlDeCuentas.CurrentRow.Cells[0].Value);
                        comboSeleccionarCuentaPrincipal.SelectedValue = Convert.ToInt32(dgvSubControlDeCuentas.CurrentRow.Cells[1].Value);
                        comboSeleccionarControles.SelectedValue = Convert.ToInt32(dgvSubControlDeCuentas.CurrentRow.Cells[3].Value);
                        textSubControlDeCuenta.Text = Convert.ToString(dgvSubControlDeCuentas.CurrentRow.Cells[5].Value);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (comboSeleccionarCuentaPrincipal.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarCuentaPrincipal, "Debe seleccionar una cuenta principal.");
                comboSeleccionarCuentaPrincipal.Focus();
                return;
            }

            if (comboSeleccionarControles.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarControles, "Debe seleccionar una cuenta de control.");
                comboSeleccionarControles.Focus();
                return;
            }

            if (textSubControlDeCuenta.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textSubControlDeCuenta, "Debe ingresar el nombre de la cuenta de sub control.");
                textSubControlDeCuenta.Focus();
                return;
            }

            DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaDeSubControlDeCuentas WHERE NombreDeSubControlDeCuenta = '" + textSubControlDeCuenta.Text.Trim() + "' AND CuentaPrincipal_ID = '" + comboSeleccionarCuentaPrincipal.SelectedValue + "' AND ControlDeCuenta_ID = '" + comboSeleccionarControles.SelectedValue + "' AND SubControlDeCuentaID != '"+ id +"'");
            if (tabla_de_datos != null)
            {
                if (tabla_de_datos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textSubControlDeCuenta, "Ya existe.");
                    textSubControlDeCuenta.Focus();
                    return;
                }
            }

            string actualizarquery = string.Format("UPDATE TablaDeSubControlDeCuentas SET CuentaPrincipal_ID = '{0}',ControlDeCuenta_ID = '{1}',Usuario_ID = '{2}',NombreDeSubControlDeCuenta = '{3}' WHERE SubControlDeCuentaID = '{4}'", comboSeleccionarCuentaPrincipal.SelectedValue, comboSeleccionarControles.SelectedValue, UsuarioActual.UsuarioID, textSubControlDeCuenta.Text.Trim(), id);
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
    
    }
}
