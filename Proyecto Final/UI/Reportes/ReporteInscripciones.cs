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
    public partial class ReporteInscripciones : Form
    {
        private List<Inscripciones> listaInscripciones;
        public ReporteInscripciones(List<Inscripciones> inscripciones)
        {
            listaInscripciones = inscripciones;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void ReporteInscripciones_Load(object sender, EventArgs e)
        {
            InscripcionesCrystalReport lista = new InscripcionesCrystalReport();
            lista.SetDataSource(listaInscripciones);

            InscripcionesCrystalReportViewer.ReportSource = lista;
            InscripcionesCrystalReportViewer.Refresh();
        }
    }
}
