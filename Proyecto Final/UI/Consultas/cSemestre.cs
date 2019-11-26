using BLL;
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

namespace Proyecto_Final.UI.Consultas
{
    public partial class cSemestre : Form
    {
        private List<Semestres> lista = new List<Semestres>();
        public cSemestre()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Semestres> repositorio = new RepositorioBase<Semestres>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = repositorio.GetList(a => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        lista = repositorio.GetList(a => a.SemestreId == id);
                        break;

                    case 2:
                        bool paso = Convert.ToBoolean(CriterioTextBox.Text);
                        lista = repositorio.GetList(a => a.Activo == paso);
                        break;

                }
                lista = lista.Where(a => a.FechaInicio.Date >= DesdeDateTimePicker.Value.Date && a.FechaInicio.Date <= HastaDateTimePicker.Value.Date).ToList();

            }
            else
            {
                lista = repositorio.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }

        private void ImprimirReporteButton_Click(object sender, EventArgs e)
        {
            if(lista.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }

            ReporteSemestres reporte = new ReporteSemestres(lista);
            reporte.ShowDialog();
        }
    }
}
