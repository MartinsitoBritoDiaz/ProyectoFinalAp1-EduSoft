using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SemestreRepositorio : RepositorioBase<Semestres>
    {
        public override bool Guardar(Semestres semestre)
        {
            if (semestre.FechaInicio <= DateTime.Now && semestre.FechaFin > DateTime.Now)
                semestre.Activo = true;
            else
                semestre.Activo = false;

            return base.Guardar(semestre);
        }

        public override bool Modificar(Semestres semestre)
        {
            if (semestre.FechaInicio <= DateTime.Now && semestre.FechaFin > DateTime.Now)
                semestre.Activo = true;
            else
                semestre.Activo = false;

            return base.Modificar(semestre);
        }
    }
}
