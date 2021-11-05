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

        [TestMethod]
        public void BuscarPersonaNotNull()
        {
            Persona persona = new Persona();
            int cedula = 5355782;

            Assert.IsNotNull(persona.BuscarPersona(cedula));
        }

        [TestMethod]
        public void BuscarAdminNotNull()
        {
            Administrador administrador = new Administrador();
            int cedula = 5355782;

            Assert.IsNotNull(administrador.BuscarAdmin(cedula));
        }

        [TestMethod]
        public void BuscarDocenteNotNull()
        {
            Docente docente = new Docente();
            int cedula = 5355782;

            Assert.IsNotNull(docente.BuscarDocente(cedula));
        }

        [TestMethod]
        public void BuscarAlumnoNotNull()
        {
            Alumno alumno = new Alumno();
            int cedula = 5355782;

            Assert.IsNotNull(alumno.BuscarAlumno(cedula));
        }

        [TestMethod]
        public void BuscarChatNull()
        {
            Chat chat = new Chat();
            int idchat = 300;

            Assert.IsNotNull(chat.BuscarChat(idchat));
        }

        [TestMethod]
        public void BuscarConsultaNull()
        {
            Consulta consulta = new Consulta();
            int idconsulta = 300;

            Assert.IsNotNull(consulta.BuscarConsulta(idconsulta));
        }

        [TestMethod]
        public void ValidarCedulaTrue()
        {
            string cedula = "5355782-4";

            Assert.IsTrue(CIValidator.Validate(cedula));
        }

        [TestMethod]
        public void ValidarCedulaFalse()
        {
            string cedula = "111111-4";

            Assert.IsFalse(CIValidator.Validate(cedula));
        }

        [TestMethod]
        public void TraerGrupoNotNull()
        {
            Grupo grupo = new Grupo();
            int idgrupo = 1;

            Assert.IsNotNull(grupo.TraerGrupo(idgrupo));
        }

        [TestMethod]
        public void ListarAlumnosNotNull()
        {
            Alumno alumno = new Alumno();

            Assert.IsNotNull(alumno.ListarAlumnos());
        }

        [TestMethod]
        public void ListarPersonasNotNull()
        {
            Persona persona = new Persona();

            Assert.IsNotNull(persona.ListarPersonas());
        }

        [TestMethod]
        public void ListarDocentesNotNUll()
        {
            Docente docente = new Docente();

            Assert.IsNotNull(docente.ListarDocentes());
        }

        [TestMethod]
        public void ListarAdminsNotNull()
        {
            Administrador administrador = new Administrador();

            Assert.IsNotNull(administrador.ListarAdmins());
        }

        [TestMethod]
        public void ListarMateriasNotNUll()
        {
            Materia materia = new Materia();

            Assert.IsNotNull(materia.ListarSoloMaterias());
        }
    }
}
