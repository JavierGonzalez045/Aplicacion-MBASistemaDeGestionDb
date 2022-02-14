using MBASistemaDeGestion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBASistemaDeGestion.Formularios.FormulariosDeClientes
{
    public partial class frmImprimirListaDeDeClientes : Form
    {
        public frmImprimirListaDeDeClientes()
        {
            InitializeComponent();
        }

        private void frmImprimirListaDeDeClientes_Load(object sender, EventArgs e)
        {
            rpt_ImprimirListaDeClientes rpt = new rpt_ImprimirListaDeClientes();
            rpt.Refresh();
            crvClientes.ReportSource = rpt;

        }
    }
}
