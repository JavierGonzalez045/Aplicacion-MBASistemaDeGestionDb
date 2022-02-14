using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBASistemaDeGestion.CodigoFuente
{
    public class ClaseProveedor
    {
        public static void ObtenerProveedor(string busqueda_a_realizar, DataGridView dgv)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT ProveedorID [ID], NombreDelProveedor [Proveedor], NoDeTelefono [Teléfono], Email [Correo],Direccion [Dirección],Descripcion [Descripción] FROM TablaDeProveedores";
            }
            else
            {
                query = "SELECT ProveedorID [ID], NombreDelProveedor [Proveedor], NoDeTelefono [Teléfono], Email [Correo],Direccion [Dirección],Descripcion [Descripción] FROM TablaDeProveedores WHERE (NombreDelProveedor +' '+NoDeTelefono+' '+Direccion+' '+Email+' '+Descripcion) LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgv.DataSource = tabladedatos;
                    dgv.Columns[0].Width = 100;    // ID Del Proveedor.
                    dgv.Columns[1].Width = 150;    // Nombre Del Proveedor.
                    dgv.Columns[2].Width = 120;    // Número Telefónico Del Proveedor.
                    dgv.Columns[3].Width = 120;    // Correo Electrónico.
                    dgv.Columns[4].Width = 200;    // Dirección.
                    dgv.Columns[5].Width = 300;    // Descripción.
                }
                else
                {
                    dgv.DataSource = null;
                }
            }
            else
            {
                dgv.DataSource = null;
            }
        }
    }
}
