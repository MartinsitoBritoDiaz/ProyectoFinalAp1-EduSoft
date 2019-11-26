namespace Proyecto_Final.UI.Reportes
{
    partial class ReporteEstudiantes
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
            this.EstudiantesCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // EstudiantesCrystalReportViewer
            // 
            this.EstudiantesCrystalReportViewer.ActiveViewIndex = -1;
            this.EstudiantesCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EstudiantesCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.EstudiantesCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EstudiantesCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.EstudiantesCrystalReportViewer.Name = "EstudiantesCrystalReportViewer";
            this.EstudiantesCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.EstudiantesCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EstudiantesCrystalReportViewer);
            this.Name = "ReporteEstudiantes";
            this.Text = "ReporteEstudiantes";
            this.Load += new System.EventHandler(this.ReporteEstudiantes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer EstudiantesCrystalReportViewer;
    }
}