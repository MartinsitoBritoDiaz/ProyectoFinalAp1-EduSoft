namespace Proyecto_Final.UI.Reportes
{
    partial class ReporteAsignaturas
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
            this.AsignaturasCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // AsignaturasCrystalReportViewer
            // 
            this.AsignaturasCrystalReportViewer.ActiveViewIndex = -1;
            this.AsignaturasCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AsignaturasCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.AsignaturasCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AsignaturasCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.AsignaturasCrystalReportViewer.Name = "AsignaturasCrystalReportViewer";
            this.AsignaturasCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.AsignaturasCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AsignaturasCrystalReportViewer);
            this.Name = "ReporteAsignaturas";
            this.Text = "Reporte asignaturas";
            this.Load += new System.EventHandler(this.ReporteAsignaturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer AsignaturasCrystalReportViewer;
    }
}