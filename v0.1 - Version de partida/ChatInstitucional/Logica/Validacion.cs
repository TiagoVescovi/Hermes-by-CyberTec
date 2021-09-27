using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatInstitucional.De_persistencia;

namespace ChatInstitucional.Logica
{
    class Validacion
    {
        public Validacion()
        {

        }

        public bool ValidarLogin(int ci, String pass)
        {
            Connect connect = new Connect();
            return connect.LogInBDD(ci, pass);
        }

        public bool CrearAlumno()
        {
            Connect connect = new Connect();
            Alumno a = new Alumno();
            return connect.AgregarAlumno(a);
        }
    }
}
