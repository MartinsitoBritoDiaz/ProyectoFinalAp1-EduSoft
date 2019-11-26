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
    public partial class rAsignaciones : Form
    {
        private int UsuarioId { get; set; }
        public rAsignaciones(int id)
        {
            UsuarioId = id;
            InitializeComponent();
        }

        private void DescripcionRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RAsignaciones_Load(object sender, EventArgs e)
        {
            //Para obtener el usuario conectado
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();

            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario != null)
                UsuarioTextBox.Text = usuario.Nombre;

            LlenarComboCategorias();
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            AsignacionIdNumericUpDown.Value = 0;
            AsignaturaIdNumericUpDown.Value = 0;
            AsignaturaTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            CategoriaComboBox.ResetText();
            FechaCreacionDateTimePicker.Value = DateTime.Now;
            FechaEntregaDateTimePicker.Value = DateTime.Now;
            DescripcionRichTextBox.Text = string.Empty;
        }

        private void LlenaCampo(Asignaciones asignacion)
        {
            AsignacionIdNumericUpDown.Value = asignacion.AsignacionId;
            AsignaturaIdNumericUpDown.Value = asignacion.AsignaturaId;
            AsignaturaTextBox.Text = asignacion.Asignatura;
            NombreTextBox.Text = asignacion.Nombre;
            CategoriaComboBox.Text = asignacion.Categoria;
            FechaCreacionDateTimePicker.Value = asignacion.FechaCreacion;
            FechaEntregaDateTimePicker.Value = asignacion.FechaEntrega;
            DescripcionRichTextBox.Text = asignacion.Descripcion;
        }

        private Asignaciones LlenaClase()
        {
            Asignaciones asignacion = new Asignaciones();
            asignacion.AsignacionId = Convert.ToInt32(AsignacionIdNumericUpDown.Value);
            asignacion.AsignaturaId = Convert.ToInt32(AsignaturaIdNumericUpDown.Value);
            asignacion.Asignatura = AsignaturaTextBox.Text;
            asignacion.Nombre = NombreTextBox.Text;
            asignacion.Categoria = CategoriaComboBox.Text;
            asignacion.FechaCreacion = FechaCreacionDateTimePicker.Value;
            asignacion.FechaEntrega = FechaEntregaDateTimePicker.Value;
            asignacion.Descripcion = DescripcionRichTextBox.Text;
            asignacion.Usuario = UsuarioTextBox.Text;
            asignacion.UsuarioId = UsuarioId;

            return asignacion;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacío");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CategoriaComboBox.Text))
            {
                MyErrorProvider.SetError(CategoriaComboBox, "Debe de seleccionar una categoria");
                CategoriaComboBox.Focus();
                paso = false;
            }

            if (FechaCreacionDateTimePicker.Value >= FechaEntregaDateTimePicker.Value)
            {
                MyErrorProvider.SetError(FechaCreacionDateTimePicker, "La fecha de creacion no puede ser mayor \nque la fecha de entrega de la asignacion");
                FechaCreacionDateTimePicker.Focus();
                paso = false;
            } 

            if (string.IsNullOrWhiteSpace(DescripcionRichTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionRichTextBox, "El campo descripción no puede estar vacío");
                DescripcionRichTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(AsignaturaTextBox.Text))
            {
                MyErrorProvider.SetError(AsignaturaTextBox, "El campo asignatura no puede estar vacío");
                AsignaturaTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaciones> repositorioAsignacion = new RepositorioBase<Asignaciones>();

            Asignaciones asignacion = repositorioAsignacion.Buscar((int)AsignacionIdNumericUpDown.Value);

            return (asignacion != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaciones> repositorioAsignacion = new RepositorioBase<Asignaciones>();

            bool paso = false;

            if (!Validar())
                return;

            Asignaciones asignacion = LlenaClase();

            if (AsignacionIdNumericUpDown.Value == 0)
                paso = repositorioAsignacion.Guardar(asignacion);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra la asignacion en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorioAsignacion.Modificar(asignacion);
            }


            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar la asignacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool ValidarAsignatura(Asignaturas asignatura)
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (asignatura == null)
            {
                MyErrorProvider.SetError(AsignaturaIdNumericUpDown, "Debe de insertar un id de asignatura valido");
                AsignaturaIdNumericUpDown.Focus();
                paso = false;
            }

            return paso;
        }

        private void AsignaturaIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if ((AsignaturaIdNumericUpDown.Value == 0))
            {
                AsignaturaTextBox.Text = string.Empty;
                return;
            }

            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura = repositorioAsignaturas.Buscar((int)AsignaturaIdNumericUpDown.Value);

            if (!ValidarAsignatura(asignatura))
            {
                AsignaturaTextBox.Text = string.Empty;
                return;
            }
               
            AsignaturaTextBox.Text = asignatura.Nombre;
        }

        private void LlenarComboCategorias()
        {
            //Caragar lista de profesores
            RepositorioBase<CategoriasAsignaciones> repositorioCategoriasAsignaciones = new RepositorioBase<CategoriasAsignaciones>();
            var listaCategoriasAsignaciones = repositorioCategoriasAsignaciones.GetList(p => true);

            CategoriaComboBox.DataSource = listaCategoriasAsignaciones;
            CategoriaComboBox.ValueMember = "CategoriaAsignacionId";
            CategoriaComboBox.DisplayMember = "Nombre";
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario.Tipo.CompareTo("Administrador") == 0)
            {
                RepositorioBase<Asignaciones> repositorioAsignacion = new RepositorioBase<Asignaciones>();

                int id;
                int.TryParse(Convert.ToString(AsignacionIdNumericUpDown.Value), out id);

                Asignaciones asignacion = repositorioAsignacion.Buscar(id);

                Limpiar();

                if (asignacion != null)
                {
                    repositorioAsignacion.Eliminar(id);
                    MessageBox.Show("Asignacion eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MyErrorProvider.SetError(AsignaturaIdNumericUpDown, "No existe ninguna asignacion con ese id para ser borrada");
            }
            else
            {
                MessageBox.Show("Esta registrado como usuario estandar, no puedes eliminar asignaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaciones> repositorioAsignacion = new RepositorioBase<Asignaciones>();

            int id;
            int.TryParse(Convert.ToString(AsignacionIdNumericUpDown.Value), out id);

            Asignaciones asignacion = repositorioAsignacion.Buscar(id);

            Limpiar();

            if (asignacion != null)
                LlenaCampo(asignacion);
            else
                MessageBox.Show("Asignacion no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
