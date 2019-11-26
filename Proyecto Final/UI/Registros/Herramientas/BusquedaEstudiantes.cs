using BLL;
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

namespace Proyecto_Final.UI.Registros.Herramientas
{
    public partial class hBusquedaEstudiantes : Form
    {
        public static List<Estudiantes> listaEstudiantes = new List<Estudiantes>();
        public hBusquedaEstudiantes()
        {
            InitializeComponent();
        }

        private void EstudiantesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BusquedaEstudiantes_Load(object sender, EventArgs e)
        {
            listaEstudiantes = new List<Estudiantes>();

            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            List<Estudiantes> lista = new List<Estudiantes>();

            lista = repositorio.GetList(l => true);

            EstudiantesDataGridView.DataSource = null;
            EstudiantesDataGridView.Rows.Clear();
            foreach (var item in lista)
                EstudiantesDataGridView.Rows.Add(false,item.EstudianteId, item.Nombre);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LlenarDataGridView();
            this.Close();
        }

        private List<Estudiantes> LlenarDataGridView()
        {
            bool paso = true;

            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            foreach (DataGridViewRow row in EstudiantesDataGridView.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[0].Value) == true))
                {
                    foreach (var item in listaEstudiantes)
                    {
                        if (item.EstudianteId == Convert.ToInt32(row.Cells[1].Value))
                        {
                            paso = false;
                            break;
                        }
                            
                    }

                    if(paso)
                        listaEstudiantes.Add(repositorio.Buscar(Convert.ToInt32(row.Cells[1].Value)));
                }
            }

            return listaEstudiantes;
        }
    }
}
