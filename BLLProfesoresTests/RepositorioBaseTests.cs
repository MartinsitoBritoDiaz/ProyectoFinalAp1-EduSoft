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
            RepositorioBase<Profesores> repositorioProfesores = new RepositorioBase<Profesores>();

            bool paso = false;

            Profesores profesores = repositorioProfesores.Buscar(2);

            if (profesores != null)
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
            RepositorioBase<Profesores> repositorioProfesores = new RepositorioBase<Profesores>();

            Assert.IsTrue(repositorioProfesores.Eliminar(3));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Profesores> repositorioProfesores = new RepositorioBase<Profesores>();

            List<Profesores> lista = new List<Profesores>();

            bool paso = false;

            lista = repositorioProfesores.GetList(p => true);

            if (lista != null)
                paso = true;

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Profesores> repositorioProfesores = new RepositorioBase<Profesores>();

            Profesores profesores = new Profesores();

            profesores.ProfesorId = 0;
            profesores.Nombre = "Martin Brito";
            profesores.Genero = 0;
            profesores.Cedula = "7894512631";
            profesores.Celular = "8294233828";
            profesores.Direccion = "Nagua";
            profesores.Email = "martinb@gmail.com";
            profesores.Telefono = "8095847013";
            profesores.Usuario = "Admin";
            profesores.UsuarioId = 1;

            Assert.IsTrue(repositorioProfesores.Guardar(profesores));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Profesores> repositorioProfesores = new RepositorioBase<Profesores>();

            Profesores profesores = new Profesores();

            profesores.ProfesorId = 2;
            profesores.Nombre = "Martin Brito";
            profesores.Genero = 0;
            profesores.Cedula = "7894512631";
            profesores.Celular = "8294233828";
            profesores.Direccion = "Nagua";
            profesores.Email = "martinb@gmail.com";
            profesores.Telefono = "8095847013";
            profesores.Usuario = "Admin";
            profesores.UsuarioId = 1;

            Assert.IsTrue(repositorioProfesores.Modificar(profesores));
        }
    }
}