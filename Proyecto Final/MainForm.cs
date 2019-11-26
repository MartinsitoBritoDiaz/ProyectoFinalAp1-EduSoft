using BLL;
using Entidades;
using Proyecto_Final.UI.Consultas;
using Proyecto_Final.UI.Registros;
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

namespace Proyecto_Final
{
    public partial class MainForm : Form
    {
        private int UsuarioId { get; set; }
        public MainForm(int id)
        {
            UsuarioId = id;

            InitializeComponent();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProfesores registroProfesor = new rProfesores(UsuarioId);
            registroProfesor.MdiParent = this;
            registroProfesor.Show();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes registroEstudiante = new rEstudiantes(UsuarioId);
            registroEstudiante.MdiParent = this;
            registroEstudiante.Show();
        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignaturas registroAsignatura = new rAsignaturas(UsuarioId);
            registroAsignatura.MdiParent = this;
            registroAsignatura.Show();
        }

        private void AsignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignaciones registroAsignacion = new rAsignaciones(UsuarioId);
            registroAsignacion.MdiParent = this;
            registroAsignacion.Show();
        }

        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategoriasAsignaciones registroCategoria = new rCategoriasAsignaciones(UsuarioId);
            registroCategoria.MdiParent = this;
            registroCategoria.Show();
        }

        private void AsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsistencias registroAsistencia = new rAsistencias(UsuarioId);
            registroAsistencia.MdiParent = this;
            registroAsistencia.Show();
        }

        private void InscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInscripciones registroInscripcion = new rInscripciones(UsuarioId);
            registroInscripcion.MdiParent = this;
            registroInscripcion.Show();
        }

        private void SemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rSemestres registroSemestre = new rSemestres(UsuarioId);
            registroSemestre.MdiParent = this;
            registroSemestre.Show();
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AsistenciasDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();
            var listaAsistencias = new List<Asistencias>();

            listaAsistencias = repositorio.GetList(p => true).Where(p => p.Fecha.Date == DateTime.Today).ToList();

            if (listaAsistencias.Count() <= 0)
            {
                MessageBox.Show("No hay asistencias hoy");
                return;
            }

            AsistenciasReportViewer reporte = new AsistenciasReportViewer(listaAsistencias);
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void ProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProfesores consulta = new cProfesores();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEstudiantes consulta = new cEstudiantes();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void AsignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cAsignacion consulta = new cAsignacion();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cAsignaturas consulta = new cAsignaturas();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void AsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cAsistencias consulta = new cAsistencias();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void CategoriasAsignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCategoriasAsignaciones consulta = new cCategoriasAsignaciones();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void SemestreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cSemestre consulta = new cSemestre();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void InscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cInscripcion consulta = new cInscripcion();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Para que se abra maximizado.
            this.WindowState = FormWindowState.Maximized;

            //Para obtener el usuario conectado
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();

            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if(usuario != null)
                UsuarioTextBox.Text = usuario.Nombre;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario.Tipo.CompareTo("Administrador") == 0)
            {
                rUsuarios registroUsuario = new rUsuarios(UsuarioId);
                registroUsuario.MdiParent = this;
                registroUsuario.Show();
            }
            else
                MessageBox.Show("Esta registrado como usuario estandar, no tienes acceso al registro de usuarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios consultaUsuarios = new cUsuarios();
            consultaUsuarios.MdiParent = this;
            consultaUsuarios.Show();
        }
    }
}
