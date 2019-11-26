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
    public partial class ReporteSemestres : Form
    {
        private List<Semestres> ListaSemestres;
        public ReporteSemestres(List<Semestres> semestres)
        {
            ListaSemestres = semestres;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void ReporteSemestres_Load(object sender, EventArgs e)
        {
            SemestresCrystalReport lista = new SemestresCrystalReport();
            lista.SetDataSource(ListaSemestres);

            SemestreCrystalReportViewer.ReportSource = lista;
            SemestreCrystalReportViewer.Refresh();
        }
    }
}
