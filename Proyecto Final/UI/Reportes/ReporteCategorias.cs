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
    public partial class ReporteCategorias : Form
    {
        private List<CategoriasAsignaciones> listaCategorias;
        public ReporteCategorias(List<CategoriasAsignaciones> categorias)
        {
            listaCategorias = categorias;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void ReporteCategorias_Load(object sender, EventArgs e)
        {
            CategoriasAsignacionesCrystalReport lista = new CategoriasAsignacionesCrystalReport();
            lista.SetDataSource(listaCategorias);

            CategoriasCrystalReportViewer.ReportSource = lista;
            CategoriasCrystalReportViewer.Refresh();
        }
    }
}
