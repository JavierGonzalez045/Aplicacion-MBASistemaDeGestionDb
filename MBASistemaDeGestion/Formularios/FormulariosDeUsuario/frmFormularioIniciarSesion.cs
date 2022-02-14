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
    public partial class frmFormularioIniciarSesion : Form
    {
        private frmFormularioPrincipal FormularioPrincipal;

        public frmFormularioIniciarSesion()
        {
            InitializeComponent();
        }

        public frmFormularioIniciarSesion(frmFormularioPrincipal formFormularioPrincipal)
        {
            InitializeComponent();
            this.FormularioPrincipal = formFormularioPrincipal;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            proveedor_de_errores.Clear();
            if (txtNombreDeUsuario.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(txtNombreDeUsuario, "Debe ingresar el nombre de usuario.");
                txtNombreDeUsuario.Focus();
                return;
            }

            if (txtContraseña.Text.Trim().Length == 0)
            {
                proveedor_de_errores.SetError(txtContraseña, "Debe ingresar la contraseña.");
                txtContraseña.Focus();
                return;
            }

            string obterequery = "SELECT  UsuarioID,TipoDeUsuario_ID,NombreCompleto,Email,NoDeTelefono,NombreDeUsuario FROM TablaUsuarios WHERE NombreDeUsuario = '" + txtNombreDeUsuario.Text.Trim() + "' AND Contraseña = '" + txtContraseña.Text.Trim() + "'";
            DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar(obterequery);
            if (tabladedatos == null)
            {
                lblError.Visible = true;
                FormularioPrincipal.tsbIniciarSesion.Visible = true;
                FormularioPrincipal.tsbCerrarSesion.Visible = false;
                FormularioPrincipal.menudenavegacion.Enabled = false;
                return;
            }
            else if (tabladedatos.Rows.Count > 0)
            {
                //Controles visibles

                FormularioPrincipal.tsbIniciarSesion.Visible = false;
                FormularioPrincipal.tsbCerrarSesion.Visible = true;
                FormularioPrincipal.menudenavegacion.Enabled = true;
                UsuarioActual.UsuarioID = Convert.ToInt32(tabladedatos.Rows[0]["UsuarioID"]);
                UsuarioActual.TipoDeUsuario_ID = Convert.ToInt32(tabladedatos.Rows[0]["TipoDeUsuario_ID"]);
                UsuarioActual.NombreCompleto = Convert.ToString(tabladedatos.Rows[0]["NombreCompleto"]);
                UsuarioActual.Email = Convert.ToString(tabladedatos.Rows[0]["Email"]);
                UsuarioActual.NoDeTelefono = Convert.ToString(tabladedatos.Rows[0]["NoDeTelefono"]);
                UsuarioActual.NombreDeUsuario = Convert.ToString(tabladedatos.Rows[0]["NombreDeUsuario"]);
                this.Close();
                return;
            }
            else
            {
                lblError.Visible = true;
            }

        }

        private void frmFormularioIniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
