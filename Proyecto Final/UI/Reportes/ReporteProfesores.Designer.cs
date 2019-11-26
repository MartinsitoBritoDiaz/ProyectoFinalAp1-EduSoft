namespace Proyecto_Final.UI.Reportes
{
    partial class ReporteProfesores
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
            this.ProfesoresCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ProfesoresCrystalReportViewer
            // 
            this.ProfesoresCrystalReportViewer.ActiveViewIndex = -1;
            this.ProfesoresCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfesoresCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProfesoresCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfesoresCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ProfesoresCrystalReportViewer.Name = "ProfesoresCrystalReportViewer";
            this.ProfesoresCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ProfesoresCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfesoresCrystalReportViewer);
            this.Name = "ReporteProfesores";
            this.Text = "ReporteProfesores";
            this.Load += new System.EventHandler(this.ReporteProfesores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ProfesoresCrystalReportViewer;
    }
}