using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBASistemaDeGestion.CodigoFuente;

namespace MBASistemaDeGestion.Formularios.FormulariosDeExistencia
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarCategorias(comboSeleccionarCategoria);
            LlenarCuadro("");
        }

        private void btnAñadirCategoria_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.ShowDialog();
            ComboDeAyuda.LlenarCategorias(comboSeleccionarCategoria);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarCategorias(comboSeleccionarCategoria);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();

            if (comboSeleccionarCategoria.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarCategoria, "Debe seleccionar la categoria.");
                comboSeleccionarCategoria.Focus();
                return;
            }
            if (textNombreDelProducto.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNombreDelProducto, "Debe ingresar el nombre del producto.");
                textNombreDelProducto.Focus();
                return;
            }

            string validarquery = string.Format("SELECT * FROM TablaDeExistencias WHERE Categoria_ID = '{0}' AND NombreDelProducto = '{1}'", comboSeleccionarCategoria.SelectedValue, textNombreDelProducto.Text.Trim());
            DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar(validarquery);
            if (tabla_de_datos != null)
            {
                if (tabla_de_datos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textNombreDelProducto, "Ya existe.");
                    textNombreDelProducto.Focus();
                    return;
                }
            }

            string insertarquery = string.Format("INSERT INTO TablaDeExistencias(Categoria_ID,Usuario_ID,NombreDelProducto,FechaDeExpiracion,FechaDeFabricacion,Descripcion) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", comboSeleccionarCategoria.SelectedValue, UsuarioActual.UsuarioID, textNombreDelProducto.Text.Trim(), dtpFechaDeCaducacion.Value.ToString("yyyy/MM/dd"), dtpFechaDeFabricacion.Value.ToString("yyyy/MM/dd"), textDescripcion.Text.Trim());
            bool resultado = AccesoABaseDeDatos.Insertar(insertarquery);
            if (resultado)
            {
                MessageBox.Show("Producto agregado exitosamente.");
                LimpiarFormulario();
                LlenarCuadro("");
            }
        }

        private void LlenarCuadro(string busqueda_a_realizar)
        {

            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT * FROM v_ListaDeProductos";
            }
            else
            {
                query = "SELECT * FROM v_ListaDeProductos WHERE (Categoría +' '+Producto +''+ [Usuario] +''+ Descripción) LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvListaDeProductos.DataSource = tabladedatos;
                    dgvListaDeProductos.Columns[0].Width = 100;
                    dgvListaDeProductos.Columns[1].Visible = false;
                    dgvListaDeProductos.Columns[2].Width = 120;
                    dgvListaDeProductos.Columns[3].Visible = false;
                    dgvListaDeProductos.Columns[4].Width = 150;
                    dgvListaDeProductos.Columns[5].Width = 150;
                    dgvListaDeProductos.Columns[6].Width = 150;
                    dgvListaDeProductos.Columns[7].Width = 150;
                    dgvListaDeProductos.Columns[8].Width = 150;
                    dgvListaDeProductos.Columns[9].Width = 150;
                    dgvListaDeProductos.Columns[10].Width = 150;
                    dgvListaDeProductos.Columns[11].Width = 150;
                    dgvListaDeProductos.Columns[12].Width = 100;
                    dgvListaDeProductos.Columns[13].Width = 300;

                    //dgvListaDeProductos.Columns[0].Width = 100;
                    //dgvListaDeProductos.Columns[1].Width = 100;
                    //dgvListaDeProductos.Columns[2].Width = 100;
                }
                else
                {
                    dgvListaDeProductos.DataSource = null;
                }
            }
            else
            {
                dgvListaDeProductos.DataSource = null;
            }
        }
        

        private void LimpiarFormulario()
        {
            textDescripcion.Clear();
            comboSeleccionarCategoria.SelectedIndex = 0;
            textNombreDelProducto.Clear();
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarCuadro(textBusqueda.Text.Trim());
        }
    }
}
