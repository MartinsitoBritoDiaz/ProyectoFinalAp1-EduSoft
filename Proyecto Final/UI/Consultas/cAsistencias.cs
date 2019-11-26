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
    public partial class cAsistencias : Form
    {
        List<Asistencias> lista = new List<Asistencias>();
        public cAsistencias()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();


            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = repositorio.GetList(a => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        lista = repositorio.GetList(a => a.AsistenciaId == id);
                        break;

                    case 2:
                        lista = repositorio.GetList(a => a.Profesor.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        int total = Convert.ToInt32(CriterioTextBox.Text);
                        lista = repositorio.GetList(a => a.Total == total);
                        break;
                }
                lista = lista.Where(a => a.Fecha.Date >= DesdeDateTimePicker.Value.Date && a.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                lista = repositorio.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImprimirReporteButton_Click(object sender, EventArgs e)
        {
            if(lista.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }

            ReporteAsistencias reporte = new ReporteAsistencias(lista);
            reporte.ShowDialog();
        }
    }
}
