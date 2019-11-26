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
    public partial class rAsignaturas : Form
    {
        private int UsuarioId { get; set; }
        public rAsignaturas(int id)
        {
            UsuarioId = id;
            InitializeComponent();
        }


        private void RAsignatura_Load(object sender, EventArgs e)
        {
            //Para obtener el usuario conectado
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();

            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario != null)
                UsuarioTextBox.Text = usuario.Nombre;
        }
        private void Limpiar()
        {
            MyErrorProvider.Clear();
            AsignaturaIdNumericUpDown.Value = 0;
            ProfesorTextBox.Text = string.Empty;
            ProfesorIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            CreditosMaskedTextBox.Text = string.Empty;
            DescripcionRichTextBox.Text = string.Empty;
        }

        private void LlenaCampo(Asignaturas asignatura)
        {
            AsignaturaIdNumericUpDown.Value = asignatura.AsignaturaId;
            ProfesorTextBox.Text = asignatura.NombreProfesor;
            ProfesorIdNumericUpDown.Value = asignatura.ProfesorId;
            NombreTextBox.Text = asignatura.Nombre;
            CreditosMaskedTextBox.Text = Convert.ToString(asignatura.Creditos);
            DescripcionRichTextBox.Text = asignatura.Descripcion;
        }

        private Asignaturas LlenaClase()
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturaId = Convert.ToInt32(AsignaturaIdNumericUpDown.Value);
            asignatura.NombreProfesor = ProfesorTextBox.Text;
            asignatura.ProfesorId = Convert.ToInt32(ProfesorIdNumericUpDown.Value);
            asignatura.Nombre = NombreTextBox.Text;
            asignatura.Creditos = Convert.ToInt32(CreditosMaskedTextBox.Text);
            asignatura.Descripcion = DescripcionRichTextBox.Text;
            asignatura.Usuario = UsuarioTextBox.Text;
            asignatura.UsuarioId = UsuarioId;

            return asignatura;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(ProfesorTextBox.Text))
            {
                MyErrorProvider.SetError(ProfesorIdNumericUpDown, "Debe seleccionar el id de un profesor");
                ProfesorIdNumericUpDown.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacío");
                NombreTextBox.Focus();
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(CreditosMaskedTextBox.Text.Replace(".", string.Empty)))
            {
                MyErrorProvider.SetError(CreditosMaskedTextBox,"El campo creditos no puede estar vacío");
                CreditosMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DescripcionRichTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionRichTextBox, "El campo descripción no puede estar vacío");
                DescripcionRichTextBox.Focus();
                paso = false;
            }

                
            return paso;
        }

        private bool ExisteEnLaBaseDatos()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura = repositorio.Buscar((int)AsignaturaIdNumericUpDown.Value);

            return (asignatura != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();

            bool paso = false;

            if (!Validar())
                return;

            Asignaturas asignatura = LlenaClase();

            if (AsignaturaIdNumericUpDown.Value == 0)
                paso = repositorioAsignaturas.Guardar(asignatura);
            else
            {
                if (!ExisteEnLaBaseDatos())
                {
                    MessageBox.Show("No se encuentra la asignatura en la base de datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorioAsignaturas.Modificar(asignatura);
            }


            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar la asignatura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();

            int id;
            int.TryParse(Convert.ToString(AsignaturaIdNumericUpDown.Value), out id);

            Asignaturas asignatura = repositorioAsignaturas.Buscar(id);

            Limpiar();

            if (asignatura != null)
                LlenaCampo(asignatura);
            else
                MessageBox.Show("Asignatura no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaciones> repositorioAsignaciones = new RepositorioBase<Asignaciones>();
            bool interruptor = false;

            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario.Tipo.CompareTo("Administrador") == 0)
            { 
                RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();

                int id;
                int.TryParse(Convert.ToString(AsignaturaIdNumericUpDown.Value), out id);

                Asignaturas asignatura = repositorioAsignaturas.Buscar(id);

                //Si existen asignaciones relacionadas no se puede eliminar.
                foreach (var item in repositorioAsignaciones.GetList(a => true))
                {
                    if (item.AsignaturaId == id)
                    {
                        interruptor = true;
                        break;
                    }
                }

                if (interruptor)
                {
                    MessageBox.Show("No puede eliminar este asignatura debido \na que existen asignaciones relacionadas con esta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Limpiar();

                if (asignatura != null)
                {
                    repositorioAsignaturas.Eliminar(id);
                    MessageBox.Show("Asignatura eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MyErrorProvider.SetError(AsignaturaIdNumericUpDown, "No se encuentra esta asignatura para poder borrarla");
            }
            else
            {
                MessageBox.Show("Esta registrado como usuario estandar, no puedes eliminar asignaturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarProfesor(Profesores profesor)
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (profesor == null)
            {
                MyErrorProvider.SetError(ProfesorIdNumericUpDown, "Debe de insertar un id de profesor valido");
                ProfesorIdNumericUpDown.Focus();
                paso = false;
            }

            return paso;
        }

        private void ProfesorIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if ((ProfesorIdNumericUpDown.Value == 0))
            {
                ProfesorTextBox.Text = string.Empty;
                return;
            }

            RepositorioBase<Profesores> repositorioProfesores = new RepositorioBase<Profesores>();

            Profesores profesor = repositorioProfesores.Buscar((int)ProfesorIdNumericUpDown.Value);

            if (!ValidarProfesor(profesor))
            {
                ProfesorTextBox.Text = string.Empty;
                return;
            }

            ProfesorTextBox.Text = profesor.Nombre;
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void DescripcionRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
