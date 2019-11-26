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
    public partial class rCategoriasAsignaciones : Form
    {
        private int UsuarioId { get; set; }
        public rCategoriasAsignaciones(int id)
        {
            UsuarioId = id;
            InitializeComponent();
        }

        private void RCategoriaAsignacion_Load(object sender, EventArgs e)
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
            CategoriaIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
        }

        private void LlenaCampo(CategoriasAsignaciones categoria)
        {
            CategoriaIdNumericUpDown.Value = categoria.CategoriaAsignacionId;
            NombreTextBox.Text = categoria.Nombre;
        }

        private CategoriasAsignaciones LlenaClase()
        {
            CategoriasAsignaciones categoria = new CategoriasAsignaciones();

            categoria.CategoriaAsignacionId = Convert.ToInt32(CategoriaIdNumericUpDown.Value);
            categoria.Nombre = NombreTextBox.Text;
            categoria.Usuario = UsuarioTextBox.Text;
            categoria.UsuarioId = UsuarioId; 

            return categoria;
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

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<CategoriasAsignaciones> repositorioCategoria = new RepositorioBase<CategoriasAsignaciones>();

            CategoriasAsignaciones categoria = repositorioCategoria.Buscar((int)CategoriaIdNumericUpDown.Value);

            return (categoria != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<CategoriasAsignaciones> repositorioCategoria = new RepositorioBase<CategoriasAsignaciones>();

            bool paso = false;

            if (!Validar())
                return;

            CategoriasAsignaciones categoria = LlenaClase();

            if (CategoriaIdNumericUpDown.Value == 0)
                paso = repositorioCategoria.Guardar(categoria);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra en la base de datos la categoria buscada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorioCategoria.Modificar(categoria);
            }


            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario.Tipo.CompareTo("Administrador") == 0)
            {
                RepositorioBase<CategoriasAsignaciones> repositorioCategoria = new RepositorioBase<CategoriasAsignaciones>();

                int id;
                int.TryParse(Convert.ToString(CategoriaIdNumericUpDown.Value), out id);

                CategoriasAsignaciones categoria= repositorioCategoria.Buscar(id);

                Limpiar();

                if (categoria != null)
                {
                    repositorioCategoria.Eliminar(id);
                    MessageBox.Show("Eliminado!");
                }
                else
                    MyErrorProvider.SetError(CategoriaIdNumericUpDown, "No se puede eliminar un semestre que no existe");
            }
            else
            {
                MessageBox.Show("Esta registrado como usuario estandar, no puedes eliminar categorias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<CategoriasAsignaciones> repositorioCategoria = new RepositorioBase<CategoriasAsignaciones>();

            int id;
            int.TryParse(Convert.ToString(CategoriaIdNumericUpDown.Value), out id);

            CategoriasAsignaciones categoria = repositorioCategoria.Buscar(id);

            Limpiar();

            if (categoria != null)
                LlenaCampo(categoria);
            else
                MessageBox.Show("No se encuentra la categoria buscada");
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
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
    }
}