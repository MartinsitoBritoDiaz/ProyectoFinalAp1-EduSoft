using Entidades;
using Proyecto_Final.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.UI.Registros
{
    public partial class AsistenciasReportViewer : Form
    {
        public  List<Asistencias> ListaAsistencias;
        public AsistenciasReportViewer(List<Asistencias> asistencias)
        {
            this.ListaAsistencias = asistencias;
            InitializeComponent();
            AsistenciasDiariasCrystalReport listadoAsistencia = new AsistenciasDiariasCrystalReport();
            listadoAsistencia.SetDataSource(ListaAsistencias);

            ReportViewer.ReportSource = listadoAsistencia;
            ReportViewer.Refresh();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e) 
        {

            
        }
    }
}
