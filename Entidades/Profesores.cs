using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesores
    {
        [Key]
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public int Genero { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public byte[] Foto { get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }

        public Profesores()
        {
            ProfesorId = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Cedula = string.Empty;
            Genero = 0;
            Email = string.Empty;
            Direccion = string.Empty;
            UsuarioId = 0;
            Usuario = string.Empty;
        }
    }
}
