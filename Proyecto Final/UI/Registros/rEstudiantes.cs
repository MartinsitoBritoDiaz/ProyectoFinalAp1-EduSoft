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
    public partial class rEstudiantes : Form
    {
        private Image ImagenOriginal;
        private int UsuarioId { get; set; }
        public rEstudiantes(int id)
        {
            UsuarioId = id;
            InitializeComponent();
        }

        private void REstudiante_Load(object sender, EventArgs e)
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
            EstudianteIdNumericUpDown.Value = 0;
            MatriculaMaskedTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            GeneroComboBox.ResetText();
            EmailTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            ImagenPictureBox.Image = ImagenOriginal;
        }

        private void LlenaCampo(Estudiantes estudiante)
        {
            EstudianteIdNumericUpDown.Value = estudiante.EstudianteId;
            MatriculaMaskedTextBox.Text = Convert.ToString(estudiante.Matricula);
            NombreTextBox.Text = estudiante.Nombre;
            TelefonoMaskedTextBox.Text = estudiante.Telefono;
            CelularMaskedTextBox.Text = estudiante.Celular;
            CedulaMaskedTextBox.Text = estudiante.Cedula;
            GeneroComboBox.SelectedIndex = estudiante.Genero;
            EmailTextBox.Text = estudiante.Email;
            DireccionTextBox.Text = estudiante.Direccion;
            ImagenPictureBox.Image = ArrgeloByteToImagen(estudiante.Foto);
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();

            estudiante.EstudianteId = Convert.ToInt32(EstudianteIdNumericUpDown.Value);
            estudiante.Matricula = Convert.ToInt32(MatriculaMaskedTextBox.Text.Replace("-", string.Empty));
            estudiante.Nombre = NombreTextBox.Text;
            estudiante.Telefono = TelefonoMaskedTextBox.Text;
            estudiante.Celular = CelularMaskedTextBox.Text;
            estudiante.Cedula = CedulaMaskedTextBox.Text;
            estudiante.Genero = GeneroComboBox.SelectedIndex;
            estudiante.Email = EmailTextBox.Text;
            estudiante.Direccion = DireccionTextBox.Text;
            estudiante.Foto = ImagenToArregloByte(ImagenPictureBox.Image);
            estudiante.UsuarioId = UsuarioId;
            estudiante.Usuario = UsuarioTextBox.Text;

            return estudiante;

        }
        private Image ArrgeloByteToImagen(byte[] ArregloByte)//Esta funcion convierte el arreglo de bytes que se guarda en la base de datos a la imagen 
        {
            MemoryStream ms = new MemoryStream(ArregloByte);
            Image retornaImagen = Image.FromStream(ms);
            return retornaImagen;
        }

        public byte[] ImagenToArregloByte(System.Drawing.Image imageIn)//Esta funcion convierte la imagen en un arreglo de bytes para poder guardarla en la base de datos
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private bool Valida()
        {
            MyErrorProvider.Clear();

            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacío");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text.Replace("-", string.Empty)) || string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text.Replace("-", string.Empty)))
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

            if (ImagenPictureBox.Image == ImagenOriginal)
            {
                MyErrorProvider.SetError(InsertarImagenButton, "Debe de suministrar una imagen de usuario");
                InsertarImagenButton.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(MatriculaMaskedTextBox.Text.Replace("-", string.Empty)))
            {
                MyErrorProvider.SetError(MatriculaMaskedTextBox, "El campo matricula no puede estar vacío");
                MatriculaMaskedTextBox.Focus();
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
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            Estudiantes estudiante = repositorio.Buscar(Convert.ToInt32(EstudianteIdNumericUpDown.Value));

            return (estudiante != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            bool paso = false;

            if (!Valida())
                return;

            Estudiantes estudiante = LlenaClase();

            if (EstudianteIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("El estudiante buscado no se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(estudiante);
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

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);
            
            if (usuario.Tipo.CompareTo("Administrador") == 0)
            {
                RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

                int id;
                int.TryParse(Convert.ToString(EstudianteIdNumericUpDown.Value), out id);

                Estudiantes estudiante = repositorio.Buscar(id);
                Limpiar();

                if (estudiante != null)
                {
                    repositorio.Eliminar(id);
                    MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MyErrorProvider.SetError(EstudianteIdNumericUpDown, "No se puede eliminar un estudiante que no se encuentra en la base de datos");

            }
            else
            {
                MessageBox.Show("Esta registrado como usuario estandar, no puede eliminar profesores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            int id;
            int.TryParse(Convert.ToString(EstudianteIdNumericUpDown.Value), out id);

            Estudiantes estudiante = repositorio.Buscar(id);
            Limpiar();

            if (estudiante != null)
                LlenaCampo(estudiante);
            else
                MessageBox.Show("El estudiante buscado no se encuentra en la base de datos");
        }

        private void MatriculaMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
