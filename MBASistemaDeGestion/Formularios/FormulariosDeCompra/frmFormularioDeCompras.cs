using MBASistemaDeGestion.CodigoFuente;
using MBASistemaDeGestion.Formularios.FormulariosDeCuentas;
using MBASistemaDeGestion.Formularios.FormulariosDeProveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBASistemaDeGestion.Formularios.FormulariosDeCompra
{
    public partial class frmFormularioDeCompras : Form
    {

        public string seleccionarproveedorid = string.Empty;
        public frmFormularioDeCompras()
        {
            InitializeComponent();
        }

        private void EstablecerAnchoDelCarritoDeCompras()
        {
            dgvCarritoDeCompras.Columns[1].Width = 100;
            dgvCarritoDeCompras.Columns[3].Width = 150;
            dgvCarritoDeCompras.Columns[4].Width = 180;
            dgvCarritoDeCompras.Columns[5].Width = 120;
            dgvCarritoDeCompras.Columns[6].Width = 180;
            dgvCarritoDeCompras.Columns[7].Width = 150;
            dgvCarritoDeCompras.Columns[8].Width = 120;
            dgvCarritoDeCompras.Columns[9].Width = 180;
        }

        private void frmFormularioDeCompras_Load(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarCategorias(comboSeleccionarCategoria);
            ComboDeAyuda.LlenarControlesDeCuentaPrincipal(comboTodasLasCuentas);
            EstablecerAnchoDelCarritoDeCompras();
        }

        private void btnAñadirProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.ShowDialog();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBuscarProveedor frm = new frmBuscarProveedor(textBusqueda.Text.Trim(), this);
            frm.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboSeleccionarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarProductoPorCategoria(comboSeleccionarProducto,comboSeleccionarCategoria.SelectedValue.ToString());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarCategorias(comboSeleccionarCategoria);
        }

        private void comboSeleccionarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboSeleccionarProducto.SelectedIndex > 0)
                {
                    DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT TOP 1 PrecioDeCompraPorUnidad,PrecioDeVentaPorUnidad,UmbralDeCantidadDeExistencias FROM TablaDeExistencias WHERE ProductoID = '" + Convert.ToString(comboSeleccionarProducto.SelectedValue) + "'");
                    textCantidadDeCompra.Text = "0";
                    if (tabladedatos != null)
                    {
                        textPrecioDeCompraPorUnidad.Text = tabladedatos.Rows[0][0] == DBNull.Value ? "0" : Convert.ToString(tabladedatos.Rows[0][0]);
                        textPrecioDeVentaPorUnidad.Text = tabladedatos.Rows[0][1] == DBNull.Value ? "0" : Convert.ToString(tabladedatos.Rows[0][1]);
                        textCantidadUmbral.Text = tabladedatos.Rows[0][2] == DBNull.Value ? "0" : Convert.ToString(tabladedatos.Rows[0][2]);
                        return;
                    }
                    else
                    {
                        textPrecioDeCompraPorUnidad.Text = "0";
                        textPrecioDeVentaPorUnidad.Text = "0";
                        textCantidadUmbral.Text = "0";
                    }
                }
                else
                {
                    textPrecioDeCompraPorUnidad.Text = "0";
                    textPrecioDeVentaPorUnidad.Text = "0";
                    textCantidadUmbral.Text = "0";
                }

            }
            catch
            {
                textPrecioDeCompraPorUnidad.Text = "0";
                textPrecioDeVentaPorUnidad.Text = "0";
                textCantidadUmbral.Text = "0";
            }
        }

        private void textCantidadDeCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite que el usuario solo pueda ingresar numeros, el usuario no podra ingresar letras aunque las pulse

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textPrecioDeCompraPorUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void HabilitarComponentesDeActualizacion()
        {
            dgvCarritoDeCompras.Enabled = false;
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnIniciarNuevaCompra.Enabled = false;
            btnFinalizar.Enabled = false;
            checkBoxFacturaDePago.Enabled = false;
            groupBProveedor.Enabled = false;
        }

        private void RestablecerControles()
        {
            dgvCarritoDeCompras.Enabled = true;
            btnAgregar.Enabled = true;
            btnBorrar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnIniciarNuevaCompra.Enabled = true;
            btnFinalizar.Enabled = true;
            checkBoxFacturaDePago.Enabled = true;
            groupBProveedor.Enabled = true;
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            comboSeleccionarProducto.SelectedIndex = 0;
            dtpFechaDeExpiracion.Value = DateTime.Now;
            dtpFechaDeFabricacion.Value = DateTime.Now;
            textCantidadDeCompra.Text = "0";
            labelMontoRestante.Text = "0";
            labelMontoPagado.Text = "0";
            checkBoxFacturaDePago.Checked = false;
        }

        private void CalcularMontoTotal()
        {

            float monto_total_de_la_compra = 0;
            float pagado = 0;
            float pagorestante = 0;
            if (dgvCarritoDeCompras != null)
            {
                if (dgvCarritoDeCompras.Rows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgvCarritoDeCompras.Rows)
                    {
                        float costo_del_articulo = 0;
                        float.TryParse(Convert.ToString(item.Cells[9].Value).Trim(), out costo_del_articulo);
                        monto_total_de_la_compra = monto_total_de_la_compra + costo_del_articulo;
                        string CuentaPrincipal_ID = string.Empty;
                        string ControlDeCuenta_ID = string.Empty;
                        string SubControlDeCuenta_ID = string.Empty;
                        Cuentas.ObtenerDetallesDeCuentas(Convert.ToString(item.Cells[4].Value), out CuentaPrincipal_ID, out ControlDeCuenta_ID, out SubControlDeCuenta_ID);
                        // Assests 1        aumenta(Debito)     disminuye(Credito)
                        // Liabilities 2    aumenta(Credito)    disminuye(Debito)
                        // Expenses 3       aumenta(Debito)     disminuye(Credito)
                        // Capital 4        aumenta(Credito)    disminuye(Debito)
                        // Revenue 5        aumenta(Credito)    disminuye(Debito)

                        if (CuentaPrincipal_ID == "3" || CuentaPrincipal_ID == "1" || CuentaPrincipal_ID == "4")
                        {
                            pagorestante = pagorestante + costo_del_articulo;
                        }
                        else
                        {
                            pagado = pagado + costo_del_articulo;
                        }
                    }
                }
            }

            labelMontoTotal.Text = Convert.ToString(monto_total_de_la_compra);
            labelMontoPagado.Text = Convert.ToString(pagado);
            labelMontoRestante.Text = Convert.ToString(pagorestante);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (comboSeleccionarCategoria.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarCategoria, "Debe seleccionar la categoria.");
                comboSeleccionarCategoria.Focus();
                return;
            }

            if (comboSeleccionarProducto.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarProducto, "Debe seleccionar el producto.");
                comboSeleccionarProducto.Focus();
                return;
            }

            if (comboTodasLasCuentas.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboTodasLasCuentas, "Debe seleccionar la cuenta.");
                comboTodasLasCuentas.Focus();
                return;
            }

            if (textCantidadDeCompra.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textCantidadDeCompra, "Debe ingresar la cantidad de la compra a realizar");
                textCantidadDeCompra.Focus();
                return;
            }

            if (textPrecioDeCompraPorUnidad.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textPrecioDeCompraPorUnidad, "Debe ingresar el precio de compra por unidad del producto.");
                textPrecioDeCompraPorUnidad.Focus();
                return;
            }

            if (textPrecioDeVentaPorUnidad.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textPrecioDeVentaPorUnidad, "Debe ingresar el precio de venta por unidad del producto.");
                textPrecioDeVentaPorUnidad.Focus();
                return;
            }

            if (textCantidadUmbral.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textCantidadUmbral, "Debe ingresar la cantidad umbral");
                textCantidadUmbral.Focus();
                return;
            }

            if (dtpFechaDeExpiracion.Value.ToString("yyyy/MM/dd") == DateTime.Now.ToString("yyyy/MM/dd"))
            {
                proveedor_de_errores.SetError(dtpFechaDeExpiracion, "Debe ingresar la fecha de expiración.");
                dtpFechaDeExpiracion.Focus();
                return;
            }

            int cantidad_de_compra, cantidad_umbral;
            float precio_de_compra_por_unidad, precio_de_venta_por_unidad;

            int.TryParse(textCantidadDeCompra.Text.Trim(), out cantidad_de_compra);
            int.TryParse(textCantidadUmbral.Text.Trim(), out cantidad_umbral);

            float.TryParse(textPrecioDeCompraPorUnidad.Text.Trim(), out precio_de_compra_por_unidad);
            float.TryParse(textPrecioDeVentaPorUnidad.Text.Trim(), out precio_de_venta_por_unidad);

            if (precio_de_compra_por_unidad == 0)
            {
                proveedor_de_errores.SetError(textPrecioDeCompraPorUnidad, "Debe ingresar el precio de compra por unidad del producto.");
                textPrecioDeCompraPorUnidad.Focus();
                return;
            }

            if (precio_de_venta_por_unidad == 0)
            {
                proveedor_de_errores.SetError(textPrecioDeVentaPorUnidad, "Debe ingresar el precio de venta por unidad del producto.");
                textPrecioDeVentaPorUnidad.Focus();
                return;
            }

            if (precio_de_compra_por_unidad > precio_de_venta_por_unidad)
            {
                proveedor_de_errores.SetError(textPrecioDeVentaPorUnidad, "El precio de venta debe ser mayor o igual al precio de compra!");
                textPrecioDeVentaPorUnidad.Focus();
                textPrecioDeVentaPorUnidad.SelectAll();
                return;
            }

            if (cantidad_de_compra == 0)
            {
                proveedor_de_errores.SetError(textCantidadDeCompra, "Debe ingresar la cantidad de la compra a realizar");
                textCantidadDeCompra.Focus();
                return;
            }

            if (cantidad_umbral == 0)
            {
                proveedor_de_errores.SetError(textCantidadUmbral, "Debe ingresar la cantidad umbral");
                textCantidadUmbral.Focus();
                return;
            }

            if (dgvCarritoDeCompras != null)
            {
                if (dgvCarritoDeCompras.Rows.Count > 0)
                {
                    foreach (DataGridViewRow comprobarfila in dgvCarritoDeCompras.Rows)
                    {
                        if (Convert.ToString(comprobarfila.Cells[0].Value) == Convert.ToString(comboSeleccionarCategoria.SelectedValue) &&
                            Convert.ToString(comprobarfila.Cells[2].Value) == Convert.ToString(comboSeleccionarProducto.SelectedValue))
                        {
                            proveedor_de_errores.SetError(comboSeleccionarProducto, "Ya está agregado en el carrito de compras!");
                            comboSeleccionarProducto.Focus();
                            comprobarfila.Selected = true;
                            return;
                        }
                    }
                }
            }

            DataGridViewRow crearfila = new DataGridViewRow();
            crearfila.CreateCells(dgvCarritoDeCompras);
            crearfila.Cells[0].Value = comboSeleccionarCategoria.SelectedValue;
            crearfila.Cells[1].Value = comboSeleccionarCategoria.Text;
            crearfila.Cells[2].Value = comboSeleccionarProducto.SelectedValue;
            crearfila.Cells[3].Value = comboSeleccionarProducto.Text;
            crearfila.Cells[4].Value = comboTodasLasCuentas.Text;
            crearfila.Cells[5].Value = textCantidadDeCompra.Text.Trim();
            crearfila.Cells[6].Value = textPrecioDeCompraPorUnidad.Text.Trim();
            crearfila.Cells[7].Value = textPrecioDeVentaPorUnidad.Text.Trim();
            crearfila.Cells[8].Value = textCantidadUmbral.Text.Trim();
            crearfila.Cells[9].Value = Convert.ToString(cantidad_de_compra * precio_de_compra_por_unidad);
            crearfila.Cells[10].Value = dtpFechaDeFabricacion.Value;
            crearfila.Cells[11].Value = dtpFechaDeExpiracion.Value;
            dgvCarritoDeCompras.Rows.Add(crearfila);
            LimpiarFormulario();
            CalcularMontoTotal();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvCarritoDeCompras != null)
            {
                if(dgvCarritoDeCompras.Rows.Count > 0)
                {
                    if(dgvCarritoDeCompras.SelectedRows.Count == 1)
                    {
                        comboSeleccionarCategoria.SelectedValue = Convert.ToString(dgvCarritoDeCompras.CurrentRow.Cells[0].Value);
                        comboSeleccionarProducto.SelectedValue = Convert.ToString(dgvCarritoDeCompras.CurrentRow.Cells[2].Value);
                        comboTodasLasCuentas.Text = Convert.ToString(dgvCarritoDeCompras.CurrentRow.Cells[4].Value);
                        textCantidadDeCompra.Text = Convert.ToString(dgvCarritoDeCompras.CurrentRow.Cells[5].Value);
                        textPrecioDeCompraPorUnidad.Text = Convert.ToString(dgvCarritoDeCompras.CurrentRow.Cells[6].Value);
                        textPrecioDeVentaPorUnidad.Text = Convert.ToString(dgvCarritoDeCompras.CurrentRow.Cells[7].Value);
                        textCantidadUmbral.Text = Convert.ToString(dgvCarritoDeCompras.CurrentRow.Cells[8].Value);
                        dtpFechaDeFabricacion.Value = Convert.ToDateTime(dgvCarritoDeCompras.CurrentRow.Cells[10].Value);
                        dtpFechaDeExpiracion.Value = Convert.ToDateTime(dgvCarritoDeCompras.CurrentRow.Cells[11].Value);
                        HabilitarComponentesDeActualizacion();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un registro.");
                    }
                }
                else
                {
                    MessageBox.Show("El carrito de compras está vacío.");
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCarritoDeCompras != null)
            {
                if (dgvCarritoDeCompras.Rows.Count > 0)
                {
                    if (dgvCarritoDeCompras.SelectedRows.Count == 1)
                    {
                        if(MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dgvCarritoDeCompras.Rows.RemoveAt(dgvCarritoDeCompras.CurrentRow.Index);
                            CalcularMontoTotal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un registro.");
                    }
                }
                else
                {
                    MessageBox.Show("El carrito de compras está vacío.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestablecerControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (comboSeleccionarCategoria.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarCategoria, "Debe seleccionar la categoria.");
                comboSeleccionarCategoria.Focus();
                return;
            }

            if (comboSeleccionarProducto.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarProducto, "Debe seleccionar el producto.");
                comboSeleccionarProducto.Focus();
                return;
            }

            if (comboTodasLasCuentas.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboTodasLasCuentas, "Debe seleccionar la cuenta.");
                comboTodasLasCuentas.Focus();
                return;
            }

            if (textCantidadDeCompra.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textCantidadDeCompra, "Debe ingresar la cantidad de la compra a realizar");
                textCantidadDeCompra.Focus();
                return;
            }

            if (textPrecioDeCompraPorUnidad.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textPrecioDeCompraPorUnidad, "Debe ingresar el precio de compra por unidad del producto.");
                textPrecioDeCompraPorUnidad.Focus();
                return;
            }

            if (textPrecioDeVentaPorUnidad.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textPrecioDeVentaPorUnidad, "Debe ingresar el precio de venta por unidad del producto.");
                textPrecioDeVentaPorUnidad.Focus();
                return;
            }

            if (textCantidadUmbral.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textCantidadUmbral, "Debe ingresar la cantidad umbral");
                textCantidadUmbral.Focus();
                return;
            }

            if (dtpFechaDeExpiracion.Value.ToString("yyyy/MM/dd") == DateTime.Now.ToString("yyyy/MM/dd"))
            {
                proveedor_de_errores.SetError(dtpFechaDeExpiracion, "Debe ingresar la fecha de expiración.");
                dtpFechaDeExpiracion.Focus();
                return;
            }

            int cantidad_de_compra, cantidad_umbral;
            float precio_de_compra_por_unidad, precio_de_venta_por_unidad;

            int.TryParse(textCantidadDeCompra.Text.Trim(), out cantidad_de_compra);
            int.TryParse(textCantidadUmbral.Text.Trim(), out cantidad_umbral);

            float.TryParse(textPrecioDeCompraPorUnidad.Text.Trim(), out precio_de_compra_por_unidad);
            float.TryParse(textPrecioDeVentaPorUnidad.Text.Trim(), out precio_de_venta_por_unidad);

            if (precio_de_compra_por_unidad == 0)
            {
                proveedor_de_errores.SetError(textPrecioDeCompraPorUnidad, "Debe ingresar el precio de compra por unidad del producto.");
                textPrecioDeCompraPorUnidad.Focus();
                return;
            }

            if (precio_de_venta_por_unidad == 0)
            {
                proveedor_de_errores.SetError(textPrecioDeVentaPorUnidad, "Debe ingresar el precio de venta por unidad del producto.");
                textPrecioDeVentaPorUnidad.Focus();
                return;
            }

            if (precio_de_compra_por_unidad > precio_de_venta_por_unidad)
            {
                proveedor_de_errores.SetError(textPrecioDeVentaPorUnidad, "El precio de venta debe ser mayor o igual al precio de compra!");
                textPrecioDeVentaPorUnidad.Focus();
                textPrecioDeVentaPorUnidad.SelectAll();
                return;
            }

            if (cantidad_de_compra == 0)
            {
                proveedor_de_errores.SetError(textCantidadDeCompra, "Debe ingresar la cantidad de la compra a realizar");
                textCantidadDeCompra.Focus();
                return;
            }

            if (cantidad_umbral == 0)
            {
                proveedor_de_errores.SetError(textCantidadUmbral, "Debe ingresar la cantidad umbral");
                textCantidadUmbral.Focus();
                return;
            }

            int actualizarindexdelafila = dgvCarritoDeCompras.CurrentRow.Index;

            if (dgvCarritoDeCompras != null)
            {
                if (dgvCarritoDeCompras.Rows.Count > 0)
                {
                    foreach (DataGridViewRow comprobarfila in dgvCarritoDeCompras.Rows)
                    {
                        if (Convert.ToString(comprobarfila.Cells[0].Value) == Convert.ToString(comboSeleccionarCategoria.SelectedValue) &&
                            Convert.ToString(comprobarfila.Cells[2].Value) == Convert.ToString(comboSeleccionarProducto.SelectedValue) &&
                            comprobarfila.Index != actualizarindexdelafila)
                        {
                            proveedor_de_errores.SetError(comboSeleccionarProducto, "Ya está agregado en el carrito de compras!");
                            comboSeleccionarProducto.Focus();
                            comprobarfila.Selected = true;
                            return;
                        }
                    }
                }
            }

            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[0].Value = comboSeleccionarCategoria.SelectedValue;
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[1].Value = comboSeleccionarCategoria.Text;
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[2].Value = comboSeleccionarProducto.SelectedValue;
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[3].Value = comboSeleccionarProducto.Text;
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[4].Value = comboTodasLasCuentas.Text;
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[5].Value = textCantidadDeCompra.Text.Trim();
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[6].Value = textPrecioDeCompraPorUnidad.Text.Trim();
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[7].Value = textPrecioDeVentaPorUnidad.Text.Trim();
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[8].Value = textCantidadUmbral.Text.Trim();
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[9].Value = Convert.ToString(cantidad_de_compra * precio_de_compra_por_unidad);
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[10].Value = dtpFechaDeFabricacion.Value;
            dgvCarritoDeCompras.Rows[actualizarindexdelafila].Cells[11].Value = dtpFechaDeExpiracion.Value;
            RestablecerControles();
            CalcularMontoTotal();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            int proveedorid = 0;
            int.TryParse(seleccionarproveedorid, out proveedorid);

            if(proveedorid == 0)
            {
                proveedor_de_errores.SetError(textBusqueda, "Debe seleccionar un proveedor");
                textBusqueda.Focus();
                return;
            }
            if(dgvCarritoDeCompras == null || dgvCarritoDeCompras.Rows.Count == 0)
            {
                proveedor_de_errores.SetError(dgvCarritoDeCompras, "El carrito de compras está vacío");
                dgvCarritoDeCompras.Focus();
                return;
            }
            CalcularMontoTotal();
            string nofactura = "PUR"+DateTime.Now.ToString("yyyyMMddHHmmssmm");
            string titulodelacompra = "Compra de " + labelProveedor.Text.Trim();
            float montototaldelacompra = 0;
            float.TryParse(labelMontoRestante.Text.Trim(), out montototaldelacompra);
            string AñoFinanciero_ID = (AccesoABaseDeDatos.Seleccionar("SELECT TOP 1 AñoFinancieroID FROM TablaAñoFinanciero WHERE EstaActivo = 1") != null ? Convert.ToString(AccesoABaseDeDatos.Seleccionar("SELECT TOP 1 AñoFinancieroID FROM TablaAñoFinanciero WHERE EstaActivo = 1").Rows[0][0]) : string.Empty);
            if (string.IsNullOrEmpty(AñoFinanciero_ID))
            {
                MessageBox.Show("Debe establecer el año fiscal");
                frmAñoFiscal frm = new frmAñoFiscal();
                frm.ShowDialog();
                return;
            }


            // Agrega los detalles a la factura principal
            string insertarfacturadelproveedor = string.Format("INSERT INTO TablaFacturaDelProveedor(Proveedor_ID, Usuario_ID, NoDeFactura, Titulo, MontoTotal, FechaDeLaFactura, Descripcion) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                   proveedorid, UsuarioActual.UsuarioID, nofactura, titulodelacompra, montototaldelacompra, DateTime.Now, "");
            bool resultado = AccesoABaseDeDatos.Insertar(insertarfacturadelproveedor);
            if (resultado == false)
            {
                proveedor_de_errores.SetError(btnFinalizar, "Verifique que toda la información esté correcta\n antes de finalizar la compra");
                btnFinalizar.Focus();
                return;
            }

            // Obtiene las facturas de compras por ID
            string facturadelproveedorid = Convert.ToString(AccesoABaseDeDatos.Seleccionar("SELECT MAX(FacturaDelProveedorID) FROM TablaFacturaDelProveedor").Rows[0][0]);
            if (string.IsNullOrEmpty(facturadelproveedorid))
            {
                proveedor_de_errores.SetError(btnFinalizar, "Verifique que toda la información esté correcta\n antes de finalizar la compra");
                btnFinalizar.Focus();
                return;
            }
            string mensajecompraexitosa = "Comprado Exitosamente!";
            foreach (DataGridViewRow filadelproducto in dgvCarritoDeCompras.Rows)
            {
                // Agrega los detalles en la factura por producto
                string querydetallesdefactura = string.Format("INSERT INTO TablaDetallesDeLaFacturaDelProveedor(FacturaDelProveedor_ID, Producto_ID, CantidadDeCompra, PrecioDeCompraPorUnidad) VALUES('{0}','{1}','{2}','{3}')",
                facturadelproveedorid,filadelproducto.Cells[2].Value, filadelproducto.Cells[5].Value, filadelproducto.Cells[6].Value);
                bool resultadodetallesdefactura = AccesoABaseDeDatos.Insertar(querydetallesdefactura);
                if (resultadodetallesdefactura == false)
                {
                    break;
                }
                
                string cantidadcompra = Convert.ToString(filadelproducto.Cells[5].Value);

                string cuentaPrincipal_ID = string.Empty;
                string controlDeCuenta_ID = string.Empty;
                string subControlDeCuenta_ID = string.Empty;
                Cuentas.ObtenerDetallesDeCuentas(Convert.ToString(filadelproducto.Cells[4].Value), out cuentaPrincipal_ID, out controlDeCuenta_ID, out subControlDeCuenta_ID);
                // Assests 1        aumenta(Debito)     disminuye(Credito)
                // Liabilities 2    aumenta(Credito)    disminuye(Debito)
                // Expenses 3       aumenta(Debito)     disminuye(Credito)
                // Capital 4        aumenta(Credito)    disminuye(Debito)
                // Revenue 5        aumenta(Credito)    disminuye(Debito) 
                string querycredito = string.Empty;
                string querydebito = string.Empty;
                string titulodetransaccion = string.Empty;
                if(controlDeCuenta_ID == "13")  // Costo directo
                {
                    titulodetransaccion = "Compra de " + labelProveedor.Text.Trim();
                    querycredito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID,NoDeFactura, Usuario_ID,Credito,Debito,FechaDeLaTransaccion,TituloDeLaTransaccion) VALUES "+
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, "2", "3", "1", nofactura, UsuarioActual.UsuarioID, Convert.ToString(filadelproducto.Cells[9].Value), "0", DateTime.Now, titulodetransaccion);

                    titulodetransaccion = labelProveedor.Text.Trim() + " , Pago de compra pendiente";
                    querydebito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID,NoDeFactura, Usuario_ID,Credito,Debito,FechaDeLaTransaccion,TituloDeLaTransaccion) VALUES " +
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, cuentaPrincipal_ID, controlDeCuenta_ID, subControlDeCuenta_ID, nofactura, UsuarioActual.UsuarioID, "0", Convert.ToString(filadelproducto.Cells[9].Value), DateTime.Now, titulodetransaccion);

                    AccesoABaseDeDatos.Insertar(querycredito);
                    AccesoABaseDeDatos.Insertar(querydebito);
                }
                else if (controlDeCuenta_ID == "3") // Cuentas por pagar
                {
                    titulodetransaccion = "Pago a " + labelProveedor.Text.Trim();
                    querycredito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, "1", "1", "1", nofactura, UsuarioActual.UsuarioID, Convert.ToString(filadelproducto.Cells[9].Value), "0", DateTime.Now, titulodetransaccion);

                    titulodetransaccion = labelProveedor.Text.Trim() + " , Pago de compra realizado exitosamente";
                    querydebito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, cuentaPrincipal_ID, controlDeCuenta_ID, subControlDeCuenta_ID, nofactura, UsuarioActual.UsuarioID, "0", Convert.ToString(filadelproducto.Cells[9].Value), DateTime.Now, titulodetransaccion);

                    AccesoABaseDeDatos.Insertar(querycredito);
                    AccesoABaseDeDatos.Insertar(querydebito);
                }
                else if (controlDeCuenta_ID == "2") // Cuentas por cobrar
                {
                    titulodetransaccion = "Obtener productos pagados de " + labelProveedor.Text.Trim();
                    querycredito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, cuentaPrincipal_ID, controlDeCuenta_ID, subControlDeCuenta_ID, nofactura, UsuarioActual.UsuarioID, Convert.ToString(filadelproducto.Cells[9].Value), "0", DateTime.Now, titulodetransaccion);

                    titulodetransaccion = labelProveedor.Text.Trim() + " , Productos pagados obtenidos";
                    querydebito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, "3", "13", subControlDeCuenta_ID, nofactura, UsuarioActual.UsuarioID, "0", Convert.ToString(filadelproducto.Cells[9].Value), DateTime.Now, titulodetransaccion);

                    AccesoABaseDeDatos.Insertar(querycredito);
                    AccesoABaseDeDatos.Insertar(querydebito);
                }
                else if (controlDeCuenta_ID == "24") // Devolver compra
                {
                    titulodetransaccion = "Devolver productos a " + labelProveedor.Text.Trim();
                    querycredito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, cuentaPrincipal_ID, controlDeCuenta_ID, subControlDeCuenta_ID, nofactura, UsuarioActual.UsuarioID, Convert.ToString(filadelproducto.Cells[9].Value), "0", DateTime.Now, titulodetransaccion);

                    titulodetransaccion = labelProveedor.Text.Trim() + " , Productos pagados obtenidos";
                    querydebito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, "1", "2", "1", nofactura, UsuarioActual.UsuarioID, "0", Convert.ToString(filadelproducto.Cells[9].Value), DateTime.Now, titulodetransaccion);

                    AccesoABaseDeDatos.Insertar(querycredito);
                    AccesoABaseDeDatos.Insertar(querydebito);
                    cantidadcompra = "-" + cantidadcompra;
                }
                else if (controlDeCuenta_ID == "23") // Productos de capital
                {
                    titulodetransaccion = "Propietario de inversión en productos " + labelProveedor.Text.Trim();
                    querycredito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, cuentaPrincipal_ID, controlDeCuenta_ID, subControlDeCuenta_ID, nofactura, UsuarioActual.UsuarioID, Convert.ToString(filadelproducto.Cells[9].Value), "0", DateTime.Now, titulodetransaccion);

                    titulodetransaccion = labelProveedor.Text.Trim() + " , Productos obtenidos del propietario";
                    querydebito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        AñoFinanciero_ID, "3", "13", subControlDeCuenta_ID, nofactura, UsuarioActual.UsuarioID, "0", Convert.ToString(filadelproducto.Cells[9].Value), DateTime.Now, titulodetransaccion);
                    AccesoABaseDeDatos.Insertar(querycredito);
                    AccesoABaseDeDatos.Insertar(querydebito);
                }

                // Actualiza existencias
                string queryactualizarexistencias = string.Format("UPDATE TablaDeExistencias SET Cantidad = Cantidad + '{0}', PrecioDeVentaPorUnidad = '{1}', PrecioDeCompraPorUnidad = '{2}', FechaDeExpiracion = '{3}', FechaDeFabricacion = '{4}', UmbralDeCantidadDeExistencias = '{5}', WHERE ProductoID = '{6}'",
                cantidadcompra, Convert.ToString(filadelproducto.Cells[7].Value).Trim(), Convert.ToString(filadelproducto.Cells[6].Value).Trim(), Convert.ToString(filadelproducto.Cells[11].Value).Trim(), Convert.ToString(filadelproducto.Cells[10].Value).Trim(), Convert.ToString(filadelproducto.Cells[8].Value).Trim(), Convert.ToString(filadelproducto.Cells[2].Value).Trim());
                bool resultadoactualizarproducto = AccesoABaseDeDatos.Actualizar(queryactualizarexistencias);
                if (resultadoactualizarproducto == false)
                {
                    Cuentas.EliminarDetallesFacturaDeCompra(facturadelproveedorid); // Esto estaba comentado en el video
                    Cuentas.EliminarDetallesDeTransaccion(nofactura); // Esto tambien
                    break;
                }
            }

            if(checkBoxFacturaDePago.Checked == true)
            {
                string titulodetransaccion = "Pago a " + labelProveedor.Text.Trim();
                string querycredito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                    " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                    AñoFinanciero_ID, "1", "1", "1", nofactura, UsuarioActual.UsuarioID, montototaldelacompra, "0", DateTime.Now, titulodetransaccion);

                titulodetransaccion = labelProveedor.Text.Trim() + " , Pago de compra realizado exitosamente";
                string querydebito = string.Format("INSERT INTO TablaDeTransacciones (AñoFinanciero_ID, CuentaPrincipal_ID, ControlDeCuenta_ID, SubControlDeCuenta_ID, NoDeFactura, Usuario_ID, Credito, Debito, FechaDeLaTransaccion, TituloDeLaTransaccion) VALUES " +
                    " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                    AñoFinanciero_ID, "2", "3", "1", nofactura, UsuarioActual.UsuarioID, "0", montototaldelacompra, DateTime.Now, titulodetransaccion);
                AccesoABaseDeDatos.Insertar(querycredito);
                AccesoABaseDeDatos.Insertar(querydebito);
                mensajecompraexitosa = mensajecompraexitosa + "\nCon Factura De Pago.";
            }

            string querypago = string.Format("INSERT INTO TablaPagosDelProveedor(Proveedor_ID, FacturaDelProveedor_ID, Usuario_ID, NoDeFactura, MontoTotal, MontoDelPago, BalanceRestante) " +
                                             "VALUES('{0}', '{1}', '{2}', '{3}',(SELECT MontoTotal FROM TablaPagosDelProveedor WHERE PagoDelProveedorID = (SELECT MAX(PagoDelProveedorID) FROM TablaPagosDelProveedor WHERE Proveedor_ID = '{4}')) + '{5}', '{6}', " +
                                             "((SELECT MontoTotal FROM TablaPagosDelProveedor WHERE PagoDelProveedorID = (SELECT MAX(PagoDelProveedorID) FROM TablaPagosDelProveedor WHERE Proveedor_ID = '{7}')) +'{8}') -'{9}' )) ",
                                             proveedorid, facturadelproveedorid, UsuarioActual.UsuarioID, nofactura, proveedorid, montototaldelacompra, labelMontoPagado.Text.Trim(), proveedorid, montototaldelacompra, labelMontoPagado.Text.Trim());
            AccesoABaseDeDatos.Insertar(querypago);
            MessageBox.Show(mensajecompraexitosa);
            this.Close();
        }
    }
}
