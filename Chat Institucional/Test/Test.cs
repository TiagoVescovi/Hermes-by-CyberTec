using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatInstitucional.Logica;
using ChatInstitucional.De_persistencia;
using System.Data;

namespace Test
{
    [TestClass]
    public class Test
    {
        public void SelectPersonasNotNull()
        {
            Connect connect = new Connect();

            DataTable dataTable = connect.Select("SELECT * FROM persona;");
            Assert.IsNotNull(dataTable);
        }

        [TestMethod]
        public void ValidarAlumnoTrue()
        {
            Alumno alumno = new Alumno();
            int cedula = 5461182;
            string pass = "1234";

            bool valida = alumno.ValidarAlumno(cedula, pass);
            Assert.IsTrue(valida);
        }

        [TestMethod]
        public void ValidarAlumnoFalse()
        {
            Alumno alumno = new Alumno();
            int cedula = 1234567;
            string pass = "1234";

            bool valida = alumno.ValidarAlumno(cedula, pass);
            Assert.IsFalse(valida);
        }

        [TestMethod]
        public void ValidarDocenteTrue()
        {
            Docente docente = new Docente();
            int cedula = 5490150;
            string pass = "5678";

            bool valida = docente.ValidarDocente(cedula, pass);
            Assert.IsTrue(valida);
        }

        [TestMethod]
        public void ValidarDocenteFalse()
        {
            Docente docente = new Docente();
            int cedula = 1234567;
            string pass = "1234";

            bool valida = docente.ValidarDocente(cedula, pass);
            Assert.IsFalse(valida);
        }

        [TestMethod]
        public void ValidarAdminTrue()
        {
            Administrador administrador = new Administrador();
            int cedula = 5355782;
            string pass = "4321";

            bool valida = administrador.ValidarAdmin(cedula, pass);
            Assert.IsTrue(valida);
        }

        [TestMethod]
        public void ValidarAdminFalse()
        {
            Administrador administrador = new Administrador();
            int cedula = 1234567;
            string pass = "1234";

            bool valida = administrador.ValidarAdmin(cedula, pass);
            Assert.IsFalse(valida);
        }
    }
}
