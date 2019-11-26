using Entidades;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class InscripcionesRepositorio : RepositorioBase<Inscripciones>
    {
        public override bool Modificar(Inscripciones inscripcion)
        {
            RepositorioBase<EstudiantesDetalles> Detalle = new RepositorioBase<EstudiantesDetalles>();

            foreach (var item in inscripcion.EstudiantesDetalle)
            {
                if (item.EstudiantesDetalleId == 0)
                {
                    _contexto.Entry(item).State = EntityState.Added;
                }
                else
                {
                    _contexto.Entry(item).State = EntityState.Modified;
                }
            }

            inscripcion.CantidadEstudiantes = inscripcion.EstudiantesDetalle.Count();

            return base.Modificar(inscripcion);
        }

        public override Inscripciones Buscar(int id)
        {
            Inscripciones inscripcion = new Inscripciones();

            inscripcion = base._contexto.Inscripciones.Find(id);

            if (inscripcion != null)
                inscripcion.EstudiantesDetalle.Count();

            return base.Buscar(id);
        }
    }
}
