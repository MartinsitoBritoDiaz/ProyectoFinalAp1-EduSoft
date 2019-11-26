namespace Proyecto_Final.UI.Reportes
{
    partial class ReporteAsistencias
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
            this.AsistenciasCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // AsistenciasCrystalReportViewer
            // 
            this.AsistenciasCrystalReportViewer.ActiveViewIndex = -1;
            this.AsistenciasCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AsistenciasCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.AsistenciasCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AsistenciasCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.AsistenciasCrystalReportViewer.Name = "AsistenciasCrystalReportViewer";
            this.AsistenciasCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.AsistenciasCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AsistenciasCrystalReportViewer);
            this.Name = "ReporteAsistencias";
            this.Text = "ReporteAsistencias";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer AsistenciasCrystalReportViewer;
    }
}