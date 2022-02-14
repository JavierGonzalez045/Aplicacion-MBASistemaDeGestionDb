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
    public partial class frmAñoFiscal : Form
    {
        public frmAñoFiscal()
        {
            InitializeComponent();
        }

        private void LlenarCuadro(string busqueda_a_realizar)
        {
            string query = string.Empty;
            checkBoxActivo.Enabled = false;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT AñoFiscalID,AñoFiscal,FechaDeInicio,FechaFinal,EstaActivo FROM TablaAñoFiscal";
            }
            else
            {
                query = "SELECT AñoFiscalID,AñoFiscal,FechaDeInicio,FechaFinal,EstaActivo FROM TablaAñoFiscal WHERE AñoFiscal LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvListaDelAñoFiscal.DataSource = tabladedatos;
                    dgvListaDelAñoFiscal.Columns[0].Width = 100;
                    dgvListaDelAñoFiscal.Columns[1].Width = 150;
                    dgvListaDelAñoFiscal.Columns[2].Width = 170;
                    dgvListaDelAñoFiscal.Columns[3].Width = 120;
                    dgvListaDelAñoFiscal.Columns[4].Width = 80;
                }
                else
                {
                    dgvListaDelAñoFiscal.DataSource = null;
                }
            }
            else
            {
                dgvListaDelAñoFiscal.DataSource = null;
            }
        }

        private void HabilitarComponentes()
        {
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            dgvListaDelAñoFiscal.Enabled = false;
            textBusqueda.Enabled = false;
            checkBoxActivo.Enabled = true;
        }

        private void DeshabilitarControl()
        {
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;
            dgvListaDelAñoFiscal.Enabled = true;
            textBusqueda.Enabled = true;
            LlenarCuadro("");
            checkBoxActivo.Enabled = false;
            RestablecerFormulario();
        }

        private void RestablecerFormulario()
        {
            dateTimePickerFechaInicial.Value = DateTime.Now;
            textTituloDelAñoFiscal.Clear();
        }

        private void frmAñoFiscal_Load(object sender, EventArgs e)
        {
            LlenarCuadro("");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            RestablecerFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarControl();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListaDelAñoFiscal != null)
            {
                if (dgvListaDelAñoFiscal.Rows.Count > 0)
                {
                    if (dgvListaDelAñoFiscal.SelectedRows.Count == 1)
                    {
                        textTituloDelAñoFiscal.Text = Convert.ToString(dgvListaDelAñoFiscal.CurrentRow.Cells[1].Value);
                        dateTimePickerFechaInicial.Value = Convert.ToDateTime(dgvListaDelAñoFiscal.CurrentRow.Cells[2].Value);
                        checkBoxActivo.Checked = Convert.ToBoolean(dgvListaDelAñoFiscal.CurrentRow.Cells[4].Value);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textTituloDelAñoFiscal.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textTituloDelAñoFiscal, "Debe ingresar el título del año financiero");
                textTituloDelAñoFiscal.Focus();
                return;
            }


            DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaAñoFiscal WHERE AñoFiscal = '" + textTituloDelAñoFiscal.Text.Trim() + "'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textTituloDelAñoFiscal, "Ya existe.");
                    textTituloDelAñoFiscal.Focus();
                    return;
                }
            }

            string insertarquery = string.Format("INSERT INTO TablaAñoFiscal(AñoFiscal,FechaDeInicio,FechaFinal,EstaActivo) VALUES('{0}','{1}',DATEADD(DAY,-1,(DATEADD(YY,1,'{2}'))),'{3}')",
                                                               textTituloDelAñoFiscal.Text.Trim(),dateTimePickerFechaInicial.Value.ToString("yyyy/MM/dd"), dateTimePickerFechaInicial.Value.ToString("yyyy/MM/dd"),checkBoxActivo.Checked);

            bool resultado = AccesoABaseDeDatos.Insertar(insertarquery);
            if (resultado)
            {
                MessageBox.Show("Guardado exitosamente.");
                checkBoxActivo.Checked = false;
                RestablecerFormulario();
                LlenarCuadro("");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (textTituloDelAñoFiscal.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textTituloDelAñoFiscal, "Debe ingresar el título del año financiero");
                textTituloDelAñoFiscal.Focus();
                return;
            }


            DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaCuentaPrincipal WHERE NombreDeLaCuentaPrincipal = '" + textTituloDelAñoFiscal.Text.Trim() + "' AND AñoFiscalID != '"+dgvListaDelAñoFiscal.CurrentRow.Cells[0].Value+"'");
            if (tabla_de_datos != null)
            {
                if (tabla_de_datos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textTituloDelAñoFiscal, "Ya existe.");
                    textTituloDelAñoFiscal.Focus();
                    return;
                }
            }

            string actualizarquery = string.Format("UPDATE TablaAñoFiscal SET AñoFiscal = '{0}',FechaDeInicio = '{1}',FechaFinal = DATEADD(DAY,-1,(DATEADD(YY,1,'{2}'))),EstaActivo = '{3}' WHERE AñoFiscalID = '{4}'",
                                                               textTituloDelAñoFiscal.Text.Trim(), dateTimePickerFechaInicial.Value.ToString("yyyy/MM/dd"), dateTimePickerFechaInicial.Value.ToString("yyyy/MM/dd"), checkBoxActivo.Checked, dgvListaDelAñoFiscal.CurrentRow.Cells[0].Value);

            bool resultado = AccesoABaseDeDatos.Actualizar(actualizarquery);
            if (resultado)
            {
                MessageBox.Show("Actualizado exitosamente.");
                checkBoxActivo.Checked = false;
                DeshabilitarControl();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }
    }
}
