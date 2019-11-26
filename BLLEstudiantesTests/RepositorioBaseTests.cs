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
            RepositorioBase<Estudiantes> repositorioEstudiantes = new RepositorioBase<Estudiantes>();

            Estudiantes estudiantes = repositorioEstudiantes.Buscar(5);

            bool paso = false;

            if (estudiantes != null)
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
            RepositorioBase<Estudiantes> repositorioEstudiantes = new RepositorioBase<Estudiantes>();

            Assert.IsTrue(repositorioEstudiantes.Eliminar(5));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Estudiantes> repositorioEstudiantes = new RepositorioBase<Estudiantes>();

            List<Estudiantes> lista = new List<Estudiantes>();

            bool paso = false;

            lista = repositorioEstudiantes.GetList(p => true);

            if (lista != null)
                paso = true;

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Estudiantes> repositorioEstudiantes = new RepositorioBase<Estudiantes>();

            Estudiantes estudiantes = new Estudiantes();

            estudiantes.EstudianteId = 0;
            estudiantes.Matricula = 20170611;
            estudiantes.Cedula = "402545789612";
            estudiantes.Celular = "8092128159";
            estudiantes.Direccion = "Nagua";
            estudiantes.Email = "MartinsitoBD@gmail.com";
            estudiantes.Genero = 0;
            estudiantes.Telefono = "8095847013";
            estudiantes.Usuario = "Administrador";
            estudiantes.UsuarioId = 1;
            estudiantes.Nombre = "Martinsito Brito Diaz";

            Assert.IsTrue(repositorioEstudiantes.Guardar(estudiantes));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estudiantes> repositorioEstudiantes = new RepositorioBase<Estudiantes>();

            Estudiantes estudiantes = new Estudiantes();

            estudiantes.EstudianteId = 5;
            estudiantes.Matricula = 20170611;
            estudiantes.Cedula = "402545789612";
            estudiantes.Celular = "8092128159";
            estudiantes.Direccion = "Nagua";
            estudiantes.Email = "MartinsitoBD@gmail.com";
            estudiantes.Genero = 0;
            estudiantes.Telefono = "8095847013";
            estudiantes.Usuario = "Administrador";
            estudiantes.UsuarioId = 1;
            estudiantes.Nombre = "Martinsito Brito Diaz";

            Assert.IsTrue(repositorioEstudiantes.Modificar(estudiantes));
        }
    }
}