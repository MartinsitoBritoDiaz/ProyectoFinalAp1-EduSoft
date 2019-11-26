using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstudiantesDetalles
    {
        [Key]
        public int EstudiantesDetalleId { get; set; }
        public int Matricula { get; set; }
        public int InscripcionId { get; set; }
        public string Asignatura { get; set; }
        public string Nombre { get; set; }
        public EstudiantesDetalles(int id,int matricula, string nombre, int inscripcionId,string asignatura)
        {
            EstudiantesDetalleId = id;
            Matricula = matricula;
            InscripcionId = inscripcionId;
            Nombre = nombre;
            Asignatura = asignatura;
        }

        public EstudiantesDetalles()
        {
            EstudiantesDetalleId = 0;
            Matricula = 0;
            InscripcionId = 0;
            Nombre = string.Empty;
            Asignatura = string.Empty;
        }

    }
}
