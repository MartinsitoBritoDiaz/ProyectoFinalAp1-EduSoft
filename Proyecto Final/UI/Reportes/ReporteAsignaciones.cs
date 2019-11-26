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
    public partial class ReporteAsignaciones : Form
    {
        private List<Asignaciones> ListaAsignaciones;
        public ReporteAsignaciones(List<Asignaciones> asignaciones)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            ListaAsignaciones = asignaciones;
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void AsignacionesReportViewer_Load(object sender, EventArgs e)
        {
            AsignacionesCrystalReport lista = new AsignacionesCrystalReport();
            lista.SetDataSource(ListaAsignaciones);

            AsignacionesCrystalReportViewer.ReportSource = lista;
            AsignacionesCrystalReportViewer.Refresh();
        }
    }
}
