namespace Proyecto_Final.UI.Reportes
{
    partial class ReporteAsignaciones
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
            this.AsignacionesCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // AsignacionesCrystalReportViewer
            // 
            this.AsignacionesCrystalReportViewer.ActiveViewIndex = -1;
            this.AsignacionesCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AsignacionesCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.AsignacionesCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AsignacionesCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.AsignacionesCrystalReportViewer.Name = "AsignacionesCrystalReportViewer";
            this.AsignacionesCrystalReportViewer.Size = new System.Drawing.Size(975, 519);
            this.AsignacionesCrystalReportViewer.TabIndex = 0;
            this.AsignacionesCrystalReportViewer.Load += new System.EventHandler(this.CrystalReportViewer1_Load);
            // 
            // ReporteAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 519);
            this.Controls.Add(this.AsignacionesCrystalReportViewer);
            this.Name = "ReporteAsignaciones";
            this.Text = "Reporte asignaciones";
            this.Load += new System.EventHandler(this.AsignacionesReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer AsignacionesCrystalReportViewer;
    }
}