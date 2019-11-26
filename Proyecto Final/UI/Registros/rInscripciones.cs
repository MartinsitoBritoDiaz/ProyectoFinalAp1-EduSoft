using BLL;
using Entidades;
using Proyecto_Final.UI.Registros.Herramientas;
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

namespace Proyecto_Final.UI.Registros
{
    public partial class rInscripciones : Form
    {
        private int UsuarioId { get; set; }
        public List<EstudiantesDetalles> Detalle { get; set; }
        public rInscripciones(int id)
        {
            UsuarioId = id;
            InitializeComponent();
            this.Detalle = new List<EstudiantesDetalles>();
        }
        private void CargarGrid()
        {
            EstudiantesDataGridView.DataSource = null;
            EstudiantesDataGridView.Rows.Clear();
            foreach (var item in this.Detalle)
                EstudiantesDataGridView.Rows.Add(item.Matricula, item.Nombre);
        }
        private void RInscripcion_Load(object sender, EventArgs e)
        {
            LlenarComboAsignaturas();

            //Para obtener el usuario conectado
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();

            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario != null)
                UsuarioTextBox.Text = usuario.Nombre;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            InscripcionIdNumericUpDown.Value = 0;
            SemestreIdNumericUpDown.Value = 0;
            AsignaturasComboBox.ResetText();
            EstudianteIdMaskedTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            CantidadEstudiantesLabel.Text = "0";

            this.Detalle = new List<EstudiantesDetalles>();
            CargarGrid();
        }

        private void LlenaCampos(Inscripciones inscripcion)
        {
            InscripcionIdNumericUpDown.Value = inscripcion.InscripcionId;
            SemestreIdNumericUpDown.Value = inscripcion.SemestreId;
            AsignaturasComboBox.Text = inscripcion.Asignatura;
            CantidadEstudiantesLabel.Text = Convert.ToString(inscripcion.CantidadEstudiantes);

            this.Detalle = inscripcion.EstudiantesDetalle;
            CargarGrid();
        }

        private Inscripciones LlenaClase()
        {
            Inscripciones inscripcion = new Inscripciones();

            inscripcion.InscripcionId = Convert.ToInt32(InscripcionIdNumericUpDown.Value);
            inscripcion.SemestreId = Convert.ToInt32(SemestreIdNumericUpDown.Value);
            inscripcion.Asignatura = AsignaturasComboBox.Text;
            inscripcion.Fecha = FechaDateTimePicker.Value;
            inscripcion.CantidadEstudiantes = Convert.ToInt32(CantidadEstudiantesLabel.Text);
            inscripcion.Usuario = UsuarioTextBox.Text;
            inscripcion.UsuarioId = UsuarioId;

            inscripcion.EstudiantesDetalle = this.Detalle;

            return inscripcion;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(AsignaturasComboBox.Text))
            {
                MyErrorProvider.SetError(AsignaturasComboBox,"Debe de seleccionar una asignatura");
                AsignaturasComboBox.Focus();
                paso = false;
            }

            if(this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(EstudiantesDataGridView, "Debe agregar algun estudiante");
                EstudiantesDataGridView.Focus();
                paso = false;
            }

            
            SemestreRepositorio repositorio = new SemestreRepositorio();

            Semestres semestre = repositorio.Buscar((int)SemestreIdNumericUpDown.Value);

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

        private bool ExisteEnLaBaseDeDatos()
        {
            InscripcionesRepositorio repositorio = new InscripcionesRepositorio();

            Inscripciones inscripcion = repositorio.Buscar((int)InscripcionIdNumericUpDown.Value);

            return (inscripcion != null);
        }

        private void AsignaturasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LlenarComboAsignaturas()
        {
            //Caragar lista de asignaturas
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();
            var listaAsignaturas = repositorioAsignaturas.GetList(p => true);

            AsignaturasComboBox.DataSource = listaAsignaturas;
            AsignaturasComboBox.ValueMember = "AsignaturaId";
            AsignaturasComboBox.DisplayMember = "Nombre";
        }

        private void AgregarEstudiantesButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorioEstudiante = new RepositorioBase<Estudiantes>();

            bool paso = true;

            if (!ValidarEstudiante())
                return;

            Estudiantes estudiante = repositorioEstudiante.Buscar(Convert.ToInt32(EstudianteIdMaskedTextBox.Text));

            if (EstudiantesDataGridView.DataSource != null)
                this.Detalle = (List<EstudiantesDetalles>)EstudiantesDataGridView.DataSource;

            foreach (var auxiliar in this.Detalle)
            {
                if (auxiliar.Nombre == NombreTextBox.Text)
                {
                    paso = false;
                    break;
                }

            }
            
            if(paso)
                this.Detalle.Add(
                    new EstudiantesDetalles(
                            id: 0,
                            matricula: estudiante.Matricula,
                            nombre: NombreTextBox.Text,
                            inscripcionId: Convert.ToInt32(InscripcionIdNumericUpDown.Value),
                            asignatura: AsignaturasComboBox.Text
                        )
                    );

            CargarGrid();
            EstudianteIdMaskedTextBox.Focus();
            EstudianteIdMaskedTextBox.Clear();
            NombreTextBox.Clear();

            CantidadEstudiantesLabel.Text = Convert.ToString(this.Detalle.Count);
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

        private bool ValidarEstudiante()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if(string.IsNullOrWhiteSpace(EstudianteIdMaskedTextBox.Text.Replace("-", string.Empty)))
            {
                MyErrorProvider.SetError(EstudianteIdMaskedTextBox,"Debe de suministrar una matricula");
                EstudianteIdMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacío");
                NombreTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void MatriculaMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void MatriculaMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            NombreTextBox.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(EstudianteIdMaskedTextBox.Text.Replace("-", string.Empty)))
                return;

            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            Estudiantes estudiante = repositorio.Buscar(Convert.ToInt32(EstudianteIdMaskedTextBox.Text.Replace("-", string.Empty)));

            if (estudiante == null)
            {
                MyErrorProvider.SetError(EstudianteIdMaskedTextBox, "Debe de ingresar una matricula valida");
                EstudianteIdMaskedTextBox.Focus();
                return;
            }

            NombreTextBox.Text = estudiante.Nombre;
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if(EstudiantesDataGridView.Rows.Count > 0 && EstudiantesDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(EstudiantesDataGridView.CurrentRow.Index);
                EstudiantesDataGridView.Rows.RemoveAt(EstudiantesDataGridView.CurrentRow.Index);

                CargarGrid();
            }

            CantidadEstudiantesLabel.Text = Convert.ToString(this.Detalle.Count());
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SeleccionarEstudiantesbutton_Click(object sender, EventArgs e)
        {
            hBusquedaEstudiantes busquedaEstudiantes = new hBusquedaEstudiantes();
            busquedaEstudiantes.ShowDialog();
            bool paso;

            foreach (var item in hBusquedaEstudiantes.listaEstudiantes)
            {
                paso = true;

                if (EstudiantesDataGridView.DataSource != null)
                    this.Detalle = (List<EstudiantesDetalles>)EstudiantesDataGridView.DataSource;

                foreach (var auxiliar in this.Detalle)
                    if (auxiliar.Nombre == item.Nombre)
                    {
                        paso = false;
                        break;
                    }
                
                if(paso)
                    this.Detalle.Add(
                        new EstudiantesDetalles(
                                id: 0,
                                matricula: item.Matricula,
                                nombre: item.Nombre,
                                inscripcionId: Convert.ToInt32(InscripcionIdNumericUpDown.Value),
                                asignatura: AsignaturasComboBox.Text
                            )
                        );

                CargarGrid();

                CantidadEstudiantesLabel.Text = Convert.ToString(this.Detalle.Count);
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            InscripcionesRepositorio repositorio = new InscripcionesRepositorio();

            bool paso = false;

            if (!Validar())
                return;

            Inscripciones inscripcion = LlenaClase();

            if (InscripcionIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(inscripcion);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra  la inscripción en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(inscripcion);
            }


            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar la inscripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            InscripcionesRepositorio repositorio = new InscripcionesRepositorio();

            int id;
            int.TryParse(Convert.ToString(InscripcionIdNumericUpDown.Value), out id);

            Inscripciones inscripcion= repositorio.Buscar(id);

            Limpiar();

            if (inscripcion != null)
                LlenaCampos(inscripcion);
            else
                MessageBox.Show("Inscripcion no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario.Tipo.CompareTo("Administrador") == 0)
            {
                InscripcionesRepositorio repositorio = new InscripcionesRepositorio();

                int id;
                int.TryParse(Convert.ToString(InscripcionIdNumericUpDown.Value), out id);

                Inscripciones inscripcion = repositorio.Buscar(id);

                Limpiar();

                if (inscripcion != null)
                {
                    repositorio.Eliminar(id);
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MyErrorProvider.SetError(InscripcionIdNumericUpDown, "No se puede eliminar una inscripcion que no existe");
            }
            else
                MessageBox.Show("Esta registrado como usuario estandar, no tienes acceso a eliminar inscripciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void CantidadEstudiantesLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
