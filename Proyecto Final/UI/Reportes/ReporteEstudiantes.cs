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
    public partial class ReporteEstudiantes : Form
    {
        private List<Estudiantes> listaEstudiantes;
        public ReporteEstudiantes(List<Estudiantes> estudiantes)
        {
            listaEstudiantes = estudiantes;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ReporteEstudiantes_Load(object sender, EventArgs e)
        {
            EstudiantesCrystalReport lista = new EstudiantesCrystalReport();
            lista.SetDataSource(listaEstudiantes);

            EstudiantesCrystalReportViewer.ReportSource = lista;
            EstudiantesCrystalReportViewer.Refresh();
        }
    }
}
