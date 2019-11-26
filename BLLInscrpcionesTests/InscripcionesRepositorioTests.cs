using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class InscripcionesRepositorioTests
    {
        [TestMethod()]
        public void ModificarTest()
        {
            InscripcionesRepositorio repositorio = new InscripcionesRepositorio();

            Inscripciones inscripciones = new Inscripciones();

            List<EstudiantesDetalles> detalle = new List<EstudiantesDetalles>();

            detalle.Add(
                new EstudiantesDetalles(
                        id: 0,
                        matricula: 20170611,
                        nombre: "Martinsito",
                        inscripcionId: 1,
                        asignatura: "Programacion aplicada 1"
                    )
                );

            detalle.Add(
                new EstudiantesDetalles(
                        id: 0,
                        matricula: 20170612,
                        nombre: "Rao",
                        inscripcionId: 1,
                        asignatura: "Programacion aplicada 1"
                    )
                );

            inscripciones.InscripcionId = 1;
            inscripciones.SemestreId = 1;
            inscripciones.Usuario = "Jose";
            inscripciones.UsuarioId = 1;
            inscripciones.Fecha = DateTime.Now;
            inscripciones.Asignatura = "Programacion aplicada 1";
            inscripciones.CantidadEstudiantes = 2;
            inscripciones.EstudiantesDetalle = detalle;

            Assert.IsTrue(repositorio.Modificar(inscripciones));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            InscripcionesRepositorio repositorio = new InscripcionesRepositorio();

            Inscripciones inscripciones = repositorio.Buscar(1);

            bool paso = false;

            if (inscripciones != null)
                paso = true;

            Assert.IsTrue(paso);

        }
    }
}