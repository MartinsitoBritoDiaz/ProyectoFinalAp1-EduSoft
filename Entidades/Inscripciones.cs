using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public int SemestreId { get; set; }
        public DateTime Fecha { get; set; }
        public string Asignatura { get; set; }
        public int CantidadEstudiantes { get; set; }
        public virtual List<EstudiantesDetalles> EstudiantesDetalle { get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public Inscripciones()
        {
            InscripcionId = 0;
            SemestreId = 0;
            Fecha = DateTime.Now;
            Asignatura = string.Empty;
            CantidadEstudiantes = 0;
            UsuarioId = 0;
            Usuario = string.Empty;

            EstudiantesDetalle = new List<EstudiantesDetalles>();
        }
    }
}
