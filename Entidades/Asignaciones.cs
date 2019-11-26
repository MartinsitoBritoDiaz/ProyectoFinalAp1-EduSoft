using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asignaciones
    {
        [Key]
        public int AsignacionId { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Descripcion { get; set; }
        public int AsignaturaId { get; set; }
        public string Asignatura { get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }

        public Asignaciones()
        {
            AsignacionId = 0;
            Nombre = string.Empty;
            Categoria = string.Empty;
            FechaCreacion = DateTime.Now;
            FechaEntrega = DateTime.Now;
            Descripcion = string.Empty;
            AsignaturaId = 0;
            Asignatura = string.Empty;
            UsuarioId = 0;
            Usuario = string.Empty;
        }
    }
}
