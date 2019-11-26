using Entidades;
using BLL;
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
    public partial class cAsignacion : Form
    {
        private List<Asignaciones> lista = new List<Asignaciones>();
        public cAsignacion()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {

            RepositorioBase<Asignaciones> repositorio = new RepositorioBase<Asignaciones>();


            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = repositorio.GetList(a => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        lista = repositorio.GetList(a => a.AsignacionId == id);
                        break;

                    case 2:
                        lista = repositorio.GetList(a => a.Nombre.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        lista = repositorio.GetList(a => a.Asignatura.Contains(CriterioTextBox.Text));
                        break;
                }
                lista = lista.Where(a => a.FechaCreacion.Date >= DesdeDateTimePicker.Value.Date && a.FechaCreacion.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                lista = repositorio.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }

        private void CAsignacion_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirReporteButton_Click(object sender, EventArgs e)
        {
            if(lista.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }

            ReporteAsignaciones reporte = new ReporteAsignaciones(lista);
            reporte.ShowDialog();
        }
    }
}
