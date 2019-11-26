namespace Proyecto_Final.UI.Reportes
{
    partial class ReporteSemestres
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
            this.SemestreCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // SemestreCrystalReportViewer
            // 
            this.SemestreCrystalReportViewer.ActiveViewIndex = -1;
            this.SemestreCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SemestreCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SemestreCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemestreCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.SemestreCrystalReportViewer.Name = "SemestreCrystalReportViewer";
            this.SemestreCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.SemestreCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteSemestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SemestreCrystalReportViewer);
            this.Name = "ReporteSemestres";
            this.Text = "Reporte semestres";
            this.Load += new System.EventHandler(this.ReporteSemestres_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer SemestreCrystalReportViewer;
    }
}