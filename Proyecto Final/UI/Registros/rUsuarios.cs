using Entidades;
using BLL;
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
    public partial class rUsuarios : Form
    {
        private int UsuarioId { get; set; }
        public rUsuarios(int id)  
        {
            UsuarioId = id;
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            UsuarioIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            GeneroComboBox.ResetText();
            TipoComboBox.ResetText();
            EmailTextBox.Text = string.Empty;
            UsuarioTextBox.Text = string.Empty;
            ContraseñaTextBox.Text = string.Empty;
            UsuarioConectadoTextBox.Text = string.Empty;
        }


        private void LlenaCampos(Usuarios usuario)
        {
            UsuarioIdNumericUpDown.Value = usuario.UsuarioId;
            NombreTextBox.Text = usuario.Nombre;
            CelularMaskedTextBox.Text = usuario.Celular;
            CedulaMaskedTextBox.Text = usuario.Cedula;
            GeneroComboBox.SelectedIndex = usuario.Genero;
            TipoComboBox.Text = usuario.Tipo;
            EmailTextBox.Text = usuario.Email;
            UsuarioTextBox.Text = usuario.Usuario;
            ContraseñaTextBox.Text = DesEncriptar(usuario.Contraseña);
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Celular = CelularMaskedTextBox.Text;
            usuario.Cedula = CedulaMaskedTextBox.Text;
            usuario.Genero = GeneroComboBox.SelectedIndex;
            usuario.Tipo = TipoComboBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.Usuario = UsuarioTextBox.Text;
            usuario.Contraseña = Encriptar(ContraseñaTextBox.Text);

            return usuario;
        }



        private string Encriptar(string cadenaAencriptar)//Esta función encripta la cadena que se le pasa por parámentro
        {
            string resultado = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            resultado = Convert.ToBase64String(encryted);
            return resultado;
        }

        private string DesEncriptar(string cadenaAdesencriptar)//Esta función desencripta la cadena que se le pasa por parámentro
        {
            string resultado = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            resultado = System.Text.Encoding.Unicode.GetString(decryted);
            return resultado;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El campo celular no puede estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo celular no puede estar vacio");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(GeneroComboBox.Text))
            {
                MyErrorProvider.SetError(GeneroComboBox, "Debe seleccionar un genero");
                GeneroComboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TipoComboBox.Text))
            {
                MyErrorProvider.SetError(TipoComboBox, "Debe seleccionar un Ttipo de usuario");
                TipoComboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyErrorProvider.SetError(EmailTextBox, "El campo email no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo usuario no puede estar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MyErrorProvider.SetError(ContraseñaTextBox, "El campo contraseña no puede estar vacio");
                ContraseñaTextBox.Focus();
                paso = false;
            }

            if (!EmailTextBox.Text.EndsWith("@gmail.com") && !EmailTextBox.Text.EndsWith("@outlook.com") )
            {
                MyErrorProvider.SetError(EmailTextBox, "El email debe de ser de @gmail.com o @outlook.com \npara poder realizar futuras recuperaciones");
                EmailTextBox.Focus();
                paso = false;
            }

            if(ContraseñaTextBox.Text.Length < 4)
            {
                MyErrorProvider.SetError(ContraseñaTextBox, "La contraseña debe de tener 4 o mas caracteres");
                ContraseñaTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            Usuarios usuario = repositorio.Buscar((int)UsuarioIdNumericUpDown.Value);

            return (usuario != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            bool paso = false;

            if (!Validar())
                return;

            Usuarios usuario = LlenaClase();

            if (UsuarioIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra el usuario en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(usuario);
            }


            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            int id;
            int.TryParse(Convert.ToString(UsuarioIdNumericUpDown.Value), out id);

            Usuarios usuario = repositorio.Buscar(id);

            Limpiar();

            if (usuario != null)
            {
                repositorio.Eliminar(id);
                MessageBox.Show("Usuario eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MyErrorProvider.SetError(UsuarioIdNumericUpDown, "No existe ningun usuario con ese id para ser borrado");

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            int id;
            int.TryParse(Convert.ToString(UsuarioIdNumericUpDown.Value), out id);

            Usuarios usuario = repositorio.Buscar(id);

            Limpiar();

            if (usuario != null)
            {
                LlenaCampos(usuario);
            }
            else
                MessageBox.Show("Usuario no encontrado");
        }

        private void RUsuarios_Load(object sender, EventArgs e)
        {
            //Para obtener el usuario conectado
            RepositorioBase<Usuarios> repositorioUsuario = new RepositorioBase<Usuarios>();

            Usuarios usuario = repositorioUsuario.Buscar(UsuarioId);

            if (usuario != null)
                UsuarioConectadoTextBox.Text = usuario.Nombre;
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
