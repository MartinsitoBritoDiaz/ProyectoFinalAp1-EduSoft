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
    public partial class rSemestres : Form
    {
        private int UsuarioId { get; set; }
        public rSemestres(int id)
        {
            UsuarioId = id;
            InitializeComponent();
        }

        private void RSemestre_Load(object sender, EventArgs e)
        {
            //Para obtener el usuario conectado
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();

            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario != null)
                UsuarioTextBox.Text = usuario.Nombre;
        }

        private void ActivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
                           
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            FechaInicioDateTimePicker.Value = DateTime.Now;
            FechaFinalDateTimePicker.Value = DateTime.Now;
            ActivoCheckBox.Checked = false;           
        }

        private Semestres LlenaClase()
        {
            Semestres semestre = new Semestres();
            semestre.SemestreId = Convert.ToInt32(IdNumericUpDown.Value);
            semestre.FechaInicio = FechaInicioDateTimePicker.Value;
            semestre.FechaFin = FechaFinalDateTimePicker.Value;
            semestre.UsuarioId = UsuarioId;
            semestre.Usuario = UsuarioTextBox.Text;

            return semestre;
        }

        private void LlenaCampo(Semestres semestre)
        {
            IdNumericUpDown.Value = semestre.SemestreId;
            FechaInicioDateTimePicker.Value = semestre.FechaInicio;
            FechaFinalDateTimePicker.Value = semestre.FechaFin;
            ActivoCheckBox.Checked = semestre.Activo;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if(FechaInicioDateTimePicker.Value >= FechaFinalDateTimePicker.Value)
            {
                MyErrorProvider.SetError(FechaInicioDateTimePicker, "La fecha de inicio no puede ser mayor \no igual que la fecha en la que finaliza el semestre");
                FechaInicioDateTimePicker.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            SemestreRepositorio repositorio = new SemestreRepositorio();

            Semestres semestre = repositorio.Buscar((int)IdNumericUpDown.Value);

            return (semestre != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            SemestreRepositorio repositorio = new SemestreRepositorio();

            bool paso = false;

            if (!Validar())
                return;

            Semestres semestre = LlenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(semestre);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra en la base de datos el semestre buscado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(semestre);
            }


            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar el semestre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Inscripciones> repositorioInscripciones = new RepositorioBase<Inscripciones>();
            bool interruptor = false;


            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario.Tipo.CompareTo("Administrador") == 0)
            {
                SemestreRepositorio repositorio = new SemestreRepositorio();

                int id;
                int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);

                Semestres semestre = repositorio.Buscar(id);

                //Si existen inscripciones relacionadas no se puede eliminar.
                foreach (var item in repositorioInscripciones.GetList(a => true))
                {
                    if (item.SemestreId == id)
                    {
                        interruptor = true;
                        break;
                    }
                }

                if (interruptor)
                {
                    MessageBox.Show("No puede eliminar este semestre debido \na que existen inscripciones relacionadas con este.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Limpiar();

                if (semestre != null)
                {
                    repositorio.Eliminar(id);
                    MessageBox.Show("Eliminado!");
                }
                else
                    MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar un semestre que no existe");
            }
            else
            {
                MessageBox.Show("Esta registrado como usuario estandar, no puedes eliminar semestres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            SemestreRepositorio repositorio = new SemestreRepositorio();

            int id;
            int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);

            Semestres semestre = repositorio.Buscar(id);

            Limpiar();

            if (semestre != null)
                LlenaCampo(semestre);
            else
                MessageBox.Show("Semestre no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FechaFinalDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void FechaInicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(FechaInicioDateTimePicker.Value <= DateTime.Now)
                ActivoCheckBox.Checked = true;
            else
                ActivoCheckBox.Checked = false;
        }
    }
}
