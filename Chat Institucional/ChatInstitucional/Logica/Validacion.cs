using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatInstitucional.De_persistencia;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Validacion
    {
        Connect connect = new Connect();
        Persona persona = new Persona();
        Alumno alumno = new Alumno();
        Docente docente = new Docente();

        public static int UsuarioActual { get; set; }

        public Validacion()
        {
            
        }

        public Alumno AlumnoActual(int ci) //Hacer GrupoActual(int ci, int id) q busque el alumno en esa cedula a q grupo pertenece
        {
            return connect.AlumnoActual(ci);
        }

        public bool ValidarLogin(int ci, String pass)
        {
            return connect.LogInBDD(ci, pass);
        }

        public bool ValidarLogOut(int ci)
        {
            return connect.LogOutBDD(ci);
        }

        public bool CrearAlumno(Alumno a)
        {
            return connect.AgregarAlumno(a);
        }

        public DataTable TraerGrupo()
        {
            return connect.TraerIdGrupo();
        }

        public DataTable TraerIdMateria()
        {
            return connect.TraerIdMateria();
        }

        public bool EnviarConsulta(Asincronica a)
        {
            return connect.EnviarConsulta(a);
        }
    }
}
