using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstudiantesAsistenciasDetalles
    {
        [Key]
        public int EstudianteId { get; set; }
        public int AsistenciaId { get; set; }
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public bool Presente { get; set; }
        public bool Ausente { get; set; }
        public bool Excusa { get; set; }

        public EstudiantesAsistenciasDetalles(int estudianteId, int asistenciaId, int matricula, string nombre, bool presente, bool ausente, bool excusa)
        {
            EstudianteId = estudianteId;
            AsistenciaId = asistenciaId;
            Matricula = matricula;
            Nombre = nombre;
            Presente = presente;
            Ausente = ausente;
            Excusa = excusa;
        }

        public EstudiantesAsistenciasDetalles()
        {
            EstudianteId = 0;
            AsistenciaId = 0;
            Matricula = 0;
            Nombre = string.Empty;
            Presente = false;
            Ausente = true;
            Excusa = false;
        }
    }
}
