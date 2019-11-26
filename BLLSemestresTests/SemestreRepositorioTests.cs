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
    public class SemestreRepositorioTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            SemestreRepositorio repositorio = new SemestreRepositorio();

            Semestres semestres = new Semestres();

            semestres.FechaInicio = DateTime.Now;
            semestres.FechaFin = DateTime.Now;
            semestres.SemestreId = 0;
            semestres.Usuario = "Jose";
            semestres.UsuarioId = 1;

            Assert.IsTrue(repositorio.Guardar(semestres));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            SemestreRepositorio repositorio = new SemestreRepositorio();

            Semestres semestres = new Semestres();

            semestres.FechaInicio = DateTime.Now;
            semestres.FechaFin = DateTime.Now;
            semestres.SemestreId = 2;
            semestres.Usuario = "Jose";
            semestres.UsuarioId = 1;

            Assert.IsTrue(repositorio.Guardar(semestres));
        }
    }
}