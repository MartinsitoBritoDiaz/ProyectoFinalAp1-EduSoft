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
    public partial class ReporteProfesores : Form
    {
        private List<Profesores> listaProfesores;
        public ReporteProfesores(List<Profesores> profesores)
        {
            listaProfesores = profesores;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ReporteProfesores_Load(object sender, EventArgs e)
        {
            ProfesoresCrystalReport lista = new ProfesoresCrystalReport();
            lista.SetDataSource(listaProfesores);

            ProfesoresCrystalReportViewer.ReportSource = lista;
            ProfesoresCrystalReportViewer.Refresh();
        }
    }
}
