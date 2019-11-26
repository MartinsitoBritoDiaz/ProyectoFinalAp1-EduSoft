using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CategoriasAsignaciones
    {
        [Key]
        public int CategoriaAsignacionId { get; set; }
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }

        public CategoriasAsignaciones()
        {
            CategoriaAsignacionId = 0;
            Nombre = string.Empty;
            Usuario = string.Empty;
            UsuarioId = 0;
        }
    }
}
