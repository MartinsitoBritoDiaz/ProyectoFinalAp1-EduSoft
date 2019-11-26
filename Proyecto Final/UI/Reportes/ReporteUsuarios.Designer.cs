namespace Proyecto_Final.UI.Reportes
{
    partial class ReporteUsuarios
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
            this.UsuariosCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // UsuariosCrystalReportViewer
            // 
            this.UsuariosCrystalReportViewer.ActiveViewIndex = -1;
            this.UsuariosCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuariosCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsuariosCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuariosCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.UsuariosCrystalReportViewer.Name = "UsuariosCrystalReportViewer";
            this.UsuariosCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.UsuariosCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsuariosCrystalReportViewer);
            this.Name = "ReporteUsuarios";
            this.Text = "Reporte usuarios";
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer UsuariosCrystalReportViewer;
    }
}