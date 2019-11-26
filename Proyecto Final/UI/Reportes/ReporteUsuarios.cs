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
    public partial class ReporteUsuarios : Form
    {
        private List<Usuarios> listaUsuarios;
        public ReporteUsuarios(List<Usuarios> usuarios)
        {
            listaUsuarios = usuarios;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            UsuariosCrystalReport lista = new UsuariosCrystalReport();
            lista.SetDataSource(listaUsuarios);

            UsuariosCrystalReportViewer.ReportSource = lista;
            UsuariosCrystalReportViewer.Refresh();
        }
    }
}
