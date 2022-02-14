
namespace MBASistemaDeGestion.Formularios.FormulariosDeProveedores
{
    partial class frmImprimirListaDeProveedores
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
            this.crvProveedores = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProveedores
            // 
            this.crvProveedores.ActiveViewIndex = -1;
            this.crvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProveedores.Location = new System.Drawing.Point(0, 0);
            this.crvProveedores.Name = "crvProveedores";
            this.crvProveedores.ReuseParameterValuesOnRefresh = true;
            this.crvProveedores.ShowCloseButton = false;
            this.crvProveedores.ShowGroupTreeButton = false;
            this.crvProveedores.ShowLogo = false;
            this.crvProveedores.ShowParameterPanelButton = false;
            this.crvProveedores.Size = new System.Drawing.Size(1015, 794);
            this.crvProveedores.TabIndex = 0;
            this.crvProveedores.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmImprimirListaDeProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 794);
            this.Controls.Add(this.crvProveedores);
            this.Name = "frmImprimirListaDeProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista De Reportes Del Proveedor";
            this.Load += new System.EventHandler(this.frmImprimirListaDeProveedores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProveedores;
    }
}