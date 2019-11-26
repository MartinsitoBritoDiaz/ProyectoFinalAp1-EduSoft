namespace Proyecto_Final.UI.Reportes
{
    partial class ReporteCategorias
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
            this.CategoriasCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CategoriasCrystalReportViewer
            // 
            this.CategoriasCrystalReportViewer.ActiveViewIndex = -1;
            this.CategoriasCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoriasCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CategoriasCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriasCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CategoriasCrystalReportViewer.Name = "CategoriasCrystalReportViewer";
            this.CategoriasCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.CategoriasCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoriasCrystalReportViewer);
            this.Name = "ReporteCategorias";
            this.Text = "Reporte categorias";
            this.Load += new System.EventHandler(this.ReporteCategorias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CategoriasCrystalReportViewer;
    }
}