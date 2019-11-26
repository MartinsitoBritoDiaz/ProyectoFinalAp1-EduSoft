using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencias
    {
        [Key]
        public int AsistenciaId { get; set; }
        public int SemestreId { get; set; }
        public DateTime Fecha { get; set; }
        public string Profesor { get; set; }
        public int Total { get; set; }
        public int CantidadPresentes { get; set; }
        public int CantidadAusentes { get; set; }
        public int CantidadExcusas { get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public virtual List<EstudiantesAsistenciasDetalles> EstudiantesAsistenciasDetalle { get; set; }
        public Asistencias()
        {
            AsistenciaId = 0;
            SemestreId = 0;
            Fecha = DateTime.Now;
            Profesor = string.Empty;
            Total = 0;
            CantidadPresentes = 0;
            CantidadAusentes = 0;
            CantidadExcusas = 0;
            UsuarioId = 0;
            Usuario = string.Empty;
            EstudiantesAsistenciasDetalle = new List<EstudiantesAsistenciasDetalles>();
        }
    }
}
