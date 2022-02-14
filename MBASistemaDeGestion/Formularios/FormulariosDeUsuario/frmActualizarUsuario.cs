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
    public partial class frmActualizarUsuario : Form
    {
        public frmActualizarUsuario()
        {
            InitializeComponent();
            
        }

        private void frmActualizarUsuario_Load(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarTiposDeUsuario(comboSeleccionarTipoDeUsuario);
            if (UsuarioActual.UsuarioID > 0)
            {
                comboSeleccionarTipoDeUsuario.SelectedValue = UsuarioActual.TipoDeUsuario_ID;
                textNombreCompleto.Text = UsuarioActual.NombreCompleto;
                textNumeroTelefonico.Text = UsuarioActual.NoDeTelefono;
                textCorreoElectronico.Text = UsuarioActual.Email;
                textNombreDeUsuario.Text = UsuarioActual.NombreDeUsuario;
            }
        }

        private void btnAñadirTiposDeUsuario_Click(object sender, EventArgs e)
        {
            frmTiposDeUsuario frm = new frmTiposDeUsuario();
            frm.ShowDialog();
            btnActualizar_Click(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarTiposDeUsuario(comboSeleccionarTipoDeUsuario);
        }

        private void BorrarFormulario()
        {
            comboSeleccionarTipoDeUsuario.SelectedIndex = 0;
            textCorreoElectronico.Clear();
            textNumeroTelefonico.Clear();
            textNombreCompleto.Clear();
            textContraseña.Clear();
            textNombreDeUsuario.Clear();
            textContraseñaActual.Clear();
            textConfirmarContraseña.Clear();
        }

        private void botonActualizar_Click(object sender, EventArgs e)
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

            if (textNumeroTelefonico.Text.Trim().Length == 0)
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


            if (textContraseñaActual.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(textContraseñaActual, "Debe ingresar la contraseña actual.");
                textContraseñaActual.Focus();
                return;
            }
            if (textContraseña.Text.Trim().Length > 0 || textConfirmarContraseña.Text.Trim().Length > 0)
            {
                if (textContraseña.Text.Trim().Length == 0)
                {
                    proveedor_de_errores.SetError(textContraseña, "Debe ingresar la nueva contraseña.");
                    textContraseña.Focus();
                    return;
                }

                if (textConfirmarContraseña.Text.Trim().Length == 0)
                {
                    proveedor_de_errores.SetError(textConfirmarContraseña, "Debe ingresar la nueva contraseña otra vez.");
                    textConfirmarContraseña.Focus();
                    return;
                }

                if (textContraseña.Text.Trim() != textConfirmarContraseña.Text.Trim())
                {
                    proveedor_de_errores.SetError(textConfirmarContraseña, "La contraseña ingresada no coincide con la anterior.");
                    textConfirmarContraseña.Focus();
                    return;
                }
            }

            DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaUsuarios WHERE NombreDeUsuario = '" + textNombreDeUsuario + "' AND UsuarioID != '"+UsuarioActual.UsuarioID+"'");
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

            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TablaUsuarios WHERE NombreCompleto = '" + textNombreCompleto.Text.Trim() + "' AND NoDeTelefono = '" + textNumeroTelefonico.Text.Trim() + "' AND UsuarioID != '"+UsuarioActual.UsuarioID+"'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    proveedor_de_errores.SetError(textNombreCompleto, "El usuario ya existe.");
                    textNombreCompleto.Focus();
                    return;
                }
            }


            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT Contraseña FROM TablaUsuarios WHERE UsuarioID = '"+UsuarioActual.UsuarioID+"'");
            {
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count > 0)
                    {
                        if (Convert.ToString(tabladedatos.Rows[0]["Contraseña"]) != textContraseñaActual.Text.Trim())
                        {
                            proveedor_de_errores.SetError(textContraseñaActual, "Contraseña incorrecta.");
                            textContraseñaActual.Focus();
                            return;
                        }
                    }
                    else
                    {
                        proveedor_de_errores.SetError(textContraseñaActual, "Contraseña incorrecta.");
                        textContraseñaActual.Focus();
                        return;
                    }
                }
                else
                {
                    proveedor_de_errores.SetError(textContraseñaActual, "Contraseña incorrecta.");
                    textContraseñaActual.Focus();
                    return;
                }
            }
            string actualizarquery = string.Empty;
            if (textContraseña.Text.Trim().Length > 0 && textConfirmarContraseña.Text.Trim().Length > 0)
            {

                actualizarquery = string.Format("UPDATE TablaUsuarios SET TipoDeUsuario_ID = '{0}',NombreCompleto = '{1}',Email = '{2}',NoDeTelefono = '{3}',NombreDeUsuario = '{4}',Contraseña = '{5}' WHERE UsuarioID = '" + UsuarioActual.UsuarioID + "'",
                   comboSeleccionarTipoDeUsuario.SelectedValue, textNombreCompleto.Text.Trim(), textCorreoElectronico.Text.Trim(), textNumeroTelefonico.Text.Trim(), textNombreDeUsuario.Text.Trim(), textContraseña.Text.Trim());
            }
            else
            {
                actualizarquery = string.Format("UPDATE TablaUsuarios SET TipoDeUsuario_ID = '{0}',NombreCompleto = '{1}',Email = '{2}',NoDeTelefono = '{3}',NombreDeUsuario = '{4}' WHERE UsuarioID = '" + UsuarioActual.UsuarioID + "'",
                   comboSeleccionarTipoDeUsuario.SelectedValue, textNombreCompleto.Text.Trim(), textCorreoElectronico.Text.Trim(), textNumeroTelefonico.Text.Trim(), textNombreDeUsuario.Text.Trim());
            }

            bool resultado = AccesoABaseDeDatos.Actualizar(actualizarquery);
            if (resultado)
            {
                MessageBox.Show("Usuario actualizado exitosamente.");
                SeleccionarInformacionDeUsuario();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }

        private void SeleccionarInformacionDeUsuario()
        {
            string contraseña = string.Empty;

            if (textContraseña.Text.Trim().Length > 0)
            {
                contraseña = textContraseña.Text.Trim();
            }
            else
            {
                contraseña = textContraseñaActual.Text.Trim();
            }

            string obterequery = "SELECT  UsuarioID,TipoDeUsuario_ID,NombreCompleto,Email,NoDeTelefono,NombreDeUsuario FROM TablaUsuarios WHERE NombreDeUsuario = '" + textNombreDeUsuario.Text.Trim() + "' AND Contraseña = '" + contraseña + "'";
            DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar(obterequery);
            if (tabladedatos.Rows.Count > 0)
            {
                UsuarioActual.UsuarioID = Convert.ToInt32(tabladedatos.Rows[0]["UsuarioID"]);
                UsuarioActual.TipoDeUsuario_ID = Convert.ToInt32(tabladedatos.Rows[0]["TipoDeUsuario_ID"]);
                UsuarioActual.NombreCompleto = Convert.ToString(tabladedatos.Rows[0]["NombreCompleto"]);
                UsuarioActual.Email = Convert.ToString(tabladedatos.Rows[0]["Email"]);
                UsuarioActual.NoDeTelefono= Convert.ToString(tabladedatos.Rows[0]["NoDeTelefono"]);
                UsuarioActual.NombreDeUsuario = Convert.ToString(tabladedatos.Rows[0]["NombreDeUsuario"]);
            }
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarFormulario();
        }
    }
}
