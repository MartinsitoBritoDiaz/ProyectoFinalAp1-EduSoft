using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.UI.Registros
{
    public partial class rProfesores : Form
    {
        private Image ImagenOriginal;
        private int UsuarioId { get; set; }

        public rProfesores(int id)
        {
            UsuarioId = id;
            InitializeComponent();
        }

        private void RProfesor_Load(object sender, EventArgs e)
        {
            ImagenOriginal = ImagenPictureBox.Image;

            //Para obtener el usuario conectado
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();

            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario != null)
                UsuarioTextBox.Text = usuario.Nombre;
        }

        private void InsertarImagenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ObtenerImagen = new OpenFileDialog();

            ObtenerImagen.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";
            ObtenerImagen.InitialDirectory = "C:\\";

            if (ObtenerImagen.ShowDialog() == DialogResult.OK)
                ImagenPictureBox.ImageLocation = ObtenerImagen.FileName;
            else
                MessageBox.Show("No se ha selecionado ninguna imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            ProfesorIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            GeneroComboBox.ResetText();
            EmailTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            ImagenPictureBox.Image = ImagenOriginal;
        }

        private void LlenaCampo(Profesores profesor)
        {
            ProfesorIdNumericUpDown.Value = profesor.ProfesorId;
            NombreTextBox.Text = profesor.Nombre;
            TelefonoMaskedTextBox.Text = profesor.Telefono;
            CelularMaskedTextBox.Text = profesor.Celular;
            CedulaMaskedTextBox.Text = profesor.Cedula;
            GeneroComboBox.SelectedIndex = profesor.Genero;
            EmailTextBox.Text = profesor.Email;
            DireccionTextBox.Text = profesor.Direccion;
            ImagenPictureBox.Image = ArrgeloByteToImagen(profesor.Foto);
        }

        private Profesores LlenaClase()
        {
            Profesores profesor = new Profesores();

            profesor.ProfesorId = Convert.ToInt32(ProfesorIdNumericUpDown.Value);
            profesor.Nombre = NombreTextBox.Text;
            profesor.Telefono = TelefonoMaskedTextBox.Text;
            profesor.Celular = CelularMaskedTextBox.Text;
            profesor.Cedula = CedulaMaskedTextBox.Text;
            profesor.Genero = GeneroComboBox.SelectedIndex;
            profesor.Email = EmailTextBox.Text;
            profesor.Direccion = DireccionTextBox.Text;
            profesor.Foto = ImagenToArregloByte(ImagenPictureBox.Image);
            profesor.UsuarioId = UsuarioId;
            profesor.Usuario = UsuarioTextBox.Text;

            return profesor;

        }
        private Image ArrgeloByteToImagen(byte[] ArregloByte)
        {
            MemoryStream ms = new MemoryStream(ArregloByte);
            Image retornaImagen = Image.FromStream(ms);
            return retornaImagen;
        }

        public byte[] ImagenToArregloByte(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
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

            if(string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text.Replace("-", string.Empty)) || string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text.Replace("-", string.Empty)))
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "Debe de suministrar un numero de telefono o celular");
                MyErrorProvider.SetError(CelularMaskedTextBox, "Debe de suministrar un numero de telefono o celular");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text.Replace("-", string.Empty)))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo cedula no puede estar vacío");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(GeneroComboBox.Text))
            {
                MyErrorProvider.SetError(GeneroComboBox, "Debe de seleccionar su genero");
                GeneroComboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyErrorProvider.SetError(EmailTextBox, "El campo email no puede estar vacío");
                EmailTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                MyErrorProvider.SetError(DireccionTextBox, "El campo direccion no puede estar vacío");
                DireccionTextBox.Focus();
                paso = false;
            }

            if(ImagenPictureBox.Image == ImagenOriginal)
            {
                MyErrorProvider.SetError(InsertarImagenButton, "Debe de suministrar una imagen de usuario");
                InsertarImagenButton.Focus();
                paso = false;
            }

            if (!EmailTextBox.Text.Contains("@"))
            {
                MyErrorProvider.SetError(EmailTextBox, "El email debe de tener arroba '@'. ");
                EmailTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Profesores> repositorio = new RepositorioBase<Profesores>();

            Profesores profesor = repositorio.Buscar(Convert.ToInt32(ProfesorIdNumericUpDown.Value));

            return (profesor != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Profesores> repositorio = new RepositorioBase<Profesores>();

            bool paso = false;

            if (!Validar())
                return;

            Profesores profesor = LlenaClase();

            if (ProfesorIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(profesor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("El profesor buscado no se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                paso = repositorio.Modificar(profesor);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar los datos del profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Profesores> repositorio = new RepositorioBase<Profesores>();

            int id;
            int.TryParse(Convert.ToString(ProfesorIdNumericUpDown.Value), out id);

            Profesores profesor = repositorio.Buscar(id);
            Limpiar();

            if (profesor != null)
                LlenaCampo(profesor);
            else
            {
                MessageBox.Show("El profesor buscado no se encuentra en la base de datos");
            }
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();
            bool interruptor = false;

            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario.Tipo.CompareTo("Administrador") == 0)
            {
                RepositorioBase<Profesores> repositorioProfesores = new RepositorioBase<Profesores>();

                int id;
                int.TryParse(Convert.ToString(ProfesorIdNumericUpDown.Value), out id);

                Profesores profesor = repositorioProfesores.Buscar(id);

                //Si existen asignaturas relacionadas no se puede eliminar.
                foreach (var item in repositorioAsignaturas.GetList(a => true))
                {
                    if (item.ProfesorId == id)
                    {
                        interruptor = true;
                        break;
                    }
                }

                if (interruptor)
                {
                    MessageBox.Show("No puede eliminar este profesor debido \na que existen asignaturas relacionadas con este.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Limpiar();

                if (profesor != null)
                {
                    repositorioProfesores.Eliminar(id);
                    MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MyErrorProvider.SetError(ProfesorIdNumericUpDown, "No se puede eliminar un profesor que no se encuentra en la base de datos");
            }
            else
            {
                MessageBox.Show("Esta registrado como usuario estandar, no puedes eliminar profesores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
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
