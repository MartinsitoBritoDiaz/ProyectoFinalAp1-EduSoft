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
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura = repositorioAsignaturas.Buscar(4);

            bool paso = false;

            if (asignatura != null)
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
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();

            Assert.IsTrue(repositorioAsignaturas.Eliminar(4));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();

            List<Asignaturas> lista = new List<Asignaturas>();

            bool paso = false;

            lista = repositorioAsignaturas.GetList(p => true);

            if (lista != null)
                paso = true;

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura = new Asignaturas();

            asignatura.AsignaturaId = 0;
            asignatura.Creditos = 4;
            asignatura.Descripcion = "Presencial";
            asignatura.Nombre = "Programacion aplicada 1";
            asignatura.NombreProfesor = "Enel Almonte";
            asignatura.ProfesorId = 2;
            asignatura.Usuario = "Administrador";
            asignatura.UsuarioId = 1;

            Assert.IsTrue(repositorioAsignaturas.Guardar(asignatura));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Asignaturas> repositorioAsignaturas = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura = new Asignaturas();

            asignatura.AsignaturaId = 4;
            asignatura.Creditos = 4;
            asignatura.Descripcion = "Presencial";
            asignatura.Nombre = "Programacion aplicada 1";
            asignatura.NombreProfesor = "Enel Almonte";
            asignatura.ProfesorId = 2;
            asignatura.Usuario = "Administrador";
            asignatura.UsuarioId = 1;

            Assert.IsTrue(repositorioAsignaturas.Modificar(asignatura));
        }
    }
}