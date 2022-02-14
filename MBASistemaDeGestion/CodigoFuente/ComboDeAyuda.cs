using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBASistemaDeGestion.CodigoFuente
{
    public class ComboDeAyuda
    {

        public static void LlenarTiposDeUsuario(ComboBox cmb)
        {
            DataTable tabladedatos_de_tipos_de_usuarios = new DataTable();
            tabladedatos_de_tipos_de_usuarios.Columns.Add("TipoDeUsuarioID");
            tabladedatos_de_tipos_de_usuarios.Columns.Add("TipoDeUsuario");
            tabladedatos_de_tipos_de_usuarios.Rows.Add("0", "Seleccionar");
            try
            {
                DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT TipoDeUsuarioID, TipoDeUsuario FROM TablaTiposDeUsuarios");
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count > 0)
                    {
                        foreach (DataRow tipos_de_usuarios in tabladedatos.Rows)
                        {
                            tabladedatos_de_tipos_de_usuarios.Rows.Add(tipos_de_usuarios["TipoDeUsuarioID"], tipos_de_usuarios["TipoDeUsuario"]);
                        }
                    }
                
                }
                cmb.DataSource = tabladedatos_de_tipos_de_usuarios;
                cmb.ValueMember = "TipoDeUsuarioID";
                cmb.DisplayMember = "TipoDeUsuario";
            }
            catch 
            {
                cmb.DataSource = tabladedatos_de_tipos_de_usuarios;
            }
        }

        public static void LlenarCategorias(ComboBox cmb)
        {
            DataTable tabladedatos_de_categorias = new DataTable();
            tabladedatos_de_categorias.Columns.Add("CategoriaID");
            tabladedatos_de_categorias.Columns.Add("NombreDeLaCategoria");
            tabladedatos_de_categorias.Rows.Add("0", "Seleccionar");
            try
            {
                DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT CategoriaID, NombreDeLaCategoria FROM TablaDeCategorias WHERE EstaBorrado = 0");
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count > 0)
                    {
                        foreach (DataRow categorias in tabladedatos.Rows)
                        {
                            tabladedatos_de_categorias.Rows.Add(categorias["CategoriaID"], categorias["NombreDeLaCategoria"]);
                        }
                    }

                }
                cmb.DataSource = tabladedatos_de_categorias;
                cmb.ValueMember = "CategoriaID";
                cmb.DisplayMember = "NombreDeLaCategoria";
            }
            catch
            {
                cmb.DataSource = tabladedatos_de_categorias;
            }
        }


        public static void LlenarProductoPorCategoria(ComboBox cmb, string categoriaid)
        {
            DataTable tabladedatos_de_productos = new DataTable();
            tabladedatos_de_productos.Columns.Add("ProductoID");
            tabladedatos_de_productos.Columns.Add("NombreDelProducto");
            tabladedatos_de_productos.Rows.Add("0", "Seleccionar");
            try
            {
                DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT ProductoID, NombreDelProducto FROM TablaDeExistencias WHERE Categoria_ID = '"+categoriaid.Trim()+"' AND EstaBorrado = 0");
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count > 0)
                    {
                        foreach (DataRow categorias in tabladedatos.Rows)
                        {
                            tabladedatos_de_productos.Rows.Add(categorias["ProductoID"], categorias["NombreDelProducto"]);
                        }
                    }

                }
                cmb.DataSource = tabladedatos_de_productos;
                cmb.ValueMember = "ProductoID";
                cmb.DisplayMember = "NombreDelProducto";
            }
            catch
            {
                cmb.DataSource = tabladedatos_de_productos;
            }
        }


        public static void LlenarCuentaPrincipal(ComboBox cmb)
        {
            DataTable tabladedatos_de_cuenta_principal = new DataTable();
            tabladedatos_de_cuenta_principal.Columns.Add("CuentaPrincipalID");
            tabladedatos_de_cuenta_principal.Columns.Add("NombreDeLaCuentaPrincipal");
            tabladedatos_de_cuenta_principal.Rows.Add("0", "Seleccionar");
            try
            {
                DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT CuentaPrincipalID, NombreDeLaCuentaPrincipal FROM TablaCuentaPrincipal");
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count > 0)
                    {
                        foreach (DataRow cuenta_principal in tabladedatos.Rows)
                        {
                            tabladedatos_de_cuenta_principal.Rows.Add(cuenta_principal["CuentaPrincipalID"], cuenta_principal["NombreDeLaCuentaPrincipal"]);
                        }
                    }
                }

                cmb.DataSource = tabladedatos_de_cuenta_principal;
                cmb.ValueMember = "CuentaPrincipalID";
                cmb.DisplayMember = "NombreDeLaCuentaPrincipal";
            }
            catch
            {
                cmb.DataSource = tabladedatos_de_cuenta_principal;
            }
        }

        public static void LlenarControlesDeCuentaPrincipal(ComboBox cmb, object principalid)
        {
            DataTable tabladedatos_de_control_de_cuentas = new DataTable();
            tabladedatos_de_control_de_cuentas.Columns.Add("ControlDeCuentaID");
            tabladedatos_de_control_de_cuentas.Columns.Add("NombreDelControlDeCuenta");
            tabladedatos_de_control_de_cuentas.Rows.Add("0", "Seleccionar");
            try
            {
                DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT ControlDeCuentaID, NombreDelControlDeCuenta FROM TablaControlDeCuentas WHERE CuentaPrincipal_ID = '" + principalid + "'");
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count > 0)
                    {
                        foreach (DataRow control_de_cuentas in tabladedatos.Rows)
                        {
                            tabladedatos_de_control_de_cuentas.Rows.Add(control_de_cuentas["ControlDeCuentaID"], control_de_cuentas["NombreDelControlDeCuenta"]);
                        }
                    }

                }
                cmb.DataSource = tabladedatos_de_control_de_cuentas;
                cmb.ValueMember = "ControlDeCuentaID";
                cmb.DisplayMember = "NombreDelControlDeCuenta";
            }
            catch
            {
                cmb.DataSource = tabladedatos_de_control_de_cuentas;
            }
        }

        public static void LlenarControlesDeCuentaPrincipal(ComboBox cmb)
        {
            DataTable tabladedatos_de_control_de_cuentas = new DataTable();
            tabladedatos_de_control_de_cuentas.Columns.Add("ControlDeCuentaID");
            tabladedatos_de_control_de_cuentas.Columns.Add("NombreDelControlDeCuenta");
            tabladedatos_de_control_de_cuentas.Rows.Add("0", "Seleccionar");
            try
            {
                DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT ControlDeCuentaID, NombreDelControlDeCuenta FROM TablaControlDeCuentas");
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count > 0)
                    {
                        foreach (DataRow control_de_cuentas in tabladedatos.Rows)
                        {
                            tabladedatos_de_control_de_cuentas.Rows.Add(control_de_cuentas["ControlDeCuentaID"], control_de_cuentas["NombreDelControlDeCuenta"]);
                        }
                    }

                }
                cmb.DataSource = tabladedatos_de_control_de_cuentas;
                cmb.ValueMember = "ControlDeCuentaID";
                cmb.DisplayMember = "NombreDelControlDeCuenta";
            }
            catch
            {
                cmb.DataSource = tabladedatos_de_control_de_cuentas;
            }
        }
    }
}
