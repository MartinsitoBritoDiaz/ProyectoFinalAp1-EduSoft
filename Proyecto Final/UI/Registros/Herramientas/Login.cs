using BLL;
using Entidades;
using Proyecto_Final.UI.Registros.Herramientas;
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
    public partial class Login : Form
    {
        public Login()
        {
            bool paso = false;

            RepositorioBase<Usuarios> RepositorioUsuario = new RepositorioBase<Usuarios>();

            foreach (var item in RepositorioUsuario.GetList(u => true))
            {
                if (item != null)
                {
                    paso = true;
                    break;
                }
            }

            if (paso == false)
            {
                Usuarios usuario = new Usuarios();
                usuario.Nombre = "Administrador";
                usuario.Celular = "8092128159";
                usuario.Cedula = "16789424587";
                usuario.Genero = 0;
                usuario.Email = "Edusoftap@gmail.com";
                usuario.Tipo = "Administrador";
                usuario.Usuario = "Admin";
                usuario.Contraseña = Encriptar("1234");

                RepositorioUsuario.Guardar(usuario);
            }

            InitializeComponent();
        }
        
        private string Encriptar(string cadenaAencriptar)//Esta función encripta la cadena que se le pasa por parámentro
        {
            string resultado = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            resultado = Convert.ToBase64String(encryted);
            return resultado;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            UsuarioTextBox.Text = string.Empty;
            ContraseñaTextBox.Text = string.Empty;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();

            bool paso = true;

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo usuario no puede estar vacío");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MyErrorProvider.SetError(ContraseñaTextBox, "El campo contraseña no puede estar vacío");
                ContraseñaTextBox.Focus();
                paso = false;
            }

            return paso;
        }
        private void IngresarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            bool paso = false;
            int id = 0;

            if (!Validar())
                return;

            foreach (var item in repositorio.GetList(u => true))
            {
                if(item.Usuario == UsuarioTextBox.Text)
                {
                    if (DesEncriptar(item.Contraseña) == ContraseñaTextBox.Text)
                    {
                        paso = true;
                        id = item.UsuarioId;
                        break;
                    }
                }
            }

            if (paso)
            {
                this.Hide();
                MainForm menu = new MainForm(id);
                menu.ShowDialog();
                this.Dispose();
            }
            else
                MyErrorProvider.SetError(IngresarButton, "Usuario o Contraseña incorrectos");
                
        }

        private string DesEncriptar(string cadenaAdesencriptar)//Esta función desencripta la cadena que se le pasa por parámentro
        {
            string resultado = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            resultado = System.Text.Encoding.Unicode.GetString(decryted);
            return resultado;
        }

        private void VisualizarPictureBox_Click(object sender, EventArgs e)
        {
            if (!ContraseñaTextBox.UseSystemPasswordChar)
                ContraseñaTextBox.UseSystemPasswordChar = true;
            else
                ContraseñaTextBox.UseSystemPasswordChar = false;
        }

        private void OlvidoLabel_Click(object sender, EventArgs e)
        {
            RecuperarContraseña recuperar = new RecuperarContraseña();
            recuperar.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
