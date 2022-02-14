using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MBASistemaDeGestion
{

    public class AccesoABaseDeDatos
    {
        public static SqlConnection conexion;

        private static SqlConnection ConexionIniciada()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(@"Data Source=JAVIER-PC;Initial Catalog=MBASistemaDeGestionDb;Integrated Security=True");
            }

            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            return conexion;
        }

        public static bool Insertar(string query)
        {
            try
            {
                int numerodefilas = 0;
                SqlCommand comando = new SqlCommand(query, ConexionIniciada());
                numerodefilas = comando.ExecuteNonQuery();
                if (numerodefilas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        public static bool Actualizar(string query)
        {
            try
            {
                int numerodefilas = 0;
                SqlCommand comando = new SqlCommand(query, ConexionIniciada());
                numerodefilas = comando.ExecuteNonQuery();
                if (numerodefilas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        public static bool Eliminar(string query)
        {
            try
            {
                int numerodefilas = 0;
                SqlCommand comando = new SqlCommand(query, ConexionIniciada());
                numerodefilas = comando.ExecuteNonQuery();
                if (numerodefilas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        public static DataTable Seleccionar(string query)
        {
            try
            {
                DataTable tabladedatos = new DataTable();
                SqlDataAdapter adaptadordedatos = new SqlDataAdapter(query, ConexionIniciada());
                adaptadordedatos.Fill(tabladedatos);
                return tabladedatos;
            }
            catch
            {
                return null;
            }
        }
    }
}
