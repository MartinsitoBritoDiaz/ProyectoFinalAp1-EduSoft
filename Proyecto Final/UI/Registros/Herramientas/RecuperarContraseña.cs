using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.UI.Registros.Herramientas
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void RecuperarButton_Click(object sender, EventArgs e)
        {
            Enviar();
        }

        private string DesEncriptar(string cadenaAdesencriptar)//Esta función desencripta la cadena que se le pasa por parámentro
        {
            string resultado = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            resultado = System.Text.Encoding.Unicode.GetString(decryted);
            return resultado;
        }

        private void Enviar()
        {
            if(!VerificarConexion())
            {
                MessageBox.Show("No existe una conexion a la red para recuperar la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }   
            
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            bool paso = false;

            int id = 0;
            string usuario = string.Empty;
            string contraseña = string.Empty;


            foreach (var item in repositorio.GetList(u => true))
            {
                if(string.Equals(item.Email, EmailTextBox.Text, StringComparison.OrdinalIgnoreCase))
                {
                    paso = true;
                    id = item.UsuarioId;
                    usuario = item.Usuario;
                    contraseña = DesEncriptar(item.Contraseña);
                    break;
                }
            }

            if (paso)
            {
                string email = EmailTextBox.Text;

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

                msg.To.Add(email);
                msg.Subject = "Recuperacion de la cuenta de edusoft";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                msg.Bcc.Add("edusoftap@gmail.com");

                msg.Body = "!Hola usuario de edusoft! <br/> <br/> Su usuario es: " + usuario + "<br/>La contraseña es: " + contraseña;
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.From = new System.Net.Mail.MailAddress("edusoftap@gmail.com");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new System.Net.NetworkCredential("edusoftap@gmail.com", "EDUSOFT199001");

                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";
                try
                {
                    cliente.Send(msg);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al enviar el correo de recuperacíon");
                }


                MessageBox.Show("Correo de recuperacion enviado","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Este email no se encuentra relacionado con ninguna cuenta en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool VerificarConexion()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
