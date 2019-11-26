using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Asistencias> Asistencia { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }
        public DbSet<Asignaciones> Asignacion { get; set; }
        public DbSet<CategoriasAsignaciones> CategoriaAsignacion { get; set; }
        public DbSet<Asignaturas> Asignatura { get; set; }
        public DbSet<Semestres> Semestre { get; set; }
        public DbSet<Estudiantes> Estudiante { get; set; }
        public DbSet<Profesores> Profesor { get; set; }
        public Contexto() : base("ConStr") { }
    }
}
