namespace Proyecto_Final.UI.Reportes
{
    partial class ReporteInscripciones
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
            this.InscripcionesCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // InscripcionesCrystalReportViewer
            // 
            this.InscripcionesCrystalReportViewer.ActiveViewIndex = -1;
            this.InscripcionesCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InscripcionesCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.InscripcionesCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InscripcionesCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.InscripcionesCrystalReportViewer.Name = "InscripcionesCrystalReportViewer";
            this.InscripcionesCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.InscripcionesCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InscripcionesCrystalReportViewer);
            this.Name = "ReporteInscripciones";
            this.Text = "Reporte inscripciones";
            this.Load += new System.EventHandler(this.ReporteInscripciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer InscripcionesCrystalReportViewer;
    }
}