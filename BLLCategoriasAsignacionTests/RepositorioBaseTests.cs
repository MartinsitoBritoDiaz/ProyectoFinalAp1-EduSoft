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
            RepositorioBase<CategoriasAsignaciones> repositorio = new RepositorioBase<CategoriasAsignaciones>();

            CategoriasAsignaciones categoria = repositorio.Buscar(1);

            bool paso = false;

            if (categoria != null)
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
            RepositorioBase<CategoriasAsignaciones> repositorio = new RepositorioBase<CategoriasAsignaciones>();

            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<CategoriasAsignaciones> repositorio = new RepositorioBase<CategoriasAsignaciones>();

            List<CategoriasAsignaciones> ListaCategoria = new List<CategoriasAsignaciones>();

            bool paso = false;

            if (ListaCategoria != null)
                paso = true;

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<CategoriasAsignaciones> repositorio = new RepositorioBase<CategoriasAsignaciones>();

            CategoriasAsignaciones categoria = new CategoriasAsignaciones();

            categoria.CategoriaAsignacionId = 0;
            categoria.Nombre = "Tarea";
            categoria.Usuario = "Jose";
            categoria.UsuarioId = 1;

            Assert.IsTrue(repositorio.Guardar(categoria));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<CategoriasAsignaciones> repositorio = new RepositorioBase<CategoriasAsignaciones>();

            CategoriasAsignaciones categoria = new CategoriasAsignaciones();

            categoria.CategoriaAsignacionId = 1;
            categoria.Nombre = "Tarea";
            categoria.Usuario = "Jose";
            categoria.UsuarioId = 1;

            Assert.IsTrue(repositorio.Guardar(categoria));
        }
    }
}