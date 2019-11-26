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
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            Usuarios usuarios = repositorio.Buscar(4);

            bool paso = false;

            if (usuarios != null)
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
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();


            Assert.IsTrue(repositorio.Eliminar(4));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios> repositorioUsuarios = new RepositorioBase<Usuarios>();

            List<Usuarios> lista = new List<Usuarios>();

            bool paso = false;

            lista = repositorioUsuarios.GetList(p => true);

            if (lista != null)
                paso = true;

            Assert.IsTrue(paso);
        }


        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = 0;
            usuario.Nombre = "Jose";
            usuario.Usuario = "user";
            usuario.Contraseña = "1234";
            usuario.Tipo = "Administrador";
            usuario.Celular = "8059885668";
            usuario.Email = "Jose@gmail.com";
            usuario.Cedula = "15484658956";
            usuario.Genero = 0;

            Assert.IsTrue(repositorio.Guardar(usuario));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = 3;
            usuario.Nombre = "Jose";
            usuario.Usuario = "user";
            usuario.Contraseña = "1234";
            usuario.Tipo = "Administrador";
            usuario.Celular = "8059885668";
            usuario.Email = "Jose@gmail.com";
            usuario.Cedula = "15484658956";
            usuario.Genero = 0;

            Assert.IsTrue(repositorio.Guardar(usuario));
        }
    }
}