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

namespace MBASistemaDeGestion.Formularios.FormulariosDeUsuario
{
    public partial class frmAñadirUsuarios : Form
    {
        public frmAñadirUsuarios()
        {
            InitializeComponent();
        }

        private void frmAñadirUsuarios_Load(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarTiposDeUsuario(comboSeleccionarTipoDeUsuario);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarTiposDeUsuario(comboSeleccionarTipoDeUsuario);
        }

        private void btnAñadirTiposDeUsuario_Click(object sender, EventArgs e)
        {
            frmTiposDeUsuario frm = new frmTiposDeUsuario();
            frm.ShowDialog();
            btnActualizar_Click(sender, e);
        }

        private void BorrarFormulario()
        {
            comboSeleccionarTipoDeUsuario.SelectedIndex = 0;
            textCorreoElectronico.Clear();
            textNumeroTelefonico.Clear();
            textNombreCompleto.Clear();
            textContraseña.Clear();
            textNombreDeUsuario.Clear();
            textConfirmarContraseña.Clear();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            proveedor_de_errores.Clear();
            if (comboSeleccionarTipoDeUsuario.SelectedIndex == 0)
            {
                proveedor_de_errores.SetError(comboSeleccionarTipoDeUsuario, "Debe seleccionar un tipo de usuario.");
                comboSeleccionarTipoDeUsuario.Focus();
                return;
            }

            if (textNombreCompleto.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNombreCompleto, "Debe ingresar el nombre completo.");
                textNombreCompleto.Focus();
                return;
            }

            if(textNumeroTelefonico.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNumeroTelefonico, "Debe ingresar el número telefónico.");
                textNumeroTelefonico.Focus();
                return;
            }

            if (textNombreDeUsuario.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textNombreDeUsuario, "Debe ingresar el nombre de usuario.");
                textNombreDeUsuario.Focus();
                return;
            }

            if (textContraseña.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textContraseña, "Debe ingresar la contraseña.");
                textContraseña.Focus();
                return;
            }

            if (textConfirmarContraseña.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textConfirmarContraseña, "Debe ingresar la misma contraseña nuevamente.");
                textConfirmarContraseña.Focus();
                return;
            }

            if (textContraseña.Text.Trim() != textConfirmarContraseña.Text.Trim())
            {
                proveedor_de_errores.SetError(textConfirmarContraseña, "La contraseña ingresada no coincide con la anterior.");
                textConfirmarContraseña.Focus();
                return;
            }
            DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaUsuarios WHERE NombreDeUsuario = '" + textNombreDeUsuario + "'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textNombreDeUsuario, "El nombre de usuario ya existe.");
                    textNombreDeUsuario.Focus();
                    return;
                }
            }
            tabladedatos = null;

            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaUsuarios WHERE NombreCompleto = '" + textNombreCompleto.Text.Trim() + "' AND NoDeTelefono = '" + textNumeroTelefonico.Text.Trim()+"'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textNombreCompleto, "El usuario ya está registrado.");
                    textNombreCompleto.Focus();
                    return;
                }
            }

            string insertarquery = string.Format("INSERT INTO TablaUsuarios(TipoDeUsuario_ID,NombreCompleto,Email,NoDeTelefono,NombreDeUsuario,Contraseña) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", 
                   comboSeleccionarTipoDeUsuario.SelectedValue, textNombreCompleto.Text.Trim(), textCorreoElectronico.Text.Trim(), textNumeroTelefonico.Text.Trim(), textNombreDeUsuario.Text.Trim(), textContraseña.Text.Trim());
            bool resultado = AccesoABaseDeDatos.Insertar(insertarquery);
            if (resultado)
            {
                MessageBox.Show("Usuario registrado exitosamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarFormulario();
        }
    }
}
