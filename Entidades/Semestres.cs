using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Semestres
    {
        [Key]
        public int SemestreId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }

        public Semestres()
        {
            SemestreId = 0;
            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
            Activo = false;
            UsuarioId = 0;
            Usuario = string.Empty;
        }
    }
}
