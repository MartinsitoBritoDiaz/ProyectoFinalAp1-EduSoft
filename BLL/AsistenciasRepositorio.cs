using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityState = System.Data.Entity.EntityState;

namespace BLL
{
    public class AsistenciasRepositorio : RepositorioBase<Asistencias>
    {
        public override bool Modificar(Asistencias asistencia)
        {
            RepositorioBase<EstudiantesDetalles> Detalle = new RepositorioBase<EstudiantesDetalles>();

            foreach (var item in asistencia.EstudiantesAsistenciasDetalle)
            {
                if (item.EstudianteId == 0)
                    _contexto.Entry(item).State = EntityState.Added;
                else
                    _contexto.Entry(item).State = EntityState.Modified;
            }

            int presente = 0;
            int ausentes = 0;
            int excusas = 0;

            foreach (var item in asistencia.EstudiantesAsistenciasDetalle)
            {
                if (item.Presente)
                    presente += 1;

                if (item.Ausente)
                    ausentes += 1;

                if (item.Excusa)
                    excusas += 1;
            }

            asistencia.CantidadAusentes = ausentes;
            asistencia.CantidadExcusas = excusas;
            asistencia.CantidadPresentes = presente;

            return base.Modificar(asistencia);
        }

        public override Asistencias Buscar(int id)
        {
            Asistencias asistencia = new Asistencias();

            asistencia = base._contexto.Asistencia.Find(id);

            if (asistencia != null)
                asistencia.EstudiantesAsistenciasDetalle.Count();

            return base.Buscar(id);
        }

        public override bool Guardar(Asistencias asistencias)
        {
            int presente = 0;
            int ausentes = 0;
            int excusas = 0;

            foreach (var item in asistencias.EstudiantesAsistenciasDetalle)
            {
                if (item.Presente)
                    presente += 1;

                if (item.Ausente)
                    ausentes += 1;

                if (item.Excusa)
                    excusas += 1;
            }

            asistencias.CantidadAusentes = ausentes;
            asistencias.CantidadExcusas = excusas;
            asistencias.CantidadPresentes = presente;

            return base.Guardar(asistencias);
        }
    }
}
