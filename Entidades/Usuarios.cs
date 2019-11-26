using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public int Genero { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Celular = string.Empty;
            Cedula = string.Empty;
            Genero = 0;
            Email = string.Empty;
            Tipo = string.Empty;
            Usuario = string.Empty;
            Contraseña = string.Empty;
        }
    }
}
