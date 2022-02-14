using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBASistemaDeGestion.CodigoFuente
{
    class Cuentas
    {
        public static void ObtenerDetallesDeCuentas(string titulodecuenta, out string cuentaPrincipal_ID, out string controlDeCuenta_ID, out string subControlDeCuenta_ID)
        {
            string queryobtenersubcontroldecuentas = string.Format("SELECT TOP 1 CuentaPrincipal_ID,ControlDeCuenta_ID, SubControlDeCuentaID FROM v_ListaSubControlDeCuentas WHERE NombreDeSubControlDeCuenta = '" + titulodecuenta.Trim()+"'");
            DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar(queryobtenersubcontroldecuentas);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count == 1)
                { 
                    cuentaPrincipal_ID = Convert.ToString(tabladedatos.Rows[0][0]);
                    controlDeCuenta_ID = Convert.ToString(tabladedatos.Rows[0][1]);
                    subControlDeCuenta_ID = Convert.ToString(tabladedatos.Rows[0][2]);
                }
                else
                {
                    tabladedatos = null;
                    string queryobtenercontroldecuentas = string.Format("SELECT TOP 1 CuentaPrincipal_ID,ControlDeCuentaID FROM v_ListaControlDeCuentas WHERE NombreDelControlDeCuenta = '" + titulodecuenta.Trim() + "'");
                    tabladedatos = AccesoABaseDeDatos.Seleccionar(queryobtenercontroldecuentas);
                    if (tabladedatos != null)
                    {
                        if (tabladedatos.Rows.Count == 1)
                        {
                            cuentaPrincipal_ID = Convert.ToString(tabladedatos.Rows[0][0]);
                            controlDeCuenta_ID = Convert.ToString(tabladedatos.Rows[0][1]);
                            subControlDeCuenta_ID = "0";
                        }
                        else
                        {
                            cuentaPrincipal_ID = string.Empty;
                            controlDeCuenta_ID = string.Empty;
                            subControlDeCuenta_ID = string.Empty;
                        }
                    }
                    else
                    {
                        cuentaPrincipal_ID = string.Empty;
                        controlDeCuenta_ID = string.Empty;
                        subControlDeCuenta_ID = string.Empty;
                    }
                }
            }
            else
            {
                tabladedatos = null;
                string queryobtenercontroldecuentas = string.Format("SELECT TOP 1 CuentaPrincipal_ID,ControlDeCuentaID FROM v_ListaControlDeCuentas WHERE NombreDelControlDeCuenta = '" + titulodecuenta.Trim() + "'");
                tabladedatos = AccesoABaseDeDatos.Seleccionar(queryobtenercontroldecuentas);
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count == 1)
                    {
                        cuentaPrincipal_ID = Convert.ToString(tabladedatos.Rows[0][0]);
                        controlDeCuenta_ID = Convert.ToString(tabladedatos.Rows[0][1]);
                        subControlDeCuenta_ID = "0";
                    }
                    else
                    {
                        cuentaPrincipal_ID = string.Empty;
                        controlDeCuenta_ID = string.Empty;
                        subControlDeCuenta_ID = string.Empty;
                    }
                }
                else
                {
                    cuentaPrincipal_ID = string.Empty;
                    controlDeCuenta_ID = string.Empty;
                    subControlDeCuenta_ID = string.Empty;
                }
            }
        }

        public static void EliminarDetallesFacturaDeCompra(string compraid)
        {
            string eliminardesdedetalles = string.Format("DELETE FROM TablaDetallesDeLaFacturaDelProveedor WHERE FacturaDelProveedor_ID = '"+compraid+"'");
            AccesoABaseDeDatos.Eliminar(eliminardesdedetalles);

            string eliminardesdedfactura = string.Format("DELETE FROM TablaFacturaDelProveedor WHERE FacturaDelProveedorID = '" + compraid + "'");
            AccesoABaseDeDatos.Eliminar(eliminardesdedetalles);
        }

        public static void EliminarDetallesDeTransaccion(string numerodefactura)
        {                                                                                   
            string eliminardetalles = string.Format("DELETE FROM TablaDeTransacciones WHERE NoDeFactura = '" + numerodefactura + "'");
            AccesoABaseDeDatos.Eliminar(eliminardetalles);
        }
    }
}
