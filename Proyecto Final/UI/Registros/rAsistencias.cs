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

namespace Proyecto_Final.UI.Registros
{
    public partial class rAsistencias : Form
    {
        private int UsuarioId { get; set; }
        public List<EstudiantesAsistenciasDetalles> Detalle { get; set; }
        public rAsistencias(int id)
        {
            UsuarioId = id;
            InitializeComponent();
            this.Detalle = new List<EstudiantesAsistenciasDetalles>();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProfesorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboAsignaturas();
        }


        private void LlenarComboProfesores()
        {
            //Caragar lista de profesores
            RepositorioBase<Profesores> repositorioProfesores = new RepositorioBase<Profesores>();
            var listaProfesores = repositorioProfesores.GetList(p => true);

            ProfesorComboBox.DataSource = listaProfesores;
            ProfesorComboBox.ValueMember = "ProfesorId";
            ProfesorComboBox.DisplayMember = "Nombre";
        }

        private void LlenarComboAsignaturas()
        {
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();
            List<Asignaturas> listaAsignaturasProfesores = new List<Asignaturas>();
            var listaAsignaturas = repositorioAsignaturas.GetList(p => true);

            foreach (var item in listaAsignaturas)
            {
                if (item.ProfesorId == (Convert.ToInt32(ProfesorComboBox.SelectedIndex) + 1))
                    listaAsignaturasProfesores.Add(item);
            }

            AsignaturasComboBox.DataSource = listaAsignaturasProfesores;
            AsignaturasComboBox.ValueMember = "AsignaturaId";
            AsignaturasComboBox.DisplayMember = "Nombre";
        }


        private void RAsistencias_Load(object sender, EventArgs e)
        {
            //Para obtener el usuario conectado
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();

            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario != null)
                UsuarioTextBox.Text = usuario.Nombre;

            LlenarComboProfesores();
        }


        private bool ValidarSemestre(Semestres semestre)
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (semestre == null)
            {
                MyErrorProvider.SetError(SemestreIdNumericUpDown, "Debe de insertar un id de un semestre valido");
                SemestreIdNumericUpDown.Focus();
                return false;
            }

            if (!semestre.Activo)
            {
                MyErrorProvider.SetError(SemestreIdNumericUpDown, "Debe de insertar un id de un semestre activo");
                SemestreIdNumericUpDown.Focus();
                paso = false;
            }

            return paso;
        }

        private void SemestreIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if ((SemestreIdNumericUpDown.Value == 0))
                return;

            SemestreRepositorio repositorio = new SemestreRepositorio();

            Semestres semestre = repositorio.Buscar((int)SemestreIdNumericUpDown.Value);

            if (!ValidarSemestre(semestre))
                return;
        }

        private void CargarGrid()
        {
            EstudiantesDataGridView.DataSource = null;
            EstudiantesDataGridView.Rows.Clear();
            foreach (var item in this.Detalle)
                EstudiantesDataGridView.Rows.Add(item.Nombre, item.Presente, item.Ausente, item.Excusa);
        }

        private void AgregarEstudiantesButton_Click(object sender, EventArgs e)
        {
            InscripcionesRepositorio repositorioInscripcion = new InscripcionesRepositorio();
            bool paso = true;

            foreach (var auxiliar in repositorioInscripcion.GetList(r => true))
            {
                foreach (var item in auxiliar.EstudiantesDetalle)
                {
                    if (auxiliar.Asignatura.CompareTo(AsignaturasComboBox.Text) == 0)
                    {
                        paso = true;

                        foreach (var temporal in this.Detalle)
                        {
                            if (temporal.Nombre == item.Nombre)
                            {
                                paso = false;
                                break;
                            }
                        }

                        if (paso)
                        {
                            if (EstudiantesDataGridView.DataSource != null)
                                this.Detalle = (List<EstudiantesAsistenciasDetalles>)EstudiantesDataGridView.DataSource;

                            this.Detalle.Add(
                                new EstudiantesAsistenciasDetalles(
                                    estudianteId: 0,
                                    asistenciaId: Convert.ToInt32(AsistenciaIdNumericUpDown.Value),
                                    matricula: item.Matricula,
                                    nombre: item.Nombre,
                                    presente: false,
                                    ausente: true,
                                    excusa: false
                                    )
                                );
                        }
                    }
                }
            }

            CargarGrid();

            TotalLabel.Text = Convert.ToString(this.Detalle.Count);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            AsistenciasRepositorio repositorio = new AsistenciasRepositorio();

            bool paso = false;

            int indice = 0;

            if (!Validar())
                return;

            foreach (var item in this.Detalle)
            {
                var checkPresente = EstudiantesDataGridView.Rows[indice].Cells[1].Value;
                var checkAusente = EstudiantesDataGridView.Rows[indice].Cells[2].Value;
                var checkExcusa = EstudiantesDataGridView.Rows[indice].Cells[3].Value;

                if ((bool)checkPresente == false && (bool)checkExcusa == false)
                    checkAusente = true;

                var objeto = this.Detalle.FirstOrDefault(x => x.Matricula == item.Matricula);

                if (objeto != null)
                {
                    objeto.Presente = (bool)checkPresente;
                    objeto.Ausente = (bool)checkAusente;
                    objeto.Excusa = (bool)checkExcusa;
                }

                indice += 1;
            }

            Asistencias asistencia = LlenaClase();

            if (AsistenciaIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(asistencia);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra la asistencia en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(asistencia);
            }


            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar la asistencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            AsistenciaIdNumericUpDown.Value = 0;
            SemestreIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            ProfesorComboBox.ResetText();
            AsignaturasComboBox.ResetText();
            Presenteslabel.Text = "0";
            Ausenteslabel.Text = "0";
            TotalLabel.Text = "0";

            this.Detalle = new List<EstudiantesAsistenciasDetalles>();
            CargarGrid();
        }

        private void LlenaCampos(Asistencias asistencia)
        {
            AsistenciaIdNumericUpDown.Value = asistencia.AsistenciaId;
            SemestreIdNumericUpDown.Value = asistencia.SemestreId;
            FechaDateTimePicker.Value = asistencia.Fecha;
            ProfesorComboBox.Text = asistencia.Profesor;
            Presenteslabel.Text = Convert.ToString(asistencia.CantidadPresentes);
            Ausenteslabel.Text = Convert.ToString(asistencia.CantidadAusentes);
            TotalLabel.Text = Convert.ToString(asistencia.Total);

            this.Detalle = asistencia.EstudiantesAsistenciasDetalle;
            CargarGrid();
        }

        private Asistencias LlenaClase()
        {
            Asistencias asistencia = new Asistencias();
            asistencia.AsistenciaId = Convert.ToInt32(AsistenciaIdNumericUpDown.Value);
            asistencia.SemestreId = Convert.ToInt32(SemestreIdNumericUpDown.Value);
            asistencia.Fecha = FechaDateTimePicker.Value;
            asistencia.Profesor = ProfesorComboBox.Text;
            asistencia.CantidadPresentes = Convert.ToInt32(Presenteslabel.Text);
            asistencia.CantidadAusentes = Convert.ToInt32(Ausenteslabel.Text);
            asistencia.Total = Convert.ToInt32(TotalLabel.Text);
            asistencia.Usuario = UsuarioTextBox.Text;
            asistencia.UsuarioId = UsuarioId;

            asistencia.EstudiantesAsistenciasDetalle = this.Detalle;

            return asistencia;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(ProfesorComboBox.Text))
            {
                MyErrorProvider.SetError(ProfesorComboBox, "Debe de seleccionar un profesor valido");
                ProfesorComboBox.Focus();
                paso = false;
            }

            if (SemestreIdNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(SemestreIdNumericUpDown, "Debe de introducir un semestre id");
                SemestreIdNumericUpDown.Focus();
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(EstudiantesDataGridView, "Debe de seleccionar una asignatura con estudiantes");
                EstudiantesDataGridView.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            AsistenciasRepositorio repositorio = new AsistenciasRepositorio();

            Asistencias asistencia = repositorio.Buscar((int)AsistenciaIdNumericUpDown.Value);

            return (asistencia != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EstudiantesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (EstudiantesDataGridView.RowCount != 0)
            {

                if (e.ColumnIndex == 1)
                {
                    var checkAusente = EstudiantesDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    var checkExcusa = EstudiantesDataGridView.Rows[e.RowIndex].Cells[3].Value;

                    if ((bool)checkAusente == true || (bool)checkExcusa == true)
                    {
                        EstudiantesDataGridView.Rows[e.RowIndex].Cells[2].Value = false;
                        EstudiantesDataGridView.Rows[e.RowIndex].Cells[3].Value = false;
                    }
                }

                if (e.ColumnIndex == 2)
                {
                    var checkAusente = EstudiantesDataGridView.Rows[e.RowIndex].Cells[1].Value;
                    var checkExcusa = EstudiantesDataGridView.Rows[e.RowIndex].Cells[3].Value;

                    if ((bool)checkAusente == true || (bool)checkExcusa == true)
                    {
                        EstudiantesDataGridView.Rows[e.RowIndex].Cells[1].Value = false;
                        EstudiantesDataGridView.Rows[e.RowIndex].Cells[3].Value = false;
                    }
                }

                if (e.ColumnIndex == 3)
                {
                    var checkAusente = EstudiantesDataGridView.Rows[e.RowIndex].Cells[1].Value;
                    var checkExcusa = EstudiantesDataGridView.Rows[e.RowIndex].Cells[2].Value;

                    if ((bool)checkAusente == true || (bool)checkExcusa == true)
                    {
                        EstudiantesDataGridView.Rows[e.RowIndex].Cells[1].Value = false;
                        EstudiantesDataGridView.Rows[e.RowIndex].Cells[2].Value = false;
                    }
                }

            }
        }

        private void ListaGroupBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario.Tipo.CompareTo("Administrador") == 0)
            {
                AsistenciasRepositorio repositorio = new AsistenciasRepositorio();

                int id;
                int.TryParse(Convert.ToString(AsistenciaIdNumericUpDown.Value), out id);

                Asistencias asistencia = repositorio.Buscar(id);

                Limpiar();

                if (asistencia != null)
                {
                    repositorio.Eliminar(id);
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Asistencia no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Esta registrado como usuario estandar, no tienes acceso a eliminar asistencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            AsistenciasRepositorio repositorio = new AsistenciasRepositorio();

            int id;
            int.TryParse(Convert.ToString(AsistenciaIdNumericUpDown.Value), out id);

            Asistencias asistencia = repositorio.Buscar(id);

            Limpiar();

            if (asistencia != null)
                LlenaCampos(asistencia);
            else
                MessageBox.Show("Asistencia no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EstudiantesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int presente = 0;
            int ausente = 0;
            int excusa = 0;


            foreach (DataGridViewRow row in EstudiantesDataGridView.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[1].Value) == true))
                    presente += 1;

                if ((Convert.ToBoolean(row.Cells[2].Value) == true))
                    ausente += 1;

                if ((Convert.ToBoolean(row.Cells[3].Value) == true))
                    excusa += 1;
            }

            Presenteslabel.Text = Convert.ToString(presente);
            Ausenteslabel.Text = Convert.ToString(ausente);
            ExcusasLabel.Text = Convert.ToString(excusa);
        }

        private void EstudiantesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void gridCategories_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void EstudiantesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void EstudiantesDataGridView_Click(object sender, EventArgs e)
        {

        }

        private void EstudiantesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}

