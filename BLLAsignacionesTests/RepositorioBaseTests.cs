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
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Asignaciones> repositorio = new RepositorioBase<Asignaciones>();

            Asignaciones asignacion = repositorio.Buscar(1);

            bool paso = false;

            if (asignacion != null)
                paso = true;

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Asignaciones> repositorio = new RepositorioBase<Asignaciones>();

            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Asignaciones> repositorio = new RepositorioBase<Asignaciones>();

            List<Asignaciones> ListaAsignacion = new List<Asignaciones>();

            bool paso = false;

            if (ListaAsignacion != null)
                paso = true;

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Asignaciones> repositorio = new RepositorioBase<Asignaciones>();

            Asignaciones asignacion = new Asignaciones();

            asignacion.AsignacionId = 0;
            asignacion.Asignatura = "Programacion Aplicada";
            asignacion.AsignaturaId = 1;
            asignacion.Categoria = "Tarea";
            asignacion.Descripcion = "Urgente";
            asignacion.FechaCreacion = DateTime.Now;
            asignacion.FechaEntrega = DateTime.Now;
            asignacion.Nombre = "Entregable 2";
            asignacion.Usuario = "Jose";
            asignacion.UsuarioId = 1;

            Assert.IsTrue(repositorio.Guardar(asignacion));
            
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Asignaciones> repositorio = new RepositorioBase<Asignaciones>();

            Asignaciones asignacion = new Asignaciones();

            asignacion.AsignacionId = 1;
            asignacion.Asignatura = "Programacion Aplicada";
            asignacion.AsignaturaId = 1;
            asignacion.Categoria = "Tarea";
            asignacion.Descripcion = "Urgente";
            asignacion.FechaCreacion = DateTime.Now;
            asignacion.FechaEntrega = DateTime.Now;
            asignacion.Nombre = "Entregable 2";
            asignacion.Usuario = "Jose";
            asignacion.UsuarioId = 1;

            Assert.IsTrue(repositorio.Guardar(asignacion));
        }
    }
}