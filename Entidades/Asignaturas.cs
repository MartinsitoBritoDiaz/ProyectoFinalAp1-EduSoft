using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        public int ProfesorId { get; set; }
        public string NombreProfesor { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }

        public Asignaturas()
        {
            AsignaturaId = 0;
            ProfesorId = 0;
            NombreProfesor = string.Empty;
            Nombre = string.Empty;
            Creditos = 0;
            Descripcion = string.Empty;
            UsuarioId = 0;
            Usuario = string.Empty;
        }
    }
}
