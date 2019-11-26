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
    public class AsistenciasRepositorioTests
    {
        [TestMethod()]
        public void ModificarTest()
        {
            AsistenciasRepositorio repositorio = new AsistenciasRepositorio();

            Asistencias asistencias = new Asistencias();

            List<EstudiantesAsistenciasDetalles> detalle = new List<EstudiantesAsistenciasDetalles>();

            detalle.Add(
                new EstudiantesAsistenciasDetalles(
                    estudianteId: 0,
                    asistenciaId: 1,
                    matricula: 20170611,
                    nombre: "Martinsito Brito",
                    presente: false,
                    ausente: true,
                    excusa: false
                    )
                );
            asistencias.AsistenciaId = 1;
            asistencias.SemestreId = 1;
            asistencias.UsuarioId = 1;
            asistencias.Usuario = "Jose";
            asistencias.Total = 1;
            asistencias.EstudiantesAsistenciasDetalle = detalle;

            Assert.IsTrue(repositorio.Modificar(asistencias));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            AsistenciasRepositorio repositorio = new AsistenciasRepositorio();

            Asistencias asistencias = repositorio.Buscar(1);

            bool paso = false;

            if (asistencias != null)
                paso = true;

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            AsistenciasRepositorio repositorio = new AsistenciasRepositorio();

            Asistencias asistencias = new Asistencias();

            List<EstudiantesAsistenciasDetalles> detalle = new List<EstudiantesAsistenciasDetalles>();

            detalle.Add(
                new EstudiantesAsistenciasDetalles(
                    estudianteId: 0,
                    asistenciaId: 0,
                    matricula: 20170611,
                    nombre: "Martinsito Brito",
                    presente: false,
                    ausente: true,
                    excusa: false
                    )
                );
            asistencias.AsistenciaId = 0;
            asistencias.SemestreId = 1;
            asistencias.UsuarioId = 1;
            asistencias.Usuario = "Jose";
            asistencias.Total = 1;
            asistencias.EstudiantesAsistenciasDetalle = detalle;

            Assert.IsTrue(repositorio.Guardar(asistencias));
        }
    }
}