
namespace MBASistemaDeGestion.Formularios.FormulariosDeClientes
{
    partial class frmImprimirListaDeDeClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvClientes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvClientes
            // 
            this.crvClientes.ActiveViewIndex = -1;
            this.crvClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvClientes.Location = new System.Drawing.Point(0, 0);
            this.crvClientes.Name = "crvClientes";
            this.crvClientes.ReuseParameterValuesOnRefresh = true;
            this.crvClientes.ShowCloseButton = false;
            this.crvClientes.ShowGroupTreeButton = false;
            this.crvClientes.ShowLogo = false;
            this.crvClientes.ShowParameterPanelButton = false;
            this.crvClientes.Size = new System.Drawing.Size(1015, 794);
            this.crvClientes.TabIndex = 1;
            this.crvClientes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmImprimirListaDeDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 794);
            this.Controls.Add(this.crvClientes);
            this.Name = "frmImprimirListaDeDeClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista De Reportes Del Cliente";
            this.Load += new System.EventHandler(this.frmImprimirListaDeDeClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvClientes;
    }
}