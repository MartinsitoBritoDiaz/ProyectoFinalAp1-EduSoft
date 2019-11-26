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
    public partial class ReporteAsignaturas : Form
    {
        private List<Asignaturas> listaAsignaturas = new List<Asignaturas>();
        public ReporteAsignaturas(List<Asignaturas> asignaturas)
        {
            this.WindowState = FormWindowState.Maximized;
            listaAsignaturas = asignaturas;
            InitializeComponent();
        }

        private void ReporteAsignaturas_Load(object sender, EventArgs e)
        {
            AsignaturasCrystalReport lista = new AsignaturasCrystalReport();
            lista.SetDataSource(listaAsignaturas);

            AsignaturasCrystalReportViewer.ReportSource = lista;
            AsignaturasCrystalReportViewer.Refresh();
        }
    }
}
