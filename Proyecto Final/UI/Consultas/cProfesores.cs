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
    public partial class cProfesores : Form
    {
        List<Profesores> lista = new List<Profesores>();
        public cProfesores()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Profesores> repositorio = new RepositorioBase<Profesores>();


            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = repositorio.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        lista = repositorio.GetList(p =>  p.ProfesorId == id);
                        break;

                    case 2:
                        lista = repositorio.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                        break;

                }
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

            ReporteProfesores reporteProfesores = new ReporteProfesores(lista);
            reporteProfesores.ShowDialog();
        }
    }
}
