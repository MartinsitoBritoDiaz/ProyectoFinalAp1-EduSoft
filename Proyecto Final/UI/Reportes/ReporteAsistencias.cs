using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.UI.Reportes
{
    public partial class ReporteAsistencias : Form
    {
        private List<Asistencias> ListaAsistencias;
        public ReporteAsistencias(List<Asistencias> asistencias)
        {
            ListaAsistencias = asistencias;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();

            AsistenciasCrystalReport lista = new AsistenciasCrystalReport();
            lista.SetDataSource(ListaAsistencias);

            AsistenciasCrystalReportViewer.ReportSource = lista;
            AsistenciasCrystalReportViewer.Refresh();
        }

        private void ReporteAsistencias_Load(object sender, EventArgs e)
        {
            
        }
    }
}
